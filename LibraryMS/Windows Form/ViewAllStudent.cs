using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;


namespace LibraryMS.Windows_Form
{
    public partial class ViewAllStudent : Form
    {
        public static ViewAllStudent vas;
        //  static string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";

        public ViewAllStudent()
        {
            InitializeComponent();
            vas = this;
        }
        public void GetStudentRecord()
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



        public void GEtbookRecord()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd1 = new SqlCommand("Select * from Books", con);


                DataTable dt1 = new DataTable();

                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                dt1.Load(sdr1);

                ViewAllstudentGrid.DataSource = dt1;
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewAllStudent_Load(object sender, EventArgs e)
        {


        }

        private PrintDialog printDialog1 = new PrintDialog();

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {

                // Create a PrintDocument instance
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();

                // Set the PrintPage event handler
                pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);

                // Display the PrintDialog to allow the user to select a printer
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    pd.PrinterSettings = printDialog1.PrinterSettings;
                    pd.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Printing", ex.Message);
            }
             
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create a Bitmap to represent the content of the DataGridView
            Bitmap bm = new Bitmap(ViewAllstudentGrid.Width, ViewAllstudentGrid.Height);
            ViewAllstudentGrid.DrawToBitmap(bm, new Rectangle(0, 0, ViewAllstudentGrid.Width, ViewAllstudentGrid.Height));

            // Draw the Bitmap on the print page
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }




    }
}
