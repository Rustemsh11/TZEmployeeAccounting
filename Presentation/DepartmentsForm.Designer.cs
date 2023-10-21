namespace Presentation
{
    partial class DepartmentsForm
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
            deleteButton = new Button();
            label10 = new Label();
            idSearchRB = new RadioButton();
            nameSearchRB = new RadioButton();
            groupBox1 = new GroupBox();
            mainComboBox = new ComboBox();
            bossComboBox = new ComboBox();
            addEmpButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            searchInput = new TextBox();
            searchButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(450, 501);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(144, 23);
            deleteButton.TabIndex = 33;
            deleteButton.Text = "Удалить запись";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 64);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 32;
            // 
            // idSearchRB
            // 
            idSearchRB.AutoSize = true;
            idSearchRB.Location = new Point(116, 15);
            idSearchRB.Margin = new Padding(3, 2, 3, 2);
            idSearchRB.Name = "idSearchRB";
            idSearchRB.Size = new Size(135, 19);
            idSearchRB.TabIndex = 31;
            idSearchRB.TabStop = true;
            idSearchRB.Text = "По идентификатору";
            idSearchRB.UseVisualStyleBackColor = true;
            // 
            // nameSearchRB
            // 
            nameSearchRB.AutoSize = true;
            nameSearchRB.Location = new Point(12, 15);
            nameSearchRB.Margin = new Padding(3, 2, 3, 2);
            nameSearchRB.Name = "nameSearchRB";
            nameSearchRB.Size = new Size(98, 19);
            nameSearchRB.TabIndex = 30;
            nameSearchRB.TabStop = true;
            nameSearchRB.Text = "По названию";
            nameSearchRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mainComboBox);
            groupBox1.Controls.Add(bossComboBox);
            groupBox1.Controls.Add(addEmpButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(12, 325);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(203, 199);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить подразделение";
            // 
            // mainComboBox
            // 
            mainComboBox.FormattingEnabled = true;
            mainComboBox.Location = new Point(6, 86);
            mainComboBox.Margin = new Padding(3, 2, 3, 2);
            mainComboBox.Name = "mainComboBox";
            mainComboBox.Size = new Size(181, 23);
            mainComboBox.TabIndex = 17;
            // 
            // bossComboBox
            // 
            bossComboBox.FormattingEnabled = true;
            bossComboBox.Location = new Point(6, 131);
            bossComboBox.Margin = new Padding(3, 2, 3, 2);
            bossComboBox.Name = "bossComboBox";
            bossComboBox.Size = new Size(181, 23);
            bossComboBox.TabIndex = 16;
            // 
            // addEmpButton
            // 
            addEmpButton.Location = new Point(41, 173);
            addEmpButton.Margin = new Padding(3, 2, 3, 2);
            addEmpButton.Name = "addEmpButton";
            addEmpButton.Size = new Size(82, 22);
            addEmpButton.TabIndex = 15;
            addEmpButton.Text = "Добавить";
            addEmpButton.UseVisualStyleBackColor = true;
            addEmpButton.Click += addEmpButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 110);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Руководитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 67);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 3;
            label2.Text = "Головное подразделение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Наименование";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(5, 40);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 23);
            nameTextBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 112);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(582, 208);
            dataGridView1.TabIndex = 27;
            // 
            // searchInput
            // 
            searchInput.Location = new Point(12, 35);
            searchInput.Margin = new Padding(3, 2, 3, 2);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(246, 23);
            searchInput.TabIndex = 26;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(264, 34);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(92, 25);
            searchButton.TabIndex = 25;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 540);
            Controls.Add(deleteButton);
            Controls.Add(label10);
            Controls.Add(idSearchRB);
            Controls.Add(nameSearchRB);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(searchInput);
            Controls.Add(searchButton);
            Name = "DepartmentsForm";
            Text = "DepartmentsForm";
            Load += DepartmentsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Label label10;
        private RadioButton idSearchRB;
        private RadioButton nameSearchRB;
        private GroupBox groupBox1;
        private Button addEmpButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nameTextBox;
        private DataGridView dataGridView1;
        private TextBox searchInput;
        private Button searchButton;
        private ComboBox mainComboBox;
        private ComboBox bossComboBox;
    }
}