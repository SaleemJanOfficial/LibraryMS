using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS.Admin
{
    public partial class AdminLogin : Form
    {
        public static AdminLogin alogin;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";

        public AdminLogin()
        {
            InitializeComponent();
            alogin = this;
        }

        //when closing form 
        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Get Record in Grid
        public void GetLibraryRecord()

        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {

                SqlCommand cmd = new SqlCommand("Select * from Librarian where LibStatus='Active'", con);
                DataTable dt = new DataTable();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                GridLibraryRecord.DataSource = dt;
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

        // Clear All text Box value
        private void ButtonClearAddStudents_Click(object sender, EventArgs e)
        {

            ClearAllValueAdduser();
        }

        //For Clear All Vaulue in 
        private void ClearAllValueAdduser()
        {
            Lid.Text=string.Empty;
            Lname.Text = string.Empty;
            Lcnic.Text = string.Empty;
            Lemail.Text = string.Empty;
            LPassword.Text = string.Empty;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            
            GetLibraryRecord();
        }

        // Grid to Textbox
        int LibrarianID;
        string Activeornot;
        private void GridLibraryRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Lid.Text = GridLibraryRecord.SelectedRows[0].Cells[0].Value.ToString();
            LibrarianID = Convert.ToInt32(Lid.Text);
            Lname.Text = GridLibraryRecord.SelectedRows[0].Cells[1].Value.ToString();
            Lcnic.Text = GridLibraryRecord.SelectedRows[0].Cells[2].Value.ToString();
            Lemail.Text = GridLibraryRecord.SelectedRows[0].Cells[3].Value.ToString();

            LPassword.Text = GridLibraryRecord.SelectedRows[0].Cells[4].Value.ToString();


            Activeornot = GridLibraryRecord.SelectedRows[0].Cells[5].Value.ToString();
            if (Activeornot == "Not Active")
            {
                btnRecover.Text = "Recover";

                btnRecover.Enabled = true;
            }
            else if (Activeornot == "Not Approve")
            {
                btnRecover.Text = "Approve";
                btnRecover.Enabled = true;
            }
            else
            {
                btnRecover.Enabled = false;
            }
        }


        //show active librarian
        private void ActiveButton_Click(object sender, EventArgs e)
        {

            GetLibraryRecord();

            PanelviewLibrarian.Show();
            ButtonDeleteAddStudents.Enabled = true;
            btnRecover.Enabled = false;
            GridLibraryRecord.Show();
            AdmChanpass.Hide();
            ucHomeadmin.Visible = false;
        }

        //show Deleted Librarian
        private void DeletedLibrarian_Click(object sender, EventArgs e)
        {
            NotActive();
            PanelviewLibrarian.Show();
            ButtonDeleteAddStudents.Enabled = false;
            GridLibraryRecord.Show();
            AdmChanpass.Hide();
            ucHomeadmin.Visible = false;
        }
        //function for Deleted librarian
        private void NotActive()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Librarian where LibStatus='Not Active'", con);

            DataTable dt1 = new DataTable();
            try
            {
                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                dt1.Load(sdr1);
                con.Close();
                GridLibraryRecord.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("When showing Deleted Librarian", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //button for Approval List
        private void ApprovalLib_Click(object sender, EventArgs e)
        {

            NotApprove();

            ButtonDeleteAddStudents.Enabled = false;
            PanelviewLibrarian.Show();
            GridLibraryRecord.Show();
            ucHomeadmin.Visible = false;
        }

        //fucntion for Approval list
        private void NotApprove()
        {

            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Librarian where LibStatus='Not Approve'", con);

            DataTable dt1 = new DataTable();
            try
            {
                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                dt1.Load(sdr1);
                GridLibraryRecord.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("When Not Approve List Updtaing", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private bool isvalid()
        {
            if (Lname.Text == string.Empty)
            {
                MessageBox.Show("Librarian Name is Embty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (Lemail.Text == string.Empty)
            {
                MessageBox.Show("Email not Entered", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (Lcnic.Text == string.Empty)
            {
                MessageBox.Show(" CNIC is Not Entered", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ButtonDeleteAddStudents_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Constr);
            if (Lname.Text != string.Empty)
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Deleteing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("update Librarian set LibStatus='Not Active' where UserId=@UserId", con);

                        cmd.Parameters.AddWithValue("@UserId", LibrarianID);


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successfuly Delete User from DATABASE ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //UCHome.FromHome.StudentCount();


                        GetLibraryRecord();

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
            }
            else
            {
                MessageBox.Show("Please Select Students From GridView", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalid())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Rocovering", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Librarian SET LibStatus=@Status where UserId=@UserId ", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@UserId", LibrarianID);
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Recovered Librarian", "Recovered", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                         if (Activeornot == "Not Active")
                        {
                            NotActive();
                        }
                        else  if(Activeornot == "Not Approve")
                        {
                            NotApprove();
                        }
                        
                        // UserId.Clear();
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LibrarianSearching();
        }

        private void LibrarianSearching()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Librarian where UserName like '%' + @Name +'%' ", con);
                sda.SelectCommand.Parameters.AddWithValue("@Name", SearchBox.Text.Trim());

                DataTable dt = new DataTable();

                sda.Fill(dt);
                GridLibraryRecord.DataSource = dt;




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

        private void LGOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.Show();
        }

        private void ButtonBackAddStudents_Click(object sender, EventArgs e)
        {
            PanelviewLibrarian.Hide();
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void changepass_Click(object sender, EventArgs e)
        {
           
            PanelviewLibrarian.Hide();

            AdmChanpass.Visible = true;
            AdmChanpass.BringToFront();
            ucHomeadmin.Visible = false;


        }

        private void vdashboard_Click(object sender, EventArgs e)
        {
           
            AdmChanpass.Visible = false;
            PanelviewLibrarian.Hide();
            
            ucHomeadmin.Visible = true;
            ucHomeadmin.BringToFront();

        }
    }
}
