using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMS.Windows_Form
{
    public partial class ViewAllbooks : Form
    {
        //  string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public ViewAllbooks()
        {
            InitializeComponent();

        }



        private void GetBookRecord()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd1 = new SqlCommand("Select * from Books", con);


                DataTable dt1 = new DataTable();

                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                dt1.Load(sdr1);

                ViewAllBookGrid.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Get Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

       

        private void ViewAllbooks_Load(object sender, EventArgs e)
        {
            GetBookRecord();
        }
    }
}
