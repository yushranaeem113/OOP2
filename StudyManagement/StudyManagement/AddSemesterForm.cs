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
    public partial class AddSemesterForm : Form
    {
        public AddSemesterForm()
        {
            InitializeComponent();
        }

        private void BaddSem_Click(object sender, EventArgs e)
        {
            //string semesterName = TsemName.Text;
            //string semesterId = TsemID.Text;
           // int credits = Convert.ToInt32(TsemCredits.Text);

           // MessageBox.Show($"Semester Added Successfully!\n\n" +
                           //$"Semester Name: {semesterName}\n" +
                          // $"Semester ID: {semesterId}\n" +
                           //$"Credits: {credits}",
                           //"Semester Added",
                          // MessageBoxButtons.OK,
                          // MessageBoxIcon.Information);
        }

        private void BbackSem_Click(object sender, EventArgs e)
        {
            StudentHomePage stuHomePage = new StudentHomePage();
            stuHomePage.Show();
            this.Hide();
        }
    }
}
