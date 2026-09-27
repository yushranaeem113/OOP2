using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagement
{
    internal class Grades
    {
            private string gradeLetter;
            private int minimumPercentage;

          
            public Grades ()
            {
            }

            
            public Grades (string gradeLetter, int minimumPercentage)
            {
                this.gradeLetter = gradeLetter;
                this.minimumPercentage = minimumPercentage;
            }

            
            public string GradeLetter
            {
                get { return gradeLetter; }
                set { gradeLetter = value; }
            }

            public int MinimumPercentage
            {
                get { return minimumPercentage; }
                set { minimumPercentage = value; }
            }

        string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security = True; Connect Timeout = 30";

        public DataTable showAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connection);

            string q = "Select * From GradeThresholds";
            SqlDataAdapter sda = new SqlDataAdapter(q, conn);
            sda.Fill(dt);

            return dt;
        }

        public bool AdminInsert(Grades g, Admin a)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            try
            {

                string q1 = "INSERT INTO GradeThresholds (GradeLetter, MinimumPercentage) " +
                            "VALUES (@Grade, @Percentage)";


                SqlCommand cmd1 = new SqlCommand(q1, conn);
                cmd1.Parameters.AddWithValue("@Grade", g.GradeLetter);
                cmd1.Parameters.AddWithValue("@Percentage", g.MinimumPercentage);
               


                int row1 = cmd1.ExecuteNonQuery();


                string q2 = "INSERT INTO AdminGradeThresholds(AID, GradeLetter) VALUES (@AdminId, @Grade)";
                SqlCommand cmd2 = new SqlCommand(q2, conn);
                cmd2.Parameters.AddWithValue("@AdminId", Session.logAdminID);
                cmd2.Parameters.AddWithValue("@Grade", g.GradeLetter);

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

        public bool Delete(Grades g)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Delete from GradeThresholds where GradeLetter = @Grade";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@Grade", g.GradeLetter);

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

        public bool Update(Grades g)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Update GradeThresholds set MinimumPercentage = @Percentage where GradeLetter = @Grade";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@Grade", g.GradeLetter);
                cmd.Parameters.AddWithValue("@Percentage", g.MinimumPercentage);


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

    }
    }

