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

                SqlCommand cmd = new SqlCommand("Select * from Students", con);
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
                MessageBox.Show(ex.Message, "Eror in GitStudentRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        //view all form object created
        ViewAllStudent vastudent = new ViewAllStudent();

        //show all user List
        private void ViewAllUserButton_Click(object sender, EventArgs e)
        {
            vastudent.ShowDialog();
            GetStudentRecord();
        }

        //Panel Add new Button
        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (PanelAddUser.Visible == false)
            {
                PanelAddUser.Show();
            }
            else
            {
                PanelAddUser.Hide();
            }
            GetStudentRecord();
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
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES ( @Name, @F_Name, @Gender, @Roll_No, @Program, @Department, @Year_Semester, @Address_, @Mobile_No, @Enrl_Date) ", con);
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
                    cmd.Parameters.AddWithValue("@Enrl_Date", txtUserEdate.Text);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved Student", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetStudentRecord();
                    ClearAllValueAdduser();
                    UCHome.FromHome.StudentCount();
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

        // For Delete Students
        private void ButtonDeleteAdduser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (txtUName.Text != string.Empty)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from students where S_Id=@S_Id", con);

                    cmd.Parameters.AddWithValue("@S_Id", StudentID);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfuly Delete User from DATABASE ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UCHome.FromHome.StudentCount();
                    GetStudentRecord();
                    ClearAllValueAdduser();
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
        }
    }
}
