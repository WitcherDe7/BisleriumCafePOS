using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace BisleriumCafe.Admin
{
    public partial class Sales : UserControl
    {
        private bool exportBtnEventSubscribed = false;
        public Sales()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string jsonFilePath = @"D:\cwAD\Final\BisleriumCafe\Database\AllOrders.json";
            List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(jsonFilePath));

            // Flatten the list of order items
            List<OrderItem> allOrderItems = orders.SelectMany(order => order.OrderItems).ToList();

            // Group by ProductName and Extras, summing up quantities
            var groupedItems = allOrderItems
                .GroupBy(item => new { item.ProductName, item.Extras })
                .Select(group => new
                {
                    ProductName = group.Key.ProductName,
                    Extras = group.Key.Extras,
                    Quantity = group.Sum(item => item.Quantity)
                })
                .OrderByDescending(item => item.Quantity)
                .Take(5)
                .ToList();

            // Display the result in DataGridView
            guna2DataGridView1.DataSource = groupedItems;
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            // Assuming that you have a method to get the groupedItems data
            List<dynamic> groupedItems = GetDataForPdfExport();

            // Export to PDF
            ExportToPdf(groupedItems);
        }

        private List<dynamic> GetDataForPdfExport()
        {
            // Implement the logic to get or calculate the data for PDF export
            string jsonFilePath = @"D:\cwAD\Final\BisleriumCafe\Database\AllOrders.json";
            List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(jsonFilePath));

            // Flatten the list of order items
            List<OrderItem> allOrderItems = orders.SelectMany(order => order.OrderItems).ToList();

            // Group by ProductName and Extras, summing up quantities
            var groupedItems = allOrderItems
                .GroupBy(item => new { item.ProductName, item.Extras })
                .Select(group => new
                {
                    ProductName = group.Key.ProductName,
                    Extras = group.Key.Extras,
                    Quantity = group.Sum(item => item.Quantity)
                })
                .OrderByDescending(item => item.Quantity)
                .Take(5)
                .ToList();

            // Explicitly cast to dynamic
            return groupedItems.Cast<dynamic>().ToList();
        }

        private void ExportToPdf(List<dynamic> data)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save PDF File"
            };

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (var writer = new PdfWriter(filePath))
                    using (var pdf = new PdfDocument(writer))
                    {
                        var document = new Document(pdf);
                        document.Add(new Paragraph("Top 5 Most Selling Items and Extras"));

                        var table = new iText.Layout.Element.Table(3);
                        table.AddCell("Product Name");
                        table.AddCell("Extras");
                        table.AddCell("Quantity");

                        foreach (var item in data)
                        {
                            table.AddCell(item.GetType().GetProperty("ProductName")?.GetValue(item)?.ToString() ?? "");
                            table.AddCell(item.GetType().GetProperty("Extras")?.GetValue(item)?.ToString() ?? "");
                            table.AddCell(item.GetType().GetProperty("Quantity")?.GetValue(item)?.ToString() ?? "");
                        }

                        document.Add(table);
                    }

                    MessageBox.Show("PDF Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting PDF: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
