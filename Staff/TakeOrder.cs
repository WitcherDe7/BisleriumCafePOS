using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BisleriumCafe.Staff
{
    public partial class checkoutBtn : UserControl
    {
        private List<Product> products;
        private List<OrderItem> orderItems;
        private Dictionary<string, double> extrasPrices; // Dictionary to store extra add-ins and their prices
        private string productsFilePath = @"D:\cwAD\Final\BisleriumCafe\Database\products.json";

        public checkoutBtn()
        {
            InitializeComponent();

            // Initialize the lists and dictionary
            products = new List<Product>();
            orderItems = new List<OrderItem>();
            extrasPrices = new Dictionary<string, double>();

            // Load products from the JSON file
            LoadProducts();

            // Populate the products ComboBox
            PopulateProductsComboBox();

            // Set up the DataGridView for order items
            SetupDataGridView();

            // Populate the extras ComboBox with random prices
            PopulateExtrasComboBox();
        }

        private void LoadProducts()
        {
            try
            {
                // Check if the file exists
                if (File.Exists(productsFilePath))
                {
                    // Read existing JSON data from the file
                    string existingJson = File.ReadAllText(productsFilePath);

                    // Deserialize existing data (check if it's an array or object)
                    if (!string.IsNullOrEmpty(existingJson) && existingJson.Trim().StartsWith("["))
                    {
                        products = JsonConvert.DeserializeObject<List<Product>>(existingJson);
                    }
                    else
                    {
                        // If not an array, create a new list with the existing product
                        products = new List<Product> { JsonConvert.DeserializeObject<Product>(existingJson) };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateProductsComboBox()
        {
            // Populate the ComboBox with product names
            foreach (Product product in products)
            {
                productName.Items.Add(product.ProductName);
            }
        }

        private void PopulateExtrasComboBox()
        {
            // Populate the extras ComboBox with random prices
            Random random = new Random();

            // Example extra add-ins with random prices
            List<string> extras = new List<string> { "Cinnamon", "Honey", "Ginger"};

            foreach (string extra in extras)
            {
                double randomPrice = random.NextDouble() * (5.0 - 1.0) + 1.0; // Generate random price between 1.0 and 5.0
                extrasPrices.Add(extra, randomPrice);
                extrasComboBox.Items.Add($"{extra} (Rs {randomPrice:N2})");
            }
        }

        private void SetupDataGridView()
        {
            // Set up the DataGridView columns
            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn extrasColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn totalColumn = new DataGridViewTextBoxColumn();

            productNameColumn.HeaderText = "Product Name";
            quantityColumn.HeaderText = "Quantity";
            priceColumn.HeaderText = "Price (Rs)";
            extrasColumn.HeaderText = "Extras";
            totalColumn.HeaderText = "Total (Rs)";

            guna2DataGridView2.Columns.AddRange(new DataGridViewColumn[] { productNameColumn, quantityColumn, priceColumn, extrasColumn, totalColumn });
        }

        private void UpdateDataGridView()
        {
            // Clear existing rows in the DataGridView
            guna2DataGridView2.Rows.Clear();

            double subtotal = 0; // Initialize subtotal variable

            // Populate the DataGridView with updated order items
            foreach (OrderItem orderItem in orderItems)
            {
                guna2DataGridView2.Rows.Add(orderItem.ProductName, orderItem.Quantity, orderItem.Price, orderItem.Extras, orderItem.Total);

                // Update subtotal
                subtotal += orderItem.Total;
            }

            // Show subtotal in the appropriate control (e.g., a label)
            subTotalLabel.Text = $"Subtotal: Rs {subtotal:N2}";

            // Calculate and show grand total (you can add taxes or discounts here if needed)
            double grandTotal = subtotal;
            grandTotalLabel.Text = $"Grand Total: Rs {grandTotal:N2}";
        }

        private void addToOrderButton_Click_1(object sender, EventArgs e)
        {
            // Get selected product name from the ComboBox
            string selectedProductName = productName.SelectedItem as string;

            // Get the selected product from the list
            Product selectedProduct = products.Find(product => product.ProductName == selectedProductName);

            if (selectedProduct != null)
            {
                // Get quantity from the TextBox
                if (int.TryParse(quantityText.Text, out int quantity) && quantity > 0)
                {
                    // Calculate total price for the order item
                    double total = quantity * selectedProduct.Price;

                    // Get selected extras and their prices
                    List<string> selectedExtras = new List<string>();
                    double extrasTotal = 0;

                    if (extrasComboBox.SelectedIndex != -1)
                    {
                        string selectedExtrasString = extrasComboBox.SelectedItem.ToString();
                        string selectedExtra = selectedExtrasString.Split(' ')[0]; // Extract extra name
                        double extraPrice = extrasPrices[selectedExtra]; // Get extra price

                        selectedExtras.Add(selectedExtra);
                        extrasTotal += extraPrice;
                    }

                    // Add the order item to the list
                    orderItems.Add(new OrderItem
                    {
                        ProductName = selectedProduct.ProductName,
                        Quantity = quantity,
                        Price = selectedProduct.Price + extrasTotal, // Include extra prices in the total price
                        Extras = string.Join(", ", selectedExtras),
                        Total = total + extrasTotal
                    });

                    // Update the DataGridView and totals
                    UpdateDataGridView();

                    // Clear the quantity TextBox
                    quantityText.Clear();
                    // Reset extras ComboBox selection
                    extrasComboBox.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Clear text properties of input controls
            productName.SelectedIndex = -1; // Clear ComboBox selection
            quantityText.Clear(); // Clear TextBox
            // Add more controls as needed

            // Clear DataGridView rows
            guna2DataGridView2.Rows.Clear();

            // Clear the orderItems list
            orderItems.Clear();

            // Clear subtotal and grand total labels
            subTotalLabel.Text = "Subtotal: Rs 0.00";
            grandTotalLabel.Text = "Grand Total: Rs 0.00";

            // Reset extras ComboBox selection
            extrasComboBox.SelectedIndex = -1;
        }


        // Class to represent a product
        private class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
        }

        // Class to represent an order item
        public class OrderItem
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public string Extras { get; set; }
            public double Total { get; set; }
        }

        private List<SalesOrder> allSalesOrders = new List<SalesOrder>();

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Get the customer number (you need to replace this with your actual logic to retrieve the customer number)
            string customerNumber = guna2TextBox1.Text;

            // Create a sales order object
            SalesOrder salesOrder = new SalesOrder
            {
                CustomerNumber = customerNumber,
                OrderDate = DateTime.Now,
                OrderItems = orderItems.ToList() // Assuming orderItems is a List<OrderItem> in your code
            };

            try
            {
                // Read existing JSON data from the file, or create an empty list if the file is empty or doesn't exist
                List<SalesOrder> existingOrders = ReadExistingJson();

                // Add the current sales order to the existing list
                existingOrders.Add(salesOrder);

                // Serialize the updated list of sales orders to JSON
                string updatedJson = JsonConvert.SerializeObject(existingOrders, Formatting.Indented);

                // Save the updated JSON data to the file
                SaveJsonToFile(updatedJson);

                // Notify the user about the successful sale and save
                MessageBox.Show("Sales order saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any potential exception during serialization or saving
                MessageBox.Show($"Error saving sales order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to read existing JSON data from the file
        private List<SalesOrder> ReadExistingJson()
        {
            string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\AllOrders.json";

            // Check if the file exists and is not empty
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                // Read existing JSON data from the file
                string existingJson = File.ReadAllText(filePath);

                // Deserialize existing JSON data to a List<SalesOrder>
                return JsonConvert.DeserializeObject<List<SalesOrder>>(existingJson);
            }
            else
            {
                // Return a new empty list if the file is empty or doesn't exist
                return new List<SalesOrder>();
            }
        }

        // Helper method to save JSON data to a file
        private void SaveJsonToFile(string jsonOrders)
        {
            // Specify the file path where you want to save the JSON data
            string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\AllOrders.json";

            try
            {
                // Write the JSON data to the file (overwrite existing content)
                File.WriteAllText(filePath, jsonOrders);
            }
            catch (Exception ex)
            {
                // Handle any potential exception during file writing
                MessageBox.Show($"Error saving JSON data to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Define a class to represent the sales order structure
        public class SalesOrder
        {
            public string CustomerNumber { get; set; }
            public DateTime OrderDate { get; set; }
            public List<OrderItem> OrderItems { get; set; }
        }

        private string membersFilePath = @"D:\cwAD\Final\BisleriumCafe\Database\members.json";

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Validate member type and apply discount

            // Get customer number from the user (replace with your actual method for getting customer number)
            string customerNumber = guna2TextBox1.Text;

            if (customerNumber != null)
            {
                // Check member information from the JSON file
                Dictionary<string, string> member = GetMemberInfo(customerNumber);

                if (member != null)
                {
                    // Apply discount based on member type
                    if (member.ContainsKey("CustomerType"))
                    {
                        string customerType = member["CustomerType"];

                        if (customerType == "Regular")
                        {
                            // For regular members, make 1 coffee free
                            AddFreeCoffee();
                        }
                        else if (customerType == "Membership")
                        {
                            // For membership members, apply a 10% discount to order items
                            ApplyMembershipDiscount();
                        }

                        // Update the DataGridView and totals
                        UpdateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("CustomerType information not found for the member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Dictionary<string, string> GetMemberInfo(string customerNumber)
        {
            // Read member information from the JSON file
            try
            {
                if (File.Exists(membersFilePath))
                {
                    string membersJson = File.ReadAllText(membersFilePath);

                    // Deserialize the JSON to a list of dictionaries
                    List<Dictionary<string, string>> members = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(membersJson);

                    // Check if the customer is a member
                    Dictionary<string, string> customer = members.FirstOrDefault(m => m.ContainsKey("PhoneNumber") && m["PhoneNumber"] == customerNumber);

                    if (customer != null)
                    {
                        return customer;
                    }
                    else
                    {
                        MessageBox.Show("Customer not found in members list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Members file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting member information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; // Return null if an error occurs
        }



        private void AddFreeCoffee()
        {
            // Find the order item with the product name "Coffee"
            OrderItem coffeeItem = orderItems.FirstOrDefault(item => item.ProductName == "Coffee");

            if (coffeeItem != null)
            {
                // Decrease the quantity by 1
                if (coffeeItem.Quantity > 0)
                {
                    coffeeItem.Quantity -= 1;
                    coffeeItem.Total = coffeeItem.Quantity * coffeeItem.Price;

                    // Update the DataGridView or any other UI representation
                    UpdateDataGridView();
                    // Update the Subtotal and Total labels or any other UI representation

                    discountlbl.Text = $"Discount: 1 Free Coffee";

                    MessageBox.Show("Quantity of coffee decreased by 1.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot decrease quantity further. The quantity is already at 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // The order does not contain any item with the product name "Coffee"
                MessageBox.Show("Coffee item not found in the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void ApplyMembershipDiscount()
        {
            // Apply a 10% discount to the order items for membership members
            foreach (OrderItem orderItem in orderItems)
            {
                orderItem.Total *= 0.9; // 10% discount
            }

            UpdateDiscountLabel(10);

            MessageBox.Show("10% discount applied for membership.", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDiscountLabel(int discountPercentage)
        {
            // Update the text of the discount label with the applied discount
            discountlbl.Text = $"Discount: {discountPercentage}%";
        }
    }
}
