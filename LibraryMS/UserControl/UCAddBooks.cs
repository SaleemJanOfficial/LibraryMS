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
    public partial class UCAddBooks : UserControl
    {
        public UCAddBooks()
        {
            InitializeComponent();
        }

        private void AddNewBookButton_Click(object sender, EventArgs e)
        {
            if (PanelAddBook.Visible == false)
            {
                PanelAddBook.Show();
            }
            else
            {
                PanelAddBook.Hide();
            }
        }

        private void ButtonClearAddBook_Click(object sender, EventArgs e)
        {
            //use for clear all value in add book
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox10.Clear();
           
        }
    }
}
