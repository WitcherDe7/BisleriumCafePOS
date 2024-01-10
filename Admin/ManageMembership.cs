using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace BisleriumCafe.Admin
{
    public partial class ManageMembership : UserControl
    {
        private List<MembershipInfo> membershipList; // Store the list of membership information
        private int selectedRowIndex = -1; // Store the index of the selected row for editing

        public ManageMembership()
        {
            InitializeComponent();
            membershipList = new List<MembershipInfo>(); // Initialize the list
            LoadMembershipData(); // Load existing data when the form is initialized
            DisplayMembershipData(); // Display the data in the DataGridView
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1)
            {
                // Add new membership information if not in edit mode
                AddMembershipInfo();
            }
            else
            {
                // Edit existing membership information if in edit mode
                EditMembershipInfo();
            }

            SaveMembershipData(); // Save the updated list to the JSON file

            DisplayMembershipData(); // Display the updated data in the DataGridView

            ClearInputFields(); // Clear input fields after adding/editing
        }

        private void dataGridViewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click to enable editing
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Populate input fields with the selected data for editing
                cusname.Text = membershipList[selectedRowIndex].CustomerName;
                custype.Text = membershipList[selectedRowIndex].CustomerType;
                cusphone.Text = membershipList[selectedRowIndex].PhoneNumber;
                cusbenifit.Text = membershipList[selectedRowIndex].Benefit;
            }
        }

        private void AddMembershipInfo()
        {
            // Assuming you have a class to represent membership information
            MembershipInfo membershipInfo = new MembershipInfo
            {
                CustomerName = cusname.Text,
                CustomerType = custype.Text,
                PhoneNumber = cusphone.Text,
                Benefit = cusbenifit.Text
            };

            membershipList.Add(membershipInfo); // Add new membership information to the list
        }

        private void EditMembershipInfo()
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < membershipList.Count)
            {
                // Edit existing membership information
                membershipList[selectedRowIndex].CustomerName = cusname.Text;
                membershipList[selectedRowIndex].CustomerType = custype.Text;
                membershipList[selectedRowIndex].PhoneNumber = cusphone.Text;
                membershipList[selectedRowIndex].Benefit = cusbenifit.Text;
            }
        }

        private void DeleteMembershipInfo()
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < membershipList.Count)
            {
                // Delete the selected membership information
                membershipList.RemoveAt(selectedRowIndex);
                selectedRowIndex = -1; // Reset selected index after deletion
            }
        }

        private void ClearInputFields()
        {
            // Clear input fields after adding/editing
            cusname.Text = string.Empty;
            custype.Text = string.Empty;
            cusphone.Text = string.Empty;
            cusbenifit.Text = string.Empty;
        }

        private void LoadMembershipData()
        {
            // Get the path where you want to load the JSON file
            string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\members.json";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read existing JSON data from the file
                    string existingJson = File.ReadAllText(filePath);

                    // Deserialize the existing data to a list
                    membershipList = JsonConvert.DeserializeObject<List<MembershipInfo>>(existingJson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading membership information: {ex.Message}");
            }
        }

        private void SaveMembershipData()
        {
            // Get the path where you want to save the JSON file
            string filePath = @"D:\cwAD\Final\BisleriumCafe\Database\members.json";

            try
            {
                // Serialize the list to JSON
                string json = JsonConvert.SerializeObject(membershipList, Formatting.Indented);

                // Write the JSON to the file
                File.WriteAllText(filePath, json);
                MessageBox.Show("Membership information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving membership information: {ex.Message}");
            }
        }

        private void DisplayMembershipData()
        {
            // Assuming you have a DataGridView named dataGridViewMembers
            guna2DataGridView1.DataSource = null; // Clear existing data source
            guna2DataGridView1.DataSource = membershipList; // Set the list as the new data source
        }

    }

    // Example class to represent membership information
    public class MembershipInfo
    {
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public string PhoneNumber { get; set; }
        public string Benefit { get; set; }
    }
}
