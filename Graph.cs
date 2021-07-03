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
    public partial class Graph : UserControl
    {
        string criteria = "";
        public Graph()
        {
            InitializeComponent();
        }
        private void Graph_Load(object sender, EventArgs e)
        {
           EnterCriteria();
            BindReviewGrid(criteria);
        }
        private void BindReviewGrid(string load)
        {
            Review rv = new Review();
            List<Review> listRating = new List<Review>();
            listRating = rv.ReviewList();
            DataTable dt = Utility.ConvertToDataTable(listRating);
            var chartData = from x in dt.AsEnumerable()
                            group x by x.Field<String>(load) into y
                            select new
                            {
                                Food = y.Key,
                                Count = y.Count()
                            };
            var lstChart = chartData.ToList();
            var d = Utility.ConvertToTable(lstChart);
            BindChart(d, load);

        }
        private void BindChart(DataTable lst, string load)
        {
            chart1.DataSource = lst;
            chart1.Name = load + " Rating";
            chart1.Series["Series1"].XValueMember = "Food";
            chart1.Series["Series1"].YValueMembers = "Count";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ratings";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "No of ratings";
            this.chart1.Titles.Remove(this.chart1.Titles.FirstOrDefault());
            this.chart1.Titles.Add(load + " Rating");
            chart1.Series["Series1"].IsValueShownAsLabel = true;
        }
        public void EnterCriteria()
        {
            Review rvobjt = new Review();
            List<Review> lst = rvobjt.ReviewList();
            if (lst != null)
            {
                int initial = 0;
                foreach (Review item in lst)
                {

                    foreach (var i in item.Criterias)
                    {
                        if (initial == 0)
                        {
                            criteria = i.Key;
                            initial++;
                        }
                        if (Ddlcriteria.Items.Contains(i.Key) == false)
                        {
                            Ddlcriteria.Items.Add(i.Key);
                        }

                    }
                }




            }

        }

        private void Btnviewchart_Click(object sender, EventArgs e)
        {
            string selected = Ddlcriteria.SelectedItem.ToString();
            BindReviewGrid(selected);
        }

       
    }
}
