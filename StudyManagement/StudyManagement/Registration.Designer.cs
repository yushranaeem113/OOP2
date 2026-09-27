namespace StudyManagement
{
    partial class Registration
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
            this.Lstugender = new System.Windows.Forms.Label();
            this.Tstugender = new System.Windows.Forms.TextBox();
            this.BconRegis = new System.Windows.Forms.Button();
            this.stuID = new System.Windows.Forms.Label();
            this.TstuId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StuReg = new System.Windows.Forms.TabPage();
            this.TstuName = new System.Windows.Forms.TextBox();
            this.Labelstuname = new System.Windows.Forms.Label();
            this.Tstucreditscom = new System.Windows.Forms.TextBox();
            this.Tstucgpa = new System.Windows.Forms.TextBox();
            this.Tstupass = new System.Windows.Forms.TextBox();
            this.Tstuemail = new System.Windows.Forms.TextBox();
            this.LCreditsCom = new System.Windows.Forms.Label();
            this.LCgpa = new System.Windows.Forms.Label();
            this.LSPass = new System.Windows.Forms.Label();
            this.LSemail = new System.Windows.Forms.Label();
            this.AdminReg = new System.Windows.Forms.TabPage();
            this.Badback = new System.Windows.Forms.Button();
            this.Tadname = new System.Windows.Forms.TextBox();
            this.Ladname = new System.Windows.Forms.Label();
            this.Badreg = new System.Windows.Forms.Button();
            this.Tadpass = new System.Windows.Forms.TextBox();
            this.Tademail = new System.Windows.Forms.TextBox();
            this.Ladpass = new System.Windows.Forms.Label();
            this.Lademail = new System.Windows.Forms.Label();
            this.Ladid = new System.Windows.Forms.Label();
            this.Tadid = new System.Windows.Forms.TextBox();
            this.Ladgender = new System.Windows.Forms.Label();
            this.Tadgender = new System.Windows.Forms.TextBox();
            this.BstuBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.StuReg.SuspendLayout();
            this.AdminReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lstugender
            // 
            this.Lstugender.AutoSize = true;
            this.Lstugender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lstugender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lstugender.Location = new System.Drawing.Point(142, 215);
            this.Lstugender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lstugender.Name = "Lstugender";
            this.Lstugender.Size = new System.Drawing.Size(60, 16);
            this.Lstugender.TabIndex = 1;
            this.Lstugender.Text = "Gender";
            // 
            // Tstugender
            // 
            this.Tstugender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tstugender.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tstugender.Location = new System.Drawing.Point(307, 215);
            this.Tstugender.Margin = new System.Windows.Forms.Padding(2);
            this.Tstugender.Name = "Tstugender";
            this.Tstugender.Size = new System.Drawing.Size(150, 26);
            this.Tstugender.TabIndex = 7;
            // 
            // BconRegis
            // 
            this.BconRegis.BackColor = System.Drawing.Color.Teal;
            this.BconRegis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BconRegis.Location = new System.Drawing.Point(149, 487);
            this.BconRegis.Margin = new System.Windows.Forms.Padding(2);
            this.BconRegis.Name = "BconRegis";
            this.BconRegis.Size = new System.Drawing.Size(88, 28);
            this.BconRegis.TabIndex = 12;
            this.BconRegis.Text = "CONFIRM";
            this.BconRegis.UseVisualStyleBackColor = false;
            this.BconRegis.Click += new System.EventHandler(this.BconRegis_Click);
            // 
            // stuID
            // 
            this.stuID.AutoSize = true;
            this.stuID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stuID.Location = new System.Drawing.Point(142, 170);
            this.stuID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(91, 16);
            this.stuID.TabIndex = 14;
            this.stuID.Text = "Student ID:";
            this.stuID.Click += new System.EventHandler(this.label1_Click);
            // 
            // TstuId
            // 
            this.TstuId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuId.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TstuId.Location = new System.Drawing.Point(307, 166);
            this.TstuId.Margin = new System.Windows.Forms.Padding(2);
            this.TstuId.Name = "TstuId";
            this.TstuId.Size = new System.Drawing.Size(150, 26);
            this.TstuId.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StuReg);
            this.tabControl1.Controls.Add(this.AdminReg);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 634);
            this.tabControl1.TabIndex = 16;
            // 
            // StuReg
            // 
            this.StuReg.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.StuReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StuReg.Controls.Add(this.BstuBack);
            this.StuReg.Controls.Add(this.TstuName);
            this.StuReg.Controls.Add(this.Labelstuname);
            this.StuReg.Controls.Add(this.Tstucreditscom);
            this.StuReg.Controls.Add(this.Tstucgpa);
            this.StuReg.Controls.Add(this.BconRegis);
            this.StuReg.Controls.Add(this.Tstupass);
            this.StuReg.Controls.Add(this.Tstuemail);
            this.StuReg.Controls.Add(this.LCreditsCom);
            this.StuReg.Controls.Add(this.LCgpa);
            this.StuReg.Controls.Add(this.LSPass);
            this.StuReg.Controls.Add(this.LSemail);
            this.StuReg.Controls.Add(this.stuID);
            this.StuReg.Controls.Add(this.TstuId);
            this.StuReg.Controls.Add(this.Lstugender);
            this.StuReg.Controls.Add(this.Tstugender);
            this.StuReg.Location = new System.Drawing.Point(4, 22);
            this.StuReg.Name = "StuReg";
            this.StuReg.Padding = new System.Windows.Forms.Padding(3);
            this.StuReg.Size = new System.Drawing.Size(627, 608);
            this.StuReg.TabIndex = 0;
            this.StuReg.Text = "Student Registration";
            this.StuReg.UseVisualStyleBackColor = true;
            // 
            // TstuName
            // 
            this.TstuName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TstuName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TstuName.Location = new System.Drawing.Point(308, 127);
            this.TstuName.Margin = new System.Windows.Forms.Padding(2);
            this.TstuName.Name = "TstuName";
            this.TstuName.Size = new System.Drawing.Size(150, 26);
            this.TstuName.TabIndex = 25;
            // 
            // Labelstuname
            // 
            this.Labelstuname.AutoSize = true;
            this.Labelstuname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelstuname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Labelstuname.Location = new System.Drawing.Point(142, 129);
            this.Labelstuname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Labelstuname.Name = "Labelstuname";
            this.Labelstuname.Size = new System.Drawing.Size(114, 16);
            this.Labelstuname.TabIndex = 24;
            this.Labelstuname.Text = "Student Name:";
            this.Labelstuname.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tstucreditscom
            // 
            this.Tstucreditscom.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tstucreditscom.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tstucreditscom.Location = new System.Drawing.Point(308, 409);
            this.Tstucreditscom.Margin = new System.Windows.Forms.Padding(2);
            this.Tstucreditscom.Name = "Tstucreditscom";
            this.Tstucreditscom.Size = new System.Drawing.Size(150, 26);
            this.Tstucreditscom.TabIndex = 23;
            // 
            // Tstucgpa
            // 
            this.Tstucgpa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tstucgpa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tstucgpa.Location = new System.Drawing.Point(308, 367);
            this.Tstucgpa.Margin = new System.Windows.Forms.Padding(2);
            this.Tstucgpa.Name = "Tstucgpa";
            this.Tstucgpa.Size = new System.Drawing.Size(150, 26);
            this.Tstucgpa.TabIndex = 22;
            // 
            // Tstupass
            // 
            this.Tstupass.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tstupass.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tstupass.Location = new System.Drawing.Point(308, 321);
            this.Tstupass.Margin = new System.Windows.Forms.Padding(2);
            this.Tstupass.Name = "Tstupass";
            this.Tstupass.Size = new System.Drawing.Size(150, 26);
            this.Tstupass.TabIndex = 21;
            // 
            // Tstuemail
            // 
            this.Tstuemail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tstuemail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tstuemail.Location = new System.Drawing.Point(308, 267);
            this.Tstuemail.Margin = new System.Windows.Forms.Padding(2);
            this.Tstuemail.Name = "Tstuemail";
            this.Tstuemail.Size = new System.Drawing.Size(150, 26);
            this.Tstuemail.TabIndex = 20;
            // 
            // LCreditsCom
            // 
            this.LCreditsCom.AutoSize = true;
            this.LCreditsCom.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCreditsCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCreditsCom.Location = new System.Drawing.Point(145, 415);
            this.LCreditsCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCreditsCom.Name = "LCreditsCom";
            this.LCreditsCom.Size = new System.Drawing.Size(135, 16);
            this.LCreditsCom.TabIndex = 19;
            this.LCreditsCom.Text = "Credit Completed";
            // 
            // LCgpa
            // 
            this.LCgpa.AutoSize = true;
            this.LCgpa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCgpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCgpa.Location = new System.Drawing.Point(145, 371);
            this.LCgpa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCgpa.Name = "LCgpa";
            this.LCgpa.Size = new System.Drawing.Size(55, 16);
            this.LCgpa.TabIndex = 18;
            this.LCgpa.Text = "CGPA";
            // 
            // LSPass
            // 
            this.LSPass.AutoSize = true;
            this.LSPass.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LSPass.Location = new System.Drawing.Point(144, 323);
            this.LSPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LSPass.Name = "LSPass";
            this.LSPass.Size = new System.Drawing.Size(76, 16);
            this.LSPass.TabIndex = 17;
            this.LSPass.Text = "Password";
            // 
            // LSemail
            // 
            this.LSemail.AutoSize = true;
            this.LSemail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LSemail.Location = new System.Drawing.Point(142, 271);
            this.LSemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LSemail.Name = "LSemail";
            this.LSemail.Size = new System.Drawing.Size(49, 16);
            this.LSemail.TabIndex = 16;
            this.LSemail.Text = "Email";
            // 
            // AdminReg
            // 
            this.AdminReg.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.AdminReg.Controls.Add(this.Badback);
            this.AdminReg.Controls.Add(this.Tadname);
            this.AdminReg.Controls.Add(this.Ladname);
            this.AdminReg.Controls.Add(this.Badreg);
            this.AdminReg.Controls.Add(this.Tadpass);
            this.AdminReg.Controls.Add(this.Tademail);
            this.AdminReg.Controls.Add(this.Ladpass);
            this.AdminReg.Controls.Add(this.Lademail);
            this.AdminReg.Controls.Add(this.Ladid);
            this.AdminReg.Controls.Add(this.Tadid);
            this.AdminReg.Controls.Add(this.Ladgender);
            this.AdminReg.Controls.Add(this.Tadgender);
            this.AdminReg.Location = new System.Drawing.Point(4, 22);
            this.AdminReg.Name = "AdminReg";
            this.AdminReg.Padding = new System.Windows.Forms.Padding(3);
            this.AdminReg.Size = new System.Drawing.Size(627, 608);
            this.AdminReg.TabIndex = 1;
            this.AdminReg.Text = "Admin Registration";
            this.AdminReg.UseVisualStyleBackColor = true;
            // 
            // Badback
            // 
            this.Badback.BackColor = System.Drawing.Color.Teal;
            this.Badback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Badback.Location = new System.Drawing.Point(384, 414);
            this.Badback.Margin = new System.Windows.Forms.Padding(2);
            this.Badback.Name = "Badback";
            this.Badback.Size = new System.Drawing.Size(88, 28);
            this.Badback.TabIndex = 42;
            this.Badback.Text = "BACK";
            this.Badback.UseVisualStyleBackColor = false;
            this.Badback.Click += new System.EventHandler(this.Badback_Click);
            // 
            // Tadname
            // 
            this.Tadname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tadname.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tadname.Location = new System.Drawing.Point(323, 162);
            this.Tadname.Margin = new System.Windows.Forms.Padding(2);
            this.Tadname.Name = "Tadname";
            this.Tadname.Size = new System.Drawing.Size(150, 26);
            this.Tadname.TabIndex = 41;
            // 
            // Ladname
            // 
            this.Ladname.AutoSize = true;
            this.Ladname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ladname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ladname.Location = new System.Drawing.Point(157, 164);
            this.Ladname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ladname.Name = "Ladname";
            this.Ladname.Size = new System.Drawing.Size(108, 16);
            this.Ladname.TabIndex = 40;
            this.Ladname.Text = "Admin Name:";
            // 
            // Badreg
            // 
            this.Badreg.BackColor = System.Drawing.Color.Teal;
            this.Badreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Badreg.Location = new System.Drawing.Point(154, 414);
            this.Badreg.Margin = new System.Windows.Forms.Padding(2);
            this.Badreg.Name = "Badreg";
            this.Badreg.Size = new System.Drawing.Size(88, 28);
            this.Badreg.TabIndex = 29;
            this.Badreg.Text = "CONFIRM";
            this.Badreg.UseVisualStyleBackColor = false;
            this.Badreg.Click += new System.EventHandler(this.Badreg_Click);
            // 
            // Tadpass
            // 
            this.Tadpass.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tadpass.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tadpass.Location = new System.Drawing.Point(323, 356);
            this.Tadpass.Margin = new System.Windows.Forms.Padding(2);
            this.Tadpass.Name = "Tadpass";
            this.Tadpass.Size = new System.Drawing.Size(150, 26);
            this.Tadpass.TabIndex = 37;
            // 
            // Tademail
            // 
            this.Tademail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tademail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tademail.Location = new System.Drawing.Point(323, 302);
            this.Tademail.Margin = new System.Windows.Forms.Padding(2);
            this.Tademail.Name = "Tademail";
            this.Tademail.Size = new System.Drawing.Size(150, 26);
            this.Tademail.TabIndex = 36;
            // 
            // Ladpass
            // 
            this.Ladpass.AutoSize = true;
            this.Ladpass.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ladpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ladpass.Location = new System.Drawing.Point(159, 358);
            this.Ladpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ladpass.Name = "Ladpass";
            this.Ladpass.Size = new System.Drawing.Size(76, 16);
            this.Ladpass.TabIndex = 33;
            this.Ladpass.Text = "Password";
            // 
            // Lademail
            // 
            this.Lademail.AutoSize = true;
            this.Lademail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lademail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lademail.Location = new System.Drawing.Point(157, 306);
            this.Lademail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lademail.Name = "Lademail";
            this.Lademail.Size = new System.Drawing.Size(49, 16);
            this.Lademail.TabIndex = 32;
            this.Lademail.Text = "Email";
            // 
            // Ladid
            // 
            this.Ladid.AutoSize = true;
            this.Ladid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ladid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ladid.Location = new System.Drawing.Point(157, 205);
            this.Ladid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ladid.Name = "Ladid";
            this.Ladid.Size = new System.Drawing.Size(85, 16);
            this.Ladid.TabIndex = 30;
            this.Ladid.Text = "Admin ID:";
            // 
            // Tadid
            // 
            this.Tadid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tadid.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tadid.Location = new System.Drawing.Point(322, 201);
            this.Tadid.Margin = new System.Windows.Forms.Padding(2);
            this.Tadid.Name = "Tadid";
            this.Tadid.Size = new System.Drawing.Size(150, 26);
            this.Tadid.TabIndex = 31;
            // 
            // Ladgender
            // 
            this.Ladgender.AutoSize = true;
            this.Ladgender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ladgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ladgender.Location = new System.Drawing.Point(157, 250);
            this.Ladgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ladgender.Name = "Ladgender";
            this.Ladgender.Size = new System.Drawing.Size(60, 16);
            this.Ladgender.TabIndex = 27;
            this.Ladgender.Text = "Gender";
            // 
            // Tadgender
            // 
            this.Tadgender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tadgender.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Tadgender.Location = new System.Drawing.Point(322, 250);
            this.Tadgender.Margin = new System.Windows.Forms.Padding(2);
            this.Tadgender.Name = "Tadgender";
            this.Tadgender.Size = new System.Drawing.Size(150, 26);
            this.Tadgender.TabIndex = 28;
            // 
            // BstuBack
            // 
            this.BstuBack.BackColor = System.Drawing.Color.Teal;
            this.BstuBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BstuBack.Location = new System.Drawing.Point(369, 487);
            this.BstuBack.Margin = new System.Windows.Forms.Padding(2);
            this.BstuBack.Name = "BstuBack";
            this.BstuBack.Size = new System.Drawing.Size(88, 28);
            this.BstuBack.TabIndex = 26;
            this.BstuBack.Text = "BACK";
            this.BstuBack.UseVisualStyleBackColor = false;
            this.BstuBack.Click += new System.EventHandler(this.BstuBack_Click_1);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 658);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registration";
            this.Text = "Registration Page";
            this.tabControl1.ResumeLayout(false);
            this.StuReg.ResumeLayout(false);
            this.StuReg.PerformLayout();
            this.AdminReg.ResumeLayout(false);
            this.AdminReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lstugender;
        private System.Windows.Forms.TextBox Tstugender;
        private System.Windows.Forms.Button BconRegis;
        private System.Windows.Forms.Label stuID;
        private System.Windows.Forms.TextBox TstuId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StuReg;
        private System.Windows.Forms.TextBox Tstucreditscom;
        private System.Windows.Forms.TextBox Tstucgpa;
        private System.Windows.Forms.TextBox Tstupass;
        private System.Windows.Forms.TextBox Tstuemail;
        private System.Windows.Forms.Label LCreditsCom;
        private System.Windows.Forms.Label LCgpa;
        private System.Windows.Forms.Label LSPass;
        private System.Windows.Forms.Label LSemail;
        private System.Windows.Forms.TabPage AdminReg;
        private System.Windows.Forms.Label Labelstuname;
        private System.Windows.Forms.TextBox TstuName;
        private System.Windows.Forms.Button Badback;
        private System.Windows.Forms.TextBox Tadname;
        private System.Windows.Forms.Label Ladname;
        private System.Windows.Forms.Button Badreg;
        private System.Windows.Forms.TextBox Tadpass;
        private System.Windows.Forms.TextBox Tademail;
        private System.Windows.Forms.Label Ladpass;
        private System.Windows.Forms.Label Lademail;
        private System.Windows.Forms.Label Ladid;
        private System.Windows.Forms.TextBox Tadid;
        private System.Windows.Forms.Label Ladgender;
        private System.Windows.Forms.TextBox Tadgender;
        private System.Windows.Forms.Button BstuBack;
    }
}