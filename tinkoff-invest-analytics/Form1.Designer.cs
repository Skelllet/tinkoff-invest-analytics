
namespace tinkoff_invest_analytics
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_margin_commission = new System.Windows.Forms.TextBox();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_get_all_operations = new System.Windows.Forms.Button();
            this.dataGridView_operations = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_operation_get = new System.Windows.Forms.Button();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Комиссия за непокрытую позицию";
            // 
            // textBox_margin_commission
            // 
            this.textBox_margin_commission.Location = new System.Drawing.Point(286, 436);
            this.textBox_margin_commission.Name = "textBox_margin_commission";
            this.textBox_margin_commission.Size = new System.Drawing.Size(152, 26);
            this.textBox_margin_commission.TabIndex = 1;
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(32, 22);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_from.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_get_all_operations);
            this.groupBox1.Controls.Add(this.dataGridView_operations);
            this.groupBox1.Controls.Add(this.button_operation_get);
            this.groupBox1.Controls.Add(this.dateTimePicker_to);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker_from);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 418);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Совершенные операции";
            // 
            // button_get_all_operations
            // 
            this.button_get_all_operations.Location = new System.Drawing.Point(579, 20);
            this.button_get_all_operations.Name = "button_get_all_operations";
            this.button_get_all_operations.Size = new System.Drawing.Size(202, 30);
            this.button_get_all_operations.TabIndex = 8;
            this.button_get_all_operations.Text = "Получить все операции";
            this.button_get_all_operations.UseVisualStyleBackColor = true;
            this.button_get_all_operations.Click += new System.EventHandler(this.Button_get_all_operations_Click);
            // 
            // dataGridView_operations
            // 
            this.dataGridView_operations.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_operations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.company_name,
            this.price,
            this.quantity,
            this.operation_type,
            this.payment,
            this.currency,
            this.date});
            this.dataGridView_operations.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView_operations.Location = new System.Drawing.Point(10, 56);
            this.dataGridView_operations.Name = "dataGridView_operations";
            this.dataGridView_operations.RowHeadersWidth = 30;
            this.dataGridView_operations.RowTemplate.Height = 28;
            this.dataGridView_operations.Size = new System.Drawing.Size(1121, 356);
            this.dataGridView_operations.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // company_name
            // 
            this.company_name.HeaderText = "Название компании";
            this.company_name.MinimumWidth = 8;
            this.company_name.Name = "company_name";
            this.company_name.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Стоимость";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.Width = 150;
            // 
            // operation_type
            // 
            this.operation_type.HeaderText = "Тип операции";
            this.operation_type.MinimumWidth = 8;
            this.operation_type.Name = "operation_type";
            this.operation_type.Width = 150;
            // 
            // payment
            // 
            this.payment.HeaderText = "Оплата";
            this.payment.MinimumWidth = 8;
            this.payment.Name = "payment";
            this.payment.Width = 150;
            // 
            // currency
            // 
            this.currency.HeaderText = "Валюта";
            this.currency.MinimumWidth = 8;
            this.currency.Name = "currency";
            this.currency.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // button_operation_get
            // 
            this.button_operation_get.Location = new System.Drawing.Point(477, 20);
            this.button_operation_get.Name = "button_operation_get";
            this.button_operation_get.Size = new System.Drawing.Size(96, 30);
            this.button_operation_get.TabIndex = 6;
            this.button_operation_get.Text = "Получить";
            this.button_operation_get.UseVisualStyleBackColor = true;
            this.button_operation_get.Click += new System.EventHandler(this.Button_operation_get_Click);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(271, 22);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_to.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "С";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1161, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_margin_commission);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Аналитика портфеля";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_margin_commission;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_operation_get;
        private System.Windows.Forms.DataGridView dataGridView_operations;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button button_get_all_operations;
    }
}

