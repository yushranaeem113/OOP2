namespace StudyManagement
{
    partial class GradeSetting
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
            this.Lgradeletter = new System.Windows.Forms.Label();
            this.Lminper = new System.Windows.Forms.Label();
            this.TgradeLetter = new System.Windows.Forms.TextBox();
            this.TMinper = new System.Windows.Forms.TextBox();
            this.BsetGrade = new System.Windows.Forms.Button();
            this.BbackSetGrade = new System.Windows.Forms.Button();
            this.datagrades = new System.Windows.Forms.DataGridView();
            this.Bdltgrade = new System.Windows.Forms.Button();
            this.Beditgrade = new System.Windows.Forms.Button();
            this.Bshowgrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrades)).BeginInit();
            this.SuspendLayout();
            // 
            // Lgradeletter
            // 
            this.Lgradeletter.AutoSize = true;
            this.Lgradeletter.BackColor = System.Drawing.Color.Transparent;
            this.Lgradeletter.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lgradeletter.ForeColor = System.Drawing.Color.White;
            this.Lgradeletter.Location = new System.Drawing.Point(38, 60);
            this.Lgradeletter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lgradeletter.Name = "Lgradeletter";
            this.Lgradeletter.Size = new System.Drawing.Size(116, 20);
            this.Lgradeletter.TabIndex = 0;
            this.Lgradeletter.Text = "Grade Letter";
            // 
            // Lminper
            // 
            this.Lminper.AutoSize = true;
            this.Lminper.BackColor = System.Drawing.Color.Transparent;
            this.Lminper.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lminper.ForeColor = System.Drawing.Color.White;
            this.Lminper.Location = new System.Drawing.Point(38, 125);
            this.Lminper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lminper.Name = "Lminper";
            this.Lminper.Size = new System.Drawing.Size(191, 20);
            this.Lminper.TabIndex = 1;
            this.Lminper.Text = "Minimum Percentage";
            // 
            // TgradeLetter
            // 
            this.TgradeLetter.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TgradeLetter.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TgradeLetter.Location = new System.Drawing.Point(267, 60);
            this.TgradeLetter.Margin = new System.Windows.Forms.Padding(2);
            this.TgradeLetter.Name = "TgradeLetter";
            this.TgradeLetter.Size = new System.Drawing.Size(136, 29);
            this.TgradeLetter.TabIndex = 2;
            // 
            // TMinper
            // 
            this.TMinper.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMinper.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TMinper.Location = new System.Drawing.Point(267, 125);
            this.TMinper.Margin = new System.Windows.Forms.Padding(2);
            this.TMinper.Name = "TMinper";
            this.TMinper.Size = new System.Drawing.Size(136, 29);
            this.TMinper.TabIndex = 3;
            // 
            // BsetGrade
            // 
            this.BsetGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BsetGrade.ForeColor = System.Drawing.Color.Black;
            this.BsetGrade.Location = new System.Drawing.Point(42, 183);
            this.BsetGrade.Margin = new System.Windows.Forms.Padding(2);
            this.BsetGrade.Name = "BsetGrade";
            this.BsetGrade.Size = new System.Drawing.Size(113, 38);
            this.BsetGrade.TabIndex = 4;
            this.BsetGrade.Text = "Set Grade";
            this.BsetGrade.UseVisualStyleBackColor = false;
            this.BsetGrade.Click += new System.EventHandler(this.BsetGrade_Click);
            // 
            // BbackSetGrade
            // 
            this.BbackSetGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BbackSetGrade.Location = new System.Drawing.Point(154, 334);
            this.BbackSetGrade.Margin = new System.Windows.Forms.Padding(2);
            this.BbackSetGrade.Name = "BbackSetGrade";
            this.BbackSetGrade.Size = new System.Drawing.Size(111, 38);
            this.BbackSetGrade.TabIndex = 5;
            this.BbackSetGrade.Text = "Back";
            this.BbackSetGrade.UseVisualStyleBackColor = false;
            this.BbackSetGrade.Click += new System.EventHandler(this.BbackSetGrade_Click);
            // 
            // datagrades
            // 
            this.datagrades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.datagrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrades.Location = new System.Drawing.Point(452, 60);
            this.datagrades.Name = "datagrades";
            this.datagrades.Size = new System.Drawing.Size(359, 515);
            this.datagrades.TabIndex = 6;
            // 
            // Bdltgrade
            // 
            this.Bdltgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bdltgrade.ForeColor = System.Drawing.Color.Black;
            this.Bdltgrade.Location = new System.Drawing.Point(42, 266);
            this.Bdltgrade.Margin = new System.Windows.Forms.Padding(2);
            this.Bdltgrade.Name = "Bdltgrade";
            this.Bdltgrade.Size = new System.Drawing.Size(113, 38);
            this.Bdltgrade.TabIndex = 7;
            this.Bdltgrade.Text = "Delete";
            this.Bdltgrade.UseVisualStyleBackColor = false;
            this.Bdltgrade.Click += new System.EventHandler(this.Bdltgrade_Click);
            // 
            // Beditgrade
            // 
            this.Beditgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Beditgrade.ForeColor = System.Drawing.Color.Black;
            this.Beditgrade.Location = new System.Drawing.Point(276, 183);
            this.Beditgrade.Margin = new System.Windows.Forms.Padding(2);
            this.Beditgrade.Name = "Beditgrade";
            this.Beditgrade.Size = new System.Drawing.Size(113, 38);
            this.Beditgrade.TabIndex = 8;
            this.Beditgrade.Text = "Edit";
            this.Beditgrade.UseVisualStyleBackColor = false;
            this.Beditgrade.Click += new System.EventHandler(this.Beditgrade_Click);
            // 
            // Bshowgrade
            // 
            this.Bshowgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bshowgrade.ForeColor = System.Drawing.Color.Black;
            this.Bshowgrade.Location = new System.Drawing.Point(276, 266);
            this.Bshowgrade.Margin = new System.Windows.Forms.Padding(2);
            this.Bshowgrade.Name = "Bshowgrade";
            this.Bshowgrade.Size = new System.Drawing.Size(113, 38);
            this.Bshowgrade.TabIndex = 9;
            this.Bshowgrade.Text = "Show All";
            this.Bshowgrade.UseVisualStyleBackColor = false;
            this.Bshowgrade.Click += new System.EventHandler(this.Bshowgrade_Click);
            // 
            // GradeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 606);
            this.Controls.Add(this.Bshowgrade);
            this.Controls.Add(this.Beditgrade);
            this.Controls.Add(this.Bdltgrade);
            this.Controls.Add(this.datagrades);
            this.Controls.Add(this.BbackSetGrade);
            this.Controls.Add(this.BsetGrade);
            this.Controls.Add(this.TMinper);
            this.Controls.Add(this.TgradeLetter);
            this.Controls.Add(this.Lminper);
            this.Controls.Add(this.Lgradeletter);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GradeSetting";
            this.Text = "Set Grades Threshold";
            ((System.ComponentModel.ISupportInitialize)(this.datagrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lgradeletter;
        private System.Windows.Forms.Label Lminper;
        private System.Windows.Forms.TextBox TgradeLetter;
        private System.Windows.Forms.TextBox TMinper;
        private System.Windows.Forms.Button BsetGrade;
        private System.Windows.Forms.Button BbackSetGrade;
        private System.Windows.Forms.DataGridView datagrades;
        private System.Windows.Forms.Button Bdltgrade;
        private System.Windows.Forms.Button Beditgrade;
        private System.Windows.Forms.Button Bshowgrade;
    }
}