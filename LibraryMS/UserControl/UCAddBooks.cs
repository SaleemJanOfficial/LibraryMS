using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryMS.Windows_Form;

namespace LibraryMS
{
    public partial class UCAddBooks : UserControl
    {
        // string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";


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
            //Use for clear all value in add book
            ClearAllValueAddbook();
        }
        // add Book
        private void ButtonSaveAddBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalid())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Books VALUES (@Book_Name, @Author, @Publisher, @Quantity, GETDATE(),'') ", con);
                        cmd.CommandType = CommandType.Text;


                        cmd.Parameters.AddWithValue("@Book_Name", Bkname.Text);
                        cmd.Parameters.AddWithValue("@Author", Author.Text);
                        cmd.Parameters.AddWithValue("@Publisher", Publisher.Text);
                        cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                        //  cmd.Parameters.AddWithValue("@Date", Bookdate.Text);

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Add Book", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllValueAddbook();
                        UCHome.FromHome.BookCount();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eror While Book Adding");
                    }
                    finally
                    {
                        con.Close();
                    }

                    GetBookRecord();

                }
            }
        }


        public void GetBookRecord()
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {


                SqlCommand cmd = new SqlCommand("Select * from Books", con);

                DataTable dt = new DataTable();

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                Booksgrid.DataSource = dt;
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
            txtBookId.Clear();
            Bkname.Clear();
            Author.Clear();
            Publisher.Clear();
            Quantity.Clear();
            //Bookdate.Value = DateTime.Today;
            Bkname.Focus();


        }


        private void ViewAllBooksButton_Click(object sender, EventArgs e)
        {
            ViewAllbooks vab = new ViewAllbooks();
            vab.ShowDialog();

        }

        public int BookId;
        private void Booksgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookId.Text = Booksgrid.SelectedRows[0].Cells[0].Value.ToString();
            BookId = Convert.ToInt32(txtBookId.Text);
            Bkname.Text = Booksgrid.SelectedRows[0].Cells[1].Value.ToString();
            Author.Text = Booksgrid.SelectedRows[0].Cells[2].Value.ToString();
            Publisher.Text = Booksgrid.SelectedRows[0].Cells[3].Value.ToString();
            Quantity.Text = Booksgrid.SelectedRows[0].Cells[4].Value.ToString();
            Bookdate.Text = Booksgrid.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void ButtonUpdateAddBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (isvalid())
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Books set Book_Name=@Book_Name, Author=@Author, Publisher=@Publisher, Quantity=@Quantity, Date=@Date where Book_Id=@Book_Id;", con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Book_Id", BookId);
                        cmd.Parameters.AddWithValue("@Book_Name", Bkname.Text);
                        cmd.Parameters.AddWithValue("@Author", Author.Text);
                        cmd.Parameters.AddWithValue("@Publisher", Publisher.Text);
                        cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                        cmd.Parameters.AddWithValue("@Date", Bookdate.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Update Book", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllValueAddbook();
                        txtBookId.Clear();

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
        }
        // For Delete Book 
        private void ButtonDeleteAddBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            if (txtBookId.Text != string.Empty)
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Deleteing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("delete from Books where Book_Id=@Book_Id", con);

                        cmd.Parameters.AddWithValue("@Book_Id", BookId);

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfuly Delete Book from DATABASE ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UCHome.FromHome.BookCount();
                        GetBookRecord();
                        ClearAllValueAddbook();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "When Deleting User");
                    }
                    finally
                    {
                        con.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select Book From GridView", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }




}


