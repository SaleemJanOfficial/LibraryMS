using LibraryMS.Windows_Form;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LibraryMS
{
    public partial class UCAddUser : UserControl
    {
    
        public UCAddUser()
        {
            InitializeComponent();
 
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True");
        private void GetStudentRecord()
        {
           
            SqlCommand cmd = new SqlCommand("Select * from Students", con);

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            GridStudentRecord.DataSource = dt;
            
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
            if (PanelAddUser.Visible==false)
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
            UName.Clear();
            Fname.Clear();
            UserRNo.Clear();
            UserMNo.Clear();
            UserAddress.Clear();
            UserDepartment.Clear();
            Programe.Clear();
            UserYearSem.Clear();
            UserMNo.Clear();
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            RadioOther.Checked = false;
            UName.Focus();
               

        }

        private void ButtonBackAddUser_Click(object sender, EventArgs e)
        {
            ClearAllValueAdduser();
            PanelAddUser.Hide();
        }

        string gender1 =null;
     
      
        //For Add User
        private void ButtonSaveAddUser_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES ( @Name, @F_Name, @Gender, @Roll_No, @Program, @Department, @Year_Semester, @Address_, @Mobile_No, @Enrl_Date) ", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", UName.Text);
                cmd.Parameters.AddWithValue("@F_Name", Fname.Text);
                cmd.Parameters.AddWithValue("@Gender", gender1);
                cmd.Parameters.AddWithValue("@Roll_No", UserRNo.Text);
                cmd.Parameters.AddWithValue("@Program", Programe.Text);
                cmd.Parameters.AddWithValue("@Department", UserDepartment.Text);
                cmd.Parameters.AddWithValue("@Year_Semester", UserYearSem.Text);
                cmd.Parameters.AddWithValue("@Address_", UserAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile_No", UserMNo.Text);
                cmd.Parameters.AddWithValue("@Enrl_Date", UserEdate.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Saved Student", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecord();
                ClearAllValueAdduser();
                UCHome.Instense.StudentCount();
            }
        }

        private bool isvalid()
        {
            if (UName.Text == string.Empty)
            { 
                MessageBox.Show("Student Name is Embty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
            }

            else if (gender1 == string.Empty)
            {
                MessageBox.Show("Gender Not Selected", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

             else if (Fname.Text == string.Empty)
            {
                MessageBox.Show("Father Name is Not Entered", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (UserRNo.Text == string.Empty)
            {
                MessageBox.Show("Roll No is not Entered ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (Programe.Text == string.Empty)
            {
                MessageBox.Show("Select Programe", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (UserYearSem.Text == string.Empty)
            {
                MessageBox.Show("Select Year or Semister ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (UserMNo.Text == string.Empty)
            {
                MessageBox.Show("Mobile No is Embty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (UserAddress.Text == string.Empty)
            {
                MessageBox.Show("Address is empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (UserDepartment.Text == string.Empty)
            {
                MessageBox.Show("Department Is not Selected", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void ButtonUpdateAdduser_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteAdduser_Click(object sender, EventArgs e)
        {

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
    }


}
