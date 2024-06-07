using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class User_IdentificationForm : Form
    {
        FormCreateChange fcc;
        private string NeHashSumm;
        public User_IdentificationForm(FormCreateChange fсс)
        {
            InitializeComponent();

            admin_user.Items.Add("user");
            admin_user.Items.Add("admin");
            admin_user.SelectedIndex = 0;
            password.Enabled = false;
            password.PasswordChar = '*';
            this.fcc = fсс;
            using (StreamReader NePorol = new StreamReader("C:\\Users\\Артём Морозов\\source\\repos\\Laba1\\Laba1\\NeParol.txt"))
            {
                NeHashSumm = NePorol.ReadLine();// Считываю из файла хэш-сумму
            }
            
        }
        

        private void OK_Click(object sender, EventArgs e) // Кнопка ОК
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Byte[] InBytes = md5.ComputeHash(Encoding.UTF8.GetBytes("admin" + password.Text));
            string InPassword = BitConverter.ToString(InBytes);
            if (NeHashSumm == InPassword)
            {

                fcc.flagRightPassword = true;
                Close();
            }
            else
            {
                Incorrect.Text = "Неверный пароль";
                Incorrect.ForeColor = Color.Red;
            }
        }
        private void OK_KeyDown(object sender, KeyEventArgs e) // При нажатии на enter выполняются теже действия, что и на кнопку OK
        {
            if (e.KeyCode == Keys.Enter)
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                Byte[] InPBytes = md5.ComputeHash(Encoding.UTF8.GetBytes("admin" + password.Text));
                string InPassword = BitConverter.ToString(InPBytes);
                if (NeHashSumm == InPassword)
                {

                    fcc.flagRightPassword = true;
                    Close();
                }
                else
                {
                    Incorrect.Text = "Неверный пароль";
                    Incorrect.ForeColor = Color.Red;
                }
            }
        }


        private void admin_user_SelectedIndexChanged(object sender, EventArgs e) // функция для включения поля Пароль и кнопки ОК
        {
            if (admin_user.SelectedIndex == 0)
            {
                password.Enabled = false;
                OK.Enabled = false;
            }
            else
            {
                password.Enabled = true;
                OK.Enabled = true;
            }
        }

        private void Password_Click(object sender, EventArgs e) // Убираю ошибку при клике на пароль
        {
            Incorrect.Text = "";
        }

        private void Admin_Click(object sender, EventArgs e) // Убираю ошибку при клике на логин
        {
            Incorrect.Text = "";
        }
        private void User_IdentificationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
