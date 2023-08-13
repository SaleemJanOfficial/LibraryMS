using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LibraryMS.Windows_Form
{
    public partial class ViewAllStudent : Form
    {
        //  static string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
       
        public ViewAllStudent()
        {
            InitializeComponent();

        }
        private void GetStudentRecord()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Students", con);

            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            dt1.Load(sdr1);
            con.Close();
            ViewAllstudentGrid.DataSource = dt1;




        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewAllStudent_Load(object sender, EventArgs e)
        {
            GetStudentRecord();

        }
    }
}
