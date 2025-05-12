using Personal_Organizer_Application;
using personel_organizer_ilk.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace personel_organizer_ilk
{
    public partial class Login: Form
    {
        public static List<User> userList = new List<User>();
        public static string path = "Kullanıcılar.csv";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.loginpage;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            Util.LoadCsv(userList, path);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            txtBoxPassword.UseSystemPasswordChar = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text != "")
            {
                pictureBox2.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SıgnUp yeniForm = new SıgnUp();
            yeniForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            bool rememberMe = RememberMe.Checked;
            for (int i = 0; i < userList.Count; i++)
            {
                User user = userList[i];
                if (user.IsValid(username, password, rememberMe) == true)
                {
                    user.RememberMe = rememberMe;
                    LoginedUser.getInstance().UserGetSet = user;
                    lblMesaj.ForeColor = Color.Green;
                    lblMesaj.BackColor = Color.Transparent;
                    lblMesaj.Text = "Successful login";
                    lblMesaj.Visible = true;
                    this.Hide();
                    LogOut yeniForm = new LogOut();
                    yeniForm.Show();

                    if (rememberMe == true)
                    {
                        Util.SaveCsv(userList, path);
                    }
                    return;
                }
            }
            lblMesaj.ForeColor = Color.Red;
            lblMesaj.BackColor = Color.Transparent;
            lblMesaj.Text = "Failed Login";
            lblMesaj.Visible = true;
            txtBoxUsername.Text = "";
            txtBoxPassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword yeniForm = new ForgetPassword();
            yeniForm.Show();
        }
    }
}
