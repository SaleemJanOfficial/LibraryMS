using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryMS.Classes;
namespace LibraryMS
{
    public partial class UCHome : UserControl
    {
        public static string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public static UCHome Instense;
        public UCHome()
        {
            InitializeComponent();
            Instense = this;


            StudentCount();
            BookCount();
            TotalIssueBook();
            CurrentIssueBook();
        }

        SqlConnection con = new SqlConnection(Constr);

        private void TstudentLable_Click(object sender, EventArgs e)
        {

        }

        // Total Students
        public void StudentCount()
        {

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
