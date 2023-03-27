using Libsys_Mercado.Connection;
using Libsys_Mercado.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libsys_Mercado
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            Fill();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();

                Function.Function.gen = "Select * from Book where accession_number = '"+cmbAccessionNumber.Text+"'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();

                if (Function.Function.gen == null)
                {
                    Function.Function.gen = "Insert into Book (title,author,quantity)values('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + txtQty.Text + "')";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                    Function.Function.command.ExecuteNonQuery();
                    MessageBox.Show("Book successfully added!", "Added", MessageBoxButtons.OK);
                    Fill();
                }
                else if(Function.Function.command != null)
                {
                    MessageBox.Show("Please Try Again", "Try Again", MessageBoxButtons.OK);
                }
                Connection.Connection.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gen == DialogResult.Yes)
                {
                    Function.Function.gen = "Delete from Book where accession_number = " + cmbAccessionNumber.Text + "";
                    Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                    Function.Function.command.ExecuteNonQuery();
                    Connection.Connection.con.Close();
                    MessageBox.Show("It has been deleted!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "Update Book Set title = '" + txtTitle.Text + "', author = '" + txtAuthor + "'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();
                Connection.Connection.con.Close();
                MessageBox.Show("It has been updated!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Fill()
        {
            Function.Function.gen = "Select * from Book";
            Function.Function.fill(Function.Function.gen, dgvBook);
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbAccessionNumber.Text = dgvBook[0, e.RowIndex].Value.ToString();
                txtTitle.Text = dgvBook[1, e.RowIndex].Value.ToString();
                txtAuthor.Text = dgvBook[2, e.RowIndex].Value.ToString();
                txtQty.Text = dgvBook[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "Select * FROM Book where accession_number like '" + txtsearch.Text + "' OR title like '" + txtsearch.Text + "' OR author like '" + txtsearch.Text + "'";
                Function.Function.fill(Function.Function.gen, dgvBook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
