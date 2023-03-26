using Libsys_Mercado.Connection;
using Libsys_Mercado.Function;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        Encryption_Decryption encrypt_decryption = new Encryption_Decryption();
       
       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpassword.Text == txtconpassword.Text)
                {
                    Connection.Connection.DB();
                    Function.Function.gen = "Select username From users where username = '" + txtusername.Text + "'";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                    Function.Function.command.ExecuteNonQuery();
                    if(Function.Function.command.ExecuteScalar() != null)
                    {
                        MessageBox.Show("username already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Connection.Connection.con.Close();

                    }
                    else
                    {
                        Connection.Connection.DB();
                        Function.Function.gen = "Insert into users values('" + txtusername.Text + "','" + encrypt_decryption.Encrypt(txtpassword.Text.Trim()) + "')";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                        Function.Function.command.ExecuteNonQuery();
                        MessageBox.Show("You can now log in with your account", "Login", MessageBoxButtons.OK);

                        DialogResult response = MessageBox.Show("Registration Successful! Proceed to Login?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (response == DialogResult.Yes)
                        {
                            new Login().Show();
                            this.Hide();
                        }
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Connection.Connection.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
