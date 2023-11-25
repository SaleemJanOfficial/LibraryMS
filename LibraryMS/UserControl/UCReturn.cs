using System;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using LibraryMS.Windows_Form;
using LibraryMS.Class;

namespace LibraryMS
{
    public partial class UCStatus : UserControl
    {
        SqlConnection con = new SqlConnection(SqlConnectionClass.Constr());
       // string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public static UCStatus ucpandig;

        public UCStatus()
        {
            InitializeComponent();
            ucpandig = this;
        }


        int ShowAllorNot = 0;
      
        public void GetIssuebook()
        {
           // SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "  SELECT i.Issue_Id,s.S_Id, s.Name AS Student_Name,s.Program+' '+s.Department+' '+s.Year_Semester  AS Class ,s.Roll_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName  As Issued_by, i.Issue_date,datediff(day,i.Issue_date,getdate()) as Days_Passed, 0 as Latedays FROM IssuedBooks i JOIN Students s ON i.S_Id = s.S_Id Join Books b ON i.Book_Id = b.Book_Id  join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId  where Return_Date is null and datediff(day,Issue_date,getdate())-7<8";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                GridIssuebook.DataSource = dt;
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
        // For select text from Add Student Grid View
        public int issueid;
        public int issuedate;
        public int bookid;
        public string latedays;
        public string TotalPasedDays;
        public string SName;
        public string TName;
        public string Lateindays1;
        private void GridIssuebook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Book Detail 
            lblissueid.Text = GridIssuebook.SelectedRows[0].Cells[0].Value.ToString();
            issueid = Convert.ToInt32(lblissueid.Text);
            lblbookid.Text = GridIssuebook.SelectedRows[0].Cells[5].Value.ToString();
            bookid = Convert.ToInt32(lblbookid.Text);
            lblbookname.Text = GridIssuebook.SelectedRows[0].Cells[6].Value.ToString();
            lblIssueby.Text = GridIssuebook.SelectedRows[0].Cells[7].Value.ToString();
            lblIssuedate.Text = GridIssuebook.SelectedRows[0].Cells[8].Value.ToString();
            TotalPasedDays = GridIssuebook.SelectedRows[0].Cells[9].Value.ToString();
            latedays = GridIssuebook.SelectedRows[0].Cells[10].Value.ToString();

            Lateindays1 = GridIssuebook.SelectedRows[0].Cells[10].Value.ToString();
            Lateindays.Text = Lateindays1 + " days";

            //Student Detal
            if (StudentsMark.Checked == true)
            {
                lblsid.Text = GridIssuebook.SelectedRows[0].Cells[1].Value.ToString();
                SName = lblsname.Text;
                lblsname.Text = GridIssuebook.SelectedRows[0].Cells[2].Value.ToString();
                lblrno.Text = GridIssuebook.SelectedRows[0].Cells[4].Value.ToString();
                lblclasssem.Text = GridIssuebook.SelectedRows[0].Cells[3].Value.ToString();
            }
            else if (TeachersMark.Checked == true)
            {
                lblTid.Text = GridIssuebook.SelectedRows[0].Cells[1].Value.ToString();
                TName = lblsname.Text;
                lblTName.Text = GridIssuebook.SelectedRows[0].Cells[2].Value.ToString();
                LblDepartment.Text = GridIssuebook.SelectedRows[0].Cells[3].Value.ToString();
                LblPno.Text = GridIssuebook.SelectedRows[0].Cells[4].Value.ToString();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValueLabel();

        }
        //Rerurn Button Students
        private void btnReturn_Click(object sender, EventArgs e)
        {

            int dayscalculte = int.Parse(latedays);

            if (dayscalculte > 0)
            {
                Int32 fine = dayscalculte * 5;

                DialogResult mbx = MessageBox.Show(lblsname.Text + " Return Book in " + dayscalculte + " Days " + "Please Collect " + +fine + " Rupess " + " Fine" + " Than Continue. Thanks", "Collect Fine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (mbx == DialogResult.Yes)
                {
                    if (ShowAllorNot == 1)
                    {
                        Returnbook();
                        getNoreturn();

                    }
                    else
                    {
                        GetIssuebook();
                    }
                }
            }
            else
            {
                Returnbook();
                GetIssuebook();
            }

        }

        private void Returnbook()
        {
            //SqlConnection con = new SqlConnection(Constr);
            if (issueid > 0 && lblissueid.Text != string.Empty)
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(
    @"
    BEGIN TRANSACTION;

    -- Update IssuedBooks to record the return.
    UPDATE IssuedBooks SET Return_by = @Return_by, Return_Date = GETDATE(), Total_Days_Passed = @Total, Late_Return_In_Days = @late
    WHERE Issue_Id = @issueId;

    -- Update the Books table to decrement Issued_Books.
    UPDATE Books SET Issued_Books = Issued_Books - 1 WHERE Book_Id = @bookId;

    -- Commit the transaction if all updates are successful.
    COMMIT;
    ", con);
                        //  SqlCommand cmd = new SqlCommand("Update IssuedBooks set Return_by=@Return_by, Return_Date=GETDATE() , Total_Days_Passed=@Total, Late_Return_In_Days=@late where Issue_Id=@issueid; UPDATE Books SET Issued_Books = Issued_Books - 1 WHERE Book_Id = @bookId;", con);

                        cmd.Parameters.AddWithValue("@issueid", issueid);
                        cmd.Parameters.AddWithValue("@bookId", bookid);
                        cmd.Parameters.AddWithValue("@Return_by", Login.lno.loginId);
                        cmd.Parameters.AddWithValue("@late", Lateindays1);
                        cmd.Parameters.AddWithValue("@Total", TotalPasedDays);
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Succefuly Return Books", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearValueLabel();

                        GetIssuebook();
                        UCHome.FromHome.Update();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error While Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select On Grid Videw", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ClearValueLabel()
        {
            lblissueid.Text = string.Empty;
            lblsid.Text = string.Empty;
            lblsname.Text = string.Empty;
            lblrno.Text = string.Empty;
            lblclasssem.Text = string.Empty;
            lblbookid.Text = string.Empty;
            lblbookname.Text = string.Empty;
            lblIssueby.Text = string.Empty;
            lblIssuedate.Text = string.Empty;
            lblTid.Text = string.Empty;
            lblTName.Text = string.Empty;
            LblDepartment.Text = string.Empty;
            LblPno.Text = string.Empty;
            Lateindays.Text = string.Empty;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private PrintDialog printDialog1 = new PrintDialog();


        private void Toprint()
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
            Bitmap bm = new Bitmap(GridIssuebook.Width, GridIssuebook.Height);
            GridIssuebook.DrawToBitmap(bm, new Rectangle(0, 0, GridIssuebook.Width, GridIssuebook.Height));

            // Draw the Bitmap on the print page
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }



        private void ToCsv()
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
                        for (int i = 0; i < GridIssuebook.Columns.Count; i++)
                        {
                            writer.Write(GridIssuebook.Columns[i].HeaderText);
                            if (i < GridIssuebook.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Write data rows to the CSV file
                        foreach (DataGridViewRow row in GridIssuebook.Rows)
                        {
                            for (int i = 0; i < GridIssuebook.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < GridIssuebook.Columns.Count - 1)
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

        private void btnhistory_Click(object sender, EventArgs e)
        {

            // ViewAllStudent vastudent = new ViewAllStudent();
            // ViewAllStudent.vas.GetHistory();
            // vastudent.ShowDialog();
        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToCsv();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toprint();

        }

        private void vIewHIstoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GetHistory();
            vastudent.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            GetIssuebook();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllorNot = 1;
            getNoreturn();
        }

        public void getNoreturn()
        {
          //  SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "SELECT i.Issue_Id,s.S_Id, s.Name AS Student_Name,s.Program+' '+s.Department+' '+s.Year_Semester  AS Class ,s.Roll_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName  As Issued_by, i.Issue_date,datediff(day,i.Issue_date,getdate()) as Days_Passed, case when datediff(day,i.Issue_date,getdate())-7>0 then datediff(day,i.Issue_date,getdate())-7 else 0 end  as OverDays FROM IssuedBooks i JOIN Students s ON i.S_Id = s.S_Id Join Books b ON i.Book_Id = b.Book_Id  join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId  where Return_Date is  null and datediff(day,Issue_date,getdate())-7>8";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                GridIssuebook.DataSource = dt;
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
        public void StudentsMark_CheckedChanged(object sender, EventArgs e)
        {
            GetIssuebook();
            btnReturn.Show();

            btnshowall.Show();
            btnNoReturn.Show();

            ShowAllTeacher.Hide();
            NotReturnTeacher.Hide();

            ReturnFromTEacher.Hide();
            PanelStudentReturn.Show();
            PanelTeacherReturn.Hide();
        }
        public void TeachersMark_CheckedChanged(object sender, EventArgs e)
        {
            GetIssueBookTeacher();
            ReturnFromTEacher.Show();
            btnNoReturn.Hide();

            NotReturnTeacher.Show();
            btnReturn.Hide();
            btnshowall.Hide();
            ShowAllTeacher.Show();

            PanelStudentReturn.Hide();
            PanelTeacherReturn.Show();
        }
        public void GetIssueBookTeacher()
        {
           // SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "  SELECT i.Issue_Id,T.T_Id, T.Name AS Teacher_Name,T.Department ,T.P_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName  As Issued_by, i.Issue_date,datediff(day,i.Issue_date,getdate()) as Days_Passed, 0 as Latedays FROM TeacherIssuedBooks i JOIN Teachers T ON i.T_Id = T.T_Id Join Books b ON i.Book_Id = b.Book_Id  join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId  where Return_Date is  null and datediff(day,Issue_date,getdate())-7<8";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                GridIssuebook.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GridIssueBook (Teachers)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }
        private void ReturnFromTEacher_Click(object sender, EventArgs e)
        {

            int dayscalculte = int.Parse(latedays);

            if (dayscalculte > 0)
            {
                Int32 fine = dayscalculte * 5;

                DialogResult mbx = MessageBox.Show(lblTName.Text + " Return Book in " + dayscalculte + " Days " + "Please Collect " + +fine + " Rupess " + " Fine" + " Than Continue. Thanks", "Collect Fine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                {
                    ReturnbookTeacher();
                    // 
                    if (ShowAllorNot == 2)
                    {
                        getNoreturnTeacher();
                        //ShowIssuedBook();
                    }
                    else
                    {
                        GetIssueBookTeacher();
                    }
                }
            }
            else
            {
                ReturnbookTeacher();
                GetIssueBookTeacher();

            }


        }
        private void ReturnbookTeacher()
        {
            //SqlConnection con = new SqlConnection(Constr);
            if (issueid > 0 && lblissueid.Text != string.Empty)
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(
    @"
    BEGIN TRANSACTION;

    -- Update TeacherIssuedBooks to record the return.
    UPDATE TeacherIssuedBooks SET Return_by = @Return_by, Return_Date = GETDATE(), Total_Days_Passed = @Total, Late_Return_In_Days = @late
    WHERE Issue_Id = @issueId;

    -- Update the Books table to decrement Issued_Books.
    UPDATE Books SET Issued_Books = Issued_Books - 1 WHERE Book_Id = @bookId;

    -- Commit the transaction if all updates are successful.
    COMMIT;
    ", con);
                        //SqlCommand cmd = new SqlCommand("Update TeacherIssuedBooks set Return_by=@Return_by, Return_Date=GETDATE() , Total_Days_Passed=@Total, Late_Return_In_Days=@late where Issue_Id=@issueid; UPDATE Books SET Issued_Books = Issued_Books - 1 WHERE Book_Id = @bookId;", con);

                        cmd.Parameters.AddWithValue("@issueid", issueid);
                        cmd.Parameters.AddWithValue("@bookId", bookid);
                        cmd.Parameters.AddWithValue("@Return_by", Login.lno.loginId);
                        cmd.Parameters.AddWithValue("@late", Lateindays1);
                        cmd.Parameters.AddWithValue("@Total", TotalPasedDays);
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Succefuly Return Books", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearValueLabel();
                        //GetIssueBookTeacher();

                        UCHome.FromHome.Update();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error While Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select On Grid Videw", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void getNoreturnTeacher()
        {

           // SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "SELECT i.Issue_Id,t.T_Id, t.Name AS Teacher_Name,t.Department,t.P_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName  As Issued_by, i.Issue_date,datediff(day,i.Issue_date,getdate()) as Days_Passed, case when datediff(day,i.Issue_date,getdate())-7>0 then datediff(day,i.Issue_date,getdate())-7 else 0 end  as OverDays FROM TeacherIssuedBooks i JOIN Teachers t ON i.T_Id = t.T_Id Join Books b ON i.Book_Id = b.Book_Id  join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId  where Return_Date is  null and datediff(day,Issue_date,getdate())-7>8";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                GridIssuebook.DataSource = dt;
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

        private void ShowAllTeacher_Click(object sender, EventArgs e)
        {
            GetIssueBookTeacher();
        }

        private void NotReturnTeacher_Click(object sender, EventArgs e)
        {
            ShowAllorNot = 2;
            getNoreturnTeacher();
        }
    }
}

