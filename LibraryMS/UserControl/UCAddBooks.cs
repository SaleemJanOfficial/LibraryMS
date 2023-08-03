using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryMS.Classes;
using LibraryMS.Windows_Form;

namespace LibraryMS
{
    public partial class UCAddBooks : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True");
     
        public UCAddBooks()
        {
            InitializeComponent();           
            GetBookRecord();
            
            
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
            ClearAllValueAddbook();
        }
        // add Book
        private void ButtonSaveAddBook_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Books VALUES (@Book_Name, @Author, @Publisher, @Quantity, @Date) ", con);
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@Book_Name", Bkname.Text);
                    cmd.Parameters.AddWithValue("@Author", Author.Text);
                    cmd.Parameters.AddWithValue("@Publisher", Publisher.Text);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                    cmd.Parameters.AddWithValue("@Date", Bookdate.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Add Book", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllValueAddbook();
                    UCHome.Instense.BookCount();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

                GetBookRecord();
            }
        }
        

            private void GetBookRecord()
            {


            try
            {


                SqlCommand cmd = new SqlCommand("Select * from Books", con);

                DataTable dt = new DataTable();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                Booksgrid.DataSource = dt;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
               

            




        }
        //check if book field is empty or not
        private bool isvalid()
        {
            if (Bkname.Text == string.Empty)
            {
                MessageBox.Show("Book, Name is Embty", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (Author.Text == string.Empty)
            {
                MessageBox.Show("Author Not Entered", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (Publisher.Text == string.Empty)
            {
                MessageBox.Show("Publisher  is Not Entered", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (Quantity.Text == string.Empty)
            {
                MessageBox.Show("Quantity is not Entered ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
            private void ClearAllValueAddbook()
            {
                Bkname.Clear();
                Author.Clear();
                Publisher.Clear();
                Quantity.Clear();
                Bkname.Focus();

}
        
        
        private void ViewAllBooksButton_Click(object sender, EventArgs e)
        {
            ViewAllbooks vab = new ViewAllbooks();
            vab.ShowDialog();

        }
    }        }
