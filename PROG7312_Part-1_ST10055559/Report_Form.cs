using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_Part_1_ST10055559
{
    public partial class Report_Form : Form
    {
        private List<Report> reports = new List<Report>();

        string filePath = "";
        string[] categories = { "Sanitation", "Roads", "Utilities" };

        public Report_Form()
        {
            InitializeComponent();

            categories_box.DataSource = categories;
        }

        private void media_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                MessageBox.Show("File uploaded succesfully.");
            }
            else
            {
                MessageBox.Show("File upload cancelled by user.");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {          
            if (performChecks() == true)
            {
                reports.Add(new Report(locationInput_txt.Text, categories_box.Text, description_txt.Text, filePath));

                MessageBox.Show("Thank you for submitting your report. We are working hard to address the issue.");

                locationInput_txt.Clear();
                categories_box.Text = categories[0];
                description_txt.Clear();
                filePath = "";
            }
            else
            {
                MessageBox.Show("Please make sure you have correctly filled in all aspects of the report before clicking the submit button.");
            }
        }

        private bool performChecks()
        {
            bool results = false;

            if (locationInput_txt.Text != "" && categories_box.Text != "" && description_txt.Text != "" && filePath != "")
            {
                results = true;
            }
            else
            {
                results = false;
            }

            return results;
        }
    }
}
