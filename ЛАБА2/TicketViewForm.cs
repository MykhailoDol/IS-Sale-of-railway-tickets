using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ЛАБА2
{
    public partial class TicketViewForm : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-JHGGMRN;Initial Catalog=Booking;Integrated Security=True";
        public TicketViewForm()
        {
            InitializeComponent();
            SQLSelect();
            if (dataGridView1.Rows.Count == 0)
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void TicketViewForm_Load(object sender, EventArgs e)
        {
            
        }

        void SQLSelect()
        {
            string str = $"SELECT ticket_id AS [Номер билета], place_number AS [Номер места], wagon_number AS [Номер вагона], " +
                $"Train.train_id AS [Номер поезда], date_and_time_of_departure AS [Дата и время отправления], " +
                $"destination AS [Пункт назначения] FROM Ticket_selling " +
                $"INNER JOIN Wagon ON Ticket_selling.wagon_id = Wagon.wagon_id " +
                $"INNER JOIN Train ON Wagon.train_id = Train.train_id " +
                $"INNER JOIN Timetable ON Train.departure_id = Timetable.departure_id AND login LIKE '%{TicketClass.login}%'";
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(str, sqlconn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new SaveForm(this);
            form.ShowDialog();
        }

        public void PrintTxt()
        {
            string a = @"C:\Users\dolgo\Documents\booking.txt";
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*",
                DefaultExt = "*.txt",
                FileName = "1",
                Title = "Укажите директорию и имя файла для сохранения"
            };
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            a = sfd.FileName;
            FileStream fs = new FileStream(a, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);

            try
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + "     ");
                    }

                    streamWriter.WriteLine();
                }

                streamWriter.Close();
                fs.Close();

                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }

        public void PrintExel()
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 0; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    if (i == 0)
                    {
                        worksheet.Rows[i + 1].Columns[j] = dataGridView1.Columns[j - 1].HeaderText;
                    }
                    else
                        worksheet.Rows[i + 1].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value.ToString();
                }
            }

            excelapp.AlertBeforeOverwriting = false;

            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "MS Excel dosuments (*.xlsx)|*.xlsx",
                DefaultExt = "*.xlsx",
                FileName = "1",
                Title = "Укажите директорию и имя файла для сохранения"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(sfd.FileName);
            }
            excelapp.Quit();
            MessageBox.Show("Файл успешно сохранен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string caption = "Удаление строки";
            string message = "Вы уверены, что хотите удалить этот билет?";

            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            int row1 = dataGridView1.CurrentCellAddress.Y;
            string row = dataGridView1.Rows[row1].Cells[0].Value.ToString();
            ticket_sellingTableAdapter.DeleteQuery(Convert.ToInt32(row));

            SQLSelect();
            bookingDataSet.AcceptChanges();
            if(dataGridView1.Rows.Count == 0)
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
