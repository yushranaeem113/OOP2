using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace StudyManagement
{
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
        }
        Student s = new Student();
        Admin a = new Admin();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                s.StudentId = TstuID.Text;
                s.Name = TstuNManage.Text;
                s.Email = TstuEmanage.Text;
                s.Gender = TstuGenManage.Text;
                s.Password = TstuPassManage.Text;
                s.CGPA = Convert.ToDouble(TCgpaManage.Text);
                s.CreditsCompleted = Convert.ToInt32(TstuCreditManage.Text);

                bool isSuccess = s.AdminInsert(s,a);
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

            DataTable dt = s.showAll();
            studentmdata.DataSource = dt;
        }
        public void Clear()
        {
            TstuID.Clear();
            TstuNManage.Clear();
            TCgpaManage.Clear();
            TstuEmanage.Clear();
            TstuGenManage.Clear();
            TstuPassManage.Clear();
            TstuCreditManage.Clear();
           
        }



        private void BdeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {

                s.StudentId = TstuID.Text;

                bool isSuccess = s.Delete(s);
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
            DataTable dt = s.showAll();
            studentmdata.DataSource = dt;
        }



        
            

        private void BEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                s.StudentId = TstuID.Text;
                s.Name = TstuNManage.Text;
                s.Email = TstuEmanage.Text;
                s.Gender = TstuGenManage.Text;
                s.Password = TstuPassManage.Text;
                s.CGPA = Convert.ToDouble(TCgpaManage.Text);
                s.CreditsCompleted = Convert.ToInt32(TstuCreditManage.Text);

                bool isSuccess = s.Update(s);
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
            DataTable dt = s.showAll();
            studentmdata.DataSource = dt;

        }

        private void BbackManage_Click(object sender, EventArgs e)
        {
            AdminHomePage a1 = new AdminHomePage();
            a1.Show();
            this.Hide();
        }

        private void TstuCreditManage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bshowstu_Click(object sender, EventArgs e)
        {
            DataTable dt = s.showAll();
          studentmdata.DataSource = dt;
        }
    }
}
