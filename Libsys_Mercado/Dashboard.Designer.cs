﻿namespace Libsys_Mercado
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.addABookpbx = new System.Windows.Forms.PictureBox();
            this.transactionpbx = new System.Windows.Forms.PictureBox();
            this.reportspbx = new System.Windows.Forms.PictureBox();
            this.exitpbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addABookpbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionpbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportspbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitpbx)).BeginInit();
            this.SuspendLayout();
            // 
            // addABookpbx
            // 
            this.addABookpbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addABookpbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addABookpbx.Image = ((System.Drawing.Image)(resources.GetObject("addABookpbx.Image")));
            this.addABookpbx.Location = new System.Drawing.Point(112, 44);
            this.addABookpbx.Name = "addABookpbx";
            this.addABookpbx.Size = new System.Drawing.Size(75, 50);
            this.addABookpbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addABookpbx.TabIndex = 0;
            this.addABookpbx.TabStop = false;
            // 
            // transactionpbx
            // 
            this.transactionpbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionpbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionpbx.Image = ((System.Drawing.Image)(resources.GetObject("transactionpbx.Image")));
            this.transactionpbx.Location = new System.Drawing.Point(216, 44);
            this.transactionpbx.Name = "transactionpbx";
            this.transactionpbx.Size = new System.Drawing.Size(72, 50);
            this.transactionpbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.transactionpbx.TabIndex = 1;
            this.transactionpbx.TabStop = false;
            // 
            // reportspbx
            // 
            this.reportspbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportspbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportspbx.Image = ((System.Drawing.Image)(resources.GetObject("reportspbx.Image")));
            this.reportspbx.Location = new System.Drawing.Point(314, 44);
            this.reportspbx.Name = "reportspbx";
            this.reportspbx.Size = new System.Drawing.Size(72, 50);
            this.reportspbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportspbx.TabIndex = 1;
            this.reportspbx.TabStop = false;
            // 
            // exitpbx
            // 
            this.exitpbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitpbx.Image = ((System.Drawing.Image)(resources.GetObject("exitpbx.Image")));
            this.exitpbx.Location = new System.Drawing.Point(417, 44);
            this.exitpbx.Name = "exitpbx";
            this.exitpbx.Size = new System.Drawing.Size(72, 50);
            this.exitpbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitpbx.TabIndex = 1;
            this.exitpbx.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 118);
            this.Controls.Add(this.exitpbx);
            this.Controls.Add(this.reportspbx);
            this.Controls.Add(this.transactionpbx);
            this.Controls.Add(this.addABookpbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.addABookpbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionpbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportspbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitpbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox addABookpbx;
        private System.Windows.Forms.PictureBox transactionpbx;
        private System.Windows.Forms.PictureBox reportspbx;
        private System.Windows.Forms.PictureBox exitpbx;
    }
}