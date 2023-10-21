namespace Presentation
{
    partial class FillEmployeeForms
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            сhooseFileButton = new Button();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 80);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(806, 296);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(854, 80);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(360, 296);
            dataGridView2.TabIndex = 1;
            // 
            // сhooseFileButton
            // 
            сhooseFileButton.Location = new Point(25, 30);
            сhooseFileButton.Margin = new Padding(3, 2, 3, 2);
            сhooseFileButton.Name = "сhooseFileButton";
            сhooseFileButton.Size = new Size(151, 22);
            сhooseFileButton.TabIndex = 2;
            сhooseFileButton.Text = "Загрузить данные";
            сhooseFileButton.UseVisualStyleBackColor = true;
            сhooseFileButton.Click += сhooseFileButton_Click_1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(25, 392);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(82, 22);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 62);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Сотрудники";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(854, 62);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 5;
            label2.Text = "Подразделения";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 396);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // FillEmployeeForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 422);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(сhooseFileButton);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FillEmployeeForms";
            Text = "FillEmployeeForms";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button сhooseFileButton;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Label label3;
    }
}