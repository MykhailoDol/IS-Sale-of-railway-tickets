
namespace ЛАБА2
{
    partial class RequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingDataSet = new ЛАБА2.BookingDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.timetable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataTable3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.timetable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.route1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new ЛАБА2.BookingDataSetTableAdapters.DataTable2TableAdapter();
            this.timetable1TableAdapter = new ЛАБА2.BookingDataSetTableAdapters.Timetable1TableAdapter();
            this.route1TableAdapter = new ЛАБА2.BookingDataSetTableAdapters.Route1TableAdapter();
            this.timetable2TableAdapter = new ЛАБА2.BookingDataSetTableAdapters.Timetable2TableAdapter();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable3TableAdapter = new ЛАБА2.BookingDataSetTableAdapters.DataTable3TableAdapter();
            this.trainidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointofdepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointofarrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtimeofdepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВагоновDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtimeofdepartureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПоездовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointofdepartureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointofarrivalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Су = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtimeofdepartureDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоМаршрутовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable1BindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запросы";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainidDataGridViewTextBoxColumn,
            this.pointofdepartureDataGridViewTextBoxColumn,
            this.pointofarrivalDataGridViewTextBoxColumn,
            this.dateandtimeofdepartureDataGridViewTextBoxColumn,
            this.количествоВагоновDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bookingDataSet;
            this.bindingSource1.Position = 0;
            // 
            // bookingDataSet
            // 
            this.bookingDataSet.DataSetName = "BookingDataSet";
            this.bookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Статистика поездов по количеству вагонов";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureidDataGridViewTextBoxColumn,
            this.dateandtimeofdepartureDataGridViewTextBoxColumn1,
            this.количествоПоездовDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.timetable1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(188, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(347, 195);
            this.dataGridView2.TabIndex = 3;
            // 
            // timetable1BindingSource
            // 
            this.timetable1BindingSource.DataMember = "Timetable1";
            this.timetable1BindingSource.DataSource = this.bindingSource1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(200, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статистика количества поездов в день";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Распечатать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pointofdepartureDataGridViewTextBoxColumn1,
            this.pointofarrivalDataGridViewTextBoxColumn1,
            this.Column1,
            this.Су});
            this.dataGridView3.DataSource = this.dataTable3BindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(38, 89);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(445, 217);
            this.dataGridView3.TabIndex = 5;
            // 
            // dataTable3BindingSource1
            // 
            this.dataTable3BindingSource1.DataMember = "DataTable3";
            this.dataTable3BindingSource1.DataSource = this.bindingSource1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статистика по количеству билетов на каждый поезд";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(756, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateandtimeofdepartureDataGridViewTextBoxColumn2,
            this.количествоМаршрутовDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.timetable2BindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(249, 81);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(245, 217);
            this.dataGridView4.TabIndex = 7;
            // 
            // timetable2BindingSource
            // 
            this.timetable2BindingSource.DataMember = "Timetable2";
            this.timetable2BindingSource.DataSource = this.bindingSource1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(160, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Статистика количества разных маршрутов каждый день";
            // 
            // route1BindingSource
            // 
            this.route1BindingSource.DataMember = "Route1";
            this.route1BindingSource.DataSource = this.bindingSource1;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // timetable1TableAdapter
            // 
            this.timetable1TableAdapter.ClearBeforeFill = true;
            // 
            // route1TableAdapter
            // 
            this.route1TableAdapter.ClearBeforeFill = true;
            // 
            // timetable2TableAdapter
            // 
            this.timetable2TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.bookingDataSet;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // trainidDataGridViewTextBoxColumn
            // 
            this.trainidDataGridViewTextBoxColumn.DataPropertyName = "train_id";
            this.trainidDataGridViewTextBoxColumn.HeaderText = "Номер поезда";
            this.trainidDataGridViewTextBoxColumn.Name = "trainidDataGridViewTextBoxColumn";
            this.trainidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pointofdepartureDataGridViewTextBoxColumn
            // 
            this.pointofdepartureDataGridViewTextBoxColumn.DataPropertyName = "point_of_departure";
            this.pointofdepartureDataGridViewTextBoxColumn.HeaderText = "Пункт отправления";
            this.pointofdepartureDataGridViewTextBoxColumn.Name = "pointofdepartureDataGridViewTextBoxColumn";
            this.pointofdepartureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pointofarrivalDataGridViewTextBoxColumn
            // 
            this.pointofarrivalDataGridViewTextBoxColumn.DataPropertyName = "point_of_arrival";
            this.pointofarrivalDataGridViewTextBoxColumn.HeaderText = "Пункты проезда";
            this.pointofarrivalDataGridViewTextBoxColumn.Name = "pointofarrivalDataGridViewTextBoxColumn";
            this.pointofarrivalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateandtimeofdepartureDataGridViewTextBoxColumn
            // 
            this.dateandtimeofdepartureDataGridViewTextBoxColumn.DataPropertyName = "date_and_time_of_departure";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn.HeaderText = "Дата и время отправления";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn.Name = "dateandtimeofdepartureDataGridViewTextBoxColumn";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоВагоновDataGridViewTextBoxColumn
            // 
            this.количествоВагоновDataGridViewTextBoxColumn.DataPropertyName = "Количество вагонов";
            this.количествоВагоновDataGridViewTextBoxColumn.HeaderText = "Количество вагонов";
            this.количествоВагоновDataGridViewTextBoxColumn.Name = "количествоВагоновDataGridViewTextBoxColumn";
            this.количествоВагоновDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureidDataGridViewTextBoxColumn
            // 
            this.departureidDataGridViewTextBoxColumn.DataPropertyName = "departure_id";
            this.departureidDataGridViewTextBoxColumn.HeaderText = "Номер отправления";
            this.departureidDataGridViewTextBoxColumn.Name = "departureidDataGridViewTextBoxColumn";
            this.departureidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateandtimeofdepartureDataGridViewTextBoxColumn1
            // 
            this.dateandtimeofdepartureDataGridViewTextBoxColumn1.DataPropertyName = "date_and_time_of_departure";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn1.HeaderText = "Дата и время отправления";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn1.Name = "dateandtimeofdepartureDataGridViewTextBoxColumn1";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // количествоПоездовDataGridViewTextBoxColumn
            // 
            this.количествоПоездовDataGridViewTextBoxColumn.DataPropertyName = "Количество поездов";
            this.количествоПоездовDataGridViewTextBoxColumn.HeaderText = "Количество поездов";
            this.количествоПоездовDataGridViewTextBoxColumn.Name = "количествоПоездовDataGridViewTextBoxColumn";
            this.количествоПоездовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pointofdepartureDataGridViewTextBoxColumn1
            // 
            this.pointofdepartureDataGridViewTextBoxColumn1.DataPropertyName = "point_of_departure";
            this.pointofdepartureDataGridViewTextBoxColumn1.HeaderText = "Пункт отправления";
            this.pointofdepartureDataGridViewTextBoxColumn1.Name = "pointofdepartureDataGridViewTextBoxColumn1";
            this.pointofdepartureDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pointofarrivalDataGridViewTextBoxColumn1
            // 
            this.pointofarrivalDataGridViewTextBoxColumn1.DataPropertyName = "point_of_arrival";
            this.pointofarrivalDataGridViewTextBoxColumn1.HeaderText = "Конечный пункт";
            this.pointofarrivalDataGridViewTextBoxColumn1.Name = "pointofarrivalDataGridViewTextBoxColumn1";
            this.pointofarrivalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "train_id";
            this.Column1.HeaderText = "Номер поезда";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Су
            // 
            this.Су.DataPropertyName = "Expr1";
            this.Су.HeaderText = "Количество билетов";
            this.Су.Name = "Су";
            this.Су.ReadOnly = true;
            // 
            // dateandtimeofdepartureDataGridViewTextBoxColumn2
            // 
            this.dateandtimeofdepartureDataGridViewTextBoxColumn2.DataPropertyName = "date_and_time_of_departure";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn2.HeaderText = "Дата и время отправления";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn2.Name = "dateandtimeofdepartureDataGridViewTextBoxColumn2";
            this.dateandtimeofdepartureDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // количествоМаршрутовDataGridViewTextBoxColumn
            // 
            this.количествоМаршрутовDataGridViewTextBoxColumn.DataPropertyName = "Количество маршрутов";
            this.количествоМаршрутовDataGridViewTextBoxColumn.HeaderText = "Количество маршрутов";
            this.количествоМаршрутовDataGridViewTextBoxColumn.Name = "количествоМаршрутовDataGridViewTextBoxColumn";
            this.количествоМаршрутовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable1BindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BookingDataSet bookingDataSet;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private BookingDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource timetable1BindingSource;
        private BookingDataSetTableAdapters.Timetable1TableAdapter timetable1TableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource route1BindingSource;
        private BookingDataSetTableAdapters.Route1TableAdapter route1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource timetable2BindingSource;
        private BookingDataSetTableAdapters.Timetable2TableAdapter timetable2TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private BookingDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.BindingSource dataTable3BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointofdepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointofarrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtimeofdepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВагоновDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtimeofdepartureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПоездовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointofdepartureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointofarrivalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Су;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtimeofdepartureDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоМаршрутовDataGridViewTextBoxColumn;
    }
}