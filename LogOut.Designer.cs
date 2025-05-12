namespace personel_organizer_ilk
{
    partial class LogOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.BtnPhoneBook = new System.Windows.Forms.Button();
            this.btnNoteBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblManagement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPhonebook = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.LblLogOut = new System.Windows.Forms.Label();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.LblBackup = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.PicPhoto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(196, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 51);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.calculator;
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculator.Location = new System.Drawing.Point(19, 80);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(85, 85);
            this.btnCalculator.TabIndex = 6;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            this.btnCalculator.MouseEnter += new System.EventHandler(this.btnCalculator_MouseEnter);
            this.btnCalculator.MouseLeave += new System.EventHandler(this.btnCalculator_MouseLeave);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.admin;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmin.Enabled = false;
            this.btnAdmin.Location = new System.Drawing.Point(169, 80);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(85, 85);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            this.btnAdmin.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnAdmin.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // BtnPhoneBook
            // 
            this.BtnPhoneBook.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.rehber;
            this.BtnPhoneBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPhoneBook.Location = new System.Drawing.Point(169, 480);
            this.BtnPhoneBook.Name = "BtnPhoneBook";
            this.BtnPhoneBook.Size = new System.Drawing.Size(85, 85);
            this.BtnPhoneBook.TabIndex = 8;
            this.BtnPhoneBook.UseVisualStyleBackColor = true;
            this.BtnPhoneBook.Click += new System.EventHandler(this.BtnPhoneBook_Click_1);
            this.BtnPhoneBook.MouseEnter += new System.EventHandler(this.BtnPhoneBook_MouseEnter);
            this.BtnPhoneBook.MouseLeave += new System.EventHandler(this.BtnPhoneBook_MouseLeave);
            // 
            // btnNoteBook
            // 
            this.btnNoteBook.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.notebook;
            this.btnNoteBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoteBook.Location = new System.Drawing.Point(169, 280);
            this.btnNoteBook.Name = "btnNoteBook";
            this.btnNoteBook.Size = new System.Drawing.Size(85, 85);
            this.btnNoteBook.TabIndex = 9;
            this.btnNoteBook.UseVisualStyleBackColor = true;
            this.btnNoteBook.Click += new System.EventHandler(this.btnNoteBook_Click);
            this.btnNoteBook.MouseEnter += new System.EventHandler(this.btnNoteBook_MouseEnter);
            this.btnNoteBook.MouseLeave += new System.EventHandler(this.btnNoteBook_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.loginpage;
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.LblManagement);
            this.panel1.Controls.Add(this.btnNoteBook);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblPhonebook);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 65535);
            this.panel1.TabIndex = 10;
            // 
            // LblManagement
            // 
            this.LblManagement.AutoSize = true;
            this.LblManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblManagement.Location = new System.Drawing.Point(71, 104);
            this.LblManagement.Name = "LblManagement";
            this.LblManagement.Size = new System.Drawing.Size(56, 20);
            this.LblManagement.TabIndex = 17;
            this.LblManagement.Text = "Admin";
            this.LblManagement.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Notebook";
            this.label2.Visible = false;
            // 
            // LblPhonebook
            // 
            this.LblPhonebook.AutoSize = true;
            this.LblPhonebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPhonebook.Location = new System.Drawing.Point(36, 511);
            this.LblPhonebook.Name = "LblPhonebook";
            this.LblPhonebook.Size = new System.Drawing.Size(91, 20);
            this.LblPhonebook.TabIndex = 18;
            this.LblPhonebook.Text = "Phonebook";
            this.LblPhonebook.Visible = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(480, 80);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 16);
            this.lblPath.TabIndex = 20;
            this.lblPath.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.loginpage;
            this.panel2.Controls.Add(this.lblCalculator);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnRemainder);
            this.panel2.Controls.Add(this.LblLogOut);
            this.panel2.Controls.Add(this.lblRemainder);
            this.panel2.Controls.Add(this.LblSalary);
            this.panel2.Controls.Add(this.lblProfile);
            this.panel2.Controls.Add(this.btnCalculator);
            this.panel2.Location = new System.Drawing.Point(714, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 65535);
            this.panel2.TabIndex = 11;
            // 
            // lblCalculator
            // 
            this.lblCalculator.AutoSize = true;
            this.lblCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalculator.Location = new System.Drawing.Point(127, 128);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(85, 20);
            this.lblCalculator.TabIndex = 21;
            this.lblCalculator.Text = "Calculator";
            this.lblCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCalculator.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.power;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.Location = new System.Drawing.Point(19, 480);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 85);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // btnRemainder
            // 
            this.btnRemainder.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.bell;
            this.btnRemainder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemainder.Location = new System.Drawing.Point(19, 280);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(85, 85);
            this.btnRemainder.TabIndex = 13;
            this.btnRemainder.UseVisualStyleBackColor = true;
            this.btnRemainder.Click += new System.EventHandler(this.btnReminder_Click);
            this.btnRemainder.MouseEnter += new System.EventHandler(this.btnRemainder_MouseEnter);
            this.btnRemainder.MouseLeave += new System.EventHandler(this.btnRemainder_MouseLeave);
            // 
            // LblLogOut
            // 
            this.LblLogOut.AutoSize = true;
            this.LblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLogOut.Location = new System.Drawing.Point(141, 511);
            this.LblLogOut.Name = "LblLogOut";
            this.LblLogOut.Size = new System.Drawing.Size(60, 20);
            this.LblLogOut.TabIndex = 14;
            this.LblLogOut.Text = "Logout";
            this.LblLogOut.Visible = false;
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainder.Location = new System.Drawing.Point(141, 311);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(81, 20);
            this.lblRemainder.TabIndex = 15;
            this.lblRemainder.Text = "Reminder";
            this.lblRemainder.Visible = false;
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSalary.Location = new System.Drawing.Point(141, 104);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(56, 20);
            this.LblSalary.TabIndex = 20;
            this.LblSalary.Text = "Salary";
            this.LblSalary.Visible = false;
            // 
            // lblProfile
            // 
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProfile.Location = new System.Drawing.Point(63, 23);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(138, 25);
            this.lblProfile.TabIndex = 12;
            this.lblProfile.Text = "Your Profile";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYedekle
            // 
            this.btnYedekle.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.recovery;
            this.btnYedekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYedekle.Location = new System.Drawing.Point(343, 528);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(85, 85);
            this.btnYedekle.TabIndex = 14;
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Visible = false;
            // 
            // LblBackup
            // 
            this.LblBackup.AutoSize = true;
            this.LblBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBackup.Location = new System.Drawing.Point(446, 560);
            this.LblBackup.Name = "LblBackup";
            this.LblBackup.Size = new System.Drawing.Size(0, 25);
            this.LblBackup.TabIndex = 16;
            this.LblBackup.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(311, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 275);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.man_8702916_1280;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 178);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(92, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "Welcome, what are you planning today?";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(306, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 24;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicPhoto
            // 
            this.PicPhoto.BackgroundImage = global::personel_organizer_ilk.Properties.Resources.work;
            this.PicPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicPhoto.Location = new System.Drawing.Point(535, 545);
            this.PicPhoto.Name = "PicPhoto";
            this.PicPhoto.Size = new System.Drawing.Size(40, 40);
            this.PicPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPhoto.TabIndex = 25;
            this.PicPhoto.TabStop = false;
            this.PicPhoto.Visible = false;
            // 
            // LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 643);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.PicPhoto);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblBackup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnPhoneBook);
            this.Controls.Add(this.panel1);
            this.Name = "LogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogOut";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button BtnPhoneBook;
        private System.Windows.Forms.Button btnNoteBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Label lblRemainder;
        private System.Windows.Forms.Label LblBackup;
        private System.Windows.Forms.Label LblManagement;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label LblLogOut;
        private System.Windows.Forms.Label LblPhonebook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox PicPhoto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.Label lblPath;
    }
}