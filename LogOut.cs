using Personal_Organizer_Application;
using personel_organizer_ilk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static personel_organizer_ilk.Util;


namespace personel_organizer_ilk
{
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
            lblProfile.Visible = true;
            lblProfile.BackColor = Color.Transparent;

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        public string path = "Kullanıcılar1.csv";
        public int flag = 0;
        Stack<CareTakerDatas> undoStack = new Stack<CareTakerDatas>();
        Stack<CareTakerDatas> redoStack = new Stack<CareTakerDatas>();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            User user = LoginedUser.getInstance().UserGetSet;

            if(user.Usertypes == "*Admin")
            {
                btnAdmin.Enabled = true;
            }
            else
            {
                btnAdmin.Enabled = false;
            }

            button1.BackgroundImage = Util.Base64ToImage(user.Photo);
         
            GlobalAlarmService.Start(); // Artık her formda hatırlatıcı aktif olacak
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            User currentUser = LoginedUser.getInstance().UserGetSet;
            int index = Login.userList.FindIndex(u => u.Username == currentUser.Username);

            if (!currentUser.IsValidForSave())
            {
                MessageBox.Show("Kullanıcı bilgileri eksik veya bozuk. Çıkış yapılamıyor.", "Uyarı");
                return;
            }

            if (index != -1)
            {
                Login.userList[index] = currentUser;
                Util.SaveCsv(Login.userList, Login.path);
            }

            this.Hide();
            this.Close();
            new Login().Show();

        }
 
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management management = new Management();
            if (management.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void BtnPhoneBook_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PhoneBook frm = new PhoneBook();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void btnNoteBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteBook frm = new NoteBook();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void BtnImagePath_Click(object sender, EventArgs e)
        {
            flag++;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            PicPhoto.ImageLocation = file.FileName;
        }


        private void btnCalculator_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryCalculator frm = new SalaryCalculator();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
        private void btnReminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reminder frm = new Reminder();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnNoteBook_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void btnNoteBook_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void BtnPhoneBook_MouseEnter(object sender, EventArgs e)
        {
            LblPhonebook.Visible = true;
        }

        private void BtnPhoneBook_MouseLeave(object sender, EventArgs e)
        {
            LblPhonebook.Visible = false;
        }

        private void btnCalculator_MouseEnter(object sender, EventArgs e)
        {
            LblSalary.Visible = true;
            lblCalculator.Visible = true;
        }

        private void btnCalculator_MouseLeave(object sender, EventArgs e)
        {
            LblSalary.Visible = false;
            lblCalculator.Visible = false;
        }

        private void btnRemainder_MouseEnter(object sender, EventArgs e)
        {
            lblRemainder.Visible = true;
        }

        private void btnRemainder_MouseLeave(object sender, EventArgs e)
        {
            lblRemainder.Visible = false;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            LblLogOut.Visible = true;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            LblLogOut.Visible = false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            LblManagement.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            LblManagement.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("F");
        }

        private void LblPhonebook_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInfo form = new UserInfo();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

    }
}
