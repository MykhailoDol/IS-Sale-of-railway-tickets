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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
            
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Ticket_selling". При необходимости она может быть перемещена или удалена.
            this.ticket_sellingTableAdapter.Fill(this.bookingDataSet.Ticket_selling);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.bookingDataSet.Train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.bookingDataSet.Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Wagon". При необходимости она может быть перемещена или удалена.
            this.wagonTableAdapter.Fill(this.bookingDataSet.Wagon);
            LoadForm();
        }
        static string[] str;
        static string[] id;
        void LoadForm()
        {
            var st = new BookingDataSet.WagonDataTable();
            wagonTableAdapter.FillBy(st, TicketClass.train_id);
            str = new string[st.Rows.Count];
            id = new string[st.Rows.Count];

            for (int i = 0; i < st.Rows.Count; i++)
            {
                object[] item = st.Rows[i].ItemArray;
                number_of_wagonsTextBox.Items.Add(item[1].ToString());
                str[i] = item[2].ToString();
                id[i] = item[0].ToString();
            }

            var st1 = new BookingDataSet.RouteDataTable();
            routeTableAdapter.FillByRoute(st1, TicketClass.route_id);

            object[] item1 = st1.Rows[0].ItemArray;
            //comboBox2.Items.Add(item1[1].ToString());
            string[] strin = item1[2].ToString().Split('-');
            for (int i = 0; i < strin.Length; i++)
            {
                comboBox2.Items.Add(strin[i]);
            }
            comboBox2.Items.Add(item1[3].ToString());

        }

        private void number_of_wagonsTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            TicketClass.wagon_id = Convert.ToInt32(id[Convert.ToInt32(number_of_wagonsTextBox.Text)-1]);
            var st = new BookingDataSet.Ticket_sellingDataTable();
            ticket_sellingTableAdapter.FillBy(st, TicketClass.wagon_id);
            DataGridView dtg = new DataGridView();
            dtg.DataSource = st;
            int count = 0;

            for (int i = 0; i < st.Rows.Count; i++)
            {
                list.Add(st.Rows[i].ItemArray[1].ToString());
                count++;
            }
            label6.Text = $"Свободных мест в вагоне: {Convert.ToInt32(str[Convert.ToInt32(number_of_wagonsTextBox.Text)-1]) - count}";

            for (int i = 1; i < Convert.ToInt32(str[Convert.ToInt32(number_of_wagonsTextBox.Text)-1]); i++)
            {
                if (!list.Contains(i.ToString()))
                    comboBox1.Items.Add(i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Пожалуйста, выберите пункт направления");
                return;
            }
            else if (number_of_wagonsTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, выберите вагон");
                return;
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Пожалуйста, выберите место");
                return;
            }
            ticket_sellingTableAdapter.InsertQuery(Convert.ToInt32(comboBox1.Text), comboBox2.Text, TicketClass.wagon_id, TicketClass.login);
            MessageBox.Show("Билет успешно оформлен");
            this.Close();
        }

        
    }
}
