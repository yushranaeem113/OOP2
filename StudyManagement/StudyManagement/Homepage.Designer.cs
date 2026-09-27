namespace StudyManagement
{
    partial class Homepage
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
            this.Bhlogin = new System.Windows.Forms.Button();
            this.Bhregistration = new System.Windows.Forms.Button();
            this.Bhexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bhlogin
            // 
            this.Bhlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bhlogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bhlogin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Bhlogin.Location = new System.Drawing.Point(319, 106);
            this.Bhlogin.Margin = new System.Windows.Forms.Padding(2);
            this.Bhlogin.Name = "Bhlogin";
            this.Bhlogin.Size = new System.Drawing.Size(154, 42);
            this.Bhlogin.TabIndex = 1;
            this.Bhlogin.Text = "LOGIN";
            this.Bhlogin.UseVisualStyleBackColor = false;
            this.Bhlogin.Click += new System.EventHandler(this.Bhlogin_Click);
            // 
            // Bhregistration
            // 
            this.Bhregistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bhregistration.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bhregistration.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Bhregistration.Location = new System.Drawing.Point(319, 179);
            this.Bhregistration.Margin = new System.Windows.Forms.Padding(2);
            this.Bhregistration.Name = "Bhregistration";
            this.Bhregistration.Size = new System.Drawing.Size(154, 38);
            this.Bhregistration.TabIndex = 2;
            this.Bhregistration.Text = "REGISTRATION";
            this.Bhregistration.UseVisualStyleBackColor = false;
            this.Bhregistration.Click += new System.EventHandler(this.Bhregistration_Click);
            // 
            // Bhexit
            // 
            this.Bhexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bhexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bhexit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Bhexit.Location = new System.Drawing.Point(319, 252);
            this.Bhexit.Margin = new System.Windows.Forms.Padding(2);
            this.Bhexit.Name = "Bhexit";
            this.Bhexit.Size = new System.Drawing.Size(154, 38);
            this.Bhexit.TabIndex = 3;
            this.Bhexit.Text = "EXIT";
            this.Bhexit.UseVisualStyleBackColor = false;
            this.Bhexit.Click += new System.EventHandler(this.Bhexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudyManagement.Properties.Resources.study_exe__2_;
            this.pictureBox1.Location = new System.Drawing.Point(318, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(821, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bhexit);
            this.Controls.Add(this.Bhregistration);
            this.Controls.Add(this.Bhlogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bhlogin;
        private System.Windows.Forms.Button Bhregistration;
        private System.Windows.Forms.Button Bhexit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

