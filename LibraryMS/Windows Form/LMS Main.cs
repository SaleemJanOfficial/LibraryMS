using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMS
{

    public partial class Main : Form
    {
        public static Main mainpage;


        public Main()
        {
            InitializeComponent();
           
           lblWelcome.Text = Login.lno.LoginName;
            mainpage = this;
        }


        //Hide all Usercontrol form
        internal protected void HideUc()
        {
            ucIssueBook.Hide();
            ucPanding.Hide();

            ucAddUser.Hide();
            ucAbout.Hide();
            ucMainHome.Hide();
            ucAddBooks.Hide();

        }
        //when form Load
        private void Main_Load(object sender, EventArgs e)
        {
            HideUc();
            ucMainHome.Visible = true;
        }
        //Home Button
        private void HomeButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = HomeButton.Height;
            Sidepanel.Top = HomeButton.Top;
            HideUc();
            ucMainHome.Visible = true;
        }
        //Issue book button 
        private void IssueButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = IssueButton.Height;
            Sidepanel.Top = IssueButton.Top;
          
            HideUc();
            ucIssueBook.Visible = true;

        }
        // Pending Button
        private void PandingButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height =ReturnButton.Height;
            Sidepanel.Top = ReturnButton.Top;
            HideUc();
            ucPanding.Visible = true;
            //  UCStatus.ucpandig.GetIssuebook();
            if (UCStatus.ucpandig.StudentsMark.Checked == true)
            {
                UCStatus.ucpandig.GetIssuebook();
            }
            else if (UCStatus.ucpandig.TeachersMark.Checked == true)
            {
                UCStatus.ucpandig.GetIssueBookTeacher();
            }

        }
        //Add user button
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = ButtonAddUser.Height;
            Sidepanel.Top = ButtonAddUser.Top;
            HideUc();
            UCHome.FromHome.Update();
            ucAddUser.Visible = true;


        }
        //Add book buttton
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonAddBook.Height;
            Sidepanel.Top = buttonAddBook.Top;
            HideUc();
            ucAddBooks.Visible = true;
        }

        //About Button
        private void AboutButton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = AboutButton.Height;
            Sidepanel.Top = AboutButton.Top;
            HideUc();
            ucAbout.Visible = true;

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


    }
}
