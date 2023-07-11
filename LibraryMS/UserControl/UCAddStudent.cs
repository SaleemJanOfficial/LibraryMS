using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMS.Windows_Form;

namespace LibraryMS
{
    public partial class UCAddUser : UserControl
    {
    
        public UCAddUser()
        {
            InitializeComponent();
        }

        //view all form object created
        ViewAllStudent vastudent = new ViewAllStudent();


        //show all user List
        private void ViewAllUserButton_Click(object sender, EventArgs e)
        {
            vastudent.ShowDialog();          
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
        }

        private void ButtonClearAdduser_Click(object sender, EventArgs e)
        {
            ClearAllValueAdduser();
        }



        //For Clear All Vaulue in Add User
        private void ClearAllValueAdduser()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            RadioOther.Checked = false;


        }

        private void ButtonBackAddUser_Click(object sender, EventArgs e)
        {
            ClearAllValueAdduser();
            PanelAddUser.Hide();
        }

        private void ButtonSaveAddUser_Click(object sender, EventArgs e)
         {

         }

        private void ButtonUpdateAdduser_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteAdduser_Click(object sender, EventArgs e)
        {

        }

        
    }


}
