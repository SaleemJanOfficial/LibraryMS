using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Main : Form
    {
         

        public Main()
        {
            InitializeComponent();

        }
       

        //Hide all Usercontrol form
        private void HideUc()
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
            HideUc();
            ucMainHome.Visible = true;
        }
        //Issue book button 
        private void IssueButton_Click(object sender, EventArgs e)
        {
            HideUc();
            ucIssueBook.Visible = true;
        }
        // Pending Button
        private void PandingButton_Click(object sender, EventArgs e)
        {
            HideUc();
            ucPanding.Visible = true;
        }
        //Add user button
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            HideUc();
            ucAddUser.Visible = true;
        }
        //Add book buttton
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            HideUc();
            ucAddBooks.Visible = true;
        }

        //About Button
        private void AboutButton_Click(object sender, EventArgs e)
        {
            HideUc();
            ucAbout.Visible = true;

        }




    }
}
