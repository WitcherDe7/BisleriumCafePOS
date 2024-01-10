using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using static BisleriumCafe.Staff.checkoutBtn;

namespace BisleriumCafe.Staff
{
    public partial class DailyReport : UserControl
    {
        private List<SalesOrder> allSalesOrders;

        public DailyReport()
        {
            InitializeComponent();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            // Load the data from the 'AllOrders.json' file
            LoadAllSalesOrders();

            // Display the data in the DataGridView and update the total label
            DisplayDataInDataGridView();
            UpdateTotalLabel();
        }

        private void LoadAllSalesOrders()
        {
            try
            {
                string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\AllOrders.json";

                // Check if the file exists and is not empty
                if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
                {
                    // Read existing JSON data from the file
                    string existingJson = File.ReadAllText(filePath);

                    // Deserialize existing JSON data to a List<SalesOrder>
                    allSalesOrders = JsonConvert.DeserializeObject<List<SalesOrder>>(existingJson);
                }
                else
                {
                    // Initialize an empty list if the file is empty or doesn't exist
                    allSalesOrders = new List<SalesOrder>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayDataInDataGridView()
        {
            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = allSalesOrders.SelectMany(order => order.OrderItems).ToList();
        }

        private void UpdateTotalLabel()
        {
            // Calculate the total based on the displayed data
            double total = allSalesOrders.SelectMany(order => order.OrderItems).Sum(item => item.Total);

            // Update the total label (assuming you have a label named lblTotal)
            //lblTotal.Text = $"Total: {total:C}";
        }

        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected date from the Guna DateTimePicker
                DateTime selectedDate = guna2DateTimePicker1.Value.Date;

                // Filter the data based on the selected date
                List<SalesOrder> filteredOrders = allSalesOrders
                    .Where(order => order.OrderDate.Date == selectedDate)
                    .ToList();

                // Update the DataGridView with the filtered data
                guna2DataGridView1.DataSource = filteredOrders.SelectMany(order => order.OrderItems).ToList();

                // Update the total label based on the filtered data
                UpdateTotalLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDataToCSV(string filePath, List<SalesOrder> orders)
        {
            try
            {
                // Create a StringBuilder to build the CSV content
                StringBuilder csvContent = new StringBuilder();

                // Add headers to the CSV file
                csvContent.AppendLine("Customer Number,Order Date,Product Name,Quantity,Price,Extras,Total");

                // Add data rows to the CSV file
                foreach (var order in orders)
                {
                    foreach (var orderItem in order.OrderItems)
                    {
                        csvContent.AppendLine($"{order.CustomerNumber},{order.OrderDate},{orderItem.ProductName},{orderItem.Quantity},{orderItem.Price},{orderItem.Extras},{orderItem.Total}");
                    }
                }

                // Write the CSV content to the file
                File.WriteAllText(filePath, csvContent.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error exporting data to CSV: {ex.Message}");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Open a SaveFileDialog to choose the export location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Export Daily Report";
                saveFileDialog.FileName = "DailyReport.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = saveFileDialog.FileName;

                    // Get the filtered orders based on the selected date
                    DateTime selectedDate = guna2DateTimePicker1.Value.Date;
                    List<SalesOrder> filteredOrders = allSalesOrders
                        .Where(order => order.OrderDate.Date == selectedDate)
                        .ToList();

                    // Export data to CSV file
                    ExportDataToCSV(filePath, filteredOrders);

                    MessageBox.Show("Daily report exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
