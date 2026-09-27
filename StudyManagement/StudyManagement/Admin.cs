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
    internal class Admin:User
    {
        private string adminId;

        public Admin() { }

        public Admin(string adminId, string name, string gender,
                     string email, string password)
            : base(name, gender, email, password)
        {
            this.adminId = adminId;

        }

        public string AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }

        string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security = True; Connect Timeout = 30";

        public DataTable showAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connection);

            string q = "Select * From Adminss";
            SqlDataAdapter sda = new SqlDataAdapter(q, conn);
            sda.Fill(dt);

            return dt;
        }

        public bool Insert(Admin a)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Insert INTO Admins (AID,AName,AEmail, AGender,APass) values " +
                    "(@Id, @Name, @Aemail, @Agender, @Apassword)";
                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@Id", a.AdminId);
                cmd.Parameters.AddWithValue("@Name", a.Name);
                cmd.Parameters.AddWithValue("@Aemail", a.Email);
                cmd.Parameters.AddWithValue("@Agender", a.Gender);
                cmd.Parameters.AddWithValue("@Apassword", a.Password);
               

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
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;


        }
        public bool Update(Admin a)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            try
            {
                string q = "Update Admins set AName = @Name,AEmail = @Aemail," +
                    "AGender = @Agender," +
                    "APass = @APassword where AID = @Id";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@Id", a.AdminId);
                cmd.Parameters.AddWithValue("@Name", a.Name);
                cmd.Parameters.AddWithValue("@Aemail", a.Email);
                cmd.Parameters.AddWithValue("@Agender", a.Gender);
                cmd.Parameters.AddWithValue("@Apassword", a.Password);

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
