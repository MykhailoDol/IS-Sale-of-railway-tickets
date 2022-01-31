using Microsoft.VisualBasic;
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
    public partial class RedactorForm : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-JHGGMRN;Initial Catalog=Booking;Integrated Security=True";
        static bool a = true;
        static int Departure_id;
        static int Train_id;
        DateTimePicker Date_and_time_of_departure;
        static int num_wag;

        public RedactorForm()
        {
            InitializeComponent();
        }
        public RedactorForm(int departure_id, int train_id, int number_of_wagons, int number_of_seats, DateTime date_and_time_of_departure, string point_of_departure, string points_of_passage, string point_of_arrival)
        {
            InitializeComponent();
            a = false;
            Departure_id = departure_id;
            Train_id = train_id;
            number_of_seatsTextBox.Text = number_of_seats.ToString();
            num_wag = number_of_wagons;
            number_of_wagonsTextBox.Text = number_of_wagons.ToString();
            date_and_time_of_departureDateTimePicker.Value = date_and_time_of_departure;
            point_of_departureTextBox.Text = point_of_departure;
            points_of_passageTextBox.Text = points_of_passage;
            point_of_arrivalTextBox.Text = point_of_arrival;
            Number_of_wagons(train_id);
        }

        public void Number_of_wagons(int num)
        {
            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }
            string str = $"SELECT wagon_number AS [Номер вагона], number_of_seats AS [Введиет количество мест] FROM dbo.Wagon WHERE train_id = {num}";
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
        private void RedactorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Timetable". При необходимости она может быть перемещена или удалена.
            this.timetableTableAdapter.Fill(this.bookingDataSet.Timetable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.bookingDataSet.Train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.bookingDataSet.Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Wagon". При необходимости она может быть перемещена или удалена.
            this.wagonTableAdapter.Fill(this.bookingDataSet.Wagon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.SelectTimetable(this.bookingDataSet.DataTable1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number_of_wagonsTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, выберите количество вагонов");
                return;
            }
            else if (point_of_departureTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите пункт отправления");
                return;
            }
            else if (points_of_passageTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите пункты проезда");
                return;
            }
            else if (point_of_arrivalTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите пункт назначения");
                return;
            }
            else
            {
                int o = -1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value == null || !Information.IsNumeric(dataGridView1.Rows[i].Cells[1].Value))
                    {
                        o = i;
                        break;
                    }
                }
                if (o != -1)
                {
                    MessageBox.Show($"Пожалуйста, введите корректное количество мест в вагоне №{o + 1}");
                    return;
                }
            }
            try
            {
                DateTime df = date_and_time_of_departureDateTimePicker.Value.Date + dateTimePicker1.Value.TimeOfDay;
                if (a)
                {
                    routeTableAdapter.InsertQuery(point_of_departureTextBox.Text, points_of_passageTextBox.Text, point_of_arrivalTextBox.Text);
                    var st = new BookingDataSet.RouteDataTable();
                    routeTableAdapter.FillBy(st, point_of_departureTextBox.Text, points_of_passageTextBox.Text, point_of_arrivalTextBox.Text);
                    int route_id = Convert.ToInt32(st.Rows[0].ItemArray[0]);

                    timetableTableAdapter.InsertQuery(df);
                    var st1 = new BookingDataSet.TimetableDataTable();
                    timetableTableAdapter.FillBy(st1, df);
                    int departure_id = Convert.ToInt32(st1.Rows[0].ItemArray[0]);

                    trainTableAdapter.InsertQuery(Convert.ToInt32(number_of_wagonsTextBox.Text), Convert.ToInt32(number_of_seatsTextBox.Text), route_id, departure_id);
                    var st2 = new BookingDataSet.TrainDataTable();
                    trainTableAdapter.FillBy(st2, Convert.ToInt32(number_of_wagonsTextBox.Text), Convert.ToInt32(number_of_seatsTextBox.Text), route_id, departure_id);
                    int train_id = Convert.ToInt32(st2.Rows[0].ItemArray[0]);


                    for (int i = 0; i < Convert.ToInt32(number_of_wagonsTextBox.Text); i++)
                    {
                        int a = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                        wagonTableAdapter.InsertQuery(i + 1, a, train_id);
                    }
                }
                else
                {
                    var st2 = new BookingDataSet.TrainDataTable();
                    int st = Convert.ToInt32(trainTableAdapter.FillById(Train_id));
                    int route_id = Convert.ToInt32(st);

                    routeTableAdapter.UpdateQuery(point_of_departureTextBox.Text, points_of_passageTextBox.Text, point_of_arrivalTextBox.Text, route_id);

                    var st4 = new BookingDataSet.TrainDataTable();
                    trainTableAdapter.FillBy1(st4, Departure_id);

                    if (st4.Rows.Count == 1)
                    {
                        timetableTableAdapter.UpdateQuery(df, Departure_id);
                    }
                    else
                        timetableTableAdapter.InsertQuery(df);

                    var st5 = new BookingDataSet.TimetableDataTable();
                    timetableTableAdapter.FillBy(st5, df);
                    Departure_id = Convert.ToInt32(st5.Rows[0].ItemArray[0].ToString());

                    trainTableAdapter.UpdateQuery(Convert.ToInt32(number_of_wagonsTextBox.Text), Convert.ToInt32(number_of_seatsTextBox.Text), route_id, Departure_id, Train_id);


                    for (int i = 0; i < Convert.ToInt32(number_of_wagonsTextBox.SelectedItem.ToString()); i++)
                    {
                        if (Convert.ToInt32(number_of_wagonsTextBox.SelectedItem.ToString()) == num_wag)
                            wagonTableAdapter.UpdateQuery(Convert.ToInt32(number_of_seatsTextBox.Text), i + 1, Train_id);
                        else if (Convert.ToInt32(number_of_wagonsTextBox.SelectedItem.ToString()) < num_wag)
                        {
                            if (Convert.ToInt32(number_of_wagonsTextBox.SelectedItem.ToString()) == i + 1)
                            {
                                for (int o = i + 1; o < num_wag; o++)
                                {
                                    wagonTableAdapter.DeleteQuery1(Train_id, o + 1);
                                }
                            }
                            else
                                wagonTableAdapter.UpdateQuery(Convert.ToInt32(number_of_seatsTextBox.Text), i + 1, Train_id);
                        }
                        else if (Convert.ToInt32(number_of_wagonsTextBox.SelectedItem.ToString()) > num_wag)
                        {
                            if (i >= num_wag)
                            {
                                int a = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                                wagonTableAdapter.InsertQuery(i + 1, a, Train_id);
                            }
                            else
                                wagonTableAdapter.UpdateQuery(Convert.ToInt32(number_of_seatsTextBox.Text), i + 1, Train_id);
                        }
                    }
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Извините, произошла непредвиденная ошибка");
            }
        }


        private void number_of_wagonsTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGrid();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    int a = 0;
                    if (number_of_wagonsTextBox.Text != "")
                        for (int i = 0; i < Convert.ToInt32(number_of_wagonsTextBox.Text); i++)
                        {
                            if (dataGridView1.Rows[i].Cells[1].Value != null)
                            {
                                a += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            }
                        }
                    number_of_seatsTextBox.Text = a.ToString();
                }
            }
            catch
            {

                MessageBox.Show($"Пожалуйста, введите корректное количество мест в вагоне №{e.RowIndex+1}");

            }
        }
        public void DataGrid()
        {
            string selectedState = number_of_wagonsTextBox.SelectedItem.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            for (int i = 0; i < Convert.ToInt32(selectedState); i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["Column1"].Value = i + 1;
            }
        }

        
    }
}