﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class UCIssueBooks : UserControl
    {
        // string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
        public UCIssueBooks()
        {
            InitializeComponent();
        }

        private void IssuedBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            int Quantity = Int32.Parse(txtquantity.Text);
            if (Quantity > 0)
            {


                DialogResult mb1 = MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo);
                if (mb1 == DialogResult.Yes)
                {

                    if (isvalid())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO IssuedBooks VALUES(@studentId, @bookId, @issueBy,GETDATE() ,NULL , NULL); UPDATE Books SET Issued_Books = Issued_Books + 1 WHERE Book_Id = @bookId; ", con);
                            cmd.CommandType = CommandType.Text;

                            cmd.Parameters.AddWithValue("@studentId", txtSID.Text);
                            cmd.Parameters.AddWithValue("@bookId", txtbookid.Text);
                            cmd.Parameters.AddWithValue("@issueBy", "Saleem Jan");
                           // cmd.Parameters.AddWithValue("@returnBy", "NULL");

                            con.Open();
                            cmd.ExecuteNonQuery();

                            // For SHow Count
                            UCHome.FromHome.CurrentIssueBook();
                            UCHome.FromHome.TotalIssueBook();


                            ClearAllIssueValue();


                            MessageBox.Show("Successfully Issued", "Info", MessageBoxButtons.OK);
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
                }
            }


            else if (txtbookid.Text != string.Empty)
            {
                MessageBox.Show("Please Select Book ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtSID.Text != string.Empty)
            {
                MessageBox.Show("Please Select Student ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("All Book Are Issued ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private bool isvalid()
        {
            if (txtSID.Text == string.Empty)
            {
                MessageBox.Show("Enter Student ID", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtbookid.Text == string.Empty)
            {
                MessageBox.Show("Book Id Not Selected", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }


        // Load Books from Database
        private void textbookid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Books where Book_Id=@Book_Id", con);
                cmd.Parameters.AddWithValue("Book_Id", txtbookid.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr;

                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    txtbookname.Text = sdr.GetValue(1).ToString();
                    txtAuthor.Text = sdr.GetValue(2).ToString();
                    txtPublisher.Text = sdr.GetValue(3).ToString();
                    txtquantity.Text = sdr.GetValue(4).ToString();
                    txtIsuued.Text = sdr.GetValue(6).ToString();
                    txtremaining.Text = sdr.GetValue(7).ToString();
                    con.Close();
                }
                else if (txtbookid.Text == string.Empty)
                {
                    ClearSelectBookvalue();

                }
                else
                {
                    MessageBox.Show("No Book Found");
                    ClearSelectBookvalue();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Books");
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
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtremaining.Clear();
        }

        //Load Student from Database
        private void txtSID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constr);

            try
            {

                SqlCommand cmd = new SqlCommand("Select Name,Roll_No, Program + ' ' +Department +' ' + Year_Semester as Class from Students where S_Id=@S_Id", con);

                con.Open();
                cmd.Parameters.AddWithValue("S_Id", txtSID.Text);


                SqlDataReader sdr1;
                sdr1 = cmd.ExecuteReader();

                if (sdr1.Read())
                {
                    txtStuName.Text = sdr1.GetValue(0).ToString();
                    txtsRno.Text = sdr1.GetValue(1).ToString();
                    txtClass.Text = sdr1.GetValue(2).ToString();

                }

                else if (txtbookid.Text == string.Empty)
                {
                    ClearSelectStudentvalue();

                }
                else
                {
                    MessageBox.Show("NO STUDENT FOUND");

                    ClearSelectStudentvalue();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOAD STUDENT");
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearSelectStudentvalue()
        {
            txtStuName.Clear();
            txtsRno.Clear();
            txtClass.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbookid.Clear();

            ClearSelectBookvalue();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            txtSID.Clear();
            ClearSelectStudentvalue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllIssueValue();
        }

        private void ClearAllIssueValue()
        {
            txtbookid.Clear();
            txtSID.Clear();
            ClearSelectBookvalue();
            ClearSelectStudentvalue();
        }
    }
}
