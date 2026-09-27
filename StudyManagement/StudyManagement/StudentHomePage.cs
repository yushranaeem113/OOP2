using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagement
{
    public partial class StudentHomePage : Form
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }

        Semester sem = new Semester();
        Student s = new Student();
        Course c = new Course();
        Assessments a = new Assessments ();
        Operations ops = new Operations ();

        private void BlogoutStuHome_Click(object sender, EventArgs e)
        {
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }
        private void StudentHomePage_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security=True;Connect Timeout=30";

            AutoCompleteStringCollection courseNames = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string q = "SELECT CName FROM Courses";
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    courseNames.Add(reader["CName"].ToString());
                }
                conn.Close();
            }
            Tstucr.AutoCompleteCustomSource = courseNames;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = @"
SELECT c.CID, c.CName
FROM Courses c
JOIN SemesterCourses sc ON c.CID = sc.CID
JOIN StudentSemesters ss ON ss.SemID = sc.SemID
WHERE ss.SID = @StudentID";

                    SqlCommand cmd1 = new SqlCommand(query, conn);
                    cmd1.Parameters.AddWithValue("@StudentID", Session.logStudentID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    courseComboBox.DataSource = null;
                    courseComboBox.DataSource = dt;
                    courseComboBox.DisplayMember = "CName";
                    courseComboBox.ValueMember = "CID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }
        }




        /*private void Baddsem_Click(object sender, EventArgs e)
        {
            AddSemesterForm addsem = new AddSemesterForm();
            addsem.Show();
            this.Hide();
        }

        private void BviewSem_Click(object sender, EventArgs e)
        {
            ViewCurrentSemesterForm viewCurrsem = new ViewCurrentSemesterForm();
            viewCurrsem.Show();
            this.Hide();
        }*/
        private void Bbacksem_Click(object sender, EventArgs e)
        {
            Session.logStudentID = null;

            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }
        private void Baddsem_Click_1(object sender, EventArgs e)
        {
            try
            {

                sem.SemesterName = Tsemname.Text;
                sem.IsActive = chisactive.Checked;

                bool isSuccess = sem.StudentInsert(sem, s);
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

            DataTable dt = sem.showAll();
            datasem.DataSource = dt;
        }

        public void Clear()
        {
            ;
            Tsemname.Clear();

        }

        private void Beditsem_Click(object sender, EventArgs e)
        {
            try
            {

                sem.SemesterName = Tsemname.Text;
                sem.IsActive = chisactive.Checked;

                bool isSuccess = sem.Update(sem);
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
            DataTable dt = sem.showAll();
            datasem.DataSource = dt;
        }

        private void Bdeletesem_Click(object sender, EventArgs e)
        {
            try
            {
                if (datasem.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a semester to delete.");
                    return;
                }

                int semId = Convert.ToInt32(datasem.SelectedRows[0].Cells["SemID"].Value);

                bool isSuccess = sem.Delete(semId);
                if (isSuccess)
                {
                    MessageBox.Show("Successfully Deleted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DataTable dt = sem.showAll();
                datasem.DataSource = dt;
            }

        }

        private void Bshowsem_Click(object sender, EventArgs e)
        {
            DataTable dt = sem.showAll();
            datasem.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Baddcourse_Click(object sender, EventArgs e)
        {
            try
            {
                c.CourseId = Tstucr.Text;


                bool isSuccess = c.CourseToActiveSemester(c.CourseId);
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

            DataTable dt = sem.showAll();
            datasem.DataSource = dt;
        }

        /*private void LoadStudentCourses()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT c.CID, c.CName
FROM Courses c
JOIN SemesterCourses sc ON c.CID = sc.CID
JOIN StudentSemesters ss ON ss.SemID = sc.SemID
JOIN Semester sem ON sem.SemID = ss.SemID
WHERE ss.SID = @StudentID
AND sem.IsActive = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", Session.logStudentID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the ComboBox
                    courseComboBox.DisplayMember = "CName"; // what user sees
                    courseComboBox.ValueMember = "CID";     // underlying value
                    courseComboBox.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }
        }*/

        private void button2_Click(object sender, EventArgs e)//ADD BUTTON FOR ASSESSMENTS
        {
            try
            {
               
                    a.AssessmentName = TAsName.Text;
                    a.AchievedMark = Convert.ToDouble(TAMark.Text);
                    a.FullMark = Convert.ToDouble(TFMark.Text);
                    a.DueDate = TDDate.Text;
                    a.Term = termComboBox.Text;

                string selectedCourseName = courseComboBox.Text;


                    bool isSuccess = a.AddAssessmentToCourse(selectedCourseName, a);
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

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = a.ShowAll();
            AssessmentData.DataSource = dt;
        }

        private void BDELETEA_Click(object sender, EventArgs e)
        {
            try
            {
                if (AssessmentData.CurrentRow != null)
                {
                    int id = Convert.ToInt32(AssessmentData.CurrentRow.Cells["AsID"].Value);

                    Assessments a = new Assessments();
                    a.AssessmentId = id;

                    bool isSuccess = a.DeleteAssessment(a);

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
                else
                {
                    MessageBox.Show("Please select a row first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data or selection error");
            }
            finally
            {
                DataTable dt = a.ShowAll();
                AssessmentData.DataSource = dt;
            }
        }

        private void Bshowcourse_Click(object sender, EventArgs e)
        {
            DataTable dt = c.studentshowAll();
            dataCourse.DataSource = dt;
        }

        private void Bdeletecourse_Click(object sender, EventArgs e)
        {
           
        }

        private void BUPDATEA_Click(object sender, EventArgs e)
        {
            try
            {
                a.AssessmentId = Convert.ToInt32(AssessmentData.CurrentRow.Cells["AsID"].Value);

                a.AssessmentName = TAsName.Text;
                a.AchievedMark = Convert.ToDouble(TAMark.Text);
                a.FullMark = Convert.ToDouble(TFMark.Text);
                a.DueDate = TDDate.Text; 
                a.Term = termComboBox.Text;

                bool isSuccess = a.UpdateAssessment(a);

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
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data format. Please check your inputs.");
            }
            finally
            {
                DataTable dt = a.ShowAll();
                AssessmentData.DataSource = dt;
            }
        }

        private void Bdeletecourse_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataCourse.CurrentRow != null)
                {
                    
                    string courseName = dataCourse.CurrentRow.Cells["CName"].Value.ToString();

                    
                    bool isSuccess = c.RemoveCourseFromSemester(courseName);

                    if (isSuccess)
                    {
                        MessageBox.Show("Course removed from this semester successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Could not remove course. It might not be assigned to this semester.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a course from the list first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                DataTable dt = c.studentshowAll();
                dataCourse.DataSource = dt;
            }
        }

        private void ShowGrades_Click(object sender, EventArgs e)
        {
            DataTable dt = ops.CalculateGrades();
            dgvGrades.DataSource = dt;

            if (dgvGrades.Columns.Contains("Credit"))
                dgvGrades.Columns["Credit"].Visible = false;

            double cgpa = ops.GetSemesterCGPA(dt);
            lblGPA.Text = "Semester CGPA: " + cgpa.ToString("0.00");
        }

        private void dgvGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    }
    




        
    
    



