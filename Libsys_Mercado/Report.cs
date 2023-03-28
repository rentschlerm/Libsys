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
            pbarLost.Value = 0;
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
                    pbarBooks.Text = pbarBooks.Value.ToString() + "%";
                }
                /* Function.Function.gen = "SELECT COUNT(accession_number) AS Number_of_Books FROM Book ";
                   Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                   Function.Function.reader = Function.Function.command.ExecuteReader();
                if (Function.Function.reader.HasRows)
                {


                    Function.Function.reader.Read();
                    pbarBooks.Value = int.Parse(Function.Function.reader["Number_of_Borrowed"].ToString());
                    pbarBooks.Text = pbarBooks.Value.ToString() + "%";
                }
                   Function.Function.gen = "SELECT COUNT(accession_number) AS Number_of_Books FROM Book ";
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
    }
}
