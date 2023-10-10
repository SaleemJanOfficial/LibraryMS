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
using LibraryMS.Admin;

namespace LibraryMS
{
    public partial class Login : Form
    {
        public string LoginName;
        public int loginId;

        public string AdLoginName;
        public int AdloginId;

        public string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public static Login lno;
        public Login()
        {
            InitializeComponent();
            lno = this;
            txtLoginEmail1.Focus();
        }


        //exite button
        private void buttonLoginExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }


        //register button
        private void LableRegister0_Click(object sender, EventArgs e)
        {

            LoginPanel.Hide();
            REGPanel.Show();
            txtName.Focus();

        }

        //login button
        public void bttonLogin1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);

            if (isvalid1())
            {
                SqlCommand cmd = new SqlCommand("select * from Librarian where Email=@Email and UPassword=@UPassword and LibStatus=@Libstatus", con);

                cmd.Parameters.AddWithValue("@Email", txtLoginEmail1.Text);
                cmd.Parameters.AddWithValue("@UPassword", txtLoginPassword1.Text);
                cmd.Parameters.AddWithValue("@LibStatus", "Active");
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successfuly Click Ok To Continue", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginName = dt.Rows[0]["UserName"].ToString();
                    string tempuid = dt.Rows[0]["UserId"].ToString();
                    loginId = Convert.ToInt32(tempuid);

                    Main form3 = new Main();
                    this.Hide();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show(" Entered Wrong EMail or Password");
                }
            }

        }

        private bool isvalid1()
        {
            if (txtLoginEmail1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Email", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtLoginPassword1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void LableLogin0_Click(object sender, EventArgs e)
        {
            REGPanel.Hide();
            LoginPanel.Show();
        }

        private void buttonRegisterBack_Click(object sender, EventArgs e)
        {
            REGPanel.Hide();
            LoginPanel.Show();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into Librarian values (@UserName, @cnic,  @Email,  @UPassword,@LibStatus)", con);
                    cmd.Parameters.AddWithValue("@UserName", txtName.Text);
                    cmd.Parameters.AddWithValue("@cnic", txtCnic.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@UPassword", TxtPassword.Text);
                    cmd.Parameters.AddWithValue("@Libstatus", "Not Approve");

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfly Registered! Waiting For Admin Approval..", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxVAlue();
                    REGPanel.Hide();
                    LoginPanel.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in User Add");
                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void ClearTextBoxVAlue()
        {
            txtName.Clear();
            txtCnic.Clear();
            txtEmail.Clear();
            TxtPassword.Clear();
            txtConfirmpd.Clear();
        }

        private bool isvalid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("User Name is Empty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtCnic.Text == string.Empty)
            {
                MessageBox.Show("Please Enter CNIC NO", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtCnic.Text.Length != 13)
            {
                MessageBox.Show("Please Enter 13 Digit In CNIC NO", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Email", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (TxtPassword.Text == string.Empty || txtConfirmpd.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (TxtPassword.Text != txtConfirmpd.Text)
            {
                MessageBox.Show("Password did not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (txtLoginPassword1.UseSystemPasswordChar != true)
            {
                txtLoginPassword1.UseSystemPasswordChar = true;
            }
            else
            {
                txtLoginPassword1.UseSystemPasswordChar = false;
            }
        }

        private void AdminClick(object sender, EventArgs e)
        {
            LoginPanel.Hide();
            REGPanel.Hide();
            AdminPanel.Show();

        }

        private void admclick_Click(object sender, EventArgs e)
        {
            LoginPanel.Hide();
            REGPanel.Hide();
            AdminPanel.Show();
            AdminEmail.Focus();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            AdminPanel.Hide();
            LoginPanel.Show();

        }
        
        private void buttonlogin2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);

            if (isvalid2())
            {
                SqlCommand cmd = new SqlCommand("select * from Admin where Email=@Email and Password=@Password", con);

                cmd.Parameters.AddWithValue("@Email", AdminEmail.Text);
                cmd.Parameters.AddWithValue("@Password", AdminPassword.Text);
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successfuly Click Ok To Continue", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdLoginName = dt.Rows[0]["Name"].ToString();
                    string tempuid = dt.Rows[0]["Admin_Id"].ToString();
                    AdloginId = Convert.ToInt32(tempuid);


                    Admin.AdminLogin adnlgn = new Admin.AdminLogin();
                    this.Hide();
                    adnlgn.Show();
                }
                else
                {
                    MessageBox.Show("Wrong E-Mail or Password");
                }


            }
        }

        public bool isvalid2()
        {
            if (AdminEmail.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Email", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (AdminPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Your Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Buttonclose2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            LoginPanel.Hide();


            adminPassChan1.Visible = true;
            adminPassChan1.BringToFront();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLoginEmail1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtLoginEmail1.Focus();
        }
    }
}

