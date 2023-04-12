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
        Encryption_Decryption encrypt_decryption = new Encryption_Decryption();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "SELECT * FROM users WHERE username = '" + txtusername.Text + "'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.reader = Function.Function.command.ExecuteReader();


                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();
                    string decryptedPassword = encrypt_decryption.Decrypt(Function.Function.reader["password"].ToString());

                    if (decryptedPassword == txtpassword.Text)
                    {
                        
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();

                    }
                    else if (decryptedPassword != txtpassword.Text)
                    {
                        MessageBox.Show("Username and password doesn't match!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtusername.Clear();
                        txtpassword.Clear();
                        txtusername.Focus();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "UserName")
            {
                txtusername.Clear();
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin_Click(sender, EventArgs.Empty);
            }
        }
    }
}
