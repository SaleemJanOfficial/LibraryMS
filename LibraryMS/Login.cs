using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Login : Form
    {
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
            this.Hide();
            Register form2 = new Register();
            form2.Show();
            
        }

        //login button
        public void bttonLogin1_Click(object sender, EventArgs e)
        {
            Main form3 = new Main();

            this.Hide();
            form3.Show();
       
        }
    }
}
