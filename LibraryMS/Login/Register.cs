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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegisterBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form2 = new Login();
            form2.Show();

        }

        private void LableLogin0_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form2 = new Login();
            form2.Show();
        }
    }
}
