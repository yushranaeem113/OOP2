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
    public partial class ManageCourses : Form
    {
        public ManageCourses()
        {
            InitializeComponent();
        }
        Course c = new Course();
        Admin a = new Admin();

        private void BaddCManage_Click(object sender, EventArgs e)
        {

            try
            {
                c.CourseId = TCourseCode.Text;
                c.CourseName = TCourseName.Text;
                c.Credit = Convert.ToInt32(TCourseCredit.Text);
                c.QuizCount = Convert.ToInt32(Tquizcount.Text);
                bool isSuccess = c.AdminInsert(c,a);
                if (isSuccess == true)
                {
                    MessageBox.Show("Successfully Added!");

                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally { }

            DataTable dt = c.showAll();
            coursemngdata.DataSource = dt;
        }




        private void BbackCManage_Click(object sender, EventArgs e)
        {
            AdminHomePage adminPage = new AdminHomePage();
            adminPage.Show();
            this.Close();
        }

        private void Bshowcourse_Click(object sender, EventArgs e)
        {
            DataTable dt = c.showAll();
            coursemngdata.DataSource = dt;
        }

        private void Bdeletecourse_Click(object sender, EventArgs e)
        {
            try
            {

                c.CourseId = TCourseCode.Text;
                

                bool isSuccess = c.Delete(c);
                if (isSuccess == true)
                {
                    MessageBox.Show("Successfully Deleted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went Wrong!! Try Again!!");
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally
            {

            }
            DataTable dt = c.showAll();
            coursemngdata.DataSource = dt;
        }

        public void Clear()
        {
            TCourseCode.Clear();
            TCourseCredit.Clear();
            TCourseName.Clear();
            Tquizcount.Clear();
          
        }

        private void Beditcourse_Click(object sender, EventArgs e)
        {

            try
            {

                c.CourseId = TCourseCode.Text;
                c.CourseName = TCourseName.Text;
                c.Credit = Convert.ToInt32(TCourseCredit.Text);
                c.QuizCount = Convert.ToInt32(Tquizcount.Text);

                bool isSuccess = c.Update(c);
                if (isSuccess == true)
                {
                    MessageBox.Show("Successfully Updated!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went Wrong!! Try Again!!");
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally
            {

            }
            DataTable dt = c.showAll();
            coursemngdata.DataSource = dt;
        }
    }
}
