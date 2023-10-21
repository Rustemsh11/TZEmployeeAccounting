namespace Presentation
{
    partial class EmployeeForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addEmpButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateEmploymentPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numTabelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.lastTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.departmentFilterRB = new System.Windows.Forms.RadioButton();
            this.departmentFilterCB = new System.Windows.Forms.ComboBox();
            this.dateTerminFilterRB = new System.Windows.Forms.RadioButton();
            this.dateemplFilterRB = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameSearchRB = new System.Windows.Forms.RadioButton();
            this.tabelSearchRB = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(298, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(11, 39);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(281, 27);
            this.searchInput.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 277);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addEmpButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateEmploymentPicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.positionTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numTabelTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить сотрудника";
            // 
            // addEmpButton
            // 
            this.addEmpButton.Location = new System.Drawing.Point(363, 229);
            this.addEmpButton.Name = "addEmpButton";
            this.addEmpButton.Size = new System.Drawing.Size(94, 29);
            this.addEmpButton.TabIndex = 15;
            this.addEmpButton.Text = "Принять";
            this.addEmpButton.UseVisualStyleBackColor = true;
            this.addEmpButton.Click += new System.EventHandler(this.addEmpButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата приема";
            // 
            // dateEmploymentPicker
            // 
            this.dateEmploymentPicker.Location = new System.Drawing.Point(6, 232);
            this.dateEmploymentPicker.Name = "dateEmploymentPicker";
            this.dateEmploymentPicker.Size = new System.Drawing.Size(207, 27);
            this.dateEmploymentPicker.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Телефон";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(250, 171);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(207, 27);
            this.phoneTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(250, 115);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 27);
            this.emailTextBox.TabIndex = 9;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(250, 53);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(201, 28);
            this.departmentComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Подразделение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Должность";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(6, 171);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(207, 27);
            this.positionTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер табеля";
            // 
            // numTabelTextBox
            // 
            this.numTabelTextBox.Location = new System.Drawing.Point(6, 115);
            this.numTabelTextBox.Name = "numTabelTextBox";
            this.numTabelTextBox.Size = new System.Drawing.Size(125, 27);
            this.numTabelTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(6, 53);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(207, 27);
            this.fioTextBox.TabIndex = 0;
            // 
            // lastTimePicker
            // 
            this.lastTimePicker.Location = new System.Drawing.Point(405, 21);
            this.lastTimePicker.Name = "lastTimePicker";
            this.lastTimePicker.Size = new System.Drawing.Size(207, 27);
            this.lastTimePicker.TabIndex = 14;
            // 
            // firstDatePicker
            // 
            this.firstDatePicker.Location = new System.Drawing.Point(157, 23);
            this.firstDatePicker.Name = "firstDatePicker";
            this.firstDatePicker.Size = new System.Drawing.Size(207, 27);
            this.firstDatePicker.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterButton);
            this.groupBox2.Controls.Add(this.departmentFilterRB);
            this.groupBox2.Controls.Add(this.departmentFilterCB);
            this.groupBox2.Controls.Add(this.dateTerminFilterRB);
            this.groupBox2.Controls.Add(this.dateemplFilterRB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lastTimePicker);
            this.groupBox2.Controls.Add(this.firstDatePicker);
            this.groupBox2.Location = new System.Drawing.Point(411, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 124);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(405, 81);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(136, 29);
            this.filterButton.TabIndex = 21;
            this.filterButton.Text = "Показать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // departmentFilterRB
            // 
            this.departmentFilterRB.AutoSize = true;
            this.departmentFilterRB.Location = new System.Drawing.Point(6, 85);
            this.departmentFilterRB.Name = "departmentFilterRB";
            this.departmentFilterRB.Size = new System.Drawing.Size(138, 24);
            this.departmentFilterRB.TabIndex = 20;
            this.departmentFilterRB.TabStop = true;
            this.departmentFilterRB.Text = "подразделение";
            this.departmentFilterRB.UseVisualStyleBackColor = true;
            // 
            // departmentFilterCB
            // 
            this.departmentFilterCB.FormattingEnabled = true;
            this.departmentFilterCB.Location = new System.Drawing.Point(157, 83);
            this.departmentFilterCB.Name = "departmentFilterCB";
            this.departmentFilterCB.Size = new System.Drawing.Size(201, 28);
            this.departmentFilterCB.TabIndex = 16;
            // 
            // dateTerminFilterRB
            // 
            this.dateTerminFilterRB.AutoSize = true;
            this.dateTerminFilterRB.Location = new System.Drawing.Point(6, 55);
            this.dateTerminFilterRB.Name = "dateTerminFilterRB";
            this.dateTerminFilterRB.Size = new System.Drawing.Size(147, 24);
            this.dateTerminFilterRB.TabIndex = 19;
            this.dateTerminFilterRB.TabStop = true;
            this.dateTerminFilterRB.Text = "дата увольнения";
            this.dateTerminFilterRB.UseVisualStyleBackColor = true;
            // 
            // dateemplFilterRB
            // 
            this.dateemplFilterRB.AutoSize = true;
            this.dateemplFilterRB.Location = new System.Drawing.Point(6, 25);
            this.dateemplFilterRB.Name = "dateemplFilterRB";
            this.dateemplFilterRB.Size = new System.Drawing.Size(131, 24);
            this.dateemplFilterRB.TabIndex = 18;
            this.dateemplFilterRB.TabStop = true;
            this.dateemplFilterRB.Text = "дата принятия";
            this.dateemplFilterRB.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "По";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "C";
            // 
            // nameSearchRB
            // 
            this.nameSearchRB.AutoSize = true;
            this.nameSearchRB.Location = new System.Drawing.Point(11, 12);
            this.nameSearchRB.Name = "nameSearchRB";
            this.nameSearchRB.Size = new System.Drawing.Size(100, 24);
            this.nameSearchRB.TabIndex = 21;
            this.nameSearchRB.TabStop = true;
            this.nameSearchRB.Text = "По имени";
            this.nameSearchRB.UseVisualStyleBackColor = true;
            // 
            // tabelSearchRB
            // 
            this.tabelSearchRB.AutoSize = true;
            this.tabelSearchRB.Location = new System.Drawing.Point(118, 12);
            this.tabelSearchRB.Name = "tabelSearchRB";
            this.tabelSearchRB.Size = new System.Drawing.Size(158, 24);
            this.tabelSearchRB.TabIndex = 22;
            this.tabelSearchRB.TabStop = true;
            this.tabelSearchRB.Text = "По номеру табеля";
            this.tabelSearchRB.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 23;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(871, 655);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(165, 31);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Уволить сотрудника";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 595);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "Удалить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabelSearchRB);
            this.Controls.Add(this.nameSearchRB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchButton);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchButton;
        private TextBox searchInput;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox phoneTextBox;
        private Label label5;
        private TextBox emailTextBox;
        private ComboBox departmentComboBox;
        private Label label4;
        private Label label3;
        private TextBox positionTextBox;
        private Label label2;
        private TextBox numTabelTextBox;
        private Label label1;
        private TextBox fioTextBox;
        private Label label7;
        private DateTimePicker dateEmploymentPicker;
        private Button addEmpButton;
        private DateTimePicker lastTimePicker;
        private DateTimePicker firstDatePicker;
        private GroupBox groupBox2;
        private Button filterButton;
        private RadioButton departmentFilterRB;
        private ComboBox departmentFilterCB;
        private RadioButton dateTerminFilterRB;
        private RadioButton dateemplFilterRB;
        private Label label9;
        private Label label8;
        private RadioButton nameSearchRB;
        private RadioButton tabelSearchRB;
        private Label label10;
        private Button deleteButton;
        private Button button1;
    }
}