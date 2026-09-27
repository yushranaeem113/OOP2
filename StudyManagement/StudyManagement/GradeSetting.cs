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
    public partial class GradeSetting : Form
    {
        public GradeSetting()
        {
            InitializeComponent();
        }

        Grades g = new Grades();
        Admin a = new Admin();

        private void BsetGrade_Click(object sender, EventArgs e)
        {
            try
            {
               g.GradeLetter = TgradeLetter.Text;
                g.MinimumPercentage = Convert.ToInt32(TMinper.Text);
               

                bool isSuccess = g.AdminInsert(g, a);
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

            DataTable dt = g.showAll();
            datagrades.DataSource = dt;
        }



        private void BbackSetGrade_Click(object sender, EventArgs e)
        {
            AdminHomePage adminPage = new AdminHomePage();
            adminPage.Show();
            this.Close();
        }

        public void Clear()
        {
            TgradeLetter.Clear();
            TMinper.Clear();
           

        }


        private void Beditgrade_Click(object sender, EventArgs e)
        {
            try
            {
                g.GradeLetter = TgradeLetter.Text;
                g.MinimumPercentage = Convert.ToInt32(TMinper.Text);

                bool isSuccess = g.Update(g);
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
            DataTable dt = g.showAll();
            datagrades.DataSource = dt;

        }

        private void Bdltgrade_Click(object sender, EventArgs e)
        {
            try
            {

                g.GradeLetter = TgradeLetter.Text;

                bool isSuccess = g.Delete(g);
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
            DataTable dt = g.showAll();
            datagrades.DataSource = dt;
        }

        private void Bshowgrade_Click(object sender, EventArgs e)
        {
            DataTable dt = g.showAll();
            datagrades.DataSource = dt;
        }
    }
}
