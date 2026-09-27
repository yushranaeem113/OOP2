using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudyManagement
{
    internal class Student : User
    {
        private string studentId;
        private double cgpa;
        private int creditsCompleted;


        public Student() { }

        public Student(string studentId, string name, string gender,
                       string email, string password, double cgpa, int creditsCompleted)
            : base(name, gender, email, password)
        {
            this.studentId = studentId;
            this.cgpa = cgpa;
            this.creditsCompleted = creditsCompleted;

        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public double CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public int CreditsCompleted
        {
            get { return creditsCompleted; }
            set { creditsCompleted = value; }
        }

        string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security = True; Connect Timeout = 30";

        public DataTable showAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connection);

            string q = "Select * From Students";
            SqlDataAdapter sda = new SqlDataAdapter(q, conn);
            sda.Fill(dt);

            return dt;
        }

        public bool Insert(Student s)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                /* string checkQuery = "SELECT COUNT(*) FROM Students WHERE SID=@Id OR SEmail=@Semail";
                 SqlCommand cmdCheck = new SqlCommand(checkQuery, conn);
                 cmdCheck.Parameters.AddWithValue("@Id", s.StudentId);
                 cmdCheck.Parameters.AddWithValue("@Semail", s.Email);

                 int count = (int)cmdCheck.ExecuteScalar();

                 if (count > 0)
                 {
                     MessageBox.Show("Student ID or Email already exists. Please use different values.");
                      // stop registration
                 }*/

                string q = "Insert INTO Students (SID,SName,SEmail,SGender,SPassword,CGPA,[Credits Complete]) values " +
                    "(@Id, @Name, @Semail, @Sgender, @Spassword, @Cgpa, @Creditscompleted)";
                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@Id", s.StudentId);
                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Semail", s.Email);
                cmd.Parameters.AddWithValue("@Sgender", s.Gender);
                cmd.Parameters.AddWithValue("@Spassword", s.Password);
                cmd.Parameters.AddWithValue("@Cgpa", s.CGPA);
                cmd.Parameters.AddWithValue("@CreditsCompleted", s.CreditsCompleted);

                int row = cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    if (row > 0)
                    {
                        success = true;
                    }

                }
            }
            catch (Exception e)
            {
                success = false;
            }
            finally
            {
                conn.Close();
            }

            return success;


        }
        public bool Update(Student s)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Update Students set SName = @Name,SEmail = @Semail," +
                    "SGender = @Sgender," +
                    "SPassword = @SPassword, CGPA = @Cgpa," +
                    "[Credits Complete] = @CreditsCompleted where SID = @Id";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@Id", s.StudentId);
                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Semail", s.Email);
                cmd.Parameters.AddWithValue("@Sgender", s.Gender);
                cmd.Parameters.AddWithValue("@Spassword", s.Password);
                cmd.Parameters.AddWithValue("@Cgpa", s.CGPA);
                cmd.Parameters.AddWithValue("@CreditsCompleted", s.CreditsCompleted);

                int row = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    if (row > 0)
                    {
                        success = true;

                    }
                }


            }
            catch (Exception e)
            {
                success = false;
            }
            finally
            {
                conn.Close();
            }

            return success;

        }

        public bool Delete(Student s)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Delete from Students where SID = @Id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@Id", s.StudentId);

                int row = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    if (row > 0)
                    {
                        success = true;
                    }
                }

            }
            catch (Exception e) { success = false; }
            finally
            {
                conn.Close();
            }
            return success;

        }

        public bool AdminInsert(Student s, Admin a)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            try
            {
                string q1 = "INSERT INTO Students (SID, SName, SEmail, SGender, SPassword, CGPA, [Credits Complete]) " +
                            "VALUES (@Id, @Name, @Email, @Gender, @Password, @Cgpa, @CreditsCompleted)";

                SqlCommand cmd1 = new SqlCommand(q1, conn);
                cmd1.Parameters.AddWithValue("@Id", s.StudentId);
                cmd1.Parameters.AddWithValue("@Name", s.Name);
                cmd1.Parameters.AddWithValue("@Email", s.Email);
                cmd1.Parameters.AddWithValue("@Gender", s.Gender);
                cmd1.Parameters.AddWithValue("@Password", s.Password);
                cmd1.Parameters.AddWithValue("@Cgpa", s.CGPA);
                cmd1.Parameters.AddWithValue("@CreditsCompleted", s.CreditsCompleted);

                int row1 = cmd1.ExecuteNonQuery();

                string q2 = "INSERT INTO AdminStudents (AID, SID) VALUES (@AdminId, @StudentId)";
                SqlCommand cmd2 = new SqlCommand(q2, conn);
                cmd2.Parameters.AddWithValue("@AdminId", Session.logAdminID); 
                cmd2.Parameters.AddWithValue("@StudentId", s.StudentId);

                int row2 = cmd2.ExecuteNonQuery();

                success = (row1 > 0 && row2 > 0);
            }
            catch (Exception ex)
            {
                success = false;
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

    }
}
