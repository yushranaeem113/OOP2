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
    internal class Assessments
    {
        
            

            private int assessmentId;
            private string assessmentName;
            private double achievedMark;
            private double fullMark;
            private string dueDate;
            private string term;



            public Assessments() { }

            public Assessments(int assessmentId, string assessmentName, int topicSize, double fullMark, string dueDate, double achievedMark, string term)
            {
                this.assessmentId = assessmentId;
                this.assessmentName = assessmentName;
                this.fullMark = fullMark;
                this.dueDate = dueDate;
                this.achievedMark = achievedMark;
                this.term = term;

            }

            public int AssessmentId
            {
                get { return assessmentId; }
                set { assessmentId = value; }
            }

            public string AssessmentName
            {
                get { return assessmentName; }
                set { assessmentName = value; }
            }

            public double AchievedMark
            {
                get { return achievedMark; }
                set { achievedMark = value; }
            }

            public double FullMark
            {
                get { return fullMark; }
                set { fullMark = value; }
            }

            public string DueDate
            {
                get { return dueDate; }
                set { dueDate = value; }
            }

            public string Term 
            { 
                get { return term; } 
              set { term = value; }

            }
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security=True;Connect Timeout=30";

        public bool AddAssessmentToCourse(string courseName, Assessments assessment)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string courseId = null;
                        string getCourseQuery = "SELECT CID FROM Courses WHERE CName=@CName";
                        using (SqlCommand cmdGetCourse = new SqlCommand(getCourseQuery, conn, transaction))
                        {
                            cmdGetCourse.Parameters.AddWithValue("@CName", courseName.Trim());
                            object result = cmdGetCourse.ExecuteScalar();
                            if (result != null)
                                courseId = result.ToString();
                            else
                            {
                                MessageBox.Show("Course not found!");
                                return false;
                            }
                        }

                       
                        string insertAssessmentQuery = @"INSERT INTO Assessments 
                                             (AsName, FullMark, AchievedMark, DueDate, Term)
                                             VALUES (@AName, @FullMark,@Achieved, @DueDate, @Term);
                                             SELECT SCOPE_IDENTITY();";
                        int assessmentId;
                        using (SqlCommand cmdInsertAssessment = new SqlCommand(insertAssessmentQuery, conn, transaction))
                        {
                            cmdInsertAssessment.Parameters.AddWithValue("@AName", assessment.AssessmentName);
                            cmdInsertAssessment.Parameters.AddWithValue("@FullMark", assessment.FullMark);
                            cmdInsertAssessment.Parameters.AddWithValue("@DueDate", assessment.DueDate);
                            cmdInsertAssessment.Parameters.AddWithValue("@Term", assessment.Term);
                            cmdInsertAssessment.Parameters.AddWithValue("@Achieved", assessment.AchievedMark);

                            assessmentId = Convert.ToInt32(cmdInsertAssessment.ExecuteScalar());
                        }

                        string insertCourseAssessment = "INSERT INTO CourseAssessments (CID, AsID) VALUES (@CID, @AsID)";
                        using (SqlCommand cmdCourseAssessment = new SqlCommand(insertCourseAssessment, conn, transaction))
                        {
                            cmdCourseAssessment.Parameters.AddWithValue("@CID", courseId);
                            cmdCourseAssessment.Parameters.AddWithValue("@AsID", assessmentId);
                            cmdCourseAssessment.ExecuteNonQuery();
                        }

                        string insertStuAs = "INSERT INTO StuAs (SID, AsID) VALUES (@SID, @AsID)";
                        using (SqlCommand cmdStuAs = new SqlCommand(insertStuAs, conn, transaction))
                        {
                            cmdStuAs.Parameters.AddWithValue("@SID", Session.logStudentID);
                            cmdStuAs.Parameters.AddWithValue("@AsID", assessmentId);
                            

                            int rows = cmdStuAs.ExecuteNonQuery();
                            success = rows > 0;
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding assessment: " + ex.Message);
                success = false;
            }

            return success;
        }


        public DataTable ShowAll()
        {
            DataTable dt = new DataTable();
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.AsID, 
                    a.AsName, 
                    a.AchievedMark, 
                    a.FullMark, 
                    a.DueDate, 
                    a.Term, 
                    ca.CID
                FROM StuAs sa
                INNER JOIN Assessments a ON sa.AsID = a.AsID
                INNER JOIN CourseAssessments ca ON a.AsID = ca.AsID
                WHERE sa.SID = @sid
                 order by  ca.CID ASC;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@sid", Session.logStudentID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dt;
        }
        public bool DeleteAssessment(Assessments assessment)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Delete from Assessments where AsID = @asid";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@asid", assessment.AssessmentId);

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

        public bool UpdateAssessment(Assessments a)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "UPDATE Assessments SET AsName = @name, AchievedMark = @mark, FullMark = @full, DueDate = @due, Term = @term WHERE AsID = @asid";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@asid", a.AssessmentId);
                cmd.Parameters.AddWithValue("@name", a.AssessmentName);
                cmd.Parameters.AddWithValue("@mark", a.AchievedMark);
                cmd.Parameters.AddWithValue("@full", a.FullMark);
                cmd.Parameters.AddWithValue("@due", a.DueDate);
                cmd.Parameters.AddWithValue("@term", a.Term);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    success = true;
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


    }
}

