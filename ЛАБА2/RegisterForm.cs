using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Аккаунт успешно создан";

            if(loginTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите логин");
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите пароль");
                return;
            }
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите имя");
                return;
            }
            if (surnameTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите фамилию");
                return;
            }
            if (patronymicTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите отчество");
                return;
            }
            if (num_telephoneTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите номер телефона");
                return;
            }
            if (e_mailTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите e-mail");
                return;
            }
            string login = loginTextBox.Text;
            var st = new BookingDataSet.UserDataTable();
            userTableAdapter.SelectLogin(st, login);
            int row = st.Rows.Count;
            if (row == 0)
                userTableAdapter.Insert(loginTextBox.Text, passwordTextBox.Text, nameTextBox.Text,
                    surnameTextBox.Text, patronymicTextBox.Text, num_telephoneTextBox.Text,
                    e_mailTextBox.Text);
            else
                message = "Этот логин уже занят. Введите другой.";
            string caption = "";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
