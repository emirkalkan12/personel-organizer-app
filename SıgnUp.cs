using Personal_Organizer_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace personel_organizer_ilk
{
    public partial class SıgnUp: Form
    {
        public SıgnUp()
        {
            InitializeComponent();
            picBoxBack.BackColor = Color.Transparent;
            lblBack.BackColor = Color.Transparent;
            lblPath.Visible = false;
        }

        private void txt_sadece_harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private string ImageToBase64(string imagePath)
        {
            try
            {
                Image img = Image.FromFile(imagePath);

                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    return Convert.ToBase64String(imageBytes);
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void SıgnUp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.loginpage;
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            txtBoxPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            txtBoxPassword.UseSystemPasswordChar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picBox.ImageLocation = openFileDialog1.FileName;
            lblPath.Text = ImageToBase64(openFileDialog1.FileName);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (Login.userList.Any())
            {
                for (int i = 0; i < Login.userList.Count(); i++)
                {
                    if (txtBoxUsername.Text == Login.userList[i].Username)
                    {
                        MessageBox.Show("User already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter++;
                        break;
                    }
                    else if (txtBoxUsername.Text == "" || txtBoxPassword.Text == "" || txtBoxName.Text == "" || txtBoxSurname.Text == "" || MtxtBoxPhone.Text == "" || txtBoxAddress.Text == "" || txtBoxEMail.Text == "" || lblPath.Text == "")
                    {
                        MessageBox.Show("Please fill in the blanks!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter++;
                        break;
                    }
                }
                if (counter != 1)
                {
                    if (Util.isEmailValid(txtBoxEMail.Text))
                    {
                        if (MtxtBoxPhone.Text.Length == 14)
                        {
                            User userAdd = new User(txtBoxUsername.Text, Util.ComputeStringToSha256Hash((txtBoxPassword.Text)), false, "user", txtBoxName.Text, txtBoxSurname.Text, MtxtBoxPhone.Text, txtBoxAddress.Text, txtBoxEMail.Text, lblPath.Text, "5000");
                            Login.userList.Add(userAdd);
                            Util.SaveCsv(Login.userList, Login.path);
                            MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtBoxUsername.Text == "" || txtBoxPassword.Text == "" || txtBoxName.Text == "" || txtBoxSurname.Text == "" || MtxtBoxPhone.Text == "" || txtBoxAddress.Text == "" || txtBoxEMail.Text == "" || lblPath.Text == "")
                {
                    MessageBox.Show("Please fill in the blanks!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Util.isEmailValid(txtBoxEMail.Text))
                    {
                        if (MtxtBoxPhone.Text.Length == 14)
                        {
                            User userAdd = new User(txtBoxUsername.Text, Util.ComputeStringToSha256Hash((txtBoxPassword.Text)), false, "*Admin", txtBoxName.Text, txtBoxUsername.Text, MtxtBoxPhone.Text, txtBoxUsername.Text, txtBoxEMail.Text, lblPath.Text, "5000");
                            Login.userList.Add(userAdd);
                            Util.SaveCsv(Login.userList, Login.path);
                            MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Phone number order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Email order incorrect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login yeniForm = new Login();
            yeniForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login yeniForm = new Login();
            yeniForm.Show();
        }
    }
}
