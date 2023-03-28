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
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
            Fill();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();


                Function.Function.gen = "Insert into Borrowed values('" + txtIdNumber.Text + "','"+cmbAccessionNumber.Text+"')";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();
                MessageBox.Show("Book successfully borrowed!", "Borrowed", MessageBoxButtons.OK);
                Fill();

                Connection.Connection.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Fill()
        {
            Function.Function.gen = "SELECT Borrowed.borrowerId,Book.accession_number,Book.title,Book.author \r\nFROM Borrowed\r\nINNER JOIN Book ON Book.accession_number = Borrowed.accession_number;";
            Function.Function.fill(Function.Function.gen, dgvBorrow);
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libsysDataSetBook.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libsysDataSetBook.Book);

        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            Fill();
            cmbAccessionNumber.Text = " ";
            txtAuthor.Text = " ";
            txtTitle.Text = " ";
            
        }

        private void cmbAccessionNumber_TextChanged(object sender, DataGridViewCellEventArgs e)
        {
            cmbAccessionNumber.Text = Books.dgvBook[0, e.RowIndex].Value.ToString();
            txtTitle.Text = dgvBook[1, e.RowIndex].Value.ToString();
            txtAuthor.Text = dgvBook[2, e.RowIndex].Value.ToString();
        }
    }
}
