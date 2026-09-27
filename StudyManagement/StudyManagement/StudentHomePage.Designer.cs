namespace StudyManagement
{
    partial class StudentHomePage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Semester = new System.Windows.Forms.TabPage();
            this.Bbacksem = new System.Windows.Forms.Button();
            this.Bshowsem = new System.Windows.Forms.Button();
            this.Bdeletesem = new System.Windows.Forms.Button();
            this.Beditsem = new System.Windows.Forms.Button();
            this.Baddsem = new System.Windows.Forms.Button();
            this.chisactive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tsemname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datasem = new System.Windows.Forms.DataGridView();
            this.StudentCourses = new System.Windows.Forms.TabPage();
            this.Blogoutcourse = new System.Windows.Forms.Button();
            this.Bshowcourse = new System.Windows.Forms.Button();
            this.Bdeletecourse = new System.Windows.Forms.Button();
            this.Baddcourse = new System.Windows.Forms.Button();
            this.Lstucr = new System.Windows.Forms.Label();
            this.Tstucr = new System.Windows.Forms.TextBox();
            this.dataCourse = new System.Windows.Forms.DataGridView();
            this.Assessments = new System.Windows.Forms.TabPage();
            this.BSHOWA = new System.Windows.Forms.Button();
            this.BDELETEA = new System.Windows.Forms.Button();
            this.BUPDATEA = new System.Windows.Forms.Button();
            this.BADDA = new System.Windows.Forms.Button();
            this.TDDate = new System.Windows.Forms.TextBox();
            this.TAMark = new System.Windows.Forms.TextBox();
            this.TFMark = new System.Windows.Forms.TextBox();
            this.TAsName = new System.Windows.Forms.TextBox();
            this.LDDate = new System.Windows.Forms.Label();
            this.LAMark = new System.Windows.Forms.Label();
            this.LFMark = new System.Windows.Forms.Label();
            this.LAsName = new System.Windows.Forms.Label();
            this.termComboBox = new System.Windows.Forms.ComboBox();
            this.Lterm = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.LselectCourse = new System.Windows.Forms.Label();
            this.AssessmentData = new System.Windows.Forms.DataGridView();
            this.Grades = new System.Windows.Forms.TabPage();
            this.lblGPA = new System.Windows.Forms.Label();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.ShowGrades = new System.Windows.Forms.Button();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Semester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasem)).BeginInit();
            this.StudentCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCourse)).BeginInit();
            this.Assessments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentData)).BeginInit();
            this.Grades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Semester);
            this.tabControl1.Controls.Add(this.StudentCourses);
            this.tabControl1.Controls.Add(this.Assessments);
            this.tabControl1.Controls.Add(this.Grades);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 208);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 396);
            this.tabControl1.TabIndex = 3;
            // 
            // Semester
            // 
            this.Semester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Semester.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.Semester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Semester.Controls.Add(this.Bbacksem);
            this.Semester.Controls.Add(this.Bshowsem);
            this.Semester.Controls.Add(this.Bdeletesem);
            this.Semester.Controls.Add(this.Beditsem);
            this.Semester.Controls.Add(this.Baddsem);
            this.Semester.Controls.Add(this.chisactive);
            this.Semester.Controls.Add(this.label2);
            this.Semester.Controls.Add(this.Tsemname);
            this.Semester.Controls.Add(this.label1);
            this.Semester.Controls.Add(this.datasem);
            this.Semester.Location = new System.Drawing.Point(4, 25);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(1075, 367);
            this.Semester.TabIndex = 4;
            this.Semester.Text = "Semester";
            // 
            // Bbacksem
            // 
            this.Bbacksem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bbacksem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbacksem.Location = new System.Drawing.Point(268, 300);
            this.Bbacksem.Name = "Bbacksem";
            this.Bbacksem.Size = new System.Drawing.Size(94, 32);
            this.Bbacksem.TabIndex = 11;
            this.Bbacksem.Text = "LOGOUT";
            this.Bbacksem.UseVisualStyleBackColor = false;
            this.Bbacksem.Click += new System.EventHandler(this.Bbacksem_Click);
            // 
            // Bshowsem
            // 
            this.Bshowsem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bshowsem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bshowsem.Location = new System.Drawing.Point(475, 228);
            this.Bshowsem.Name = "Bshowsem";
            this.Bshowsem.Size = new System.Drawing.Size(94, 32);
            this.Bshowsem.TabIndex = 10;
            this.Bshowsem.Text = "SHOW";
            this.Bshowsem.UseVisualStyleBackColor = false;
            this.Bshowsem.Click += new System.EventHandler(this.Bshowsem_Click);
            // 
            // Bdeletesem
            // 
            this.Bdeletesem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bdeletesem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdeletesem.Location = new System.Drawing.Point(332, 228);
            this.Bdeletesem.Name = "Bdeletesem";
            this.Bdeletesem.Size = new System.Drawing.Size(94, 32);
            this.Bdeletesem.TabIndex = 9;
            this.Bdeletesem.Text = "DELETE";
            this.Bdeletesem.UseVisualStyleBackColor = false;
            this.Bdeletesem.Click += new System.EventHandler(this.Bdeletesem_Click);
            // 
            // Beditsem
            // 
            this.Beditsem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Beditsem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beditsem.Location = new System.Drawing.Point(194, 228);
            this.Beditsem.Name = "Beditsem";
            this.Beditsem.Size = new System.Drawing.Size(94, 32);
            this.Beditsem.TabIndex = 8;
            this.Beditsem.Text = "EDIT";
            this.Beditsem.UseVisualStyleBackColor = false;
            this.Beditsem.Click += new System.EventHandler(this.Beditsem_Click);
            // 
            // Baddsem
            // 
            this.Baddsem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Baddsem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baddsem.Location = new System.Drawing.Point(60, 228);
            this.Baddsem.Name = "Baddsem";
            this.Baddsem.Size = new System.Drawing.Size(94, 32);
            this.Baddsem.TabIndex = 7;
            this.Baddsem.Text = "ADD";
            this.Baddsem.UseVisualStyleBackColor = false;
            this.Baddsem.Click += new System.EventHandler(this.Baddsem_Click_1);
            // 
            // chisactive
            // 
            this.chisactive.AutoSize = true;
            this.chisactive.BackColor = System.Drawing.Color.White;
            this.chisactive.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chisactive.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chisactive.Location = new System.Drawing.Point(306, 155);
            this.chisactive.Name = "chisactive";
            this.chisactive.Size = new System.Drawing.Size(92, 20);
            this.chisactive.TabIndex = 6;
            this.chisactive.Text = "ACTIVE";
            this.chisactive.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ACTIVE:";
            // 
            // Tsemname
            // 
            this.Tsemname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tsemname.Location = new System.Drawing.Point(306, 96);
            this.Tsemname.Name = "Tsemname";
            this.Tsemname.Size = new System.Drawing.Size(168, 26);
            this.Tsemname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEMESTER NAME:";
            // 
            // datasem
            // 
            this.datasem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.datasem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasem.Location = new System.Drawing.Point(608, 16);
            this.datasem.Name = "datasem";
            this.datasem.Size = new System.Drawing.Size(462, 332);
            this.datasem.TabIndex = 0;
            // 
            // StudentCourses
            // 
            this.StudentCourses.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.StudentCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StudentCourses.Controls.Add(this.Blogoutcourse);
            this.StudentCourses.Controls.Add(this.Bshowcourse);
            this.StudentCourses.Controls.Add(this.Bdeletecourse);
            this.StudentCourses.Controls.Add(this.Baddcourse);
            this.StudentCourses.Controls.Add(this.Lstucr);
            this.StudentCourses.Controls.Add(this.Tstucr);
            this.StudentCourses.Controls.Add(this.dataCourse);
            this.StudentCourses.Location = new System.Drawing.Point(4, 25);
            this.StudentCourses.Name = "StudentCourses";
            this.StudentCourses.Padding = new System.Windows.Forms.Padding(3);
            this.StudentCourses.Size = new System.Drawing.Size(1075, 367);
            this.StudentCourses.TabIndex = 1;
            this.StudentCourses.Text = "Courses";
            this.StudentCourses.UseVisualStyleBackColor = true;
            // 
            // Blogoutcourse
            // 
            this.Blogoutcourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Blogoutcourse.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogoutcourse.Location = new System.Drawing.Point(240, 280);
            this.Blogoutcourse.Name = "Blogoutcourse";
            this.Blogoutcourse.Size = new System.Drawing.Size(94, 32);
            this.Blogoutcourse.TabIndex = 15;
            this.Blogoutcourse.Text = "LOGOUT";
            this.Blogoutcourse.UseVisualStyleBackColor = false;
            this.Blogoutcourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bshowcourse
            // 
            this.Bshowcourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bshowcourse.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bshowcourse.Location = new System.Drawing.Point(376, 209);
            this.Bshowcourse.Name = "Bshowcourse";
            this.Bshowcourse.Size = new System.Drawing.Size(94, 32);
            this.Bshowcourse.TabIndex = 14;
            this.Bshowcourse.Text = "SHOW";
            this.Bshowcourse.UseVisualStyleBackColor = false;
            this.Bshowcourse.Click += new System.EventHandler(this.Bshowcourse_Click);
            // 
            // Bdeletecourse
            // 
            this.Bdeletecourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bdeletecourse.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdeletecourse.Location = new System.Drawing.Point(240, 209);
            this.Bdeletecourse.Name = "Bdeletecourse";
            this.Bdeletecourse.Size = new System.Drawing.Size(94, 32);
            this.Bdeletecourse.TabIndex = 13;
            this.Bdeletecourse.Text = "DELETE";
            this.Bdeletecourse.UseVisualStyleBackColor = false;
            this.Bdeletecourse.Click += new System.EventHandler(this.Bdeletecourse_Click_1);
            // 
            // Baddcourse
            // 
            this.Baddcourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Baddcourse.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baddcourse.Location = new System.Drawing.Point(102, 209);
            this.Baddcourse.Name = "Baddcourse";
            this.Baddcourse.Size = new System.Drawing.Size(94, 32);
            this.Baddcourse.TabIndex = 8;
            this.Baddcourse.Text = "ADD";
            this.Baddcourse.UseVisualStyleBackColor = false;
            this.Baddcourse.Click += new System.EventHandler(this.Baddcourse_Click);
            // 
            // Lstucr
            // 
            this.Lstucr.AutoSize = true;
            this.Lstucr.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lstucr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lstucr.Location = new System.Drawing.Point(165, 66);
            this.Lstucr.Name = "Lstucr";
            this.Lstucr.Size = new System.Drawing.Size(239, 20);
            this.Lstucr.TabIndex = 2;
            this.Lstucr.Text = "ENTER COURSE NAME:";
            // 
            // Tstucr
            // 
            this.Tstucr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tstucr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Tstucr.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tstucr.Location = new System.Drawing.Point(143, 115);
            this.Tstucr.Name = "Tstucr";
            this.Tstucr.Size = new System.Drawing.Size(271, 29);
            this.Tstucr.TabIndex = 1;
            // 
            // dataCourse
            // 
            this.dataCourse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCourse.Location = new System.Drawing.Point(589, 20);
            this.dataCourse.Name = "dataCourse";
            this.dataCourse.Size = new System.Drawing.Size(480, 335);
            this.dataCourse.TabIndex = 0;
            // 
            // Assessments
            // 
            this.Assessments.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.Assessments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Assessments.Controls.Add(this.BSHOWA);
            this.Assessments.Controls.Add(this.BDELETEA);
            this.Assessments.Controls.Add(this.BUPDATEA);
            this.Assessments.Controls.Add(this.BADDA);
            this.Assessments.Controls.Add(this.TDDate);
            this.Assessments.Controls.Add(this.TAMark);
            this.Assessments.Controls.Add(this.TFMark);
            this.Assessments.Controls.Add(this.TAsName);
            this.Assessments.Controls.Add(this.LDDate);
            this.Assessments.Controls.Add(this.LAMark);
            this.Assessments.Controls.Add(this.LFMark);
            this.Assessments.Controls.Add(this.LAsName);
            this.Assessments.Controls.Add(this.termComboBox);
            this.Assessments.Controls.Add(this.Lterm);
            this.Assessments.Controls.Add(this.courseComboBox);
            this.Assessments.Controls.Add(this.LselectCourse);
            this.Assessments.Controls.Add(this.AssessmentData);
            this.Assessments.Location = new System.Drawing.Point(4, 25);
            this.Assessments.Name = "Assessments";
            this.Assessments.Size = new System.Drawing.Size(1075, 367);
            this.Assessments.TabIndex = 2;
            this.Assessments.Text = "Assessments";
            this.Assessments.UseVisualStyleBackColor = true;
            // 
            // BSHOWA
            // 
            this.BSHOWA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BSHOWA.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSHOWA.Location = new System.Drawing.Point(448, 295);
            this.BSHOWA.Name = "BSHOWA";
            this.BSHOWA.Size = new System.Drawing.Size(83, 26);
            this.BSHOWA.TabIndex = 17;
            this.BSHOWA.Text = "SHOW";
            this.BSHOWA.UseVisualStyleBackColor = false;
            this.BSHOWA.Click += new System.EventHandler(this.button5_Click);
            // 
            // BDELETEA
            // 
            this.BDELETEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BDELETEA.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDELETEA.Location = new System.Drawing.Point(304, 295);
            this.BDELETEA.Name = "BDELETEA";
            this.BDELETEA.Size = new System.Drawing.Size(89, 26);
            this.BDELETEA.TabIndex = 16;
            this.BDELETEA.Text = "DELETE";
            this.BDELETEA.UseVisualStyleBackColor = false;
            this.BDELETEA.Click += new System.EventHandler(this.BDELETEA_Click);
            // 
            // BUPDATEA
            // 
            this.BUPDATEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BUPDATEA.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUPDATEA.Location = new System.Drawing.Point(155, 295);
            this.BUPDATEA.Name = "BUPDATEA";
            this.BUPDATEA.Size = new System.Drawing.Size(89, 26);
            this.BUPDATEA.TabIndex = 15;
            this.BUPDATEA.Text = "EDIT";
            this.BUPDATEA.UseVisualStyleBackColor = false;
            this.BUPDATEA.Click += new System.EventHandler(this.BUPDATEA_Click);
            // 
            // BADDA
            // 
            this.BADDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BADDA.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BADDA.Location = new System.Drawing.Point(32, 295);
            this.BADDA.Name = "BADDA";
            this.BADDA.Size = new System.Drawing.Size(76, 26);
            this.BADDA.TabIndex = 14;
            this.BADDA.Text = "ADD";
            this.BADDA.UseVisualStyleBackColor = false;
            this.BADDA.Click += new System.EventHandler(this.button2_Click);
            // 
            // TDDate
            // 
            this.TDDate.Location = new System.Drawing.Point(232, 253);
            this.TDDate.Name = "TDDate";
            this.TDDate.Size = new System.Drawing.Size(218, 21);
            this.TDDate.TabIndex = 12;
            // 
            // TAMark
            // 
            this.TAMark.Location = new System.Drawing.Point(232, 222);
            this.TAMark.Name = "TAMark";
            this.TAMark.Size = new System.Drawing.Size(218, 21);
            this.TAMark.TabIndex = 11;
            // 
            // TFMark
            // 
            this.TFMark.Location = new System.Drawing.Point(232, 188);
            this.TFMark.Name = "TFMark";
            this.TFMark.Size = new System.Drawing.Size(218, 21);
            this.TFMark.TabIndex = 10;
            // 
            // TAsName
            // 
            this.TAsName.Location = new System.Drawing.Point(232, 156);
            this.TAsName.Name = "TAsName";
            this.TAsName.Size = new System.Drawing.Size(218, 21);
            this.TAsName.TabIndex = 9;
            // 
            // LDDate
            // 
            this.LDDate.AutoSize = true;
            this.LDDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDDate.ForeColor = System.Drawing.Color.White;
            this.LDDate.Location = new System.Drawing.Point(50, 253);
            this.LDDate.Name = "LDDate";
            this.LDDate.Size = new System.Drawing.Size(76, 16);
            this.LDDate.TabIndex = 8;
            this.LDDate.Text = "Due Date";
            // 
            // LAMark
            // 
            this.LAMark.AutoSize = true;
            this.LAMark.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAMark.ForeColor = System.Drawing.Color.White;
            this.LAMark.Location = new System.Drawing.Point(50, 222);
            this.LAMark.Name = "LAMark";
            this.LAMark.Size = new System.Drawing.Size(119, 16);
            this.LAMark.TabIndex = 7;
            this.LAMark.Text = "Achieved Mark";
            // 
            // LFMark
            // 
            this.LFMark.AutoSize = true;
            this.LFMark.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFMark.ForeColor = System.Drawing.Color.White;
            this.LFMark.Location = new System.Drawing.Point(50, 188);
            this.LFMark.Name = "LFMark";
            this.LFMark.Size = new System.Drawing.Size(79, 16);
            this.LFMark.TabIndex = 6;
            this.LFMark.Text = "Full Mark";
            // 
            // LAsName
            // 
            this.LAsName.AutoSize = true;
            this.LAsName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAsName.ForeColor = System.Drawing.Color.White;
            this.LAsName.Location = new System.Drawing.Point(50, 156);
            this.LAsName.Name = "LAsName";
            this.LAsName.Size = new System.Drawing.Size(138, 16);
            this.LAsName.TabIndex = 5;
            this.LAsName.Text = "Assessment Name";
            // 
            // termComboBox
            // 
            this.termComboBox.FormattingEnabled = true;
            this.termComboBox.Items.AddRange(new object[] {
            "Midterm",
            "Finalterm"});
            this.termComboBox.Location = new System.Drawing.Point(232, 96);
            this.termComboBox.Name = "termComboBox";
            this.termComboBox.Size = new System.Drawing.Size(218, 24);
            this.termComboBox.TabIndex = 4;
            // 
            // Lterm
            // 
            this.Lterm.AutoSize = true;
            this.Lterm.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lterm.ForeColor = System.Drawing.Color.White;
            this.Lterm.Location = new System.Drawing.Point(86, 98);
            this.Lterm.Name = "Lterm";
            this.Lterm.Size = new System.Drawing.Size(99, 16);
            this.Lterm.TabIndex = 3;
            this.Lterm.Text = "Select Term:";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(232, 46);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(218, 24);
            this.courseComboBox.TabIndex = 2;
            // 
            // LselectCourse
            // 
            this.LselectCourse.AutoSize = true;
            this.LselectCourse.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LselectCourse.ForeColor = System.Drawing.Color.White;
            this.LselectCourse.Location = new System.Drawing.Point(86, 48);
            this.LselectCourse.Name = "LselectCourse";
            this.LselectCourse.Size = new System.Drawing.Size(112, 16);
            this.LselectCourse.TabIndex = 1;
            this.LselectCourse.Text = "Select Course:";
            // 
            // AssessmentData
            // 
            this.AssessmentData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AssessmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentData.Location = new System.Drawing.Point(593, 16);
            this.AssessmentData.Name = "AssessmentData";
            this.AssessmentData.Size = new System.Drawing.Size(476, 339);
            this.AssessmentData.TabIndex = 0;
            // 
            // Grades
            // 
            this.Grades.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.Grades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Grades.Controls.Add(this.lblSuggestion);
            this.Grades.Controls.Add(this.ShowGrades);
            this.Grades.Controls.Add(this.dgvGrades);
            this.Grades.Controls.Add(this.lblGPA);
            this.Grades.Location = new System.Drawing.Point(4, 25);
            this.Grades.Name = "Grades";
            this.Grades.Size = new System.Drawing.Size(1075, 367);
            this.Grades.TabIndex = 3;
            this.Grades.Text = "Grades";
            this.Grades.UseVisualStyleBackColor = true;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.ForeColor = System.Drawing.Color.White;
            this.lblGPA.Location = new System.Drawing.Point(62, 49);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(138, 16);
            this.lblGPA.TabIndex = 0;
            this.lblGPA.Text = "Semester Average";
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(368, 23);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.Size = new System.Drawing.Size(693, 327);
            this.dgvGrades.TabIndex = 1;
            this.dgvGrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellClick);
            // 
            // ShowGrades
            // 
            this.ShowGrades.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGrades.Location = new System.Drawing.Point(123, 255);
            this.ShowGrades.Name = "ShowGrades";
            this.ShowGrades.Size = new System.Drawing.Size(117, 23);
            this.ShowGrades.TabIndex = 2;
            this.ShowGrades.Text = "SHow Grades";
            this.ShowGrades.UseVisualStyleBackColor = true;
            this.ShowGrades.Click += new System.EventHandler(this.ShowGrades_Click);
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.ForeColor = System.Drawing.Color.White;
            this.lblSuggestion.Location = new System.Drawing.Point(62, 108);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(164, 16);
            this.lblSuggestion.TabIndex = 3;
            this.lblSuggestion.Text = "Semester Suggestions";
            // 
            // StudentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 618);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentHomePage";
            this.Text = "Student Home Page";
            this.Load += new System.EventHandler(this.StudentHomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.Semester.ResumeLayout(false);
            this.Semester.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasem)).EndInit();
            this.StudentCourses.ResumeLayout(false);
            this.StudentCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCourse)).EndInit();
            this.Assessments.ResumeLayout(false);
            this.Assessments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentData)).EndInit();
            this.Grades.ResumeLayout(false);
            this.Grades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StudentCourses;
        private System.Windows.Forms.TabPage Assessments;
        private System.Windows.Forms.TabPage Grades;
        private System.Windows.Forms.DataGridView dataCourse;
        private System.Windows.Forms.TabPage Semester;
        private System.Windows.Forms.DataGridView datasem;
        private System.Windows.Forms.DataGridView AssessmentData;
        private System.Windows.Forms.CheckBox chisactive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tsemname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bdeletesem;
        private System.Windows.Forms.Button Beditsem;
        private System.Windows.Forms.Button Baddsem;
        private System.Windows.Forms.Button Bbacksem;
        private System.Windows.Forms.Button Bshowsem;
        private System.Windows.Forms.Label Lstucr;
        private System.Windows.Forms.TextBox Tstucr;
        private System.Windows.Forms.Button Blogoutcourse;
        private System.Windows.Forms.Button Bshowcourse;
        private System.Windows.Forms.Button Bdeletecourse;
        private System.Windows.Forms.Button Baddcourse;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label LselectCourse;
        private System.Windows.Forms.ComboBox termComboBox;
        private System.Windows.Forms.Label Lterm;
        private System.Windows.Forms.Label LAMark;
        private System.Windows.Forms.Label LFMark;
        private System.Windows.Forms.Label LAsName;
        private System.Windows.Forms.TextBox TAsName;
        private System.Windows.Forms.Label LDDate;
        private System.Windows.Forms.TextBox TDDate;
        private System.Windows.Forms.TextBox TAMark;
        private System.Windows.Forms.TextBox TFMark;
        private System.Windows.Forms.Button BSHOWA;
        private System.Windows.Forms.Button BDELETEA;
        private System.Windows.Forms.Button BUPDATEA;
        private System.Windows.Forms.Button BADDA;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Button ShowGrades;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label lblSuggestion;
    }
}