using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace ЛАБА2
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.bookingDataSet.DataTable3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.bookingDataSet.DataTable3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Timetable2". При необходимости она может быть перемещена или удалена.
            this.timetable2TableAdapter.Fill(this.bookingDataSet.Timetable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Route1". При необходимости она может быть перемещена или удалена.
            this.route1TableAdapter.Fill(this.bookingDataSet.Route1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.Timetable1". При необходимости она может быть перемещена или удалена.
            this.timetable1TableAdapter.Fill(this.bookingDataSet.Timetable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookingDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.bookingDataSet.DataTable2);

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
    }
}
