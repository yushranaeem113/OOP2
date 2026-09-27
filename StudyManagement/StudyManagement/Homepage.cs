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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void Bhlogin_Click(object sender, EventArgs e)
        {
            LogIn l1 = new LogIn();
            l1.Show();
            this.Hide();
        }

        private void Bhregistration_Click(object sender, EventArgs e)
        {
            Registration r1 = new Registration();
            r1.Show();
            this.Hide();
        }

        private void Bhexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
