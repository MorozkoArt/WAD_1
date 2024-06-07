using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Initial_form : Form
    {
        public Initial_form()
        {
            InitializeComponent();
            Sort_label.ForeColor = Color.Red;
            Sort_label.Text = "Выкл";                                  
        }
        public List<InterfacePerson> Users = new List<InterfacePerson>();
        List<string> CardName_Indiv = new List<string>();
        public Boolean CD = false;
        public void UpdateListBox(List<InterfacePerson> Users) //Функция для обновления списка клиентов
        {            
            listBox.Items.Clear();
            for (int i = 0; i < Users.Count; i++)
            {
                listBox.Items.Add(Users[i].Name + " - " + Users[i].calcAge(DateTime.Now) + " Лет/года".ToString());
            }                  
        }
        public Boolean chek = false;
        private void Create_Click(object sender, EventArgs e) // первая кнопка - создание новой записи
        {///todo если созданно 4 пользователь и щёлкнули 1-го потом 3-го потом 2-го, то удалить загорается красным
            FormCreateChange Fcreate = new FormCreateChange(null, CardName_Indiv);
            if (Fcreate.ShowDialog() == DialogResult.OK)
            {
                this.Users.Add(Fcreate.GetPerson());
                this.users_sort.Add(Fcreate.GetPerson());
                Sortii = false;
                Sort_label.ForeColor = Color.Red;
                Sort_label.Text = "Выкл";
            }
            UpdateListBox(Users);            
        }
        ///todo создать кнопку которая будет производить сортировку пользователей(через лямбду функций) по любому критерию и создать вторую кнопку, которая будет фильтровать пользователей
        private void Change_Click(object sender, EventArgs e) // вторая кнопка - изменение записи
        {
            if (listBox.SelectedIndex == -1)
            {
                nochoose.Text = "Выберите запись, которую хотите изменить.";
                nochoose.ForeColor = Color.Red;
            }
            else
            {
                FormCreateChange FChange = new FormCreateChange(Users[listBox.SelectedIndex], CardName_Indiv);
                FChange.ShowDialog();
                Sortii = false;
                CD = true;
                Sort_label.ForeColor = Color.Red;
                Sort_label.Text = "Выкл";
                UpdateListBox(Users);               
            }
        }
        
        private void Delete_Click(object sender, EventArgs e) // третья кнопка - удаление записи
        {
            if (listBox.SelectedIndex == -1)
            {
                nochoose1.Text = "Выберите запись, которую хотите удалить.";
                nochoose1.ForeColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("Удалить запись " + Users[listBox.SelectedIndex].Name + " - " + Users[listBox.SelectedIndex].calcAge(DateTime.Now)+ " Лет/года?",
                                    "Удаление",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < CardName_Indiv.Count; i++)
                    {
                        if (CardName_Indiv[i] == Users[listBox.SelectedIndex].CardName)
                        {
                            CardName_Indiv.RemoveAt(i);
                        }
                    }
                    for (int i = 0; i < users_sort.Count; i++)
                    {
                        if (users_sort[i].CardName == Users[listBox.SelectedIndex].CardName)
                        {
                            users_sort.RemoveAt(i);
                        }
                    }
                    Users.RemoveAt(listBox.SelectedIndex);                              
                    UpdateListBox(Users);                   
                }
            }
        }

        int com=0;
        int s = 0;
        private void listbox_Click(object sender, EventArgs e) // Убирает ошибки при нажатии на пользователя в списке
        {
            int size = Users.Count;
            if (listBox.SelectedIndex != -1)
            {
                nochoose.Text = "";
                nochoose1.Text = "";
            }
            if (size == 4)// первый доп
            {
                com = com * 10 + listBox.SelectedIndex;
                s++;
                if ((com == 21)&& (s==3))
                {
                    Delete.BackColor = Color.Red;
                    s = 0;
                    com = 0;
                }
                else if (s == 3)
                {
                    Delete.BackColor = Color.White;
                    s = 0;
                    com = 0;
                }
                else if ((s == 2)&&(com!=2))
                {
                    Delete.BackColor = Color.White;
                    s = 0;
                    com = 0;
                }
                else if ((s == 1) && (com != 0))
                {
                    Delete.BackColor = Color.White;
                    s = 0;
                    com = 0;
                }
            }
        }
    
        public Boolean Sortii = false;
        public void copy_sort(List<InterfacePerson> users2, List<InterfacePerson> users)// функция копирования списка
        {
            for (int y1 = 0; y1 < users2.Count; y1++)
            {
                users.Add(users2[y1]);
            }
        }
        public List<InterfacePerson> users_sort = new List<InterfacePerson>(); // список с неотсортированными пользователями

        public void Sort_Click(object sender, EventArgs e)// сортировка (вкл/выкл)
        {
            if(Users.Count > 1)
            {
                if (Sortii == true)
                {
                    Users.Clear();
                    copy_sort(users_sort, Users);
                    Sortii = false;
                    UpdateListBox(Users);
                    Sort_label.ForeColor = Color.Red;
                    Sort_label.Text = "Выкл";
                }
                else
                {
                    Users.Sort((b1, b2) => string.Compare(b1.Name, b2.Name));
                    Sortii = true;
                    UpdateListBox(Users);
                    Sort_label.ForeColor = Color.Green;
                    Sort_label.Text = "Вкл";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//открытие окна фильтрация
        {
            if (checkBox1.Checked == true) 
            {
                Filtr fil = new Filtr(Users, users_sort, this, Sortii, CD);
                fil.Show();             
            }          
        }
        public void Sent(List<InterfacePerson> users3, List<InterfacePerson> users)
        {
            Users.Clear();
            copy_sort(users3, Users);
            users_sort.Clear();
            copy_sort(users, users_sort);
            UpdateListBox(users3);
        }
        private void initial_form_Load(object sender, EventArgs e)
        {

        }

        void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
