namespace StudyManagement
{
    partial class AdminHomePage
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
            this.Bmanagestu = new System.Windows.Forms.Button();
            this.BmanageC = new System.Windows.Forms.Button();
            this.Bsetgrade = new System.Windows.Forms.Button();
            this.BlogoutAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bmanagestu
            // 
            this.Bmanagestu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bmanagestu.Location = new System.Drawing.Point(215, 132);
            this.Bmanagestu.Margin = new System.Windows.Forms.Padding(2);
            this.Bmanagestu.Name = "Bmanagestu";
            this.Bmanagestu.Size = new System.Drawing.Size(142, 37);
            this.Bmanagestu.TabIndex = 0;
            this.Bmanagestu.Text = "Manage Students";
            this.Bmanagestu.UseVisualStyleBackColor = false;
            this.Bmanagestu.Click += new System.EventHandler(this.Bmanagestu_Click);
            // 
            // BmanageC
            // 
            this.BmanageC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BmanageC.Location = new System.Drawing.Point(215, 183);
            this.BmanageC.Margin = new System.Windows.Forms.Padding(2);
            this.BmanageC.Name = "BmanageC";
            this.BmanageC.Size = new System.Drawing.Size(142, 42);
            this.BmanageC.TabIndex = 1;
            this.BmanageC.Text = "Manage Courses";
            this.BmanageC.UseVisualStyleBackColor = false;
            this.BmanageC.Click += new System.EventHandler(this.BmanageC_Click);
            // 
            // Bsetgrade
            // 
            this.Bsetgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bsetgrade.Location = new System.Drawing.Point(215, 243);
            this.Bsetgrade.Margin = new System.Windows.Forms.Padding(2);
            this.Bsetgrade.Name = "Bsetgrade";
            this.Bsetgrade.Size = new System.Drawing.Size(142, 42);
            this.Bsetgrade.TabIndex = 2;
            this.Bsetgrade.Text = "Set Grades Threshold";
            this.Bsetgrade.UseVisualStyleBackColor = false;
            this.Bsetgrade.Click += new System.EventHandler(this.Bsetgrade_Click);
            // 
            // BlogoutAd
            // 
            this.BlogoutAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BlogoutAd.Location = new System.Drawing.Point(215, 300);
            this.BlogoutAd.Margin = new System.Windows.Forms.Padding(2);
            this.BlogoutAd.Name = "BlogoutAd";
            this.BlogoutAd.Size = new System.Drawing.Size(142, 37);
            this.BlogoutAd.TabIndex = 3;
            this.BlogoutAd.Text = "LogOut";
            this.BlogoutAd.UseVisualStyleBackColor = false;
            this.BlogoutAd.Click += new System.EventHandler(this.BlogoutAd_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BlogoutAd);
            this.Controls.Add(this.Bsetgrade);
            this.Controls.Add(this.BmanageC);
            this.Controls.Add(this.Bmanagestu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminHomePage";
            this.Text = "Admin Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bmanagestu;
        private System.Windows.Forms.Button BmanageC;
        private System.Windows.Forms.Button Bsetgrade;
        private System.Windows.Forms.Button BlogoutAd;
    }
}