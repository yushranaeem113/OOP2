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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        Student s = new Student();
        Admin a = new Admin();
        private void BconRegis_Click(object sender, EventArgs e)
        {
            

            try 
            {
                s.StudentId = TstuId.Text;
                s.Name = TstuName.Text;
                s.Email = Tstuemail.Text;
                s.Gender = Tstugender.Text;
                s.Password = Tstupass.Text;
                s.CGPA = Convert.ToDouble(Tstucgpa.Text);
                s.CreditsCompleted = Convert.ToInt32(Tstucreditscom.Text);

                bool isSuccess = s.Insert(s);
                if(isSuccess == true)
                {
                    MessageBox.Show("Successfully Registered!");
                    
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
            
        }

        /*private void BstuBack_Click(object sender, EventArgs e)
        {
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BstuBack_Click_1(object sender, EventArgs e)
        {
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }

        private void Badreg_Click(object sender, EventArgs e)
        {
            try
            {
                a.AdminId = Tadid.Text;
                a.Name = Tadname.Text;
                a.Email = Tademail.Text;
                a.Gender = Tadgender.Text;
                a.Password = Tadpass.Text;
               

                bool isSuccess = a.Insert(a);
                if (isSuccess == true)
                {
                    MessageBox.Show("Successfully Registered!");

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

        }

        private void Badback_Click(object sender, EventArgs e)
        {
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }
    }
 }

