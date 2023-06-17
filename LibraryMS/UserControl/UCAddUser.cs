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


        private void ViewAllUserButton_Click(object sender, EventArgs e)
        {
            vastudent.ShowDialog();          
        }
    }
}
