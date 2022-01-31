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
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
            if(TicketClass.login != "admin")
            {
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button14.Visible = false;
                panel7.Visible = false;
            }
        }
        const string ConnectionString = @"Data Source=DESKTOP-JHGGMRN;Initial Catalog=Booking;Integrated Security=True";
        string str = "SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
            "Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
            "FROM Route INNER JOIN Train ON Route.route_id = Train.route_id INNER JOIN Timetable " +
            "ON Train.departure_id = Timetable.departure_id";
        private void TimetableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet1.Ticket_selling". При необходимости она может быть перемещена или удалена.
            this.ticket_sellingTableAdapter.Fill(this.bookingDataSet1.Ticket_selling);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet2.Wagon". При необходимости она может быть перемещена или удалена.
            this.wagonTableAdapter.Fill(this.bookingDataSet2.Wagon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet2.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.bookingDataSet2.Train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.SelectTimetable(this.bookingDataSet1.DataTable1);
            //try
            //{
            //    SqlConnection sqlconn = new SqlConnection(ConnectionString);
            //    sqlconn.Open();
            //    SqlDataAdapter oda = new SqlDataAdapter(str, sqlconn);
            //    DataTable dt = new DataTable();
            //    oda.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    sqlconn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(@"Error: " + ex.Message);
            //}
            if(dataGridView1.Rows.Count == 0)
            {
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                str = $"SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
                    $"Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
                    $"FROM Route INNER JOIN Train ON Route.route_id = Train.route_id INNER JOIN Timetable " +
                    $"ON Train.departure_id = Timetable.departure_id " +
                    $"AND DATEDIFF(day, Timetable.date_and_time_of_departure, '{textBox2.Value}')=0";
                if (textBox1.Text != "" && checkBox1.Checked == true)
                    str = $"SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
                    $"Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
                    $" FROM Route " +
                    $"INNER JOIN Train ON Route.route_id = Train.route_id AND (Route.points_of_passage LIKE '%{textBox1.Text}%' " +
                    $"OR Route.point_of_arrival LIKE '%{textBox1.Text}%')" +
                    $"INNER JOIN Timetable ON Train.departure_id = Timetable.departure_id " +
                    $"AND DATEDIFF(day, Timetable.date_and_time_of_departure, '{textBox2.Value}')=0";

                if (textBox3.Text != "" && checkBox3.Checked == true)
                    str = $"SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
                    $"Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
                    $"FROM Route " +
                    $"INNER JOIN Train ON Route.route_id = Train.route_id AND Train.number_of_seats LIKE '%{textBox3.Text}%'" +
                    $"INNER JOIN Timetable ON Train.departure_id = Timetable.departure_id " +
                    $"AND DATEDIFF(day, Timetable.date_and_time_of_departure, '{textBox2.Value}')=0";
                if (textBox1.Text != "" && textBox3.Text != "" && checkBox1.Checked == true && checkBox3.Checked == true)
                    str = $"SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
                    $"Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
                    "FROM Route " +
                    $"INNER JOIN Train ON Route.route_id = Train.route_id AND (Route.points_of_passage LIKE '%{textBox1.Text}%' " +
                    $"OR Route.point_of_arrival LIKE '%{textBox1.Text}%') AND Train.number_of_seats LIKE '%{textBox3.Text}%'" +
                    $"INNER JOIN Timetable ON Train.departure_id = Timetable.departure_id " +
                    $"AND DATEDIFF(day, Timetable.date_and_time_of_departure, '{textBox2.Value}')=0";
               }
            else
            {
                if (textBox1.Text != "" && checkBox1.Checked == true)
                    str = $"SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
                    $"Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
                    $" FROM Route " +
                    $"INNER JOIN Train ON Route.route_id = Train.route_id AND (Route.points_of_passage LIKE '%{textBox1.Text}%' " +
                    $"OR Route.point_of_arrival LIKE '%{textBox1.Text}%')" +
                    $"INNER JOIN Timetable ON Train.departure_id = Timetable.departure_id";

                if (textBox3.Text != "" && checkBox3.Checked == true)
                    str = $"SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
                    $"Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
                    $"FROM Route " +
                    $"INNER JOIN Train ON Route.route_id = Train.route_id AND Train.number_of_seats LIKE '%{textBox3.Text}%'" +
                    $"INNER JOIN Timetable ON Train.departure_id = Timetable.departure_id";
                if (textBox1.Text != "" && textBox3.Text != "" && checkBox1.Checked == true && checkBox3.Checked == true)
                    str = $"SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
                    $"Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
                    "FROM Route " +
                    $"INNER JOIN Train ON Route.route_id = Train.route_id AND (Route.points_of_passage LIKE '%{textBox1.Text}%' " +
                    $"OR Route.point_of_arrival LIKE '%{textBox1.Text}%') AND Train.number_of_seats LIKE '%{textBox3.Text}%'" +
                    $"INNER JOIN Timetable ON Train.departure_id = Timetable.departure_id";
            }
            SQLSelect(str);
        }

        void SQLSelect(string str)
        {
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
        private void button2_Click(object sender, EventArgs e)
        {
            str = "SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
            "Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
            "FROM Route INNER JOIN Train ON Route.route_id = Train.route_id INNER JOIN Timetable " +
            "ON Train.departure_id = Timetable.departure_id";
            SQLSelect(str);
        }

        static string first = "";
        static string second = "";
        static string third = "";
        static bool first1;
        static bool second1;
        static bool third1;
        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = str;
            if (first != "" || second != "" || third != "")
            {
                str1 += " ORDER BY";
                BoolVal();
                if (first != "")
                {
                    str1 += first;
                    if (first1)
                        str1 += " DESC";
                }
                if(second != "")
                {
                    if (first != "")
                        str1 += ",";
                    str1 += second;
                    if (second1)
                        str1 += " DESC";
                }
                if(third != "")
                {
                    if (first != "" || second != "")
                        str1 += ",";
                    str1 += second;
                    if (third1)
                        str1 += " DESC";
                }
            }
            SQLSelect(str1);

        }

        void BoolVal()
        {
            if (first == " point_of_arrival")
                first1 = radioButton2.Checked;
            if (second == " point_of_arrival")
                second1 = radioButton2.Checked;
            if(third == " point_of_arrival")
                third1 = radioButton2.Checked;

            if (first == " date_and_time_of_departure")
                first1 = radioButton4.Checked;
            if (second == " date_and_time_of_departure")
                second1 = radioButton4.Checked;
            if (third == " date_and_time_of_departure")
                third1 = radioButton4.Checked;

            if (first == " number_of_seats")
                first1 = radioButton6.Checked;
            if (second == " number_of_seats")
                second1 = radioButton6.Checked;
            if (third == " number_of_seats")
                third1 = radioButton6.Checked;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            string a = " point_of_arrival";
            if (checkBox6.Checked)
            {
                if (first == "")
                    first = a;
                else if (second == "")
                    second = a;
                else if (first == "")
                    third = a;
            }
            else
            {
                if (first == a)
                {
                    first = second;
                    second = third;
                    third = "";
                }
                else if (second == a)
                {
                    second = third;
                    third = "";
                }
                else if (third == a)
                    third = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            string a = " date_and_time_of_departure";
            if (checkBox5.Checked)
            {
                if (first == "")
                    first = a;
                else if (second == "")
                    second = a;
                else if(second == "")
                    third = a;
            }
            else
            {
                if (first == a)
                {
                    first = second;
                    second = third;
                    third = "";
                }
                else if (second == a)
                {
                    second = third;
                    third = "";
                }
                else if (third == a)
                    third = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string a = " number_of_seats";
            if (checkBox4.Checked)
            {
                if (first == "")
                    first = a;
                else if (second == "")
                    second = a;
                else if(third == "")
                    third = a;
            }
            else
            {
                if (first == a)
                {
                    first = second;
                    second = third;
                    third = "";
                }
                else if (second == a)
                {
                    second = third;
                    third = "";
                }
                else if (third == a)
                    third = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Rows[i].Selected = false;
                for (int j = 5; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            break;
                        }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = "SELECT Timetable.departure_id, Train.train_id, Train.number_of_wagons, Train.number_of_seats, " +
            "Timetable.date_and_time_of_departure, Route.point_of_departure, Route.points_of_passage, Route.point_of_arrival " +
            "FROM Route INNER JOIN Train ON Route.route_id = Train.route_id INNER JOIN Timetable " +
            "ON Train.departure_id = Timetable.departure_id";
            SQLSelect(str);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new RedactorForm();
            form.ShowDialog();
            this.dataTable1TableAdapter.SelectTimetable(this.bookingDataSet1.DataTable1);
            bookingDataSet.AcceptChanges();
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int row1 = dataGridView1.CurrentCellAddress.Y;
            //int train_id = Convert.ToInt32(dataGridView1.Rows[row1].Cells[1].Value);
            //int departure_id = Convert.ToInt32(dataGridView1.Rows[row1].Cells[0].Value);
            //dataTable1TableAdapter.FillBy(st, train_id, departure_id);

            //object[] row = st.Rows[row1].ItemArray;
            string[] row = new string[dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                row[i] = dataGridView1.Rows[row1].Cells[i].Value.ToString();
            }
            Form form = new RedactorForm(Convert.ToInt32(row[0]), Convert.ToInt32(row[1]), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToDateTime(row[2]), row[5], row[6], row[7]);
            form.ShowDialog();
            this.dataTable1TableAdapter.SelectTimetable(this.bookingDataSet1.DataTable1);
            bookingDataSet.AcceptChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string caption = "Удаление строки";
            string message = "Вы уверены, зотите удалить эту строку?";

            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            int row1 = dataGridView1.CurrentCellAddress.Y;
            string row = dataGridView1.Rows[row1].Cells[1].Value.ToString();
            ticket_sellingTableAdapter.UpdateQuery(null, "Неактивен", Convert.ToInt32(row));
            for (int i = 0; i < Convert.ToInt32(row[3]); i++)
            {
                wagonTableAdapter.DeleteQuery(Convert.ToInt32(row));
            }
            trainTableAdapter.DeleteQuery1(Convert.ToInt32(row));
            
            this.dataTable1TableAdapter.SelectTimetable(this.bookingDataSet1.DataTable1);
            bookingDataSet.AcceptChanges();
            if (dataGridView1.Rows.Count == 0)
            {
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form = new RequestForm();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            int row1 = dataGridView1.CurrentCellAddress.Y;
            int row = Convert.ToInt32(dataGridView1.Rows[row1].Cells[1].Value);
            TicketClass.train_id = row;

            int st = Convert.ToInt32(trainTableAdapter.FillById(TicketClass.train_id));
            TicketClass.route_id = st;

            Form form = new TicketForm();
            form.Show();
        }

        private void TimetableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form form = new TicketViewForm();
            form.Show();
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }
    }
}
