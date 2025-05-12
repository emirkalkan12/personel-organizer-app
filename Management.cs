using personel_organizer_ilk;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace personel_organizer_ilk
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.loginpage;
            List();
        }

        private void List()
        {
            Util.LoadCsv(Login.userList, Login.path);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Login.userList;

            for (int i = 0; i < Login.userList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            var user = Login.userList[rowIndex];

            TxtRegisterNo.Text = rowIndex.ToString();
            TxtUsername.Text = user.Username;
            TxtPassword.Text = user.AccoundPassword;
            TxtUsertypes.Text = user.Usertypes;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int accept = 0;
            for (int i = 0; i < Login.userList.Count; i++)
            {
                if (TxtUsername.Text == Login.userList[i].Username &&
                    (TxtPassword.Text) == Login.userList[i].AccoundPassword &&
                    Login.userList[i].Usertypes == TxtUsertypes.Text)
                {
                    MessageBox.Show("User already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsername.Text == "" || TxtPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                else if (TxtUsertypes.Text == "*Admin")
                {
                    MessageBox.Show("*Admin already exists! There can be only one in this system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accept++;
                    break;
                }
                if (TxtUsertypes.Text != "Admin" && TxtUsertypes.Text != "admin" && TxtUsertypes.Text != "user" && TxtUsertypes.Text != "part-time-user")
                {
                    MessageBox.Show("There is no such user type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    accept++;
                    break;
                }
            }
            if (accept == 0)
            {
                if (Login.userList[0].Usertypes == "*Admin")
                {
                    User user = Login.userList[int.Parse(TxtRegisterNo.Text)];
                    user.Username = TxtUsername.Text;
                    user.AccoundPassword = (TxtPassword.Text);
                    user.Usertypes = TxtUsertypes.Text;
                    Util.SaveCsv(Login.userList, Login.path);
                    MessageBox.Show("Updating...");
                    deleteText();
                }
                else
                {
                    MessageBox.Show("*Admin ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            var user = Login.userList[index];

            if (user.Usertypes == "*Admin")
            {
                MessageBox.Show("*Admin silinemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Login.userList.RemoveAt(index);
            Util.SaveCsv(Login.userList, Login.path);
            MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void BtnLists_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOut logOut = new LogOut();
            logOut.ShowDialog();
            this.Close();
        }
        private void deleteText()
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtUsertypes.Text = "";
            TxtRegisterNo.Text = "";
        }
        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kapatma uyarısı kaldırıldı. Sessizce kapanır.
        }
    }
}
