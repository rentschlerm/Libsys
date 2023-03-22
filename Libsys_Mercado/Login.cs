using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libsys_Mercado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT username, password FROM users WHERE username = '" + txtusername + "'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.reader = Function.Function.command.ExecuteReader();
                if (Function.Function.reader.Read())
                {
                    string encryptedPassword = Function.Function.reader.GetString(1);
                    string decryptedPassword = decryptPassword(encryptedPassword);

                    if ((decryptedPassword == txtpassword.Text))
                    {
                        MessageBox.Show("Welcome Home!");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Username and password doesn't match!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtusername.Clear();
                        txtpassword.Clear();
                        txtusername.Focus();
                    }
                }
                else
                {
                    DialogResult response = MessageBox.Show("User Account doesn't exist. Proceed to Register?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == DialogResult.Yes)
                    {
                        new Register().Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }
        public static string decryptPassword(string encryptedPassword)
        {
            string decryptedPassword = "";
            foreach (char c in encryptedPassword)
            {
                int asciiValue = (int)c;
                asciiValue -= 2;
                decryptedPassword += (char)asciiValue;
            }
            return decryptedPassword;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
