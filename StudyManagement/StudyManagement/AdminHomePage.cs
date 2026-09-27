using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagement
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void Bmanagestu_Click(object sender, EventArgs e)
        {
            ManageStudents m1 = new ManageStudents();
            m1.Show();
            this.Hide();
        }

        private void BmanageC_Click(object sender, EventArgs e)
        {
            ManageCourses m2 = new ManageCourses();
            m2.Show(); 
            this.Hide();
        }

        private void Bsetgrade_Click(object sender, EventArgs e)
        {
            GradeSetting g1 = new GradeSetting();
            g1.Show();
            this.Hide();
        }

        private void BlogoutAd_Click(object sender, EventArgs e)
        {
            Session.logAdminID = null;
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }
    }
}
