using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace LibraryMS
{
    public partial class UCAbout : UserControl
    {
        public UCAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

        }

        private void Clearcompl_Click(object sender, EventArgs e)
        {
            Subjectbox.Text = string.Empty;
            bodyBox.Text = string.Empty;

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendEmail();

        }

        public void SendEmail()
        {
            try
            {
                string recipientEmail = "Jansaleem3344@gmail.com";

                string subject = Subjectbox.Text.ToString();

                string body = bodyBox.Text.ToString();
                string mailtoURL = $"mailto: {recipientEmail}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";
                Process.Start(new ProcessStartInfo(mailtoURL));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "While Sending Email");
            }
        }

        private void Developers_Click(object sender, EventArgs e)
        {
            Enginers.Show();
            Enginers.BringToFront();
            ComandSugg.Hide();
        }

        private void ContactUs_Click(object sender, EventArgs e)
        {
            Enginers.Hide();
            ComandSugg.Show();
            ComandSugg.BringToFront();
        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            AboutP.Show();
            AboutP.BringToFront();
            Enginers.Hide();
            ComandSugg.Hide();
        }

        private void SEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100057277157493");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/UniversityofSwabiOfficial/");
        }


        // Emai Sending for future project
        /*
          try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sender");
                mail.To.Add("reciver");
                mail.Subject = "Done";
                mail.Body = "This is message body";

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("sender", "password");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
          
          */


    }
}
