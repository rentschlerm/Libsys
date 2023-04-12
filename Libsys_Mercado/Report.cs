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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            pbarBooks.Value = 0;
            pbarBorrowed.Value = 0;
            pbarReturned.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {


                Connection.Connection.DB();
                Function.Function.gen = "SELECT COUNT(accession_number) AS Number_of_Books FROM Book ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();
                    pbarBooks.Value = int.Parse(Function.Function.reader["Number_of_Books"].ToString());
                    pbarBooks.Text = pbarBooks.Value.ToString();
                    Function.Function.reader.Close();
                }

                   /*Function.Function.gen = "SELECT COUNT(accession_number) AS Number_of_Books FROM Book ";
                   Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                   Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.gen = "SELECT COUNT(accession_number) AS Number_of_Books FROM Book ";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                    Function.Function.reader = Function.Function.command.ExecuteReader();

                    Function.Function.reader.Read();
                    pbarBooks.Value = int.Parse(Function.Function.reader["Number_of_Lost"].ToString());
                    pbarBooks.Text = pbarBooks.Value.ToString() + "%";
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                pbarBorrowed.Value = 0;
                Connection.Connection.DB();
                Function.Function.gen = "SELECT COUNT(borrowerId) AS Number_of_Books_Borrowed FROM Borrowed Where status = 'Borrowed'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.reader = Function.Function.command.ExecuteReader();
                if (Function.Function.reader.HasRows)
                {


                    Function.Function.reader.Read();
                    pbarBorrowed.Value = int.Parse(Function.Function.reader["Number_of_Books_Borrowed"].ToString());
                    pbarBorrowed.Text = pbarBorrowed.Value.ToString();
                    Function.Function.reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                pbarReturned.Value = 0;
                Connection.Connection.DB();
                Function.Function.gen = "SELECT COUNT(borrowerId) AS Number_of_Books_Returned FROM Borrowed Where status = 'Returned' ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.reader = Function.Function.command.ExecuteReader();
                if (Function.Function.reader.HasRows)
                {


                    Function.Function.reader.Read();
                    pbarReturned.Value = int.Parse(Function.Function.reader["Number_of_Books_Returned"].ToString());
                    pbarReturned.Text = pbarReturned.Value.ToString();
                    Function.Function.reader.Close();
                }
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

        private void pboxReturnToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
        public void pboxReturnToDashboard_Closer()
        {
            pboxReturnToDashboard.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to delete the record for Returned books?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                Connection.Connection.DB();
                Function.Function.gen = "Delete From Borrowed Where status = 'Returned'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();
                Function.Function.reader.Close();
            }
        }
    }
}
