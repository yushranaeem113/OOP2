namespace StudyManagement
{
    partial class AddSemesterForm
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
            this.LsemName = new System.Windows.Forms.Label();
            this.LsemID = new System.Windows.Forms.Label();
            this.TsemName = new System.Windows.Forms.TextBox();
            this.TsemID = new System.Windows.Forms.TextBox();
            this.BaddSem = new System.Windows.Forms.Button();
            this.BbackSem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsemName
            // 
            this.LsemName.AutoSize = true;
            this.LsemName.BackColor = System.Drawing.Color.Transparent;
            this.LsemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsemName.ForeColor = System.Drawing.Color.White;
            this.LsemName.Location = new System.Drawing.Point(118, 53);
            this.LsemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LsemName.Name = "LsemName";
            this.LsemName.Size = new System.Drawing.Size(146, 24);
            this.LsemName.TabIndex = 0;
            this.LsemName.Text = "Semester Name";
            // 
            // LsemID
            // 
            this.LsemID.AutoSize = true;
            this.LsemID.BackColor = System.Drawing.Color.Transparent;
            this.LsemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsemID.ForeColor = System.Drawing.Color.White;
            this.LsemID.Location = new System.Drawing.Point(118, 119);
            this.LsemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LsemID.Name = "LsemID";
            this.LsemID.Size = new System.Drawing.Size(112, 24);
            this.LsemID.TabIndex = 1;
            this.LsemID.Text = "Semester ID";
            // 
            // TsemName
            // 
            this.TsemName.Location = new System.Drawing.Point(290, 48);
            this.TsemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TsemName.Name = "TsemName";
            this.TsemName.Size = new System.Drawing.Size(122, 20);
            this.TsemName.TabIndex = 3;
            // 
            // TsemID
            // 
            this.TsemID.Location = new System.Drawing.Point(290, 119);
            this.TsemID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TsemID.Name = "TsemID";
            this.TsemID.Size = new System.Drawing.Size(122, 20);
            this.TsemID.TabIndex = 4;
            // 
            // BaddSem
            // 
            this.BaddSem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BaddSem.ForeColor = System.Drawing.Color.White;
            this.BaddSem.Location = new System.Drawing.Point(154, 283);
            this.BaddSem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BaddSem.Name = "BaddSem";
            this.BaddSem.Size = new System.Drawing.Size(94, 32);
            this.BaddSem.TabIndex = 6;
            this.BaddSem.Text = "Add Semester";
            this.BaddSem.UseVisualStyleBackColor = false;
            this.BaddSem.Click += new System.EventHandler(this.BaddSem_Click);
            // 
            // BbackSem
            // 
            this.BbackSem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BbackSem.Location = new System.Drawing.Point(302, 283);
            this.BbackSem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BbackSem.Name = "BbackSem";
            this.BbackSem.Size = new System.Drawing.Size(94, 32);
            this.BbackSem.TabIndex = 7;
            this.BbackSem.Text = "Back";
            this.BbackSem.UseVisualStyleBackColor = false;
            this.BbackSem.Click += new System.EventHandler(this.BbackSem_Click);
            // 
            // AddSemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BbackSem);
            this.Controls.Add(this.BaddSem);
            this.Controls.Add(this.TsemID);
            this.Controls.Add(this.TsemName);
            this.Controls.Add(this.LsemID);
            this.Controls.Add(this.LsemName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddSemesterForm";
            this.Text = "Add Semester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LsemName;
        private System.Windows.Forms.Label LsemID;
        private System.Windows.Forms.TextBox TsemName;
        private System.Windows.Forms.TextBox TsemID;
        private System.Windows.Forms.Button BaddSem;
        private System.Windows.Forms.Button BbackSem;
    }
}