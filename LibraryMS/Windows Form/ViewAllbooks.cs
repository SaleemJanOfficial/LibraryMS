﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryMS.Windows_Form
{
    public partial class ViewAllbooks : Form
    {
        string Constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public ViewAllbooks()
        {
            InitializeComponent();
   
        }
        
        

        private void GetBookRecord()
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd1 = new SqlCommand("Select * from Books", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            dt1.Load(sdr1);
            con.Close();
            ViewAllBookGrid.DataSource = dt1;
        }


        private void ViewAllbooks_Load(object sender, EventArgs e)
        {
            GetBookRecord();
        }
    }
}
