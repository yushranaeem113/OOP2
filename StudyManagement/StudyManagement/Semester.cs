using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagement
{
    internal class Semester
    {
        private int semesterId;
        private string semesterName;
        private bool isActive;
        private List<Course> courses;  

        
        public Semester()
        {
            courses = new List<Course>();
        }

        
        public Semester(int semesterId, string semesterName, bool isActive)
        {
            this.semesterId = semesterId;
            this.semesterName = semesterName;
            this.isActive = isActive;
            this.courses = new List<Course>();
        }

       
        public int SemesterId
        {
            get { return semesterId; }
            set { semesterId = value; }
        }

        public string SemesterName
        {
            get { return semesterName; }
            set { semesterName = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }


        string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security = True; Connect Timeout = 30";

        public DataTable showAll()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string q = @"SELECT s.SemID, s.SemName, s.isActive 
                         FROM Semesters s
                         INNER JOIN StudentSemesters ss ON s.SemID = ss.SemID
                         WHERE ss.SID = @sid";

                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@sid", Session.logStudentID);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading semesters: " + ex.Message);
            }

            return dt;
        }
        
        public bool StudentInsert (Semester sem, Student s)
        {
           
            bool success = false;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                try
                {
                    if (sem.IsActive)
                    {
                        string q0 = @"
                    UPDATE Semesters 
                    SET IsActive = 0 
                    WHERE SemID IN (SELECT SemID FROM StudentSemesters WHERE SID = @sid)";
                        using (SqlCommand cmd0 = new SqlCommand(q0, conn))
                        {
                            cmd0.Parameters.AddWithValue("@sid", Session.logStudentID);
                            cmd0.ExecuteNonQuery();
                        }
                    }

                    string q1 = "INSERT INTO Semesters (SemName, IsActive) VALUES (@semname, @active); SELECT SCOPE_IDENTITY();";
                    int newSemId;
                    using (SqlCommand cmd1 = new SqlCommand(q1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@semname", sem.SemesterName);
                        cmd1.Parameters.AddWithValue("@active", sem.IsActive);
                        newSemId = Convert.ToInt32(cmd1.ExecuteScalar()); 
                    }

                    string q2 = "INSERT INTO StudentSemesters (SID, SemID) VALUES (@sid, @semid)";
                    using (SqlCommand cmd2 = new SqlCommand(q2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@sid", Session.logStudentID);
                        cmd2.Parameters.AddWithValue("@semid", newSemId);
                        int row2 = cmd2.ExecuteNonQuery();

                        success = row2 > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding semester: " + ex.Message);
                    success = false;
                }
            }

            return success;
        }

        
           public bool Delete(int semId)
        {
            bool success = false;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                try
                {
                    string q = "DELETE FROM Semesters WHERE SemID = @semid";
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@semid", semId);
                        int row = cmd.ExecuteNonQuery();
                        success = row > 0;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error deleting semester: " + e.Message);
                    success = false;
                }
            }
            return success;
        }

        

        public bool Update(Semester sem)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Update Semesters set SemName = @semname,IsActive = @active " +
                    
                    " where SemID = @semid";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@semid", sem.SemesterId);
                cmd.Parameters.AddWithValue("@semname", sem.SemesterName);
                cmd.Parameters.AddWithValue("@active", sem.IsActive);


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


        public bool HasCourses()
        {
            return courses.Count > 0;
        }


    }
}
