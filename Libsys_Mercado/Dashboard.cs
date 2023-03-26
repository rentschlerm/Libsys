using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libsys_Mercado
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            OnResize();
        }
        protected void OnResize()
        {
            
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }

        private void addABookpbx_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            this.Hide();
        }

        private void transactionpbx_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Hide();
        }

        private void reportspbx_Click(object sender, EventArgs e)
        {

        }

        private void exitpbx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
