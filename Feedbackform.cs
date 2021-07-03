using Newtonsoft.Json;
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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit ? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            List<string> Criteri = Utility.CsvReader(@"Criterias.txt");
            int Height = 10;


            for (int i = 0; i < Criteri.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = Criteri[i];
                lbl.Location = new Point(10, Height);
                lbl.Size = new Size(210, 34);
                this.Criteripanel.Controls.Add(lbl);

                ComboBox cmb = new ComboBox();
                cmb.Name = Criteri[i];
                cmb.Items.AddRange(new object[] { 1, 2, 3, 4 });
                cmb.Size = new Size(45,34);
                cmb.Location = new Point(225, Height);
                
                this.Criteripanel.Controls.Add(cmb);
                Height += 50;
            }

        }

        private void BthSubmit_Click(object sender, EventArgs e)
        {

            List<string> Criteri = Utility.CsvReader(@"Criterias.txt");

            Review rv = new Review();
                int counter = 0;
                int count = 0;
                bool valid = Utility.IsValid_Contact(TxtCntctNo.Text);
                if (TxtCntctNo.Text!="")
                {
                    if (valid)
                    {
                        rv.ContactNo = TxtCntctNo.Text;
                        counter++;

                    }
                    else
                    {
                        MessageBox.Show("Invalid Contact Number. Please Enter Valid");
                    }
                }
                else
                {
                    counter++;
                }
                if (counter > 0)
                {
                    rv.CustomerName = TxtCustName.Text;
                    rv.Email = TxtEmaillAd.Text;

                    rv.Suggestion = TxtSugg.Text;
                    var present = DateTime.Now;
  
                    rv.SubmittedDate = present;
                    rv.Criterias = new Dictionary<string, string>();

                    foreach (Control combobox in this.Criteripanel.Controls)
                    {
                        if (counter > 0)
                        {
                            if (combobox is ComboBox)
                            {

                                if (combobox.Text != "")
                                {
                                    ComboBox cb = combobox as ComboBox;
                                    
                                    rv.Criterias.Add(cb.Name, cb.Text);
                                    cb.Text = "";
                                    count++;
                                }
                                else
                                {
                                    counter = 0;
                                    MessageBox.Show("Criteria cannot be empty!!");
                                }

                            }
                        }
                    }
                if (count == Criteri.Count)
                {
                    string criteriaData = JsonConvert.SerializeObject(rv, Formatting.None);
                        bool sucess = Utility.TextWriter(@"Rating.txt", criteriaData, true, 0);
                        if (sucess)
                        {
                            MessageBox.Show("Thank you for your Feedback :)");
                            TxtCustName.Clear();
                            TxtEmaillAd.Clear();
                            TxtCustName.Clear();
                            TxtSugg.Clear();
                        }
                }

            }




            
        }

        private void TxtEmaillAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
