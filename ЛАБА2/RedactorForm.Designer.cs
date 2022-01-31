
namespace ЛАБА2
{
    partial class RedactorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label date_and_time_of_departureLabel;
            System.Windows.Forms.Label point_of_departureLabel;
            System.Windows.Forms.Label number_of_wagonsLabel;
            System.Windows.Forms.Label number_of_seatsLabel;
            System.Windows.Forms.Label points_of_passageLabel;
            System.Windows.Forms.Label point_of_arrivalLabel;
            System.Windows.Forms.Label label1;
            this.date_and_time_of_departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.point_of_departureTextBox = new System.Windows.Forms.TextBox();
            this.number_of_seatsTextBox = new System.Windows.Forms.TextBox();
            this.points_of_passageTextBox = new System.Windows.Forms.TextBox();
            this.point_of_arrivalTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_wagonsTextBox = new System.Windows.Forms.ComboBox();
            this.bookingDataSet = new ЛАБА2.BookingDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new ЛАБА2.BookingDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new ЛАБА2.BookingDataSetTableAdapters.TableAdapterManager();
            this.bookingDataSet1 = new ЛАБА2.BookingDataSet();
            this.wagonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wagonTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.WagonTableAdapter();
            this.routeTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.RouteTableAdapter();
            this.trainTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.TrainTableAdapter();
            this.timetableTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.TimetableTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            date_and_time_of_departureLabel = new System.Windows.Forms.Label();
            point_of_departureLabel = new System.Windows.Forms.Label();
            number_of_wagonsLabel = new System.Windows.Forms.Label();
            number_of_seatsLabel = new System.Windows.Forms.Label();
            points_of_passageLabel = new System.Windows.Forms.Label();
            point_of_arrivalLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_and_time_of_departureLabel
            // 
            date_and_time_of_departureLabel.AutoSize = true;
            date_and_time_of_departureLabel.Location = new System.Drawing.Point(64, 29);
            date_and_time_of_departureLabel.Name = "date_and_time_of_departureLabel";
            date_and_time_of_departureLabel.Size = new System.Drawing.Size(104, 13);
            date_and_time_of_departureLabel.TabIndex = 5;
            date_and_time_of_departureLabel.Text = "Дата отправления:";
            // 
            // point_of_departureLabel
            // 
            point_of_departureLabel.AutoSize = true;
            point_of_departureLabel.Location = new System.Drawing.Point(64, 134);
            point_of_departureLabel.Name = "point_of_departureLabel";
            point_of_departureLabel.Size = new System.Drawing.Size(108, 13);
            point_of_departureLabel.TabIndex = 7;
            point_of_departureLabel.Text = "Пункт отправления:";
            // 
            // number_of_wagonsLabel
            // 
            number_of_wagonsLabel.AutoSize = true;
            number_of_wagonsLabel.Location = new System.Drawing.Point(64, 84);
            number_of_wagonsLabel.Name = "number_of_wagonsLabel";
            number_of_wagonsLabel.Size = new System.Drawing.Size(113, 13);
            number_of_wagonsLabel.TabIndex = 9;
            number_of_wagonsLabel.Text = "Количество вагонов:";
            // 
            // number_of_seatsLabel
            // 
            number_of_seatsLabel.AutoSize = true;
            number_of_seatsLabel.Location = new System.Drawing.Point(64, 110);
            number_of_seatsLabel.Name = "number_of_seatsLabel";
            number_of_seatsLabel.Size = new System.Drawing.Size(97, 13);
            number_of_seatsLabel.TabIndex = 11;
            number_of_seatsLabel.Text = "Количество мест:";
            // 
            // points_of_passageLabel
            // 
            points_of_passageLabel.AutoSize = true;
            points_of_passageLabel.Location = new System.Drawing.Point(64, 160);
            points_of_passageLabel.Name = "points_of_passageLabel";
            points_of_passageLabel.Size = new System.Drawing.Size(93, 13);
            points_of_passageLabel.TabIndex = 13;
            points_of_passageLabel.Text = "Пункты проезда:";
            // 
            // point_of_arrivalLabel
            // 
            point_of_arrivalLabel.AutoSize = true;
            point_of_arrivalLabel.Location = new System.Drawing.Point(64, 186);
            point_of_arrivalLabel.Name = "point_of_arrivalLabel";
            point_of_arrivalLabel.Size = new System.Drawing.Size(91, 13);
            point_of_arrivalLabel.TabIndex = 15;
            point_of_arrivalLabel.Text = "Конечный пункт:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(64, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 13);
            label1.TabIndex = 21;
            label1.Text = "Время отправления:";
            // 
            // date_and_time_of_departureDateTimePicker
            // 
            this.date_and_time_of_departureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_and_time_of_departureDateTimePicker.Location = new System.Drawing.Point(204, 29);
            this.date_and_time_of_departureDateTimePicker.Name = "date_and_time_of_departureDateTimePicker";
            this.date_and_time_of_departureDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_and_time_of_departureDateTimePicker.TabIndex = 6;
            // 
            // point_of_departureTextBox
            // 
            this.point_of_departureTextBox.Location = new System.Drawing.Point(204, 131);
            this.point_of_departureTextBox.Name = "point_of_departureTextBox";
            this.point_of_departureTextBox.Size = new System.Drawing.Size(200, 20);
            this.point_of_departureTextBox.TabIndex = 8;
            // 
            // number_of_seatsTextBox
            // 
            this.number_of_seatsTextBox.Location = new System.Drawing.Point(204, 107);
            this.number_of_seatsTextBox.Name = "number_of_seatsTextBox";
            this.number_of_seatsTextBox.ReadOnly = true;
            this.number_of_seatsTextBox.Size = new System.Drawing.Size(200, 20);
            this.number_of_seatsTextBox.TabIndex = 12;
            // 
            // points_of_passageTextBox
            // 
            this.points_of_passageTextBox.Location = new System.Drawing.Point(204, 157);
            this.points_of_passageTextBox.Name = "points_of_passageTextBox";
            this.points_of_passageTextBox.Size = new System.Drawing.Size(200, 20);
            this.points_of_passageTextBox.TabIndex = 14;
            // 
            // point_of_arrivalTextBox
            // 
            this.point_of_arrivalTextBox.Location = new System.Drawing.Point(204, 183);
            this.point_of_arrivalTextBox.Name = "point_of_arrivalTextBox";
            this.point_of_arrivalTextBox.Size = new System.Drawing.Size(200, 20);
            this.point_of_arrivalTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(508, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 195);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер вагона";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Введите количество мест";
            this.Column2.Name = "Column2";
            // 
            // number_of_wagonsTextBox
            // 
            this.number_of_wagonsTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.number_of_wagonsTextBox.FormattingEnabled = true;
            this.number_of_wagonsTextBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.number_of_wagonsTextBox.Location = new System.Drawing.Point(204, 80);
            this.number_of_wagonsTextBox.Name = "number_of_wagonsTextBox";
            this.number_of_wagonsTextBox.Size = new System.Drawing.Size(200, 21);
            this.number_of_wagonsTextBox.TabIndex = 20;
            this.number_of_wagonsTextBox.SelectedIndexChanged += new System.EventHandler(this.number_of_wagonsTextBox_SelectedIndexChanged);
            // 
            // bookingDataSet
            // 
            this.bookingDataSet.DataSetName = "BookingDataSet";
            this.bookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "Timetable";
            this.dataTable1BindingSource.DataSource = this.bookingDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PriceTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.Ticket_sellingTableAdapter = null;
            this.tableAdapterManager.TimetableTableAdapter = null;
            this.tableAdapterManager.TrainTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ЛАБА2.BookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.WagonTableAdapter = null;
            // 
            // bookingDataSet1
            // 
            this.bookingDataSet1.DataSetName = "BookingDataSet";
            this.bookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wagonBindingSource
            // 
            this.wagonBindingSource.DataMember = "Wagon";
            this.wagonBindingSource.DataSource = this.bookingDataSet1;
            // 
            // wagonTableAdapter
            // 
            this.wagonTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // timetableTableAdapter
            // 
            this.timetableTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 9, 16, 40, 0, 0);
            // 
            // RedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 360);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.number_of_wagonsTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(date_and_time_of_departureLabel);
            this.Controls.Add(this.date_and_time_of_departureDateTimePicker);
            this.Controls.Add(point_of_departureLabel);
            this.Controls.Add(this.point_of_departureTextBox);
            this.Controls.Add(number_of_wagonsLabel);
            this.Controls.Add(number_of_seatsLabel);
            this.Controls.Add(this.number_of_seatsTextBox);
            this.Controls.Add(points_of_passageLabel);
            this.Controls.Add(this.points_of_passageTextBox);
            this.Controls.Add(point_of_arrivalLabel);
            this.Controls.Add(this.point_of_arrivalTextBox);
            this.Name = "RedactorForm";
            this.Text = "RedactorForm";
            this.Load += new System.EventHandler(this.RedactorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookingDataSet bookingDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private BookingDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private BookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker date_and_time_of_departureDateTimePicker;
        private System.Windows.Forms.TextBox point_of_departureTextBox;
        private System.Windows.Forms.TextBox number_of_seatsTextBox;
        private System.Windows.Forms.TextBox points_of_passageTextBox;
        private System.Windows.Forms.TextBox point_of_arrivalTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookingDataSet bookingDataSet1;
        private System.Windows.Forms.BindingSource wagonBindingSource;
        private BookingDataSetTableAdapters.WagonTableAdapter wagonTableAdapter;
        private System.Windows.Forms.ComboBox number_of_wagonsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private BookingDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private BookingDataSetTableAdapters.TrainTableAdapter trainTableAdapter;
        private BookingDataSetTableAdapters.TimetableTableAdapter timetableTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}