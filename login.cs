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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Txtpassword.PasswordChar='#';
        }

       
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
      

       

        private void Bthgivefeedback_Click(object sender, EventArgs e)
        {
            new Feedback().Show();
            this.Hide();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if ((Txtusername.Text == "admin") && (Txtpassword.Text == "admin"))
            {
                new Admin().Show();
                this.Hide();

            }
            else if (Txtusername.Text == "" && Txtpassword.Text == "" || Txtusername.Text == "" || Txtpassword.Text == "")
            {
                MessageBox.Show("Please fill all the empty fields");

            }
            else
            {
                MessageBox.Show("Please enter valid username and password");
            }
        }
    }
}
