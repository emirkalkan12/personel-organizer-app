using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace personel_organizer_ilk
{
    public partial class ForgetPassword : Form
    {
        private string sentCode = "";
        private string targetUsername = "";

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.loginpage;
        }

        private void SendPasswordResetEmail(string userEmail, string resetCode)
        {
            try
            {
                // 
                lblStatus.Text = "Sending email...";
                lblStatus.Visible = true;
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.Visible = true;
                progressBar1.MarqueeAnimationSpeed = 30;

                Application.DoEvents(); 
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("abcde2@gmail.com");
                mail.To.Add(userEmail);
                mail.Subject = "Password Reset Request";
                mail.Body = $"Merhaba,\n\nŞifre sıfırlama kodunuz: {resetCode}\n\nBu işlemi siz başlatmadıysanız lütfen bu e-postayı dikkate almayınız.";

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("abcde@gmail.com", "abcde fgh klmn");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

                // 
                lblStatus.Text = "Email sent successfully.";
                progressBar1.Visible = false;

                MessageBox.Show("Password reset code has been sent to your email address.", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                lblStatus.Text = "Failed to send email.";
                progressBar1.Visible = false;

                MessageBox.Show("Email could not be sent:" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = txtBoxUsename.Text.Trim();
            string inputEmail = txtBoxEmail.Text.Trim();
            string path = Login.path;

            List<User> userList = new List<User>();
            Util.LoadCsv(userList, path);

            User foundUser = userList.FirstOrDefault(u =>
                u.Username.Equals(inputUsername, StringComparison.OrdinalIgnoreCase) &&
                u.Email.Equals(inputEmail, StringComparison.OrdinalIgnoreCase));

            if (foundUser != null)
            {
                string resetCode = Guid.NewGuid().ToString().Substring(0, 6);
                sentCode = resetCode;
                targetUsername = foundUser.Username;

                SendPasswordResetEmail(foundUser.Email, resetCode);

                this.Hide();
                ResetPasswordForm resetForm = new ResetPasswordForm(targetUsername, sentCode);
                resetForm.Show();
            }
            else
            {
                MessageBox.Show("Username or email is incorrect!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login yeniForm = new Login();
            yeniForm.Show();
        }
    }
}
