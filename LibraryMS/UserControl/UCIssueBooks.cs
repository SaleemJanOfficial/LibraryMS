using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class UCAddOrder : UserControl
    {
        public UCAddOrder()
        {
            InitializeComponent();
        }

        private void IssuedBook_Click(object sender, EventArgs e)
        {
            DialogResult mb1= MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo);
            if(mb1==DialogResult.Yes)
            {
                MessageBox.Show("Successfully Issued", "Info", MessageBoxButtons.OK);
            }
            
        }
    }
}
