using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_organizer_ilk
{
    public partial class ResetPasswordForm : Form
    {
        private string expectedCode;
        private string username;

        public ResetPasswordForm(string username, string code)
        {
            InitializeComponent();
            this.username = username;
            this.expectedCode = code;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string enteredCode = txtResetCode.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (enteredCode != expectedCode)
            {
                MessageBox.Show("The verification code is incorrect.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = Login.path;
            List<User> userList = new List<User>();
            Util.LoadCsv(userList, path);

            User targetUser = userList.FirstOrDefault(u => u.Username == username);
            if (targetUser != null)
            {
                targetUser.AccoundPassword = Util.ComputeStringToSha256Hash(newPassword);
                Util.SaveCsv(userList, path);
                MessageBox.Show("Your password has been updated successfully.", "SUCCESSFULl", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new Login().Show();
            }
            else
            {
                MessageBox.Show("User not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.loginpage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            txtConfirmPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            txtConfirmPassword.UseSystemPasswordChar = false;
        }
    }

}
