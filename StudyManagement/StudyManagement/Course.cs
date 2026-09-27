using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudyManagement
{

    internal class Course
    {
        private string courseId;
        private string courseName;
        private int credit;
        private int quizCount;
        private List<Assessment> assessments;


        public Course()
        {
            assessments = new List<Assessment>();
        }

        public Course(string courseId, string courseName, int credit, int quizCount)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.credit = credit;
            this.quizCount = quizCount;
            this.assessments = new List<Assessment>();
        }



        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }

        public int QuizCount
        {
            get { return quizCount; }
            set { quizCount = value; }
        }

        public List<Assessment> Assessments
        {
            get { return assessments; }
            set { assessments = value; }
        }


        public void AddAssessment(Assessment a)
        {
            assessments.Add(a);
        }

        public void RemoveAssessment(Assessment a)
        {
            assessments.Remove(a);
        }

        public bool HasAssessments()
        {
            return assessments.Count > 0;
        }


        string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security = True; Connect Timeout = 30";

        public DataTable showAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connection);

            string q = "Select * From Courses";
            SqlDataAdapter sda = new SqlDataAdapter(q, conn);
            sda.Fill(dt);

            return dt;
        }

        public bool AdminInsert(Course c, Admin a)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            try
            {
                
                string q1 = "INSERT INTO Courses (CID, CName,Credit, QuizCount) " +
                            "VALUES (@CId, @Name, @Credit, @Qcount)";


                SqlCommand cmd1 = new SqlCommand(q1, conn);
                cmd1.Parameters.AddWithValue("@CId", c.CourseId);
                cmd1.Parameters.AddWithValue("@Name", c.CourseName);
                cmd1.Parameters.AddWithValue("@Credit", c.Credit);
                cmd1.Parameters.AddWithValue("@Qcount", c.QuizCount);
               

                int row1 = cmd1.ExecuteNonQuery();

               
                string q2 = "INSERT INTO AdminCourses(AID, CID) VALUES (@AdminId, @CId)";
                SqlCommand cmd2 = new SqlCommand(q2, conn);
                cmd2.Parameters.AddWithValue("@AdminId", Session.logAdminID); 
                cmd2.Parameters.AddWithValue("@CId", c.CourseId);

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

        public bool Delete(Course c)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Delete from Courses where CID = @CId";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@CId", c.CourseId);

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

        public bool Update(Course c)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Update Courses set CName = @CName,Credit = @Credit," +
                    "QuizCount = @Qcount" + 
                    " where CID = @CId";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@CId", c.CourseId);
                cmd.Parameters.AddWithValue("@CName", c.CourseName);
                cmd.Parameters.AddWithValue("@Credit", c.Credit);
                cmd.Parameters.AddWithValue("@Qcount", c.QuizCount);
               

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

        public bool CourseToActiveSemester(string courseName)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    Operations op = new Operations();
                    string activeSemId = op.GetActiveSemesterId(Session.logStudentID);

                    if (string.IsNullOrEmpty(activeSemId))
                    {
                        MessageBox.Show("No active semester found.");
                        return false;
                    }

                  
                    string courseId = null;
                    string getIdQuery = "SELECT CID FROM Courses WHERE CName=@CName";
                    using (SqlCommand cmdGetId = new SqlCommand(getIdQuery, conn))
                    {
                        cmdGetId.Parameters.AddWithValue("@CName", courseName.Trim());
                        object result = cmdGetId.ExecuteScalar();
                        if (result != null)
                            courseId = result.ToString(); 
                        else
                        {
                            MessageBox.Show("Course not found! Please select a valid course name.");
                            return false;
                        }
                    }
                    string checkQuery = "SELECT COUNT(*) FROM SemesterCourses WHERE SemID=@SemId AND CID=@Cid";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@SemId", activeSemId);
                        checkCmd.Parameters.AddWithValue("@Cid", courseId);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Course already added to this semester.");
                            return false;
                        }
                    }

                    string q = "INSERT INTO SemesterCourses (SemID, CID) VALUES (@SemId, @Cid)";
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@SemId", activeSemId);
                        cmd.Parameters.AddWithValue("@Cid", courseId);

                        int row = cmd.ExecuteNonQuery();
                        success = row > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
                success = false;
            }

            return success;
        }

        public DataTable studentshowAll()
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    Operations op = new Operations();
                    string activeSemId = op.GetActiveSemesterId(Session.logStudentID);

                    if (string.IsNullOrEmpty(activeSemId))
                    {
                        MessageBox.Show("No active semester found.");
                        return dt;
                    }

                    string q = @"SELECT c.CID, c.CName, c.Credit, c.QuizCount
                         FROM StudentSemesters ss
                         INNER JOIN Semesters sem ON ss.SemID = sem.SemID
                         INNER JOIN SemesterCourses sc ON sem.SemID = sc.SemID
                         INNER JOIN Courses c ON sc.CID = c.CID
                         WHERE ss.SID = @sid 
                           AND sem.isActive = 1;";

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
                MessageBox.Show("Error loading courses: " + ex.Message);
            }

            return dt;
        }

        public bool RemoveCourseFromSemester(string courseName)
        {
            bool success = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    Operations op = new Operations();
                    string activeSemId = op.GetActiveSemesterId(Session.logStudentID);

                    if (string.IsNullOrEmpty(activeSemId))
                    {
                        MessageBox.Show("No active semester found.");
                        return false;
                    }

                    string courseId = null;
                    string getIdQuery = "SELECT CID FROM Courses WHERE CName=@CName";
                    using (SqlCommand cmdGetId = new SqlCommand(getIdQuery, conn))
                    {
                        cmdGetId.Parameters.AddWithValue("@CName", courseName);
                        object result = cmdGetId.ExecuteScalar();
                        if (result == null) return false;
                        courseId = result.ToString();
                    }

                    string q = "DELETE FROM SemesterCourses WHERE SemID=@SemId AND CID=@Cid";
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@SemId", activeSemId);
                        cmd.Parameters.AddWithValue("@Cid", courseId);

                        int row = cmd.ExecuteNonQuery();
                        success = row > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing course: " + ex.Message);
                success = false;
            }
            return success;
        }
        public bool UpdateCourse(Course c)
        {
            bool success = false;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string q = "UPDATE Courses SET CName=@name, Credit=@credit, QuizCount=@qcount WHERE CID=@id";

                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", c.CourseId);
                        cmd.Parameters.AddWithValue("@name", c.CourseName);
                        cmd.Parameters.AddWithValue("@credit", c.Credit);
                        cmd.Parameters.AddWithValue("@qcount", c.QuizCount);

                        int rows = cmd.ExecuteNonQuery();
                        success = rows > 0;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }
            }
            return success;
        }
    }





}











