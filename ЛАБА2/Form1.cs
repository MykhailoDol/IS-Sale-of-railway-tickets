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
    public partial class Form1 : Form
    {
        static string Login;
        public Form1()
        {
            InitializeComponent();
            //Login = login;
        }
        const string ConnectionString = @"Data Source=DESKTOP-JHGGMRN;Initial Catalog=Booking;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.bookingDataSet.Train);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
            trainTableAdapter.Fill(bookingDataSet.Train);
            bookingDataSet.AcceptChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string caption = "Удаление строки";
            string message = "Вы уверены, зотите удалить эту строку?";

            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            int row = dataGridView1.CurrentCellAddress.Y;
            trainTableAdapter.DeleteQuery(
            Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value)
            );
            trainTableAdapter.Fill(bookingDataSet.Train);
            bookingDataSet.AcceptChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var st = new BookingDataSet.TrainDataTable();
            int row1 = dataGridView1.CurrentCellAddress.Y;
            int train_id = Convert.ToInt32(dataGridView1.Rows[row1].Cells[0].Value);
            //trainTableAdapter.FillBy(st, train_id);
            object[] row = st.Rows[0].ItemArray;
            Form form = new Form2(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]));
            form.ShowDialog();
            trainTableAdapter.Fill(bookingDataSet.Train);
            bookingDataSet.AcceptChanges();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
