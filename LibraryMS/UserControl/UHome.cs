using LibraryMS.Windows_Form;
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

            Update();
        }

        public void Update()
        {
            StudentCount();
            BookCount();
            TotalIssueBook();
            CurrentIssueBook();
            CurrentIssueBookStudent();
            CurrentIssueBookTeacher();
            TeacherCount();
        }





        // Total Students
        public void StudentCount()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Students where status='Active'", con);
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

        public void TeacherCount()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Teachers where status='Active'", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                TTeacher.Text = Convert.ToString(StudentCount);

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
                SqlCommand cmd = new SqlCommand("select (select COUNT(*) from IssuedBooks) + (select COUNT(*) from TeacherIssuedBooks)", con);

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
                SqlCommand cmd = new SqlCommand("select (select COUNT(*) from IssuedBooks where Return_Date IS NULL) + (select COUNT(*) from TeacherIssuedBooks where Return_Date IS NULL) ", con);
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
        public void CurrentIssueBookStudent()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from IssuedBooks where Return_Date IS NULL ", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                lblTeacherIssue.Text = Convert.ToString(StudentCount);
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

        public void CurrentIssueBookTeacher()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd = new SqlCommand(" select COUNT(*) from TeacherIssuedBooks where Return_Date IS NULL ", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                lblStudentIssue.Text = Convert.ToString(StudentCount);
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
        
       

        private void guna2GradientPanel2_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GEtbookRecord();
            vastudent.ShowDialog();

        }

        // Total Issue Book
        

        private void guna2GradientPanel4_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GetStudentRecord();
            vastudent.ShowDialog();
        }

        private void TTeacherCount_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GetTeacherRecord();
            vastudent.ShowDialog();

        }

        private void CurrentIssuedStud_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GetIssuebook();
            vastudent.ShowDialog();
        }

        private void CurrentIssueTeach_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GetIssuebookTeacher();
            vastudent.ShowDialog();
        }
    }
}
