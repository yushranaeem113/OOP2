using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagement
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Blog_Click(object sender, EventArgs e)
        {

            string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amzad\Documents\studentstudy.mdf;Integrated Security = True; Connect Timeout = 30";
             
            if (RoleCombo.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Role Before Logging In.");
                return;
            }

            string role = RoleCombo.SelectedItem.ToString();
            string q = "";

            if (role == "ADMIN")
            {
                q = "SELECT COUNT(*) FROM Admins WHERE AEmail='"
                    + Tlogemail.Text + "' AND APass='" + Tlogpass.Text + "'";
            }
            else if (role == "STUDENT")
            {
                q = "SELECT COUNT(*) FROM Students WHERE SEmail='"
                    + Tlogemail.Text + "' AND SPassword='" + Tlogpass.Text + "'";
            }

            SqlDataAdapter sda = new SqlDataAdapter(q, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                if (role == "ADMIN")
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string getIDQuery = "SELECT AID FROM Admins WHERE AEmail=@email AND APass=@pass";
                        SqlCommand cmd = new SqlCommand(getIDQuery, conn);
                        cmd.Parameters.AddWithValue("@email", Tlogemail.Text);
                        cmd.Parameters.AddWithValue("@pass", Tlogpass.Text);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Session.logAdminID = reader[0].ToString();
                        }
                    }

                    AdminHomePage ah = new AdminHomePage();
                    ah.Show();
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string getIDQuery = "SELECT SID FROM Students WHERE SEmail=@email AND SPassword=@pass";
                        SqlCommand cmd = new SqlCommand(getIDQuery, conn);
                        cmd.Parameters.AddWithValue("@email", Tlogemail.Text);
                        cmd.Parameters.AddWithValue("@pass", Tlogpass.Text);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Session.logStudentID = reader[0].ToString();
                        }
                    }
                    StudentHomePage sh = new StudentHomePage();
                    sh.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }

        }

     

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void bloginback_Click(object sender, EventArgs e)
        {
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }
    }
}
