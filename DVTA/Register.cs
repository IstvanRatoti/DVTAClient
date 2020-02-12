using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientDataHandling;

namespace DVTA
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
           
            String username = txtRegUsername.Text.Trim();
            String password = txtRegPass.Text.Trim();
            String confirmpassword = txtRegCfmPass.Text.Trim();
            String email = txtRegEmail.Text.Trim();   

            if (username == string.Empty || password == string.Empty || confirmpassword == string.Empty || email == string.Empty)
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }
            else
            {

                if (password != confirmpassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                else
                {   // TODO server address and IP from config.
                    if (ClientConnect.Register(Main.serverAddress, Main.serverPort, username, password, email))
                    {
                        txtRegUsername.Text = "";
                        txtRegPass.Text = "";
                        txtRegCfmPass.Text="";
                        txtRegEmail.Text="";
                        MessageBox.Show("Registration Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed!");
                    }
                }
               
            }

        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

    }
}
