using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BisleriumCafe.Admin
{
    public partial class ManageProduct : UserControl
    {
        // Define a list to store products
        private List<Product> products;

        public ManageProduct()
        {
            InitializeComponent();
            // Initialize the list of products
            products = new List<Product>();
            // Load existing products to the list
            LoadProducts();
            // Populate the DataGridView
            PopulateDataGridView();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Get product information from your UI controls
            string productName = productN.Text;
            decimal price = Convert.ToDecimal(priceN.Text);
            string category = categoryN.Text;

            // Create a Product object
            Product product = new Product
            {
                ProductName = productName,
                Price = price,
                Category = category
            };

            // Add the new product to the list
            products.Add(product);

            // Save the products to the JSON file
            SaveProducts();

            // Populate the DataGridView
            PopulateDataGridView();

            MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadProducts()
        {
            // Specify the full path for the JSON file
            string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\products.json";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read existing JSON data from the file
                    string existingJson = File.ReadAllText(filePath);

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

        private void SaveProducts()
        {
            // Specify the full path for the JSON file
            string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\products.json";

            try
            {
                // Serialize the products to JSON
                string json = JsonConvert.SerializeObject(products, Formatting.Indented);

                // Write the JSON data to the file
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView()
        {
            // Clear existing rows in the DataGridView
            guna2DataGridView2.Rows.Clear();

            // Populate the DataGridView with product data
            foreach (Product product in products)
            {
                guna2DataGridView2.Rows.Add(product.ProductName, product.Price, product.Category);
            }
        }

        // Define a class to represent the product
        private class Product
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            productN.Text = string.Empty;
            priceN.Text = string.Empty;
            categoryN.Text = string.Empty;
        }
    }
}
