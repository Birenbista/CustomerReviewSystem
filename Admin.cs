using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Feedback_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            criteria1.Hide();
            report1.Hide();
            graph1.Hide();
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit ? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            graph1.Hide();
            report1.Hide();
            criteria1.Hide();
        }

        private void BthsetCriteria_Click(object sender, EventArgs e)
        {
            criteria1.Show();
            criteria1.BringToFront();
            graph1.Hide();
            report1.Hide();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            criteria1.Hide();
            graph1.Hide();
            report1.Show();
            report1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            criteria1.Hide();
            graph1.Show();
            report1.Hide();
            graph1.BringToFront();

        }

       
    }
}
