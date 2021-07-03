using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Feedback_System
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid(bool sort = false)
        {
            Review rv = new Review();
            List<Review> rvlst = rv.ReviewList();
            DataTable dt = new DataTable();
            if (sort)
            {
                dt = Utility.ConvertToDataTable(rvlst, true);

            }
            else
            {
                dt = Utility.ConvertToDataTable(rvlst);
            }
            if (dt != null)
            {
                dataGridView1.DataSource = dt;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].Width = 250;
                }
                dataGridView1.ForeColor = Color.Black;

            }


        }

        private void BtnSortbydate_Click(object sender, EventArgs e)
        {
            BindGrid(true);
        }
    }
}
