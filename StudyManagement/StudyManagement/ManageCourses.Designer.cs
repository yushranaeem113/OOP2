namespace StudyManagement
{
    partial class ManageCourses
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
            this.LcourseCode = new System.Windows.Forms.Label();
            this.LcourseName = new System.Windows.Forms.Label();
            this.LcourseCredit = new System.Windows.Forms.Label();
            this.TCourseCode = new System.Windows.Forms.TextBox();
            this.TCourseName = new System.Windows.Forms.TextBox();
            this.TCourseCredit = new System.Windows.Forms.TextBox();
            this.BaddCManage = new System.Windows.Forms.Button();
            this.BbackCManage = new System.Windows.Forms.Button();
            this.coursemngdata = new System.Windows.Forms.DataGridView();
            this.Tquizcount = new System.Windows.Forms.TextBox();
            this.quizcount = new System.Windows.Forms.Label();
            this.Bdeletecourse = new System.Windows.Forms.Button();
            this.Bshowcourse = new System.Windows.Forms.Button();
            this.Beditcourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coursemngdata)).BeginInit();
            this.SuspendLayout();
            // 
            // LcourseCode
            // 
            this.LcourseCode.AutoSize = true;
            this.LcourseCode.BackColor = System.Drawing.Color.Transparent;
            this.LcourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcourseCode.ForeColor = System.Drawing.Color.White;
            this.LcourseCode.Location = new System.Drawing.Point(54, 52);
            this.LcourseCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LcourseCode.Name = "LcourseCode";
            this.LcourseCode.Size = new System.Drawing.Size(156, 29);
            this.LcourseCode.TabIndex = 0;
            this.LcourseCode.Text = "Course Code";
            // 
            // LcourseName
            // 
            this.LcourseName.AutoSize = true;
            this.LcourseName.BackColor = System.Drawing.Color.Transparent;
            this.LcourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcourseName.ForeColor = System.Drawing.Color.White;
            this.LcourseName.Location = new System.Drawing.Point(54, 107);
            this.LcourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LcourseName.Name = "LcourseName";
            this.LcourseName.Size = new System.Drawing.Size(162, 29);
            this.LcourseName.TabIndex = 1;
            this.LcourseName.Text = "Course Name";
            // 
            // LcourseCredit
            // 
            this.LcourseCredit.AutoSize = true;
            this.LcourseCredit.BackColor = System.Drawing.Color.Transparent;
            this.LcourseCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcourseCredit.ForeColor = System.Drawing.Color.White;
            this.LcourseCredit.Location = new System.Drawing.Point(54, 162);
            this.LcourseCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LcourseCredit.Name = "LcourseCredit";
            this.LcourseCredit.Size = new System.Drawing.Size(162, 29);
            this.LcourseCredit.TabIndex = 2;
            this.LcourseCredit.Text = "Course Credit";
            // 
            // TCourseCode
            // 
            this.TCourseCode.Location = new System.Drawing.Point(247, 61);
            this.TCourseCode.Margin = new System.Windows.Forms.Padding(2);
            this.TCourseCode.Name = "TCourseCode";
            this.TCourseCode.Size = new System.Drawing.Size(122, 20);
            this.TCourseCode.TabIndex = 3;
            // 
            // TCourseName
            // 
            this.TCourseName.Location = new System.Drawing.Point(247, 116);
            this.TCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.TCourseName.Name = "TCourseName";
            this.TCourseName.Size = new System.Drawing.Size(122, 20);
            this.TCourseName.TabIndex = 4;
            // 
            // TCourseCredit
            // 
            this.TCourseCredit.Location = new System.Drawing.Point(247, 166);
            this.TCourseCredit.Margin = new System.Windows.Forms.Padding(2);
            this.TCourseCredit.Name = "TCourseCredit";
            this.TCourseCredit.Size = new System.Drawing.Size(122, 20);
            this.TCourseCredit.TabIndex = 5;
            // 
            // BaddCManage
            // 
            this.BaddCManage.BackColor = System.Drawing.Color.Teal;
            this.BaddCManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BaddCManage.Location = new System.Drawing.Point(59, 293);
            this.BaddCManage.Margin = new System.Windows.Forms.Padding(2);
            this.BaddCManage.Name = "BaddCManage";
            this.BaddCManage.Size = new System.Drawing.Size(94, 32);
            this.BaddCManage.TabIndex = 6;
            this.BaddCManage.Text = "Add Course";
            this.BaddCManage.UseVisualStyleBackColor = false;
            this.BaddCManage.Click += new System.EventHandler(this.BaddCManage_Click);
            // 
            // BbackCManage
            // 
            this.BbackCManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BbackCManage.ForeColor = System.Drawing.SystemColors.Control;
            this.BbackCManage.Location = new System.Drawing.Point(158, 425);
            this.BbackCManage.Margin = new System.Windows.Forms.Padding(2);
            this.BbackCManage.Name = "BbackCManage";
            this.BbackCManage.Size = new System.Drawing.Size(102, 32);
            this.BbackCManage.TabIndex = 7;
            this.BbackCManage.Text = "Back";
            this.BbackCManage.UseVisualStyleBackColor = false;
            this.BbackCManage.Click += new System.EventHandler(this.BbackCManage_Click);
            // 
            // coursemngdata
            // 
            this.coursemngdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.coursemngdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursemngdata.Location = new System.Drawing.Point(392, 61);
            this.coursemngdata.Name = "coursemngdata";
            this.coursemngdata.Size = new System.Drawing.Size(331, 579);
            this.coursemngdata.TabIndex = 8;
            // 
            // Tquizcount
            // 
            this.Tquizcount.Location = new System.Drawing.Point(247, 224);
            this.Tquizcount.Margin = new System.Windows.Forms.Padding(2);
            this.Tquizcount.Name = "Tquizcount";
            this.Tquizcount.Size = new System.Drawing.Size(122, 20);
            this.Tquizcount.TabIndex = 10;
            // 
            // quizcount
            // 
            this.quizcount.AutoSize = true;
            this.quizcount.BackColor = System.Drawing.Color.Transparent;
            this.quizcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizcount.ForeColor = System.Drawing.Color.White;
            this.quizcount.Location = new System.Drawing.Point(54, 220);
            this.quizcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quizcount.Name = "quizcount";
            this.quizcount.Size = new System.Drawing.Size(131, 29);
            this.quizcount.TabIndex = 9;
            this.quizcount.Text = "Quiz Count";
            // 
            // Bdeletecourse
            // 
            this.Bdeletecourse.BackColor = System.Drawing.Color.Teal;
            this.Bdeletecourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bdeletecourse.Location = new System.Drawing.Point(59, 360);
            this.Bdeletecourse.Margin = new System.Windows.Forms.Padding(2);
            this.Bdeletecourse.Name = "Bdeletecourse";
            this.Bdeletecourse.Size = new System.Drawing.Size(94, 32);
            this.Bdeletecourse.TabIndex = 11;
            this.Bdeletecourse.Text = "Delete";
            this.Bdeletecourse.UseVisualStyleBackColor = false;
            this.Bdeletecourse.Click += new System.EventHandler(this.Bdeletecourse_Click);
            // 
            // Bshowcourse
            // 
            this.Bshowcourse.BackColor = System.Drawing.Color.Teal;
            this.Bshowcourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bshowcourse.Location = new System.Drawing.Point(263, 293);
            this.Bshowcourse.Margin = new System.Windows.Forms.Padding(2);
            this.Bshowcourse.Name = "Bshowcourse";
            this.Bshowcourse.Size = new System.Drawing.Size(94, 32);
            this.Bshowcourse.TabIndex = 12;
            this.Bshowcourse.Text = "Show All";
            this.Bshowcourse.UseVisualStyleBackColor = false;
            this.Bshowcourse.Click += new System.EventHandler(this.Bshowcourse_Click);
            // 
            // Beditcourse
            // 
            this.Beditcourse.BackColor = System.Drawing.Color.Teal;
            this.Beditcourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Beditcourse.Location = new System.Drawing.Point(263, 360);
            this.Beditcourse.Margin = new System.Windows.Forms.Padding(2);
            this.Beditcourse.Name = "Beditcourse";
            this.Beditcourse.Size = new System.Drawing.Size(94, 32);
            this.Beditcourse.TabIndex = 13;
            this.Beditcourse.Text = "Edit";
            this.Beditcourse.UseVisualStyleBackColor = false;
            this.Beditcourse.Click += new System.EventHandler(this.Beditcourse_Click);
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 678);
            this.Controls.Add(this.Beditcourse);
            this.Controls.Add(this.Bshowcourse);
            this.Controls.Add(this.Bdeletecourse);
            this.Controls.Add(this.Tquizcount);
            this.Controls.Add(this.quizcount);
            this.Controls.Add(this.coursemngdata);
            this.Controls.Add(this.BbackCManage);
            this.Controls.Add(this.BaddCManage);
            this.Controls.Add(this.TCourseCredit);
            this.Controls.Add(this.TCourseName);
            this.Controls.Add(this.TCourseCode);
            this.Controls.Add(this.LcourseCredit);
            this.Controls.Add(this.LcourseName);
            this.Controls.Add(this.LcourseCode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageCourses";
            this.Text = "Course Managing Page";
            ((System.ComponentModel.ISupportInitialize)(this.coursemngdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LcourseCode;
        private System.Windows.Forms.Label LcourseName;
        private System.Windows.Forms.Label LcourseCredit;
        private System.Windows.Forms.TextBox TCourseCode;
        private System.Windows.Forms.TextBox TCourseName;
        private System.Windows.Forms.TextBox TCourseCredit;
        private System.Windows.Forms.Button BaddCManage;
        private System.Windows.Forms.Button BbackCManage;
        private System.Windows.Forms.DataGridView coursemngdata;
        private System.Windows.Forms.TextBox Tquizcount;
        private System.Windows.Forms.Label quizcount;
        private System.Windows.Forms.Button Bdeletecourse;
        private System.Windows.Forms.Button Bshowcourse;
        private System.Windows.Forms.Button Beditcourse;
    }
}