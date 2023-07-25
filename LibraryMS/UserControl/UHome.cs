using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryMS.Classes;
namespace LibraryMS
{
    public partial class UCHome : UserControl
    {
        public static UCHome Instense;
        public UCHome()
        {     
            InitializeComponent();
            Instense = this;
            StudentCount();
            BookCount();
        }

      

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True");

        private void TstudentLable_Click(object sender, EventArgs e)
        {

        }
        
        // Count Total Students
        public void StudentCount()
        {
            try
            {
               SqlCommand cmd = new SqlCommand("select COUNT(*) from Students", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                TstudentLable.Text = Convert.ToString(StudentCount);
                
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
        
        //Count Total Books

        public void BookCount()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) from Books", con);
                con.Open();
                int StudentCount = Convert.ToInt32(cmd.ExecuteScalar());
                Tbooklable.Text = Convert.ToString(StudentCount);
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            //StudentCount();
            //BookCount();
            
        }
    }
}
