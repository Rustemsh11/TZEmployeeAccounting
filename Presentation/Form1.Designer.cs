namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            repositoryContextFactoryBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            заплонитьБазуДанныхToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            подразделенияToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)repositoryContextFactoryBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // repositoryContextFactoryBindingSource
            // 
            repositoryContextFactoryBindingSource.DataSource = typeof(ContextFactory.RepositoryContextFactory);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { заплонитьБазуДанныхToolStripMenuItem, сотрудникиToolStripMenuItem, подразделенияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // заплонитьБазуДанныхToolStripMenuItem
            // 
            заплонитьБазуДанныхToolStripMenuItem.Name = "заплонитьБазуДанныхToolStripMenuItem";
            заплонитьБазуДанныхToolStripMenuItem.Size = new Size(149, 20);
            заплонитьБазуДанныхToolStripMenuItem.Text = "Заплонить базу данных";
            заплонитьБазуДанныхToolStripMenuItem.Click += заплонитьБазуДанныхToolStripMenuItem_Click;
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(85, 20);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            сотрудникиToolStripMenuItem.Click += сотрудникиToolStripMenuItem_Click;
            // 
            // подразделенияToolStripMenuItem
            // 
            подразделенияToolStripMenuItem.Name = "подразделенияToolStripMenuItem";
            подразделенияToolStripMenuItem.Size = new Size(104, 20);
            подразделенияToolStripMenuItem.Text = "Подразделения";
            подразделенияToolStripMenuItem.Click += подразделенияToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)repositoryContextFactoryBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource repositoryContextFactoryBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem заплонитьБазуДанныхToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem подразделенияToolStripMenuItem;
    }
}