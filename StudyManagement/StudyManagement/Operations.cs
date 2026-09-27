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
    internal class Operations
    {
        string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security = True; Connect Timeout = 30";

        public string GetActiveSemesterId(string studentId)
        {
            string activeSemId = null;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                try
                {
                    string query =
                        @"SELECT ss.SemID
                  FROM StudentSemesters ss
                  JOIN Semesters sem ON ss.SemID = sem.SemID
                  WHERE ss.SID = @sid AND sem.IsActive = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sid", studentId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            activeSemId = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    activeSemId = null;
                }
            }

            return activeSemId;
        }

        
            public DataTable CalculateGrades()
        {
            DataTable finalReport = new DataTable();
            finalReport.Columns.Add("CID");
            finalReport.Columns.Add("Midterm%", typeof(double));
            finalReport.Columns.Add("Finalterm%", typeof(double));
            finalReport.Columns.Add("FinalScore", typeof(double));
            finalReport.Columns.Add("Grade");
            finalReport.Columns.Add("Credit", typeof(int));

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string q = @"SELECT ca.CID, a.Term, SUM(a.AchievedMark) as SumAchieved, c.Credit
                                FROM StuAs sa
                                INNER JOIN Assessments a ON sa.AsID = a.AsID
                                INNER JOIN CourseAssessments ca ON a.AsID = ca.AsID
                                INNER JOIN Courses c ON ca.CID = c.CID
                                WHERE sa.SID = @sid
                                GROUP BY ca.CID, a.Term, c.Credit";

                    DataTable rawData = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@sid", Session.logStudentID);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(rawData);
                    }



                    List<string> courseList = new List<string>();
                    foreach (DataRow row in rawData.Rows)
                    {
                        string cid = row["CID"].ToString();
                        if (!courseList.Contains(cid))
                        {
                            courseList.Add(cid);
                        }
                    }
                    foreach (string cid in courseList)
                    {
                        double midPoints = 0;
                        double finalPoints = 0;
                        int credits = 0;

                        foreach (DataRow row in rawData.Rows)
                        {
                            if (row["CID"].ToString() == cid)
                            {
                                string term = row["Term"].ToString().ToLower();
                                double marks = Convert.ToDouble(row["SumAchieved"]);
                                credits = Convert.ToInt32(row["Credit"]);

                                if (term.Contains("mid"))
                                {
                                    midPoints += marks;
                                }
                                else if (term.Contains("final"))
                                {
                                    finalPoints += marks;
                                }
                            }
                        }

                        double finalScore = (midPoints * 0.4) + (finalPoints * 0.6);
                        string gradeLetter = GetGradeLetter(finalScore, conn);

                        finalReport.Rows.Add(cid, midPoints, finalPoints, Math.Round(finalScore, 2), gradeLetter, credits);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return finalReport;
        }



        private string GetGradeLetter(double score, SqlConnection conn)
        {
            string q = "SELECT TOP 1 GradeLetter FROM GradeThresholds WHERE MinimumPercentage <= @score ORDER BY MinimumPercentage DESC";

            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@score", score);
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return "F";
                }

                return result.ToString();
            }
        }

        public double GetSemesterCGPA(DataTable report)
        {
            double totalQualityPoints = 0;
            int totalCredits = 0;

            foreach (DataRow row in report.Rows)
            {
                string letter = row["Grade"].ToString();
                int credit = Convert.ToInt32(row["Credit"]);
                double points = 0;

                switch (letter)
                {
                    case "A+": points = 4.00; break;
                    case "A": points = 3.75; break;
                    case "B+": points = 3.50; break;
                    case "B": points = 3.25; break;
                    case "C+": points = 3.00; break;
                    case "C": points = 2.75; break;
                    case "D+": points = 2.50; break;
                    case "D": points = 2.25; break;
                    default: points = 0.00; break;
                }

                totalQualityPoints += (points * credit);
                totalCredits += credit;
            }

            if (totalCredits <= 0)
            {
                return 0;
            }

            return totalQualityPoints / totalCredits;
        }

        

    }
}
