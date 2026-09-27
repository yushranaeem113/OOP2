namespace StudyManagement
{
    partial class LogIn
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
            this.Lemail = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.Tlogemail = new System.Windows.Forms.TextBox();
            this.Tlogpass = new System.Windows.Forms.TextBox();
            this.Blog = new System.Windows.Forms.Button();
            this.roleLabel = new System.Windows.Forms.Label();
            this.RoleCombo = new System.Windows.Forms.ComboBox();
            this.bloginback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.BackColor = System.Drawing.Color.Transparent;
            this.Lemail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lemail.Location = new System.Drawing.Point(165, 172);
            this.Lemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(48, 15);
            this.Lemail.TabIndex = 0;
            this.Lemail.Text = "EMAIL";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.BackColor = System.Drawing.Color.Transparent;
            this.LPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LPassword.Location = new System.Drawing.Point(165, 205);
            this.LPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(84, 15);
            this.LPassword.TabIndex = 1;
            this.LPassword.Text = "PASSWORD";
            this.LPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tlogemail
            // 
            this.Tlogemail.Location = new System.Drawing.Point(262, 167);
            this.Tlogemail.Margin = new System.Windows.Forms.Padding(2);
            this.Tlogemail.Name = "Tlogemail";
            this.Tlogemail.Size = new System.Drawing.Size(168, 20);
            this.Tlogemail.TabIndex = 2;
            // 
            // Tlogpass
            // 
            this.Tlogpass.Location = new System.Drawing.Point(262, 203);
            this.Tlogpass.Margin = new System.Windows.Forms.Padding(2);
            this.Tlogpass.Name = "Tlogpass";
            this.Tlogpass.Size = new System.Drawing.Size(168, 20);
            this.Tlogpass.TabIndex = 3;
            // 
            // Blog
            // 
            this.Blog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Blog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blog.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Blog.Location = new System.Drawing.Point(146, 248);
            this.Blog.Margin = new System.Windows.Forms.Padding(2);
            this.Blog.Name = "Blog";
            this.Blog.Size = new System.Drawing.Size(121, 44);
            this.Blog.TabIndex = 4;
            this.Blog.Text = "LOGIN";
            this.Blog.UseVisualStyleBackColor = false;
            this.Blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roleLabel.Location = new System.Drawing.Point(165, 138);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(69, 15);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "YOU ARE:";
            this.roleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoleCombo
            // 
            this.RoleCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleCombo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.RoleCombo.FormattingEnabled = true;
            this.RoleCombo.Items.AddRange(new object[] {
            "ADMIN",
            "STUDENT"});
            this.RoleCombo.Location = new System.Drawing.Point(262, 132);
            this.RoleCombo.Name = "RoleCombo";
            this.RoleCombo.Size = new System.Drawing.Size(121, 23);
            this.RoleCombo.TabIndex = 6;
            // 
            // bloginback
            // 
            this.bloginback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bloginback.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloginback.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bloginback.Location = new System.Drawing.Point(338, 248);
            this.bloginback.Margin = new System.Windows.Forms.Padding(2);
            this.bloginback.Name = "bloginback";
            this.bloginback.Size = new System.Drawing.Size(121, 44);
            this.bloginback.TabIndex = 7;
            this.bloginback.Text = "BACK";
            this.bloginback.UseVisualStyleBackColor = false;
            this.bloginback.Click += new System.EventHandler(this.bloginback_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bloginback);
            this.Controls.Add(this.RoleCombo);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.Blog);
            this.Controls.Add(this.Tlogpass);
            this.Controls.Add(this.Tlogemail);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.Lemail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox Tlogemail;
        private System.Windows.Forms.TextBox Tlogpass;
        private System.Windows.Forms.Button Blog;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox RoleCombo;
        private System.Windows.Forms.Button bloginback;
    }
}