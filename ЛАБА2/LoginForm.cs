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
    public partial class LoginForm : Form
    {
        Form Form;
        public LoginForm(Form form)
        {
            Form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            var st = new BookingDataSet.UserDataTable();
            userTableAdapter1.ForLogin(st, login, password);
            int row = st.Rows.Count;
            if (row == 1)
            {
                TicketClass.login = login;
                Form form = new TimetableForm();
                form.Show();
                Form.Hide();
            }
            else
            {
                string message = "Логин или пароль введены неправильно";
                string caption = "";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
