using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Customer_Feedback_System
{
    public partial class Criteria : UserControl
    {
        string filename = "Criterias.txt";

        public Criteria()
        {
            InitializeComponent();

        }

        private void BtnAdCriteria_Click(object sender, EventArgs e)
        {
            if (TxtCriteria.Text != "")
            {
                string criteria = JsonConvert.SerializeObject(TxtCriteria.Text, Formatting.None);
                bool success = Utility.TextWriter(@"Criterias.txt", criteria);

                if (success)
                {
                    //counter++;

                    TxtCriteria.Clear();
                }
                AddCriteria(filename);
                MessageBox.Show("Added sucessfully");
            }
            else
            {
                MessageBox.Show("Please fill up the text field.");
            }
        }
        
           
        
        

        private void Criteria_Load(object sender, EventArgs e)
        {
            AddCriteria(filename);
        }

        private void AddCriteria(string filename)
        {
            List<string> Criteri = Utility.CsvReader(filename);
            if (Criteri.Count != 0)
            {
                int Height = 10;


                for (int i = 0; i < Criteri.Count; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = Criteri[i];
                    lbl.Location = new Point(10, Height);
                    
                    lbl.Size = new Size(100, 24);
                    this.Criteriapnl.Controls.Add(lbl);

                    Height += 30;
                }
            }
            else
            {
                Criteriapnl.Controls.Clear();
            }
        }

       

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"Criterias.txt", string.Empty);
            AddCriteria(filename);

            MessageBox.Show("Criterias Deleted Sucessfully");

        }

        
    }
}
