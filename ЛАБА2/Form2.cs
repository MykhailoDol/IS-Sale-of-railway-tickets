using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА2
{
    public partial class Form2 : Form
    {
        int Train_id;
        static bool a = true;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int train_id, int number_of_wagons, 
            int number_of_seats, int route_id, int departure_id)
        {
            InitializeComponent();
            a = false;
            Train_id = train_id;
            textBox1.Text = train_id.ToString();
            textBox2.Text = number_of_seats.ToString();
            textBox3.Text = number_of_wagons.ToString();
            textBox4.Text = route_id.ToString();
            textBox5.Text = departure_id.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (a)
            //    trainTableAdapter.Insert(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text),
            //    Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
            //else
            //    trainTableAdapter.Update1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),
            //        Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.bookingDataSet.Train);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
