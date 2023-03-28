namespace Libsys_Mercado
{
    partial class Borrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pboxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pboxBorrow = new System.Windows.Forms.PictureBox();
            this.cmbAccessionNumber = new System.Windows.Forms.ComboBox();
            this.libsysDataSetBook = new Libsys_Mercado.libsysDataSetBook();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Libsys_Mercado.libsysDataSetBookTableAdapters.BookTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libsysDataSetBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Transaction";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(17, 226);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 28);
            this.panel1.TabIndex = 30;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(14, 252);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.Size = new System.Drawing.Size(319, 150);
            this.dgvBorrow.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Accession Number";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Location = new System.Drawing.Point(185, 163);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(94, 13);
            this.txtAuthor.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "_______________";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(185, 133);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(94, 13);
            this.txtTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "_______________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "__________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Id number";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdNumber.Location = new System.Drawing.Point(185, 76);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(94, 13);
            this.txtIdNumber.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "_______________";
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pbRefresh.Image")));
            this.pbRefresh.Location = new System.Drawing.Point(185, 201);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(28, 25);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRefresh.TabIndex = 38;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Libsys_Mercado.Properties.Resources.return_icon;
            this.pictureBox6.Location = new System.Drawing.Point(2, 30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pboxReturn
            // 
            this.pboxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pboxReturn.Image")));
            this.pboxReturn.Location = new System.Drawing.Point(270, 201);
            this.pboxReturn.Name = "pboxReturn";
            this.pboxReturn.Size = new System.Drawing.Size(24, 25);
            this.pboxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxReturn.TabIndex = 33;
            this.pboxReturn.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(124, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pboxBorrow
            // 
            this.pboxBorrow.Image = ((System.Drawing.Image)(resources.GetObject("pboxBorrow.Image")));
            this.pboxBorrow.Location = new System.Drawing.Point(229, 201);
            this.pboxBorrow.Name = "pboxBorrow";
            this.pboxBorrow.Size = new System.Drawing.Size(24, 25);
            this.pboxBorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBorrow.TabIndex = 28;
            this.pboxBorrow.TabStop = false;
            this.pboxBorrow.Click += new System.EventHandler(this.pboxBorrow_Click);
            // 
            // cmbAccessionNumber
            // 
            this.cmbAccessionNumber.DataSource = this.bookBindingSource;
            this.cmbAccessionNumber.DisplayMember = "accession_number";
            this.cmbAccessionNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAccessionNumber.FormattingEnabled = true;
            this.cmbAccessionNumber.Location = new System.Drawing.Point(185, 98);
            this.cmbAccessionNumber.Name = "cmbAccessionNumber";
            this.cmbAccessionNumber.Size = new System.Drawing.Size(80, 21);
            this.cmbAccessionNumber.TabIndex = 39;
            this.cmbAccessionNumber.ValueMember = "accession_number";
            this.cmbAccessionNumber.TextChanged += new System.EventHandler(this.cmbAccessionNumber_TextChanged);
            // 
            // libsysDataSetBook
            // 
            this.libsysDataSetBook.DataSetName = "libsysDataSetBook";
            this.libsysDataSetBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libsysDataSetBook;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 457);
            this.Controls.Add(this.cmbAccessionNumber);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pboxReturn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.pboxBorrow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libsysDataSetBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxBorrow;
        private System.Windows.Forms.PictureBox pboxReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.ComboBox cmbAccessionNumber;
        private libsysDataSetBook libsysDataSetBook;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private libsysDataSetBookTableAdapters.BookTableAdapter bookTableAdapter;
    }
}