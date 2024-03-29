﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryMS
{
    public partial class UCStatus : UserControl
    {
        string Constr = @"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True";
       public static UCStatus ucpandig;
        public UCStatus()
        {
            InitializeComponent();
            ucpandig = this;
            GetIssuebook();
        }

        public void GetIssuebook()
        {
            SqlConnection con = new SqlConnection(Constr);
            try
            {
                string query = "SELECT i.Issue_Id,s.S_Id, s.Name AS Student_Name,s.Program+' '+s.Department+' '+s.Year_Semester AS Class ,s.Roll_No, b.Book_Id ,b.Book_Name AS BookName , l.UserName As Issued_by, i.Issue_date,l2.UserName as Returned_by, i.Return_Date FROM IssuedBooks i JOIN Students s ON i.S_Id = s.S_Id Join Books b ON i.Book_Id = b.Book_Id join Librarian l on i.Issue_by= l.UserId left join Librarian l2 on i.Return_by=l2.UserId where Return_Date is  null";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);

                GridIssuebook.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GridIssueBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        // For select text from Add Student Grid View
        public int issueid;
        public int issuedate;
        public int bookid;
        private void GridIssuebook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Book Detail 
            lblissueid.Text = GridIssuebook.SelectedRows[0].Cells[0].Value.ToString();
            issueid = Convert.ToInt32(lblissueid.Text);
            lblbookid.Text = GridIssuebook.SelectedRows[0].Cells[5].Value.ToString();
            bookid = Convert.ToInt32(lblbookid.Text);
            lblbookname.Text = GridIssuebook.SelectedRows[0].Cells[6].Value.ToString();
            lblIssueby.Text = GridIssuebook.SelectedRows[0].Cells[7].Value.ToString();
            lblIssuedate.Text = GridIssuebook.SelectedRows[0].Cells[8].Value.ToString();

            //Student Detal
            lblsid.Text = GridIssuebook.SelectedRows[0].Cells[1].Value.ToString();
            lblsname.Text = GridIssuebook.SelectedRows[0].Cells[2].Value.ToString();
            lblrno.Text = GridIssuebook.SelectedRows[0].Cells[4].Value.ToString();
            lblclasssem.Text = GridIssuebook.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValueLabel();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Constr);
            if (issueid > 0 && lblissueid.Text != string.Empty)
            {
                DialogResult mbx = MessageBox.Show("Are You Sure?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mbx == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update IssuedBooks set Return_by=@Return_by, Return_Date=GETDATE() where Issue_Id=@issueid; UPDATE Books SET Issued_Books = Issued_Books - 1 WHERE Book_Id = @bookId;", con);

                        cmd.Parameters.AddWithValue("@issueid", issueid);
                        cmd.Parameters.AddWithValue("@bookId", bookid);
                        cmd.Parameters.AddWithValue("@Return_by", Login.lno.loginId);
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Succefuly Return Books", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearValueLabel();
                        GetIssuebook();
                       UCHome.FromHome.CurrentIssueBook();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error While Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select On Grid Videw", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
        private void ClearValueLabel()
        {
            lblissueid.Text = string.Empty;
            lblsid.Text = string.Empty;
            lblsname.Text = string.Empty;
            lblrno.Text = string.Empty;
            lblclasssem.Text = string.Empty;
            lblbookid.Text = string.Empty;
            lblbookname.Text = string.Empty;
            lblIssueby.Text = string.Empty;
            lblIssuedate.Text = string.Empty;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
