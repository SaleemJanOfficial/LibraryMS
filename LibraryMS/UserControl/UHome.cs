using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LibraryMS
{
    public partial class UCHome : UserControl
    {

        // string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public static UCHome FromHome;
        public UCHome()
        {
            InitializeComponent();
            FromHome = this;

            StudentCount();
            BookCount();
            TotalIssueBook();
            CurrentIssueBook();
        }



        private void TstudentLable_Click(object sender, EventArgs e)
        {

        }

        // Total Students
        public void StudentCount()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Students", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                TstudentLable.Text = Convert.ToString(StudentCount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not Retrived Total Student");
            }
            finally
            {
                con.Close();
            }
        }

        //Count Total Book
        public void BookCount()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Books", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                Tbooklable.Text = Convert.ToString(StudentCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Total Books Not Retrived");
            }

            finally
            {
                con.Close();
            }
        }


        //Count Total IssueBook

        public void TotalIssueBook()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from IssuedBooks", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                lblTIssueBook.Text = Convert.ToString(StudentCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not Retrived Total Issue Book");
            }

            finally
            {
                con.Close();
            }
        }


        //Count Total Current IssueBook

        public void CurrentIssueBook()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from IssuedBooks where Return_Date IS NULL ", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                lblCurrentIssue.Text = Convert.ToString(StudentCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not Retrived Total Issue Book");
            }

            finally
            {
                con.Close();
            }
        }

    }
}
