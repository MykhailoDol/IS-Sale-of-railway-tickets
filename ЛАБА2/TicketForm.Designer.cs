
namespace ЛАБА2
{
    partial class TicketForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.number_of_wagonsTextBox = new System.Windows.Forms.ComboBox();
            this.bookingDataSet = new ЛАБА2.BookingDataSet();
            this.wagonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wagonTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.WagonTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.routeTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.RouteTableAdapter();
            this.trainTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.TrainTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ticket_sellingTableAdapter = new ЛАБА2.BookingDataSetTableAdapters.Ticket_sellingTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите пункт направления, вагон и место";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вагон";
            // 
            // number_of_wagonsTextBox
            // 
            this.number_of_wagonsTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.number_of_wagonsTextBox.FormattingEnabled = true;
            this.number_of_wagonsTextBox.Location = new System.Drawing.Point(220, 138);
            this.number_of_wagonsTextBox.Name = "number_of_wagonsTextBox";
            this.number_of_wagonsTextBox.Size = new System.Drawing.Size(114, 21);
            this.number_of_wagonsTextBox.TabIndex = 21;
            this.number_of_wagonsTextBox.SelectedIndexChanged += new System.EventHandler(this.number_of_wagonsTextBox_SelectedIndexChanged);
            // 
            // bookingDataSet
            // 
            this.bookingDataSet.DataSetName = "BookingDataSet";
            this.bookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wagonBindingSource
            // 
            this.wagonBindingSource.DataMember = "Ticket_selling";
            this.wagonBindingSource.DataSource = this.bookingDataSet;
            // 
            // wagonTableAdapter
            // 
            this.wagonTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Место";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(220, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Пункт направления";
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ticket_sellingTableAdapter
            // 
            this.ticket_sellingTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Свободных мест в вагоне: ";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 329);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.number_of_wagonsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox number_of_wagonsTextBox;
        private BookingDataSet bookingDataSet;
        private System.Windows.Forms.BindingSource wagonBindingSource;
        private BookingDataSetTableAdapters.WagonTableAdapter wagonTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private BookingDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private BookingDataSetTableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.Button button1;
        private BookingDataSetTableAdapters.Ticket_sellingTableAdapter ticket_sellingTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}