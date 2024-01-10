using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;  // Added for LINQ
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BisleriumCafe.Admin
{
    public partial class Reports : UserControl
    {
        // Path to your JSON file
        string FilePath = @"D:\cwAD\Final\BisleriumCafe\Database\AllOrders.json";

        public Reports()
        {
            InitializeComponent();

            // Subscribe to the ValueChanged event of the DateTimePicker
            guna2DateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            // Load data from JSON and populate the DataGridView
            LoadData();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Reload data when the DateTimePicker value changes
            LoadData();
        }

        private void LoadData()
        {
            // Read JSON file and deserialize into a list of objects
            List<Order> allOrders = JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(FilePath));

            // Get the selected month and year from the DateTimePicker
            DateTime selectedDate = guna2DateTimePicker1.Value;
            int selectedMonth = selectedDate.Month;
            int selectedYear = selectedDate.Year;

            // Filter orders based on the selected month and year
            List<Order> filteredOrders = allOrders
                .Where(order => order.OrderDate.Month == selectedMonth && order.OrderDate.Year == selectedYear)
                .ToList();

            // Create a DataTable to bind to the DataGridView
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CustomerNumber");
            dataTable.Columns.Add("OrderDate", typeof(DateTime));
            dataTable.Columns.Add("ProductName");
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Revenue", typeof(double));

            // Populate DataTable with filtered order data
            foreach (var order in filteredOrders)
            {
                foreach (var orderItem in order.OrderItems)
                {
                    dataTable.Rows.Add(order.CustomerNumber, order.OrderDate, orderItem.ProductName, orderItem.Quantity, orderItem.Total);
                }
            }

            // Bind DataTable to DataGridView
            guna2DataGridView1.DataSource = dataTable;

            // Calculate and display total revenue for the filtered orders
            double totalRevenue = CalculateTotalRevenue(filteredOrders);
            labelTotalRevenue.Text = $"Total Revenue: Rs {totalRevenue:N2}";
        }


        private double CalculateTotalRevenue(List<Order> orders)
        {
            double totalRevenue = 0;

            foreach (var order in orders)
            {
                foreach (var orderItem in order.OrderItems)
                {
                    totalRevenue += orderItem.Total;
                }
            }

            return totalRevenue;
        }

        private void buttonExportCSV_Click(object sender, EventArgs e)
        {

        }

        private void ExportToCSV(DataGridView dataGridView, string filePath, double totalRevenue)
        {
            // Export the DataGridView data and total revenue to CSV
            StringBuilder csvContent = new StringBuilder();

            // Add column headers
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                csvContent.Append(column.HeaderText + ",");
            }

            // Add a column header for TotalRevenue
            csvContent.AppendLine("TotalRevenue,");

            // Add data
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csvContent.Append(cell.Value + ",");
                }

                csvContent.AppendLine(); // Move to the next line for the next row
            }

            // Add total revenue at the end
            csvContent.AppendLine($",,,,{totalRevenue},");

            // Write CSV content to the file
            File.WriteAllText(filePath, csvContent.ToString());

            MessageBox.Show("CSV file exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            // Choose the location to save the CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Export to CSV";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                // Filter orders based on selected month and year
                DateTime selectedDate = guna2DateTimePicker1.Value;
                List<Order> filteredOrders = FilterOrdersByMonthAndYear(JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(FilePath)), selectedDate.Month, selectedDate.Year);

                // Calculate total revenue for filtered orders
                double totalRevenue = CalculateTotalRevenue(filteredOrders);

                // Export DataGridView data and total revenue to CSV
                ExportToCSV(guna2DataGridView1, saveFileDialog.FileName, totalRevenue);
            }
        }

        // Function to filter orders based on month and year
        private List<Order> FilterOrdersByMonthAndYear(List<Order> orders, int month, int year)
        {
            return orders.Where(order => order.OrderDate.Month == month && order.OrderDate.Year == year).ToList();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }

    // Define classes to represent the structure of your JSON data
    public class Order
    {
        public string CustomerNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Extras { get; set; }
        public double Total { get; set; }
    }
}
