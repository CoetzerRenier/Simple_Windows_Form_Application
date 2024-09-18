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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            Report_Form rf = new Report_Form();
            rf.Show();
        }

        private void events_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming soon.");
        }

        private void service_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming soon.");
        }
    }
}
