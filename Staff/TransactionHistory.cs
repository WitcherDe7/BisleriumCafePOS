using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BisleriumCafe.Staff
{
    public partial class TransactionHistory : UserControl
    {
        private List<Order> allOrders;

        public TransactionHistory()
        {
            InitializeComponent();
            InitializeOrderHistoryGridView();
        }

        private void InitializeOrderHistoryGridView()
        {
            // Assuming dataGridViewOrderHistory is the name of your DataGridView control
            dataGridViewOrderHistory.AutoGenerateColumns = false;
            dataGridViewOrderHistory.Columns.Add("CustomerNumber", "Customer Number");
            dataGridViewOrderHistory.Columns.Add("OrderDate", "Order Date");
            dataGridViewOrderHistory.Columns.Add("ProductName", "Product Name");
            dataGridViewOrderHistory.Columns.Add("Quantity", "Quantity");
            dataGridViewOrderHistory.Columns.Add("Price", "Price");
            dataGridViewOrderHistory.Columns.Add("Extras", "Extras");
            dataGridViewOrderHistory.Columns.Add("Total", "Total");

            // Load JSON data from the file
            string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\AllOrders.json";
            string jsonData = System.IO.File.ReadAllText(filePath);
            allOrders = JsonConvert.DeserializeObject<List<Order>>(jsonData);

            // Populate the DataGridView with JSON data
            UpdateOrderHistoryGridView(allOrders);
        }

        private void btnFilterByPhoneNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateOrderHistoryGridView(List<Order> orders)
        {
            dataGridViewOrderHistory.Rows.Clear();

            foreach (Order order in orders)
            {
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    dataGridViewOrderHistory.Rows.Add(
                        order.CustomerNumber,
                        order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss"),
                        orderItem.ProductName,
                        orderItem.Quantity,
                        orderItem.Price,
                        orderItem.Extras,
                        orderItem.Total
                    );
                }
            }
        }

        private class Order
        {
            public string CustomerNumber { get; set; }
            public DateTime OrderDate { get; set; }
            public List<OrderItem> OrderItems { get; set; }
        }

        private class OrderItem
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public string Extras { get; set; }
            public double Total { get; set; }
        }

        private void btnFilterByPhoneNumber_Click_1(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                List<Order> filteredOrders = allOrders
                    .Where(order => order.CustomerNumber.Contains(phoneNumber))
                    .ToList();

                UpdateOrderHistoryGridView(filteredOrders);
            }
            else
            {
                // If the phone number is empty, show all orders
                UpdateOrderHistoryGridView(allOrders);
            }
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
