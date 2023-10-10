using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryMS.Admin;

namespace LibraryMS
{
    public partial class AdminPassChan : UserControl
    {
        public string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";

        public AdminPassChan()
        {
            InitializeComponent();
        }

        private void Changepass_Click(object sender, EventArgs e)
        {
            if (Login.lno.Visible == true)
            {
                
                ChangepasswordLIB();
            }

            else if (AdminLogin.alogin.Visible == true)
            {
                Changepassword();
            }

        }

        string LoginName;
        int loginId;

        private void ChangepasswordLIB()
        {
            SqlConnection con = new SqlConnection(Constr);

            if (isvalid1())
            {
                SqlCommand cmd = new SqlCommand("select * from Librarian where Email=@Email and UPassword=@Password and LibStatus='Active' ", con);

                cmd.Parameters.AddWithValue("@Email", EmailChan.Text);
                cmd.Parameters.AddWithValue("@Password", OldPassch.Text);
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    LoginName = dt.Rows[0]["UserName"].ToString();
                    string tempuid = dt.Rows[0]["UserId"].ToString();
                    loginId = Convert.ToInt32(tempuid);

                    if (NewPass.Text == ConfirmPass.Text)
                    {
                        //beagibn here



                        DialogResult mbx = MessageBox.Show("Are You Sure?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (mbx == DialogResult.Yes)
                        {
                            try
                            {
                                SqlCommand cmd1 = new SqlCommand("UPDATE Librarian SET UPassword=@Password1 where  Email=@Email1 ", con);
                                cmd1.CommandType = CommandType.Text;

                                cmd1.Parameters.AddWithValue("@Email1", EmailChan.Text.ToString());
                                cmd1.Parameters.AddWithValue("@Password1", NewPass.Text.ToString());
                                if (con.State != ConnectionState.Open)
                                {
                                    con.Open();
                                }
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Success Fully New Passwrod Changed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                NewPass.Clear();
                                EmailChan.Clear();
                                ConfirmPass.Clear();
                                OldPassch.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("while Changing password",ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                    }

                    //end here


                    else
                    {
                        MessageBox.Show("Password not Match");
                    }
                }


                else
                {
                    MessageBox.Show(" Entered Wrong EMail or Old Password");
                }
            }

        }
        private void Changepassword()
        {
            SqlConnection con = new SqlConnection(Constr);

            if (isvalid1())
            {
                SqlCommand cmd = new SqlCommand("select * from Admin where Email=@Email and Password=@Password ", con);

                cmd.Parameters.AddWithValue("@Email", EmailChan.Text);
                cmd.Parameters.AddWithValue("@Password", OldPassch.Text);
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    LoginName = dt.Rows[0]["Name"].ToString();
                    string tempuid = dt.Rows[0]["Admin_Id"].ToString();
                    loginId = Convert.ToInt32(tempuid);

                    if (NewPass.Text == ConfirmPass.Text)
                    {
                        //beagibn here



                        DialogResult mbx = MessageBox.Show("Are You Sure?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (mbx == DialogResult.Yes)
                        {
                            try
                            {
                                SqlCommand cmd1 = new SqlCommand("UPDATE Admin SET Password=@Password1 where  Email=@Email1 ", con);
                                cmd1.CommandType = CommandType.Text;

                                cmd1.Parameters.AddWithValue("@Email1", EmailChan.Text.ToString());
                                cmd1.Parameters.AddWithValue("@Password1", NewPass.Text.ToString());
                                if (con.State != ConnectionState.Open)
                                {
                                    con.Open();
                                }
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Success Fully New Passwrod Changed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                NewPass.Clear();
                                EmailChan.Clear();
                                ConfirmPass.Clear();
                                OldPassch.Clear();
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

                    //end here


                    else
                    {
                        MessageBox.Show("Password not Match");
                    }
                }


                else
                {
                    MessageBox.Show(" Entered Wrong EMail or Old Password");
                }
            }

        }
        private bool isvalid1()
        {
            if (EmailChan.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Email", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (OldPassch.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Old Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (NewPass.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your New Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (ConfirmPass.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Confirm Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;

        }

        private void Exitchange_Click(object sender, EventArgs e)
        {


            this.Hide();
            if (Login.lno.Visible == true)
            {
                Login.lno.LoginPanel.Show();
            }


        }

        private void AdminPassChan_Load(object sender, EventArgs e)
        {
            EmailChan.Focus();
        }
    }
}
