namespace StudyManagement
{
    partial class ManageStudents
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
            this.LstuIdManage = new System.Windows.Forms.Label();
            this.LstuNameManage = new System.Windows.Forms.Label();
            this.LstuGenderManage = new System.Windows.Forms.Label();
            this.LstuEmailManage = new System.Windows.Forms.Label();
            this.LstuPassManage = new System.Windows.Forms.Label();
            this.LstuCgpaManage = new System.Windows.Forms.Label();
            this.LCgpaManage = new System.Windows.Forms.Label();
            this.TstuID = new System.Windows.Forms.TextBox();
            this.TstuNManage = new System.Windows.Forms.TextBox();
            this.TstuGenManage = new System.Windows.Forms.TextBox();
            this.TstuEmanage = new System.Windows.Forms.TextBox();
            this.TstuPassManage = new System.Windows.Forms.TextBox();
            this.TCgpaManage = new System.Windows.Forms.TextBox();
            this.TstuCreditManage = new System.Windows.Forms.TextBox();
            this.BaddStudent = new System.Windows.Forms.Button();
            this.BdeleteStudent = new System.Windows.Forms.Button();
            this.BEditStudent = new System.Windows.Forms.Button();
            this.BbackManage = new System.Windows.Forms.Button();
            this.studentmdata = new System.Windows.Forms.DataGridView();
            this.Bshowstu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentmdata)).BeginInit();
            this.SuspendLayout();
            // 
            // LstuIdManage
            // 
            this.LstuIdManage.AutoSize = true;
            this.LstuIdManage.BackColor = System.Drawing.Color.Transparent;
            this.LstuIdManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstuIdManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LstuIdManage.Location = new System.Drawing.Point(47, 118);
            this.LstuIdManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LstuIdManage.Name = "LstuIdManage";
            this.LstuIdManage.Size = new System.Drawing.Size(103, 20);
            this.LstuIdManage.TabIndex = 0;
            this.LstuIdManage.Text = "Student ID";
            this.LstuIdManage.Click += new System.EventHandler(this.label1_Click);
            // 
            // LstuNameManage
            // 
            this.LstuNameManage.AutoSize = true;
            this.LstuNameManage.BackColor = System.Drawing.Color.Transparent;
            this.LstuNameManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstuNameManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LstuNameManage.Location = new System.Drawing.Point(47, 152);
            this.LstuNameManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LstuNameManage.Name = "LstuNameManage";
            this.LstuNameManage.Size = new System.Drawing.Size(130, 20);
            this.LstuNameManage.TabIndex = 1;
            this.LstuNameManage.Text = "Student Name";
            // 
            // LstuGenderManage
            // 
            this.LstuGenderManage.AutoSize = true;
            this.LstuGenderManage.BackColor = System.Drawing.Color.Transparent;
            this.LstuGenderManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstuGenderManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LstuGenderManage.Location = new System.Drawing.Point(47, 189);
            this.LstuGenderManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LstuGenderManage.Name = "LstuGenderManage";
            this.LstuGenderManage.Size = new System.Drawing.Size(71, 20);
            this.LstuGenderManage.TabIndex = 2;
            this.LstuGenderManage.Text = "Gender";
            // 
            // LstuEmailManage
            // 
            this.LstuEmailManage.AutoSize = true;
            this.LstuEmailManage.BackColor = System.Drawing.Color.Transparent;
            this.LstuEmailManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstuEmailManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LstuEmailManage.Location = new System.Drawing.Point(47, 234);
            this.LstuEmailManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LstuEmailManage.Name = "LstuEmailManage";
            this.LstuEmailManage.Size = new System.Drawing.Size(66, 20);
            this.LstuEmailManage.TabIndex = 3;
            this.LstuEmailManage.Text = "E-mail";
            // 
            // LstuPassManage
            // 
            this.LstuPassManage.AutoSize = true;
            this.LstuPassManage.BackColor = System.Drawing.Color.Transparent;
            this.LstuPassManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstuPassManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LstuPassManage.Location = new System.Drawing.Point(47, 273);
            this.LstuPassManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LstuPassManage.Name = "LstuPassManage";
            this.LstuPassManage.Size = new System.Drawing.Size(90, 20);
            this.LstuPassManage.TabIndex = 4;
            this.LstuPassManage.Text = "Password";
            // 
            // LstuCgpaManage
            // 
            this.LstuCgpaManage.AutoSize = true;
            this.LstuCgpaManage.BackColor = System.Drawing.Color.Transparent;
            this.LstuCgpaManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstuCgpaManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LstuCgpaManage.Location = new System.Drawing.Point(47, 309);
            this.LstuCgpaManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LstuCgpaManage.Name = "LstuCgpaManage";
            this.LstuCgpaManage.Size = new System.Drawing.Size(54, 20);
            this.LstuCgpaManage.TabIndex = 5;
            this.LstuCgpaManage.Text = "Cgpa";
            // 
            // LCgpaManage
            // 
            this.LCgpaManage.AutoSize = true;
            this.LCgpaManage.BackColor = System.Drawing.Color.Transparent;
            this.LCgpaManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCgpaManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCgpaManage.Location = new System.Drawing.Point(47, 349);
            this.LCgpaManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCgpaManage.Name = "LCgpaManage";
            this.LCgpaManage.Size = new System.Drawing.Size(70, 20);
            this.LCgpaManage.TabIndex = 6;
            this.LCgpaManage.Text = "Credits";
            // 
            // TstuID
            // 
            this.TstuID.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuID.Location = new System.Drawing.Point(185, 115);
            this.TstuID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TstuID.Name = "TstuID";
            this.TstuID.Size = new System.Drawing.Size(185, 29);
            this.TstuID.TabIndex = 7;
            // 
            // TstuNManage
            // 
            this.TstuNManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuNManage.Location = new System.Drawing.Point(185, 152);
            this.TstuNManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TstuNManage.Name = "TstuNManage";
            this.TstuNManage.Size = new System.Drawing.Size(185, 29);
            this.TstuNManage.TabIndex = 8;
            // 
            // TstuGenManage
            // 
            this.TstuGenManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuGenManage.Location = new System.Drawing.Point(185, 189);
            this.TstuGenManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TstuGenManage.Name = "TstuGenManage";
            this.TstuGenManage.Size = new System.Drawing.Size(185, 29);
            this.TstuGenManage.TabIndex = 9;
            // 
            // TstuEmanage
            // 
            this.TstuEmanage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuEmanage.Location = new System.Drawing.Point(185, 234);
            this.TstuEmanage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TstuEmanage.Name = "TstuEmanage";
            this.TstuEmanage.Size = new System.Drawing.Size(185, 29);
            this.TstuEmanage.TabIndex = 10;
            // 
            // TstuPassManage
            // 
            this.TstuPassManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuPassManage.Location = new System.Drawing.Point(185, 273);
            this.TstuPassManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TstuPassManage.Name = "TstuPassManage";
            this.TstuPassManage.Size = new System.Drawing.Size(185, 29);
            this.TstuPassManage.TabIndex = 11;
            // 
            // TCgpaManage
            // 
            this.TCgpaManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCgpaManage.Location = new System.Drawing.Point(185, 309);
            this.TCgpaManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TCgpaManage.Name = "TCgpaManage";
            this.TCgpaManage.Size = new System.Drawing.Size(185, 29);
            this.TCgpaManage.TabIndex = 12;
            // 
            // TstuCreditManage
            // 
            this.TstuCreditManage.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuCreditManage.Location = new System.Drawing.Point(185, 349);
            this.TstuCreditManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TstuCreditManage.Name = "TstuCreditManage";
            this.TstuCreditManage.Size = new System.Drawing.Size(185, 29);
            this.TstuCreditManage.TabIndex = 13;
            this.TstuCreditManage.TextChanged += new System.EventHandler(this.TstuCreditManage_TextChanged);
            // 
            // BaddStudent
            // 
            this.BaddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BaddStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaddStudent.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.BaddStudent.Location = new System.Drawing.Point(51, 438);
            this.BaddStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BaddStudent.Name = "BaddStudent";
            this.BaddStudent.Size = new System.Drawing.Size(104, 28);
            this.BaddStudent.TabIndex = 14;
            this.BaddStudent.Text = "Add Student";
            this.BaddStudent.UseVisualStyleBackColor = false;
            this.BaddStudent.Click += new System.EventHandler(this.BaddStudent_Click);
            // 
            // BdeleteStudent
            // 
            this.BdeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BdeleteStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BdeleteStudent.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.BdeleteStudent.Location = new System.Drawing.Point(275, 438);
            this.BdeleteStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BdeleteStudent.Name = "BdeleteStudent";
            this.BdeleteStudent.Size = new System.Drawing.Size(95, 28);
            this.BdeleteStudent.TabIndex = 15;
            this.BdeleteStudent.Text = "Delete Student";
            this.BdeleteStudent.UseVisualStyleBackColor = false;
            this.BdeleteStudent.Click += new System.EventHandler(this.BdeleteStudent_Click);
            // 
            // BEditStudent
            // 
            this.BEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BEditStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditStudent.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.BEditStudent.Location = new System.Drawing.Point(51, 505);
            this.BEditStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BEditStudent.Name = "BEditStudent";
            this.BEditStudent.Size = new System.Drawing.Size(106, 28);
            this.BEditStudent.TabIndex = 16;
            this.BEditStudent.Text = "Edit Student";
            this.BEditStudent.UseVisualStyleBackColor = false;
            this.BEditStudent.Click += new System.EventHandler(this.BEditStudent_Click);
            // 
            // BbackManage
            // 
            this.BbackManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BbackManage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BbackManage.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.BbackManage.Location = new System.Drawing.Point(161, 607);
            this.BbackManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BbackManage.Name = "BbackManage";
            this.BbackManage.Size = new System.Drawing.Size(87, 28);
            this.BbackManage.TabIndex = 17;
            this.BbackManage.Text = "Back";
            this.BbackManage.UseVisualStyleBackColor = false;
            this.BbackManage.Click += new System.EventHandler(this.BbackManage_Click);
            // 
            // studentmdata
            // 
            this.studentmdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentmdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentmdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentmdata.Location = new System.Drawing.Point(401, 34);
            this.studentmdata.Name = "studentmdata";
            this.studentmdata.Size = new System.Drawing.Size(559, 601);
            this.studentmdata.TabIndex = 18;
            // 
            // Bshowstu
            // 
            this.Bshowstu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bshowstu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bshowstu.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Bshowstu.Location = new System.Drawing.Point(264, 505);
            this.Bshowstu.Margin = new System.Windows.Forms.Padding(2);
            this.Bshowstu.Name = "Bshowstu";
            this.Bshowstu.Size = new System.Drawing.Size(106, 28);
            this.Bshowstu.TabIndex = 19;
            this.Bshowstu.Text = "Show All";
            this.Bshowstu.UseVisualStyleBackColor = false;
            this.Bshowstu.Click += new System.EventHandler(this.Bshowstu_Click);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 658);
            this.Controls.Add(this.Bshowstu);
            this.Controls.Add(this.studentmdata);
            this.Controls.Add(this.BbackManage);
            this.Controls.Add(this.BEditStudent);
            this.Controls.Add(this.BdeleteStudent);
            this.Controls.Add(this.BaddStudent);
            this.Controls.Add(this.TstuCreditManage);
            this.Controls.Add(this.TCgpaManage);
            this.Controls.Add(this.TstuPassManage);
            this.Controls.Add(this.TstuEmanage);
            this.Controls.Add(this.TstuGenManage);
            this.Controls.Add(this.TstuNManage);
            this.Controls.Add(this.TstuID);
            this.Controls.Add(this.LCgpaManage);
            this.Controls.Add(this.LstuCgpaManage);
            this.Controls.Add(this.LstuPassManage);
            this.Controls.Add(this.LstuEmailManage);
            this.Controls.Add(this.LstuGenderManage);
            this.Controls.Add(this.LstuNameManage);
            this.Controls.Add(this.LstuIdManage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStudents";
            this.Text = "Student Managing Page";
            ((System.ComponentModel.ISupportInitialize)(this.studentmdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LstuIdManage;
        private System.Windows.Forms.Label LstuNameManage;
        private System.Windows.Forms.Label LstuGenderManage;
        private System.Windows.Forms.Label LstuEmailManage;
        private System.Windows.Forms.Label LstuPassManage;
        private System.Windows.Forms.Label LstuCgpaManage;
        private System.Windows.Forms.Label LCgpaManage;
        private System.Windows.Forms.TextBox TstuID;
        private System.Windows.Forms.TextBox TstuNManage;
        private System.Windows.Forms.TextBox TstuGenManage;
        private System.Windows.Forms.TextBox TstuEmanage;
        private System.Windows.Forms.TextBox TstuPassManage;
        private System.Windows.Forms.TextBox TCgpaManage;
        private System.Windows.Forms.TextBox TstuCreditManage;
        private System.Windows.Forms.Button BaddStudent;
        private System.Windows.Forms.Button BdeleteStudent;
        private System.Windows.Forms.Button BEditStudent;
        private System.Windows.Forms.Button BbackManage;
        private System.Windows.Forms.DataGridView studentmdata;
        private System.Windows.Forms.Button Bshowstu;
    }
}