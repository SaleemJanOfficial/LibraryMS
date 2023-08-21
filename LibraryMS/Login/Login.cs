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

namespace LibraryMS
{
    public partial class Login : Form
    {
        public string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }


        //exite button
        private void buttonLoginExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }


        //register button
        private void LableRegister0_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Register form2 = new Register();
            //form2.Show();
            LoginPanel.Hide();
            REGPanel.Show();

        }

        //login button
        public void bttonLogin1_Click(object sender, EventArgs e)
        {
            Main form3 = new Main();

            this.Hide();
            form3.Show();

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
                    SqlCommand cmd = new SqlCommand("insert into Librarian values (@UserName, @cnic,  @Email,  @UPassword)", con);
                    cmd.Parameters.AddWithValue("@UserName", txtName.Text);
                    cmd.Parameters.AddWithValue("@cnic", txtCnic.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@UPassword", TxtPassword.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfly Add User", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private bool isvalid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("User Name is Embty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtCnic.Text == string.Empty)
            {
                MessageBox.Show("Please Enter CNIC NO", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
