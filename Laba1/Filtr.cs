using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Filtr : Form
    {       
        List<InterfacePerson> users = new List<InterfacePerson>();
        List<InterfacePerson> users2 = new List<InterfacePerson>();
        List<InterfacePerson> users_sort2 = new List<InterfacePerson>();
        Initial_form Initial_form;
        Boolean chec = false;
        Boolean CD = false;
       
        public Filtr(List<InterfacePerson> users, List<InterfacePerson> users_sort2, Initial_form Initial_form, Boolean Sortii, Boolean CD)
        {
            InitializeComponent();
            this.Initial_form = Initial_form;
            copy(users ,this.users);// копирую исходный список
            copy(users_sort2, this.users_sort2);// копирую исходный список с неотсортированными пользователями
            Initial_form.checkBox1.Enabled = false;
            if (Sortii == true)
            {
                chec = true;
            }
            this.CD = CD;
            this.CD = false;
        }
        public void copy(List<InterfacePerson> users3, List<InterfacePerson> users) // функция копирования списков
        {
            for (int y1 = 0; y1 < users3.Count; y1++)
            {
                users.Add(users3[y1]);
            }
        }
        private void inTextForFiltr_TextChanged(object sender, EventArgs e) // при вводе текста в textbox
        {
            coorrrrect();
            users2.Clear();
            for (int i = 0; i < users.Count; i++)// фильтрация
            {
                if (users[i].Name.ToUpper().StartsWith(inTextForFiltr.Text.ToUpper())) {
                    users2.Add(users[i]);
                }
            }
            Initial_form.Sent(users2, Initial_form.Users);           
        }                                                   
        public void coorrrrect() // функция для проверки удаленных или созданных пользователей во время фильтрации
        {            
            for (int q  = 0; q < users2.Count; q++)// проверка на удаление
            {
                if (Initial_form.Users.Contains(users2[q]) == false)
                {
                    users.Remove(users2[q]);
                    users_sort2.Remove(users2[q]);                    
                }                                           
            }
            if (users2.Count != 0)
            {
                for (int q_2 = 0; q_2 < Initial_form.Users.Count; q_2++) // проверка на создание новых пользователей
                {
                    if(users2.Contains(Initial_form.Users[q_2]) == false)
                    {
                        users_sort2.Add(Initial_form.Users[q_2]);
                        users.Add(Initial_form.Users[q_2]);
                        CD = true;
                        Initial_form.Sortii = false;
                    }
                }
            }           
        }
        private void button1_Click(object sender, EventArgs e)// кнопка для закрытия формы
        {
            this.Close();
        }

        private void Filter_Closed(object sender, FormClosedEventArgs e)// функция, которая выполняется после закрытия формы
        {
            coorrrrect();
            Initial_form.checkBox1.Checked = false;
            Initial_form.checkBox1.Enabled = true;
            Initial_form.Sent(users, users_sort2);
            if (chec != Initial_form.Sortii)// возвращаю значение сортировки (вкл или выкл)
            {
                if ((chec == true) && (Initial_form.CD == true) || ((chec == false) && (Initial_form.CD == true)) || ((chec == false) && (Initial_form.CD == false)))
                {
                    Initial_form.Sort_label.ForeColor = Color.Red;
                    Initial_form.Sort_label.Text = "Выкл";
                    Initial_form.Sortii = false;
                }
                else if((chec == true) && (Initial_form.CD == false))
                {
                    Initial_form.Sort_label.ForeColor = Color.Green;
                    Initial_form.Sort_label.Text = "Вкл";
                    Initial_form.Sortii = true;
                }
            }     
            users2.Clear();
        }    
        private void Filtr_Load(object sender, EventArgs e)
        {
            
        }
    }    
}
