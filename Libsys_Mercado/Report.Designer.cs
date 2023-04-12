namespace Libsys_Mercado
{
    partial class Report
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
            this.pbarBooks = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbarBorrowed = new CircularProgressBar.CircularProgressBar();
            this.pbarReturned = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pboxReturnToDashboard = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReturnToDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbarBooks
            // 
            this.pbarBooks.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarBooks.AnimationSpeed = 500;
            this.pbarBooks.BackColor = System.Drawing.Color.Transparent;
            this.pbarBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbarBooks.ForeColor = System.Drawing.Color.White;
            this.pbarBooks.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pbarBooks.InnerMargin = 2;
            this.pbarBooks.InnerWidth = -1;
            this.pbarBooks.Location = new System.Drawing.Point(50, 76);
            this.pbarBooks.MarqueeAnimationSpeed = 2000;
            this.pbarBooks.Name = "pbarBooks";
            this.pbarBooks.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbarBooks.OuterMargin = -18;
            this.pbarBooks.OuterWidth = 18;
            this.pbarBooks.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pbarBooks.ProgressWidth = 18;
            this.pbarBooks.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarBooks.Size = new System.Drawing.Size(198, 202);
            this.pbarBooks.StartAngle = 270;
            this.pbarBooks.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarBooks.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarBooks.SubscriptText = "";
            this.pbarBooks.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarBooks.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarBooks.SuperscriptText = "";
            this.pbarBooks.TabIndex = 0;
            this.pbarBooks.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbarBooks.Value = 68;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 30);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Reports";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(779, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbarBorrowed
            // 
            this.pbarBorrowed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarBorrowed.AnimationSpeed = 500;
            this.pbarBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.pbarBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbarBorrowed.ForeColor = System.Drawing.Color.White;
            this.pbarBorrowed.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pbarBorrowed.InnerMargin = 2;
            this.pbarBorrowed.InnerWidth = -1;
            this.pbarBorrowed.Location = new System.Drawing.Point(302, 76);
            this.pbarBorrowed.MarqueeAnimationSpeed = 2000;
            this.pbarBorrowed.Name = "pbarBorrowed";
            this.pbarBorrowed.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbarBorrowed.OuterMargin = -18;
            this.pbarBorrowed.OuterWidth = 18;
            this.pbarBorrowed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pbarBorrowed.ProgressWidth = 18;
            this.pbarBorrowed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarBorrowed.Size = new System.Drawing.Size(198, 202);
            this.pbarBorrowed.StartAngle = 270;
            this.pbarBorrowed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarBorrowed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarBorrowed.SubscriptText = "";
            this.pbarBorrowed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarBorrowed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarBorrowed.SuperscriptText = "";
            this.pbarBorrowed.TabIndex = 2;
            this.pbarBorrowed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbarBorrowed.Value = 68;
            // 
            // pbarReturned
            // 
            this.pbarReturned.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarReturned.AnimationSpeed = 500;
            this.pbarReturned.BackColor = System.Drawing.Color.Transparent;
            this.pbarReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbarReturned.ForeColor = System.Drawing.Color.White;
            this.pbarReturned.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pbarReturned.InnerMargin = 2;
            this.pbarReturned.InnerWidth = -1;
            this.pbarReturned.Location = new System.Drawing.Point(554, 76);
            this.pbarReturned.MarqueeAnimationSpeed = 2000;
            this.pbarReturned.Name = "pbarReturned";
            this.pbarReturned.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbarReturned.OuterMargin = -18;
            this.pbarReturned.OuterWidth = 18;
            this.pbarReturned.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pbarReturned.ProgressWidth = 18;
            this.pbarReturned.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarReturned.Size = new System.Drawing.Size(198, 202);
            this.pbarReturned.StartAngle = 270;
            this.pbarReturned.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarReturned.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarReturned.SubscriptText = "";
            this.pbarReturned.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarReturned.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarReturned.SuperscriptText = "";
            this.pbarReturned.TabIndex = 3;
            this.pbarReturned.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbarReturned.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(372, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Borrowed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(630, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Returned";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pboxReturnToDashboard
            // 
            this.pboxReturnToDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxReturnToDashboard.Image = global::Libsys_Mercado.Properties.Resources.return_icon;
            this.pboxReturnToDashboard.Location = new System.Drawing.Point(3, 35);
            this.pboxReturnToDashboard.Name = "pboxReturnToDashboard";
            this.pboxReturnToDashboard.Size = new System.Drawing.Size(31, 29);
            this.pboxReturnToDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxReturnToDashboard.TabIndex = 41;
            this.pboxReturnToDashboard.TabStop = false;
            this.pboxReturnToDashboard.Click += new System.EventHandler(this.pboxReturnToDashboard_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboxReturnToDashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbarReturned);
            this.Controls.Add(this.pbarBorrowed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbarBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReturnToDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pbarBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private CircularProgressBar.CircularProgressBar pbarBorrowed;
        private CircularProgressBar.CircularProgressBar pbarReturned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pboxReturnToDashboard;
    }
}