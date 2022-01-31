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
    public partial class Form3 : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-JHGGMRN;Initial Catalog=Ticket;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = 0;
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "SELECT";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketDataSet.Wagon". При необходимости она может быть перемещена или удалена.
            this.wagonTableAdapter.Fill(this.ticketDataSet.Wagon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketDataSet.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.ticketDataSet.Train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.ticketDataSet.Ticket);
            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = 0;
        }
    }
}
