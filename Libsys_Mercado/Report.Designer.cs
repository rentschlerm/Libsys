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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbarBorrowed = new CircularProgressBar.CircularProgressBar();
            this.pbarLost = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
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
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(779, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
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
            // pbarLost
            // 
            this.pbarLost.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbarLost.AnimationSpeed = 500;
            this.pbarLost.BackColor = System.Drawing.Color.Transparent;
            this.pbarLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbarLost.ForeColor = System.Drawing.Color.White;
            this.pbarLost.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pbarLost.InnerMargin = 2;
            this.pbarLost.InnerWidth = -1;
            this.pbarLost.Location = new System.Drawing.Point(554, 76);
            this.pbarLost.MarqueeAnimationSpeed = 2000;
            this.pbarLost.Name = "pbarLost";
            this.pbarLost.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbarLost.OuterMargin = -18;
            this.pbarLost.OuterWidth = 18;
            this.pbarLost.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pbarLost.ProgressWidth = 18;
            this.pbarLost.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbarLost.Size = new System.Drawing.Size(198, 202);
            this.pbarLost.StartAngle = 270;
            this.pbarLost.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarLost.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbarLost.SubscriptText = "";
            this.pbarLost.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbarLost.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbarLost.SuperscriptText = "";
            this.pbarLost.TabIndex = 3;
            this.pbarLost.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbarLost.Value = 68;
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
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lost";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbarLost);
            this.Controls.Add(this.pbarBorrowed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbarBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pbarBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private CircularProgressBar.CircularProgressBar pbarBorrowed;
        private CircularProgressBar.CircularProgressBar pbarLost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}