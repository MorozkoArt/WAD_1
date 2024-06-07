using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class FormCreateChange : Form
    {

        string StartCardName = "";
        Person new_person = new Person();
        Boolean IsChange = false;
        List<string> CardName_Indiv = new List<string>();
        //Random rnd = new Random();
        public FormCreateChange(InterfacePerson person, List<string> CardName_Indiv)
        {
            InitializeComponent();
            this.CardName_Indiv = CardName_Indiv;
            Birthday1.MaxDate = DateTime.Today;
            Birthday1.Value = DateTime.Today;
            if (person != null) //Заполнение полей, если была нажата кнопка изменения записи
            {
                label4.Text = "Изменение записи";
                Name1.Text = person.Name;
                Birthday1.Value = person.Birthday;
                CardName1.Text = person.CardName;
                StartCardName = person.CardName;
                Birthday1.Enabled = false;
                CardName1.Enabled = false;
                new_person = (Person)person;
                IsChange = true;
            }
        }

        public InterfacePerson GetPerson() // Передаёт значение new_person в начальную форму
        {
            return new_person;
        }

        private void CardName1_KeyPress(object sender, KeyPressEventArgs e) // Пользователь может вводить только цифры и Backspase в textbox номера карты
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void CardName1_TextChanged(object sender, EventArgs e) // Функция для отображения корректности ввода номера карты
        {
            if (Regex.IsMatch(CardName1.Text, "[0-9]{5}") == false)
            {
                CardName1.ForeColor = Color.Red;
            }
            else CardName1.ForeColor = Color.Green;
            NoCardName.Text = "";
        }
        Boolean Chek(List<string> chek_individ) // проверка на индивидуальность номера карты
        {
            int k = 0;
            if (IsChange == false)
            {
                for (int i = 0; i < chek_individ.Count; i++)
                {
                    if (CardName1.Text != chek_individ[i])
                    {
                        k += 0;
                    }
                    else
                    {
                        k += 1;
                    }
                }
                if (k == 0) return true;
                else return false;
            }
            else return true;
        }
        private void Accept_Click(object sender, EventArgs e) // Кнопка принять
        {
            NoName.Text = "";
            NoCardName.Text = "";
            if ((string.IsNullOrEmpty(Name1.Text) == false) && (string.IsNullOrEmpty(CardName1.Text) == false) && (Regex.IsMatch(CardName1.Text, "[0-9]{5}"))&& (Chek(CardName_Indiv) ==true))
            {
                new_person.Name = Name1.Text;
                new_person.Birthday = Birthday1.Value;                                
                new_person.CardName = CardName1.Text;
                if (IsChange == false)
                {
                    CardName_Indiv.Add(CardName1.Text);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (string.IsNullOrEmpty(Name1.Text) == true)
                {
                    NoName.Text = "Не введено имя";
                    NoName.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(CardName1.Text) == true)
                {
                    NoCardName.Text = "Не введен номер карты";
                    NoCardName.ForeColor = Color.Red;
                }
                else if (Regex.IsMatch(CardName1.Text, "[0-9]{5}") == false)
                {
                    NoCardName.Text = "Номер карты должен содержать 5 цифр";
                    NoCardName.ForeColor = Color.Red;
                }
                else if ((Chek(CardName_Indiv)== false))
                {
                    NoCardName.Text = "Такой номер карты уже существует";
                    NoCardName.ForeColor = Color.Red;
                }
            }
        }

        private void Name_Click(object sender, EventArgs e) // Убираю текст ошибок при нажатии на поля
        {
            NoName.Text = "";
        }

        private void CardName1_Click(object sender, EventArgs e) //
        {
            NoCardName.Text = "";
        }

        private void Cancellation_Click(object sender, EventArgs e) // Кнопка отменить
        {
            this.Close();
        }

        private void FormCreateChange_KeyDown(object sender, KeyEventArgs e) // При нажатии клавиш открывается немодальное окно User_Identification
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.L && IsChange==true)
            {
                User_IdentificationForm fLogin = new User_IdentificationForm(this);
                fLogin.Show();
            }
            if (e.KeyCode == Keys.Enter) // При нажатии кнопки enter выполняются теже действия, что и при нажатии на кнопку принять
            {
                NoName.Text = "";
                NoCardName.Text = "";
                if ((string.IsNullOrEmpty(Name1.Text) == false) && (string.IsNullOrEmpty(CardName1.Text) == false) && (Regex.IsMatch(CardName1.Text, "[0-9]{5}")) && (Chek(CardName_Indiv) == true))
                {
                    new_person.Name = Name1.Text;
                    new_person.Birthday = Birthday1.Value;
                    new_person.CardName = CardName1.Text;
                    if (IsChange == false)
                    {
                        CardName_Indiv.Add(CardName1.Text);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (string.IsNullOrEmpty(Name1.Text) == true)
                    {
                        NoName.Text = "Не введено имя";
                        NoName.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrEmpty(CardName1.Text) == true)
                    {
                        NoCardName.Text = "Не введен номер карты";
                        NoCardName.ForeColor = Color.Red;
                    }
                    else if (Regex.IsMatch(CardName1.Text, "[0-9]{5}") == false)
                    {
                        NoCardName.Text = "Номер карты должен содержать 5 цифр";
                        NoCardName.ForeColor = Color.Red;
                    }
                    else if ((Chek(CardName_Indiv) == false))
                    {
                        NoCardName.Text = "Такой номер карты уже существует";
                        NoCardName.ForeColor = Color.Red;
                    }
                }
            }
        }

        public Boolean flagRightPassword = false;
        private void FormCreateChange_Activated(object sender, EventArgs e)// при входе в режим админ меняем интерфейс формы
        {
            if (flagRightPassword)
            {

                CardName1.Enabled = true; // и открывает поля: номер карты и дата рождения
                Birthday1.Enabled = true;
                this.BackColor = Color.Gold;
                Name1.BackColor = Color.Goldenrod;
                CardName1.BackColor = Color.Goldenrod;
                cancellation.BackColor = Color.Red;
                Accept.BackColor = Color.GreenYellow;
                label4.Text = "Изменение записи - режим 'ADMIN'";
            }
        }
        private void Accept_MouseMove(object sender, MouseEventArgs e) // Движение кнопки от курсора мыши
        {
            /* 
               |1   |   3| так я разделил кнопку на четыре части
               |---------|
               |2   |   4|
            */  
            
            if ((this.BackColor != Color.Gold) || (CardName1.Text == StartCardName)) return; 

            int cY = Cursor.Position.Y - this.Top - 30; // получаю положение мыши относительно элемента управлени
            int cX = Cursor.Position.X - this.Left - 4;

            if ((cX <= Accept.Location.X + Accept.Size.Width / 2) && (cY <= Accept.Location.Y + Accept.Size.Height / 2)) // Если курсор мыши касается 1
            {
                if ((Accept.Location.X == this.Size.Width - Accept.Size.Width - 17) && (Accept.Location.Y == this.Size.Height - Accept.Size.Height - 42))
                    Accept.Location = new Point(0, 0); // переносит из правого нижнего - в левыйй верхний
                else if (Accept.Location.X == this.Size.Width - Accept.Size.Width - 17)
                    Accept.Location = new Point(Accept.Location.X, Accept.Location.Y + 1);
                else if (Accept.Location.Y == this.Size.Height - Accept.Size.Height - 42)
                    Accept.Location = new Point(Accept.Location.X + 1, Accept.Location.Y);
                else Accept.Location = new Point(Accept.Location.X + 1, Accept.Location.Y + 1);
            }
            else if ((cX <= Accept.Location.X + Accept.Size.Width / 2) && (cY > Accept.Location.Y + Accept.Size.Height / 2)) // Если курсор мыши касается 2
            {
                if ((Accept.Location.X == this.Size.Width - Accept.Size.Width - 17) && (Accept.Location.Y == 0))
                    Accept.Location = new Point(0, this.Size.Height - Accept.Size.Height - 42); // переносит из правого верхнего в левый нижний
                else if (Accept.Location.X == this.Size.Width - Accept.Size.Width - 17)
                    Accept.Location = new Point(Accept.Location.X, Accept.Location.Y - 1);
                else if (Accept.Location.Y == 0)
                    Accept.Location = new Point(Accept.Location.X + 1, 0);
                else Accept.Location = new Point(Accept.Location.X + 1, Accept.Location.Y - 1);
            }
            else if ((cX > Accept.Location.X + Accept.Size.Width / 2) && (cY <= Accept.Location.Y + Accept.Size.Height / 2)) // Если курсор мыши касается 3
            {
                if ((Accept.Location.X == 0) && (Accept.Location.Y == this.Size.Height - Accept.Size.Height - 42))
                    Accept.Location = new Point(this.Size.Width - Accept.Size.Width - 17, 0); // переносит из левого нижнего в правый верхний
                else if (Accept.Location.X == 0)
                    Accept.Location = new Point(0, Accept.Location.Y + 1);
                else if (Accept.Location.Y == this.Size.Height - Accept.Size.Height - 42)
                    Accept.Location = new Point(Accept.Location.X - 1, Accept.Location.Y);
                else Accept.Location = new Point(Accept.Location.X - 1, Accept.Location.Y + 1);
            }
            else if ((cX > Accept.Location.X + Accept.Size.Width / 2) && (cY > Accept.Location.Y + Accept.Size.Height / 2)) // Если курсор мыши касается 4
            {
                if ((Accept.Location.X == 0) && (Accept.Location.Y == 0)) // переносит из левого верхнего в правый нижний
                    Accept.Location = new Point(this.Size.Width - Accept.Size.Width - 17, this.Size.Height - Accept.Size.Height - 42);
                else if (Accept.Location.X == 0)
                    Accept.Location = new Point(0, Accept.Location.Y - 1);
                else if (Accept.Location.Y == 0)
                    Accept.Location = new Point(Accept.Location.X - 1, 0);
                else Accept.Location = new Point(Accept.Location.X - 1, Accept.Location.Y - 1);
            }
            

        }

        private void FormCreateChange_Load(object sender, EventArgs e)
        {

        }
    }
}
