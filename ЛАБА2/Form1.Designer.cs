
namespace ЛАБА2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofwagonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofseatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingDataSet = new ЛАБА2.BookingDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trainTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.TrainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainidDataGridViewTextBoxColumn,
            this.numberofwagonsDataGridViewTextBoxColumn,
            this.numberofseatsDataGridViewTextBoxColumn,
            this.routeidDataGridViewTextBoxColumn,
            this.departureidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 114);
            this.dataGridView1.TabIndex = 1;
            // 
            // trainidDataGridViewTextBoxColumn
            // 
            this.trainidDataGridViewTextBoxColumn.DataPropertyName = "train_id";
            this.trainidDataGridViewTextBoxColumn.HeaderText = "train_id";
            this.trainidDataGridViewTextBoxColumn.Name = "trainidDataGridViewTextBoxColumn";
            this.trainidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberofwagonsDataGridViewTextBoxColumn
            // 
            this.numberofwagonsDataGridViewTextBoxColumn.DataPropertyName = "number_of_wagons";
            this.numberofwagonsDataGridViewTextBoxColumn.HeaderText = "number_of_wagons";
            this.numberofwagonsDataGridViewTextBoxColumn.Name = "numberofwagonsDataGridViewTextBoxColumn";
            this.numberofwagonsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberofseatsDataGridViewTextBoxColumn
            // 
            this.numberofseatsDataGridViewTextBoxColumn.DataPropertyName = "number_of_seats";
            this.numberofseatsDataGridViewTextBoxColumn.HeaderText = "number_of_seats";
            this.numberofseatsDataGridViewTextBoxColumn.Name = "numberofseatsDataGridViewTextBoxColumn";
            this.numberofseatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routeidDataGridViewTextBoxColumn
            // 
            this.routeidDataGridViewTextBoxColumn.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn.HeaderText = "route_id";
            this.routeidDataGridViewTextBoxColumn.Name = "routeidDataGridViewTextBoxColumn";
            this.routeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureidDataGridViewTextBoxColumn
            // 
            this.departureidDataGridViewTextBoxColumn.DataPropertyName = "departure_id";
            this.departureidDataGridViewTextBoxColumn.HeaderText = "departure_id";
            this.departureidDataGridViewTextBoxColumn.Name = "departureidDataGridViewTextBoxColumn";
            this.departureidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.bindingSource1;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BookingDataSet bookingDataSet;
        private BookingDataSetTableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofwagonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofseatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureidDataGridViewTextBoxColumn;
    }
}

