using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryMS
{
    public partial class UCAddOrder : UserControl
    {
      public static string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlConnection con = new SqlConnection(Constr);
        public UCAddOrder()
        {
            InitializeComponent();
        }

        private void IssuedBook_Click(object sender, EventArgs e)
        {
            DialogResult mb1 = MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo);
            if (mb1 == DialogResult.Yes)
            {
                MessageBox.Show("Successfully Issued", "Info", MessageBoxButtons.OK);
            }

        }

        private void textbookid_TextChanged(object sender, EventArgs e)
        {
           

            try
            {
 
                SqlCommand cmd = new SqlCommand("Select * from Books where Book_Id=@Book_Id", con);
                
                

                con.Open();
                cmd.Parameters.AddWithValue("Book_Id", txtbookid.Text);
                SqlDataReader sdr ;

                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    txtbookname.Text = sdr.GetValue(1).ToString();

                    txtAuthor.Text = sdr.GetValue(2).ToString();
                    txtPublisher.Text = sdr.GetValue(3).ToString();
                    txtquantity.Text = sdr.GetValue(4).ToString();
                    txtIsuued.Text = sdr.GetValue(6).ToString();
                    txtremaining.Text = sdr.GetValue(7).ToString();
                }
                else if (txtbookid.Text == string.Empty )
                {
                    ClearSelectBookvalue();

                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void ClearSelectBookvalue()
        {
            txtbookname.Clear();
            txtquantity.Clear();
            txtIsuued.Clear();
        }
    } 
}
