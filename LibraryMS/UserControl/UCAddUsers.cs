using LibraryMS.Windows_Form;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryMS
{
    public partial class UCAddUser : UserControl
    {

        // Connection String from App.config
        //  string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public UCAddUser()
        {
            InitializeComponent();

            txtUserEdate.Value = DateTime.Today;
        }


        public void GetStudentRecord()

        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {

                SqlCommand cmd = new SqlCommand("Select * from Students where Status='Active'", con);
                DataTable dt = new DataTable();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                GridStudentRecord.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror in Get StudentRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        //show all user List
        private void ViewAllUserButton_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GetStudentRecord();
            vastudent.ShowDialog();


        }


        //Panel Add new Button
        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (PanelAddUser.Visible == false)
            {
                PanelAddUser.Show();
                ActiveButton.Show();
                DeletedStudent.Show();
                PanelAddTeacher.Hide();
                TActiveButton.Hide();
                TDeletedButton.Hide();
            }
            else
            {
                PanelAddUser.Hide();
                ActiveButton.Hide();
                DeletedStudent.Hide();

            }
            GetStudentRecord();
            SearchBox.Focus();
        }

        private void ButtonClearAdduser_Click(object sender, EventArgs e)
        {
            ClearAllValueAdduser();
        }

        //For Clear All Vaulue in Add User
        private void ClearAllValueAdduser()
        {
            UserId.Clear();
            txtUName.Clear();
            txtFname.Clear();
            txtUserRNo.Clear();
            txtUserMNo.Clear();
            txtUserAddress.Clear();
            txtUserDepartment.Clear();
            txtPrograme.Clear();
            txtUserYearSem.Clear();
            txtUserMNo.Clear();
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            RadioOther.Checked = false;
            txtUName.Focus();
            btnRecover.Enabled = false;
        }

        // Button Back
        private void ButtonBackAddUser_Click(object sender, EventArgs e)
        {
            ClearAllValueAdduser();
            PanelAddUser.Hide();

        }

        string gender1;


        //For Add User
        private void ButtonSaveAddUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalid())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    string query = "SELECT COUNT(*) FROM Students WHERE Roll_No = @RollNo";

                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    command.Parameters.AddWithValue("@RollNo", txtUserRNo.Text);

                    int DuplicateBookcheck = (int)command.ExecuteScalar();
                    con.Close();
                    if (DuplicateBookcheck > 0)
                    {
                        MessageBox.Show("This Roll No is Already Exist", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }

                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES ( @Name, @F_Name, @Gender, @Roll_No, @Program, @Department, @Year_Semester, @Address_, @Mobile_No, GETDATE(), @Status) ", con);
                            cmd.CommandType = CommandType.Text;

                            cmd.Parameters.AddWithValue("@Name", txtUName.Text);
                            cmd.Parameters.AddWithValue("@F_Name", txtFname.Text);
                            cmd.Parameters.AddWithValue("@Gender", gender1);
                            cmd.Parameters.AddWithValue("@Roll_No", txtUserRNo.Text);
                            cmd.Parameters.AddWithValue("@Program", txtPrograme.Text);
                            cmd.Parameters.AddWithValue("@Department", txtUserDepartment.Text);
                            cmd.Parameters.AddWithValue("@Year_Semester", txtUserYearSem.Text);
                            cmd.Parameters.AddWithValue("@Address_", txtUserAddress.Text);
                            cmd.Parameters.AddWithValue("@Mobile_No", txtUserMNo.Text);
                            cmd.Parameters.AddWithValue("@Status", "Active");

                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                            }

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved Student", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetStudentRecord();
                            ClearAllValueAdduser();
                            UCHome.FromHome.Update();
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

        private bool isvalid()
        {
            if (txtUName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is Embty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (gender1 == string.Empty)
            {
                MessageBox.Show("Gender Not Selected", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtFname.Text == string.Empty)
            {
                MessageBox.Show("Father Name is Not Entered", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtUserRNo.Text == string.Empty)
            {
                MessageBox.Show("Roll No is not Entered ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtPrograme.Text == string.Empty)
            {
                MessageBox.Show("Select Programe", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtUserYearSem.Text == string.Empty)
            {
                MessageBox.Show("Select Year or Semister ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtUserMNo.Text == string.Empty)
            {
                MessageBox.Show("Mobile No is Embty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtUserAddress.Text == string.Empty)
            {
                MessageBox.Show("Address is empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtUserDepartment.Text == string.Empty)
            {
                MessageBox.Show("Department Is not Selected", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ButtonUpdateAdduser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalid())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Students SET  Name=@Name, F_Name=@F_Name, Gender=@Gender, Roll_No=@Roll_No, Program=@Program, Department=@Department, Year_Semester=@Year_Semester, Address_=@Address_, Mobile_No=@Mobile_No, Enrl_Date=@Enrl_Date where S_Id=@S_Id ", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@S_Id", StudentID);
                        cmd.Parameters.AddWithValue("@Name", txtUName.Text);
                        cmd.Parameters.AddWithValue("@F_Name", txtFname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender1);
                        cmd.Parameters.AddWithValue("@Roll_No", txtUserRNo.Text);
                        cmd.Parameters.AddWithValue("@Program", txtPrograme.Text);
                        cmd.Parameters.AddWithValue("@Department", txtUserDepartment.Text);
                        cmd.Parameters.AddWithValue("@Year_Semester", txtUserYearSem.Text);
                        cmd.Parameters.AddWithValue("@Address_", txtUserAddress.Text);
                        cmd.Parameters.AddWithValue("@Mobile_No", txtUserMNo.Text);
                        cmd.Parameters.AddWithValue("@Enrl_Date", txtUserEdate.Text);

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Update Student", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetStudentRecord();
                        UserId.Clear();
                        ClearAllValueAdduser();
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

        // For Delete Students
        private void ButtonDeleteAdduser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (txtUName.Text != string.Empty)
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Deleteing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("Select * from IssuedBooks where S_Id = @S_Id and Return_by is null", con);
                        SqlCommand cmd = new SqlCommand("update Students set Status='Not Active' where S_Id=@S_Id", con);

                        cmd1.Parameters.AddWithValue("@S_Id", StudentID);


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd1.ExecuteNonQuery();


                        SqlDataAdapter sda = new SqlDataAdapter(cmd1);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);


                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Student is Issued A Book Please Return Than Delete It", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@S_Id", StudentID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Successfuly Delete User from DATABASE ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UCHome.FromHome.Update();
                            GetStudentRecord();
                            ClearAllValueAdduser();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "When Deleting User");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Students From GridView", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RadioMale_CheckedChanged(object sender, EventArgs e)
        {
            gender1 = "Male";
        }
        private void RadioFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender1 = "Female";

        }
        private void RadioOther_CheckedChanged(object sender, EventArgs e)
        {
            gender1 = "Other";
        }
        //variable declare 
        public int StudentID;
        public string Gender;
        public string Activeornot;

        // For select text from Add Student Grid View
        private void GridStudentRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId.Text = GridStudentRecord.SelectedRows[0].Cells[0].Value.ToString();
            StudentID = Convert.ToInt32(UserId.Text);
            txtUName.Text = GridStudentRecord.SelectedRows[0].Cells[1].Value.ToString();
            txtFname.Text = GridStudentRecord.SelectedRows[0].Cells[2].Value.ToString();
            Gender = GridStudentRecord.SelectedRows[0].Cells[3].Value.ToString();

            if (Gender == "Male") { RadioMale.Checked = true; }
            else if (Gender == "Female") { RadioFemale.Checked = true; }
            else if (Gender == "Other") { RadioOther.Checked = true; }

            txtUserRNo.Text = GridStudentRecord.SelectedRows[0].Cells[4].Value.ToString();
            txtPrograme.Text = GridStudentRecord.SelectedRows[0].Cells[5].Value.ToString();
            txtUserDepartment.Text = GridStudentRecord.SelectedRows[0].Cells[6].Value.ToString();
            txtUserYearSem.Text = GridStudentRecord.SelectedRows[0].Cells[7].Value.ToString();
            txtUserAddress.Text = GridStudentRecord.SelectedRows[0].Cells[8].Value.ToString();
            txtUserMNo.Text = GridStudentRecord.SelectedRows[0].Cells[9].Value.ToString();
            txtUserEdate.Text = GridStudentRecord.SelectedRows[0].Cells[10].Value.ToString();
            Activeornot = GridStudentRecord.SelectedRows[0].Cells[11].Value.ToString();
            if (Activeornot == "Not Active")
            {
                btnRecover.Enabled = true;
            }
            else
            {
                btnRecover.Enabled = false;
            }
        }

        private void DeletedStudent_Click(object sender, EventArgs e)
        {
            NonActive();
            ButtonSaveAddStudents.Enabled = false;
            ButtonUpdateAddStudents.Enabled = false;
            ButtonDeleteAddStudents.Enabled = false;
        }

        private void NonActive()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Students where Status='Not Active'", con);

            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            dt1.Load(sdr1);
            con.Close();
            GridStudentRecord.DataSource = dt1;
        }

        private void ActiveButton_Click(object sender, EventArgs e)
        {

            GetStudentRecord();

            ButtonSaveAddStudents.Enabled = true;
            ButtonUpdateAddStudents.Enabled = true;
            ButtonDeleteAddStudents.Enabled = true;
            btnRecover.Enabled = false;
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalid())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Students SET Status=@Status where S_Id=@S_Id ", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@S_Id", StudentID);
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Recovered Student", "Recovered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NonActive();
                        UserId.Clear();
                        ClearAllValueAdduser();
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
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            StudentSearching();
        }

        private void StudentSearching()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Students where Name like '%' + @Name +'%' ", con);
                sda.SelectCommand.Parameters.AddWithValue("@Name", SearchBox.Text.Trim());

                DataTable dt = new DataTable();

                sda.Fill(dt);
                GridStudentRecord.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Searching", ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void TAddnewTeacher_Click(object sender, EventArgs e)
        {




            if (PanelAddTeacher.Visible == false)
            {
                PanelAddTeacher.Show();
                TActiveButton.Show();
                TDeletedButton.Show();
                PanelAddUser.Hide();
                GetTeacherRecord();
                ActiveButton.Hide();
                DeletedStudent.Hide();
            }
            else
            {
                PanelAddTeacher.Hide();
                TActiveButton.Hide();
                TDeletedButton.Hide();

            }
        }

        public void GetTeacherRecord()

        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                DataTable GridDt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from Teachers where Status='Active'", con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr3 = cmd.ExecuteReader();
                GridDt.Load(sdr3);
                TGridview.DataSource = GridDt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror in Get StudentRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        int TeacherId;
        private void TGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (TGridview.Rows.Count > 0)
            {
                TID.Text = TGridview.SelectedRows[0].Cells[0].Value.ToString();
                TeacherId = Convert.ToInt32(TID.Text);
                TName.Text = TGridview.SelectedRows[0].Cells[1].Value.ToString();
                Tdepartment.Text = TGridview.SelectedRows[0].Cells[2].Value.ToString();
                TPno.Text = TGridview.SelectedRows[0].Cells[3].Value.ToString();
                TMno.Text = TGridview.SelectedRows[0].Cells[4].Value.ToString();
                EnrlDate.Text = TGridview.SelectedRows[0].Cells[5].Value.ToString();
                string ActiveornotTeacher = TGridview.SelectedRows[0].Cells[6].Value.ToString();
                if (ActiveornotTeacher == "Not Active")
                {
                    TRecover.Enabled = true;
                }
                else
                {
                    TRecover.Enabled = false;
                }
            }
        }
        //for save Teacher in Database
        private void tSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalidteacher())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    string query = "SELECT COUNT(*) FROM teachers WHERE  P_No= @Pno";

                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    command.Parameters.AddWithValue("@Pno", TPno.Text);

                    int DuplicateBookcheck = (int)command.ExecuteScalar();
                    con.Close();
                    if (DuplicateBookcheck > 0)
                    {
                        MessageBox.Show("This Personal No is Already Exist", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }

                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Teachers VALUES ( @Name, @Department, @Pno, @Mno, GETDATE(), 'Active') ", con);
                            cmd.CommandType = CommandType.Text;

                            cmd.Parameters.AddWithValue("@Name", TName.Text);
                            cmd.Parameters.AddWithValue("@Department", Tdepartment.Text);
                            cmd.Parameters.AddWithValue("@Pno", TPno.Text);
                            cmd.Parameters.AddWithValue("@Mno", TMno.Text);


                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                            }

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved Teacher", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetTeacherRecord();
                            ClearAllValueAddTeacher();
                             UCHome.FromHome.Update();
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

        private void ClearAllValueAddTeacher()
        {
            TID.Clear();
            TName.Clear();
            Tdepartment.Clear();
            TPno.Clear();
            TMno.Clear();
        }

        private bool isvalidteacher()
        {
            if (TName.Text == string.Empty)
            {
                MessageBox.Show("Teacher Name is Embty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (Tdepartment.Text == string.Empty)
            {
                MessageBox.Show("Departmant is Not Entered", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (TPno.Text == string.Empty)
            {
                MessageBox.Show("Personal Number is not Entered ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (TMno.Text == string.Empty)
            {
                MessageBox.Show("Mobile No is Not Entered", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void Tclear_Click(object sender, EventArgs e)
        {
            ClearAllValueAddTeacher();
        }

        private void TUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalidteacher())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update Teachers set  Name=@Name, Department=@Department, P_No=@Pno, Mobile_No=@Mno where T_Id=@TID", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("TID", TeacherId);
                        cmd.Parameters.AddWithValue("@Name", TName.Text);
                        cmd.Parameters.AddWithValue("@Department", Tdepartment.Text);
                        cmd.Parameters.AddWithValue("@Pno", TPno.Text);
                        cmd.Parameters.AddWithValue("@Mno", TMno.Text);


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Update Teacher", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetTeacherRecord();
                        ClearAllValueAddTeacher();
                        UCHome.FromHome.Update();
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

        private void Tdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (TName.Text != string.Empty)
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Deleteing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("Select * from TeacherIssuedBooks where T_Id = @T_Id and Return_by is null", con);
                        SqlCommand cmd = new SqlCommand("update Teachers set Status='Not Active' where T_Id=@T_Id", con);

                        cmd1.Parameters.AddWithValue("@T_Id", TeacherId);


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd1.ExecuteNonQuery();


                        SqlDataAdapter sda = new SqlDataAdapter(cmd1);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);


                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("This Teacher is Issued A Book Please Return Than Delete It", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@T_Id", TeacherId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Successfuly Delete Teacher from DATABASE ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UCHome.FromHome.Update();
                            GetTeacherRecord();
                            ClearAllValueAddTeacher();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "When Deleting Teacher");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Teacher From GridView", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TActiveButton_Click(object sender, EventArgs e)
        {
            GetTeacherRecord();    
            tSave.Enabled = true;
            TUpdate.Enabled = true;
            TRecover.Enabled = false;
        }

        private void NonActiveTeacher()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Teachers where Status='Not Active'", con);

            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            dt1.Load(sdr1);
            con.Close();
            TGridview.DataSource = dt1;
        }
        private void TDeletedButton_Click(object sender, EventArgs e)
        {
            NonActiveTeacher();
            tSave.Enabled = false;
            TUpdate.Enabled = false;
            TRecover.Enabled = false;
        }

        private void TViewAllTeacher_Click(object sender, EventArgs e)
        {
            ViewAllStudent vastudent = new ViewAllStudent();
            ViewAllStudent.vas.GetTeacherRecord();
            vastudent.ShowDialog();
        }

        private void TRecover_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalidteacher())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Teachers SET Status=@Status where T_Id=@T_Id ", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@T_Id", TeacherId);
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Recovered Teacher", "Recovered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NonActiveTeacher();
                        TID.Clear();
                        ClearAllValueAddTeacher();
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
            }
        }

      

       

        private void SearchTeacherBox_TextChanged(object sender, EventArgs e)
        {
            SearchTeacher();
        }
        private void SearchTeacher()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Teachers where Name like '%' + @Name +'%' ", con);
                sda.SelectCommand.Parameters.AddWithValue("@Name", SearchTeacherBox.Text.Trim());

                DataTable dt = new DataTable();

                sda.Fill(dt);
                TGridview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Searchng", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ClearAllValueAddTeacher();
            PanelAddTeacher.Hide();
        }
    }

}


