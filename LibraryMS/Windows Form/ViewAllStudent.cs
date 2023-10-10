using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;

namespace LibraryMS.Windows_Form
{
    public partial class ViewAllStudent : Form
    {
        public static ViewAllStudent vas;
        //  static string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";

        public ViewAllStudent()
        {
            InitializeComponent();

            vas = this;
        }

        public void GetStudentRecord()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Students where Status='Active'", con);

            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            dt1.Load(sdr1);
            con.Close();
            ViewAllstudentGrid.DataSource = dt1;

        }


        public void GetTeacherRecord()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Teachers where Status='Active'", con);

            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            dt1.Load(sdr1);
            con.Close();
            ViewAllstudentGrid.DataSource = dt1;
        }
        public void GEtbookRecord()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd1 = new SqlCommand("Select * from Books", con);


                DataTable dt1 = new DataTable();

                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                dt1.Load(sdr1);

                ViewAllstudentGrid.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Get Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void GetHistory()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "SELECT i.Issue_Id,s.S_Id, s.Name AS Student_Name,s.Program+' '+s.Department+' '+s.Year_Semester AS Class ,s.Roll_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName As Issued_by, i.Issue_date,l2.UserName as Returned_by, i.Return_Date FROM IssuedBooks i JOIN Students s ON i.S_Id = s.S_Id Join Books b ON i.Book_Id = b.Book_Id join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                ViewAllstudentGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GridIssueBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewAllStudent_Load(object sender, EventArgs e)
        {


        }


        //Print Button
        private PrintDialog printDialog1 = new PrintDialog();

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {

                // Create a PrintDocument instance
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();

                // Set the PrintPage event handler
                pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);

                // Display the PrintDialog to allow the user to select a printer
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    pd.PrinterSettings = printDialog1.PrinterSettings;
                    pd.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Printing", ex.Message);
            }

        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create a Bitmap to represent the content of the DataGridView
            Bitmap bm = new Bitmap(ViewAllstudentGrid.Width, ViewAllstudentGrid.Height);
            ViewAllstudentGrid.DrawToBitmap(bm, new Rectangle(0, 0, ViewAllstudentGrid.Width, ViewAllstudentGrid.Height));

            // Draw the Bitmap on the print page
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }







        // For Export to CSV
        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a SaveFileDialog to specify the CSV file location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.FileName = "ExportedData.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Write column headers to the CSV file
                        for (int i = 0; i < ViewAllstudentGrid.Columns.Count; i++)
                        {
                            writer.Write(ViewAllstudentGrid.Columns[i].HeaderText);
                            if (i < ViewAllstudentGrid.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Write data rows to the CSV file
                        foreach (DataGridViewRow row in ViewAllstudentGrid.Rows)
                        {
                            for (int i = 0; i < ViewAllstudentGrid.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < ViewAllstudentGrid.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Data exported to CSV successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIewHIstoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void GetIssuebook()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "SELECT i.Issue_Id,s.S_Id, s.Name AS Student_Name,s.Program+' '+s.Department+' '+s.Year_Semester AS Class ,s.Roll_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName As Issued_by, i.Issue_date,l2.UserName as Returned_by, i.Return_Date FROM IssuedBooks i JOIN Students s ON i.S_Id = s.S_Id Join Books b ON i.Book_Id = b.Book_Id join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId where Return_Date is null";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                ViewAllstudentGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GridIssueBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void GetIssuebookTeacher()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "SELECT i.Issue_Id,T.T_Id, T.Name AS Teacher_Name,T.Department ,T.P_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName  As Issued_by, i.Issue_date,datediff(day,i.Issue_date,getdate()) as Days_Passed, 0 as Latedays FROM TeacherIssuedBooks i JOIN Teachers T ON i.T_Id = T.T_Id Join Books b ON i.Book_Id = b.Book_Id  join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId  where Return_Date is  null ";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                ViewAllstudentGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GridIssueBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

    }



}

