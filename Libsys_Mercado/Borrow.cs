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

        private void pboxReturn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();


                Function.Function.gen = "Update Borrowed Set status = 'Returned' Where borrowerId = '" + txtIdNumber.Text + "'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();
                MessageBox.Show("Book successfully returned!", "Return", MessageBoxButtons.OK);
                Fill();
                Connection.Connection.con.Close();


                /* else
                 {
                     MessageBox.Show("Book does'nt exist", "Failed", MessageBoxButtons.OK);

                 }*/



                Connection.Connection.DB();
                //Function.Function.gen = "Update Book.quantity Set quantity = quantity+1,  Borrowed.date_borrowed = '"+dtpTransaction.Text+"' From Book Where accession_number = '" + cmbAccessionNumber.Text + "' and borrowerId = '"+txtIdNumber.Text+"' INNER JOIN accession_number On Book.accession_number = Borrowed.accession_number";
                Function.Function.gen = "UPDATE Book SET quantity = quantity + 1 WHERE accession_number = '" + cmbAccessionNumber.Text + "' ";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();
                Function.Function.gen = "UPDATE Borrowed SET date_returned = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE borrowerId = '"+txtIdNumber.Text+"'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();
                Connection.Connection.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Fill()
        {
            Function.Function.gen = "SELECT Borrowed.status,Borrowed.borrowerId,Book.accession_number,Book.title,Book.author \r\nFROM Borrowed\r\nINNER JOIN Book ON Book.accession_number = Borrowed.accession_number Where Borrowed.status = 'Borrowed'";
            Function.Function.fill(Function.Function.gen, dgvBorrow);
        }
        public void Fill2()
        {
            Function.Function.gen = "SELECT Borrowed.status,Borrowed.borrowerId,Book.accession_number,Book.title,Book.author \r\nFROM Borrowed\r\nINNER JOIN Book ON Book.accession_number = Borrowed.accession_number Where Borrowed.status = 'Returned'";
            Function.Function.fill(Function.Function.gen, dgvBorrowerReturned);
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
            cmbAuthor.Text = " ";
            cmbTitle.Text = " ";
            
        }

        private void cmbAccessionNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdNumber.Text = dgvBorrow[1, e.RowIndex].Value.ToString();
                cmbAccessionNumber.Text = dgvBorrow[2, e.RowIndex].Value.ToString();
                cmbTitle.Text = dgvBorrow[3, e.RowIndex].Value.ToString();
                cmbAuthor.Text = dgvBorrow[4, e.RowIndex].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvBorrowerReturned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdNumber.Text = dgvBorrow[1, e.RowIndex].Value.ToString();
                cmbAccessionNumber.Text = dgvBorrow[2, e.RowIndex].Value.ToString();
                cmbTitle.Text = dgvBorrow[3, e.RowIndex].Value.ToString();
                cmbAuthor.Text = dgvBorrow[4, e.RowIndex].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pboxBorrow_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "Select quantity from Book " +
                    "where accession_number = '"+cmbAccessionNumber.Text+"'";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.reader = Function.Function.command.ExecuteReader();

                if (Function.Function.reader.HasRows)
                {
                    Function.Function.reader.Read();
                    int quantity = Int32.Parse(Function.Function.reader["quantity"].ToString());

                    if (quantity == 0)
                    {
                        MessageBox.Show("No more book to borrow", "Error", MessageBoxButtons.OK);
                    }

                    else
                    {
                        Connection.Connection.DB();
                        Function.Function.gen = "Insert into Borrowed (borrowerId, accession_number, date_borrowed) values('" + txtIdNumber.Text + "','" + cmbAccessionNumber.Text + "', '"+DateTime.Now.ToString("yyyy-MM-dd")+"')";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                        Function.Function.command.ExecuteNonQuery();
                        Fill();
                        MessageBox.Show("Book successfully borrowed!", "Borrowed", MessageBoxButtons.OK);
                        Connection.Connection.con.Close();

                        Connection.Connection.DB();
                        Function.Function.gen = "Update Book Set quantity = quantity-1" +
                            "Where accession_number = '" + cmbAccessionNumber.Text + "'";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                        Function.Function.command.ExecuteNonQuery();
                        Connection.Connection.con.Close();

                        Connection.Connection.DB();
                        Function.Function.gen = "Update Borrowed Set Status = 'Borrowed' " +
                            "Where borrowerId = '" + txtIdNumber.Text + "'";
                        Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                        Function.Function.command.ExecuteNonQuery();
                        Connection.Connection.con.Close();

                    }

                    /* else
                     {
                         MessageBox.Show("Book does'nt exist", "Failed", MessageBoxButtons.OK);

                     }*/






                }
                Fill();
                Connection.Connection.con.Close();


               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            dgvBorrowerReturned.Visible = true;
            Fill2();
            btnReturned.Visible = false;
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            dgvBorrowerReturned.Visible = false;
            Fill();
            btnReturned.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();

            report.pboxReturnToDashboard_Closer();
        }

        
    }
}
