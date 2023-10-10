using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class UCIssueBooks : UserControl
    {
        // string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public UCIssueBooks()
        {
            InitializeComponent();
        }
        int CheckALreadyIssued;
        private void IssuedBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            int Remaining = -1;
            if (txtremaining.Text != string.Empty && txtbookid.Text != string.Empty)
            {
                Remaining = Int32.Parse(txtremaining.Text);


                if (Remaining > 0)
                {
                    if (txtsRno.Text != string.Empty)
                    {
                        DialogResult mb1 = MessageBox.Show(" Are You Sure?", "Issue Book To Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mb1 == DialogResult.Yes)
                        {

                            SqlCommand cmd1 = new SqlCommand("Select  i.Issue_Id, b.Book_Id, b.Book_Name  from IssuedBooks i join Books b on i.Book_Id=b.Book_Id where S_Id =@S_Id and Return_by is null ", con);
                            cmd1.Parameters.AddWithValue("@S_Id", txtSID.Text);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            SqlDataAdapter sda = new SqlDataAdapter(cmd1);

                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                string tempuid = dt.Rows[0]["Book_Name"].ToString();
                                MessageBox.Show("This Student is Already Issued A " + "\" " + tempuid + " \"" + " Book Please Return Book Than Issue More Book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                con.Close();
                            }

                            else
                            {
                                if (isvalid())
                                {
                                    try
                                    {
                                        SqlCommand cmd = new SqlCommand(
    @"
    BEGIN TRANSACTION;

    -- Insert a record into IssuedBooks for the issuance.
    INSERT INTO IssuedBooks (S_Id, Book_Id, Issue_by, Issue_date)
    VALUES (@studentId, @bookId, @issueBy, GETDATE());

    -- Update the Books table to increment Issued_Books.
    UPDATE Books SET Issued_Books = Issued_Books + 1 WHERE Book_Id = @bookId;

    -- Commit the transaction if all updates are successful.
    COMMIT;
    ", con);
                                        //   SqlCommand cmd = new SqlCommand("INSERT INTO IssuedBooks VALUES(@studentId, @bookId, @issueBy,GETDATE() ,NULL , NULL,NULL,NULL); UPDATE Books SET Issued_Books = Issued_Books + 1 WHERE Book_Id = @bookId; ", con);
                                        cmd.CommandType = CommandType.Text;

                                        cmd.Parameters.AddWithValue("@studentId", txtSID.Text);
                                        cmd.Parameters.AddWithValue("@bookId", txtbookid.Text);
                                        cmd.Parameters.AddWithValue("@issueBy", Login.lno.loginId);

                                        if (con.State != ConnectionState.Open)
                                        {
                                            con.Open();
                                        }
                                        cmd.ExecuteNonQuery();

                                        // For SHow Count
                                        UCHome.FromHome.Update();


                                        MessageBox.Show("Successfully Issued", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                        ClearAllIssueValue();
                                    }

                                    catch (Exception ex)
                                    {

                                        MessageBox.Show(ex.Message);
                                    }

                                    finally
                                    {
                                        con.Close();
                                    }
                                }

                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Student Not Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Remaining == 0)
                {
                    MessageBox.Show("All Book Are Issued ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else if (Remaining == -1)
            {
                MessageBox.Show("Book is Not Selected Correctly ", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isvalid()
        {
            if (txtSID.Text == string.Empty)
            {
                MessageBox.Show("Enter Student ID", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtbookid.Text == string.Empty)
            {
                MessageBox.Show("Book Id Not Selected", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }


        // Load Books from Database
        private void textbookid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Books where Book_Id=@Book_Id", con);


                cmd.Parameters.AddWithValue("Book_Id", txtbookid.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();


                if (sdr.Read())
                {
                    txtbookname.Text = sdr.GetValue(1) + " By " + sdr.GetValue(2).ToString();


                    //  txtPublisher.Text = sdr.GetValue(3).ToString();
                    txtPublisher.Text = sdr.GetValue(3).ToString();
                    TxtStatus.Text = "Total:" + sdr.GetValue(4) + " Issued:" + sdr.GetValue(6) + " Remaining:" + sdr.GetValue(7).ToString();
                    txtremaining.Text = sdr.GetValue(7).ToString();
                    con.Close();
                }
                else if (txtbookid.Text == string.Empty)
                {
                    ClearSelectBookvalue();

                }
                else
                {

                    // MessageBox.Show("No Book Found");
                    ClearSelectBookvalue();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Books");
            }

            finally
            {
                con.Close();
            }

        }

        private void ClearSelectBookvalue()
        {
            txtbookname.Text = string.Empty;
            TxtStatus.Text = string.Empty;
            txtPublisher.Text = string.Empty;
            txtremaining.Text = string.Empty;
            txtBookSearch.Clear();
        }

        private void ClearSelectTeachervalue()
        {
            txtTName.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtPno.Text = string.Empty;
            ALreadyIssuedTeacher.Text = string.Empty;


        }

        //Load Student from Database
        private void txtSID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {

                SqlCommand cmd = new SqlCommand("Select Name,Roll_No, Program + ' ' +Department +' ' + Year_Semester as Class from Students where S_Id=@S_Id and Status='Active'", con);

                con.Open();
                cmd.Parameters.AddWithValue("S_Id", txtSID.Text);


                SqlDataReader sdr1;
                sdr1 = cmd.ExecuteReader();

                if (sdr1.Read())
                {
                    txtStuName.Text = sdr1.GetValue(0).ToString();
                    txtsRno.Text = sdr1.GetValue(1).ToString();
                    txtClass.Text = sdr1.GetValue(2).ToString();
                    IfBookIssue();

                }
                else if (txtbookid.Text == string.Empty)
                {

                    ClearSelectStudentvalue();

                }
                else
                {
                    //MessageBox.Show("NO STUDENT FOUND");
                    ClearSelectStudentvalue();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOAD STUDENT");
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearSelectStudentvalue()
        {
            txtStuName.Text = string.Empty;
            txtsRno.Text = string.Empty;
            txtClass.Text = string.Empty;
            AlreadyIssued.Text = string.Empty;
            txtstudentSearch.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbookid.Clear();
            ClearSelectBookvalue();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSID.Clear();
            ClearSelectStudentvalue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllIssueValue();
        }

        private void ClearAllIssueValue()
        {
            txtbookid.Clear();
            txtSID.Clear();
            TId.Clear();
            ClearSelectBookvalue();
            ClearSelectStudentvalue();
            ClearSelectTeachervalue();

        }
        public int status = 0;

        // Button for Book Search

        //Button For Student Search
        private void txtstudentSearchBox_TextChanged(object sender, EventArgs e)
        {
            txtBookSearch.Clear();
            SearchTeacher.Clear();
            status = 2;
            BookandStudentSearching();

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            txtstudentSearch.Clear();
            status = 1;
            BookandStudentSearching();
        }

        // Function For get data from database to Grid View
        public void GetBooksearchingRecord()

        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                if (status == 1)
                {
                    DataTable dta = new DataTable();
                    GridBookview.DataSource = null;
                    SqlCommand cmd = new SqlCommand("select * from Books ", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dta.Load(sdr);
                    GridBookview.DataSource = dta;
                }
                else if (status == 2)
                {
                    DataTable dt1b = new DataTable();
                    GridBookview.DataSource = null;
                    SqlCommand cmd = new SqlCommand("select * from Students where Status='Active'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt1b.Load(sdr);
                    GridBookview.DataSource = dt1b;
                }
                else if (status == 3)
                {
                    DataTable dt2b = new DataTable();
                    GridBookview.DataSource = null;
                    SqlCommand cmd = new SqlCommand("select * from Teachers where Status='Active'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt2b.Load(sdr);
                    GridBookview.DataSource = dt2b;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror While fetch Data from Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        //Function For Searching Both Book And Student
        private void BookandStudentSearching()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                if (status == 1)
                {
                    DataTable BookData = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from Books where book_name like '%' + @Name +'%'  ", con);
                    sda.SelectCommand.Parameters.AddWithValue("@Name", txtBookSearch.Text.Trim());
                    sda.Fill(BookData);
                    GridBookview.DataSource = BookData;
                    GridBookview.Show();
                    if (txtBookSearch.Text == string.Empty)
                    {
                        GridBookview.Hide();
                        GridBookview.DataSource = null;
                    }
                }
                else if (status == 2)
                {

                    DataTable Studentdata = new DataTable();
                    SqlDataAdapter sda2 = new SqlDataAdapter("Select * from Students  where  Name like '%' + @Name +'%' and Status='Active'", con);
                    sda2.SelectCommand.Parameters.AddWithValue("@Name", txtstudentSearch.Text.Trim());
                    sda2.Fill(Studentdata);
                    GridBookview.DataSource = Studentdata;
                    GridBookview.Show();

                    if (txtstudentSearch.Text == string.Empty)
                    {
                        GridBookview.Hide();
                        GridBookview.DataSource = null;
                    }

                }
                else if (status == 3)
                {
                    DataTable TeacherData = new DataTable();
                    SqlDataAdapter sda3 = new SqlDataAdapter("Select * from Teachers  where  Name like '%' + @Name +'%' and Status='Active' ", con);
                    sda3.SelectCommand.Parameters.AddWithValue("@Name", SearchTeacher.Text.Trim());
                    sda3.Fill(TeacherData);
                    GridBookview.DataSource = TeacherData;
                    GridBookview.Show();

                    if (SearchTeacher.Text == string.Empty)
                    {
                        GridBookview.Hide();
                        GridBookview.DataSource = null;
                    }
                }
                if (txtstudentSearch.Text == string.Empty && txtBookSearch.Text == string.Empty && SearchTeacher.Text==string.Empty)
                {
                    GridBookview.DataSource = null;
                    GridBookview.Hide();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Recovering", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Data Gridview to TextBox
        private void GridviewBooksearching_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (status == 1)
            {
                txtbookid.Text = GridBookview.SelectedRows[0].Cells[0].Value.ToString();
            }
            else if (status == 2)
            {
                txtSID.Text = GridBookview.SelectedRows[0].Cells[0].Value.ToString();
                IfBookIssue();
            }
            else if (status == 3)
            {
                TId.Text = GridBookview.SelectedRows[0].Cells[0].Value.ToString();
                teacherBookissueornot();
            }
        }

        //if Book issue or not
        private void IfBookIssue()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select  i.Issue_Id, b.Book_Id, b.Book_Name  from IssuedBooks i join Books b on i.Book_Id=b.Book_Id where S_Id =@S_Id and Return_by is null", con);
            cmd1.Parameters.AddWithValue("@S_Id", txtSID.Text);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd1);

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckALreadyIssued = dt2.Rows.Count;
            if (CheckALreadyIssued == 0)
            {
                AlreadyIssued.Text = "No";
            }
            if (CheckALreadyIssued == 1)
            {
                AlreadyIssued.Text = "Yes";
            }
        }

        private void teacherBookissueornot()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select  i.Issue_Id, b.Book_Id, b.Book_Name  from TeacherIssuedBooks i join Books b on i.Book_Id=b.Book_Id where T_Id =@T_Id and Return_by is null", con);
            cmd1.Parameters.AddWithValue("@T_Id", TId.Text);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd1);

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckALreadyIssued = dt2.Rows.Count;
            if (CheckALreadyIssued == 0)
            {
                ALreadyIssuedTeacher.Text = "No";
            }
            if (CheckALreadyIssued == 1)
            {
                ALreadyIssuedTeacher.Text = "Yes";
            }
        }

        private void txtBookSearch_Click(object sender, EventArgs e)
        {
            txtstudentSearch.Clear();
        }

        private void txtstudentSearch_Click(object sender, EventArgs e)
        {
            txtBookSearch.Clear();
        }

        private void viewAllStudent_Click(object sender, EventArgs e)
        {

            status = 2;
            GetBooksearchingRecord();
            GridBookview.Show();

        }

        private void ViewAllBook_Click(object sender, EventArgs e)
        {
            status = 1;
            GetBooksearchingRecord();
            GridBookview.Show();
        }

        private void txtIdbox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {

                SqlCommand cmd = new SqlCommand("Select Name,Department, P_No from Teachers where T_Id=@T_Id and Status='Active'", con);

                con.Open();
                cmd.Parameters.AddWithValue("T_Id", TId.Text);


                SqlDataReader sdr1;
                sdr1 = cmd.ExecuteReader();

                if (sdr1.Read())
                {
                    txtTName.Text = sdr1.GetValue(0).ToString();
                    txtDepartment.Text = sdr1.GetValue(1).ToString();
                    txtPno.Text = sdr1.GetValue(2).ToString();
                    teacherBookissueornot();

                }
                else if (TId.Text == string.Empty)
                {

                    ClearSelectTeachervalue();

                }
                else
                {
                    //MessageBox.Show("NO STUDENT FOUND");
                    ClearSelectTeachervalue();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOAD Teacher");
            }
            finally
            {
                con.Close();
            }
        }

        private void viewallTeacher_Click(object sender, EventArgs e)
        {
            status = 3;
            GetBooksearchingRecord();
            GridBookview.Show();
        }

        private void SHowStudent_Click(object sender, EventArgs e)
        {
            if (PanelStudent.Visible == false)
            {
                PanelStudent.Show();
                PanelTacher.Hide();
                IssuetoTeacher.Hide();
                IssuedBook.Show();
            }
            else
            {
                PanelStudent.Hide();
                IssuedBook.Hide();


            }
        }

        private void showteacher_Click(object sender, EventArgs e)
        {
            if (PanelTacher.Visible == false)
            {
                PanelTacher.Show();
                PanelStudent.Hide();
                IssuetoTeacher.Show();
                IssuedBook.Hide();
            }
            else
            {
                PanelTacher.Hide();
                IssuetoTeacher.Hide();
            }
        }

        private void SearchTeacher_TextChanged(object sender, EventArgs e)
        {
            txtBookSearch.Clear();
            txtstudentSearch.Clear();
            status = 3;
            BookandStudentSearching();
        }

        private void IssuetoTeacher_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            int Remaining = -1;
            if (txtremaining.Text != string.Empty && txtbookid.Text != string.Empty)
            {
                Remaining = Int32.Parse(txtremaining.Text);


                if (Remaining > 0)
                {
                    if (txtPno.Text != string.Empty && TId.Text!=string.Empty)
                    {
                        DialogResult mb1a = MessageBox.Show(" Are You Sure?", "Issue Book to Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mb1a == DialogResult.Yes)
                        {

                            SqlCommand cmd1 = new SqlCommand("Select  i.Issue_Id, b.Book_Id, b.Book_Name  from TeacherIssuedBooks i join Books b on i.Book_Id=b.Book_Id where T_Id =@T_Id and Return_by is null", con);
                            cmd1.Parameters.AddWithValue("@T_Id", TId.Text);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            SqlDataAdapter sda = new SqlDataAdapter(cmd1);

                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                string tempuid = dt.Rows[0]["Book_Name"].ToString();
                                MessageBox.Show("This Teacher is Already Issued A " + "\" " + tempuid + " \"" + " Book Please Return Book Than Issue More Book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                con.Close();
                            }

                            else
                            {
                                if (isvalid2())
                                {
                                    try
                                    {
                                        SqlCommand cmd = new SqlCommand(
    @"
    BEGIN TRANSACTION;

    -- Insert a record into TeacherIssuedBooks for the issuance to a teacher.
    INSERT INTO TeacherIssuedBooks (T_Id, Book_Id, Issue_By, Issue_date)
    VALUES (@teacherId, @bookId, @issueBy, GETDATE());

    -- Update the Books table to increment Issued_Books.
    UPDATE Books SET Issued_Books = Issued_Books + 1 WHERE Book_Id = @bookId;

    -- Commit the transaction if all updates are successful.
    COMMIT;
    ", con);
                                        //SqlCommand cmd = new SqlCommand("INSERT INTO TeacherIssuedBooks VALUES(@TeacherId, @bookId, @issueBy,GETDATE() ,NULL , NULL,NULL,NULL); UPDATE Books SET Issued_Books = Issued_Books + 1 WHERE Book_Id = @bookId; ", con);
                                        cmd.CommandType = CommandType.Text;

                                        cmd.Parameters.AddWithValue("@TeacherId", TId.Text);
                                        cmd.Parameters.AddWithValue("@bookId", txtbookid.Text);
                                        cmd.Parameters.AddWithValue("@issueBy", Login.lno.loginId);

                                        if (con.State != ConnectionState.Open)
                                        {
                                            con.Open();
                                        }
                                        cmd.ExecuteNonQuery();

                                        // For SHow Count
                                        UCHome.FromHome.Update();
                                        ClearAllIssueValue();

                                        MessageBox.Show("Successfully Issued", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    }

                                    catch (Exception ex)
                                    {

                                        MessageBox.Show(ex.Message,"While Issue book");
                                    }

                                    finally
                                    {
                                        con.Close();
                                    }
                                }

                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Teacher Not Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Remaining == 0)
                {
                    MessageBox.Show("All Book Are Issued ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else if (Remaining == -1)
            {
                MessageBox.Show("Book is Not Selected Correctly ", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isvalid2()
        {
            if (TId.Text == string.Empty)
            {
                MessageBox.Show("Enter Teacher ID", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtbookid.Text == string.Empty)
            {
                MessageBox.Show("Book Id Not Selected", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void cleaerbuttonTeacher_Click(object sender, EventArgs e)
        {
            TId.Clear();
            ClearSelectTeachervalue();
        }
    }
}

