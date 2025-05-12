using personel_organizer_ilk;
using Personal_Organizer_Application;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace personel_organizer_ilk
{
    public partial class UserInfo : Form
    {
        private int flag = 0;
        private bool isReturningToLogin = false;

        Stack<CareTakerDatas> undoStack = new Stack<CareTakerDatas>();
        Stack<CareTakerDatas> redoStack = new Stack<CareTakerDatas>();

        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            var user = LoginedUser.getInstance().UserGetSet;

            txtUserName.Text = user.Username;
            TxtUserType.Text = user.Usertypes;
            TxtName.Text = user.Name;
            TxtSurname.Text = user.Surname;
            MTxtPhoneNumber.Text = user.PhoneNumber;
            TxtSalary.Text = user.Salary;
            TxtAddress.Text = user.Address.Replace("#", ",");
            TxtEmail.Text = user.Email;
            PicPhoto.Image = Util.Base64ToImage(user.Photo);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            User user = LoginedUser.getInstance().UserGetSet;

            // Kullanıcı adı kontrolü
            int existing = Login.userList.FindIndex(u => u.Username == txtUserName.Text && u != user);
            if (existing != -1)
            {
                MessageBox.Show("Username already taken.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // GÜNCELLE
            user.Username = txtUserName.Text;
            if (!string.IsNullOrEmpty(TxtPassword.Text))
                user.AccoundPassword = Util.ComputeStringToSha256Hash(TxtPassword.Text);

            user.Name = TxtName.Text;
            user.Surname = TxtSurname.Text;
            user.Address = TxtAddress.Text.Replace(",", "#");

            if (!Util.isEmailValid(TxtEmail.Text))
            {
                MessageBox.Show("Email order incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MTxtPhoneNumber.Text.Length != 14)
            {
                MessageBox.Show("Phone number order incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.Email = TxtEmail.Text;
            user.PhoneNumber = MTxtPhoneNumber.Text;

            if (flag > 0 && !string.IsNullOrEmpty(PicPhoto.ImageLocation))
                user.Photo = Util.ImageToBase64(PicPhoto.ImageLocation);

            // Son kontrol ve kayıt
            if (!user.IsValidForSave())
            {
                MessageBox.Show("Eksik kullanıcı bilgisi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Listeyi güncelle ve kaydet
            int index = Login.userList.FindIndex(u => u.Username == user.Username);
            if (index != -1)
            {
                Login.userList[index] = user;
                Util.SaveCsv(Login.userList, Login.path);
            }

            MessageBox.Show("Update Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtPassword.Text = "";
        }

        private void BtnImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                PicPhoto.ImageLocation = file.FileName;
                flag++;
            }
        }

        private void undoRedoOperations(Stack<CareTakerDatas> mainStack, Stack<CareTakerDatas> backUpStack)
        {
            if (mainStack.Count > 0)
            {
                User tempUser = new User();
                CareTakerDatas taker = mainStack.Pop();
                CareTakerDatas oldTaker = new CareTakerDatas();

                tempUser.Undo(taker.Memento);

                txtUserName.Text = tempUser.Username;
                TxtPassword.Text = tempUser.AccoundPassword;
                TxtName.Text = tempUser.Name;
                TxtSurname.Text = tempUser.Surname;
                MTxtPhoneNumber.Text = tempUser.PhoneNumber;
                TxtAddress.Text = tempUser.Address.Replace("#", ",");
                TxtEmail.Text = tempUser.Email;
                PicPhoto.Image = Util.Base64ToImage(tempUser.Photo);

                oldTaker.Memento = tempUser.Save();
                backUpStack.Push(oldTaker);
            }
        }

        private void UserInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)26)
                undoRedoOperations(undoStack, redoStack);
            else if (e.KeyChar == (char)25)
                undoRedoOperations(redoStack, undoStack);
            else
            {
                User tempUser = new User(
                    txtUserName.Text,
                    TxtPassword.Text,
                    false,
                    TxtUserType.Text,
                    TxtName.Text,
                    TxtSurname.Text,
                    MTxtPhoneNumber.Text,
                    TxtAddress.Text,
                    TxtEmail.Text,
                    "", "");

                tempUser.Photo = flag > 0 ? Util.ImageToBase64(PicPhoto.ImageLocation) : LoginedUser.getInstance().UserGetSet.Photo;

                CareTakerDatas data = new CareTakerDatas();
                data.Memento = tempUser.Save();
                undoStack.Push(data);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
    }
}
