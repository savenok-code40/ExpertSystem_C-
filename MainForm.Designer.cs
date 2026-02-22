namespace ExpertBase
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            modbusToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            tabControl_General = new TabControl();
            tabPage1_Edit = new TabPage();
            tabControl_Edit = new TabControl();
            tabPage3 = new TabPage();
            factsControl1 = new FactsControl();
            tabPage4 = new TabPage();
            rulesControl1 = new RulesControl();
            tabPage5 = new TabPage();
            tabPage2_Work = new TabPage();
            inferenceControl1 = new ExpertBase.InferenceEngine.InferenceControl();
            panel1 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            menuStrip1.SuspendLayout();
            tabControl_General.SuspendLayout();
            tabPage1_Edit.SuspendLayout();
            tabControl_Edit.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage2_Work.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, настройкиToolStripMenuItem, помощьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1034, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, загрузитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(162, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить как...";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(162, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modbusToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // modbusToolStripMenuItem
            // 
            modbusToolStripMenuItem.Name = "modbusToolStripMenuItem";
            modbusToolStripMenuItem.Size = new Size(118, 22);
            modbusToolStripMenuItem.Text = "Modbus";
            modbusToolStripMenuItem.Click += modbusToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 20);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // tabControl_General
            // 
            tabControl_General.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_General.Controls.Add(tabPage1_Edit);
            tabControl_General.Controls.Add(tabPage2_Work);
            tabControl_General.Location = new Point(10, 59);
            tabControl_General.Margin = new Padding(3, 2, 3, 2);
            tabControl_General.Name = "tabControl_General";
            tabControl_General.SelectedIndex = 0;
            tabControl_General.Size = new Size(962, 488);
            tabControl_General.TabIndex = 1;
            // 
            // tabPage1_Edit
            // 
            tabPage1_Edit.Controls.Add(tabControl_Edit);
            tabPage1_Edit.Location = new Point(4, 24);
            tabPage1_Edit.Margin = new Padding(3, 2, 3, 2);
            tabPage1_Edit.Name = "tabPage1_Edit";
            tabPage1_Edit.Padding = new Padding(3, 2, 3, 2);
            tabPage1_Edit.Size = new Size(954, 460);
            tabPage1_Edit.TabIndex = 0;
            tabPage1_Edit.Text = "Редактирование";
            tabPage1_Edit.UseVisualStyleBackColor = true;
            // 
            // tabControl_Edit
            // 
            tabControl_Edit.Controls.Add(tabPage3);
            tabControl_Edit.Controls.Add(tabPage4);
            tabControl_Edit.Controls.Add(tabPage5);
            tabControl_Edit.Dock = DockStyle.Fill;
            tabControl_Edit.Location = new Point(3, 2);
            tabControl_Edit.Margin = new Padding(3, 2, 3, 2);
            tabControl_Edit.Name = "tabControl_Edit";
            tabControl_Edit.SelectedIndex = 0;
            tabControl_Edit.Size = new Size(948, 456);
            tabControl_Edit.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(factsControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(940, 428);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Факты";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // factsControl1
            // 
            factsControl1.AutoScroll = true;
            factsControl1.BackColor = SystemColors.ActiveCaption;
            factsControl1.Dock = DockStyle.Fill;
            factsControl1.Location = new Point(3, 2);
            factsControl1.Margin = new Padding(3, 2, 3, 2);
            factsControl1.Name = "factsControl1";
            factsControl1.Size = new Size(934, 424);
            factsControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(rulesControl1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(940, 428);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Правила";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // rulesControl1
            // 
            rulesControl1.BackColor = SystemColors.ActiveCaption;
            rulesControl1.Dock = DockStyle.Fill;
            rulesControl1.Location = new Point(3, 2);
            rulesControl1.Margin = new Padding(3, 2, 3, 2);
            rulesControl1.Name = "rulesControl1";
            rulesControl1.Size = new Size(934, 424);
            rulesControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(940, 428);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Вопросы";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage2_Work
            // 
            tabPage2_Work.Controls.Add(inferenceControl1);
            tabPage2_Work.Location = new Point(4, 24);
            tabPage2_Work.Margin = new Padding(0);
            tabPage2_Work.Name = "tabPage2_Work";
            tabPage2_Work.Size = new Size(954, 460);
            tabPage2_Work.TabIndex = 1;
            tabPage2_Work.Text = "Работа";
            tabPage2_Work.UseVisualStyleBackColor = true;
            // 
            // inferenceControl1
            // 
            inferenceControl1.BackColor = SystemColors.ActiveCaption;
            inferenceControl1.Dock = DockStyle.Fill;
            inferenceControl1.Location = new Point(0, 0);
            inferenceControl1.Name = "inferenceControl1";
            inferenceControl1.Size = new Size(954, 460);
            inferenceControl1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(0, 47);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 508);
            panel1.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1034, 565);
            Controls.Add(tabControl_General);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Экспертная база системы вентиляции";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl_General.ResumeLayout(false);
            tabPage1_Edit.ResumeLayout(false);
            tabControl_Edit.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage2_Work.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private TabControl tabControl_General;
        private TabPage tabPage1_Edit;
        private TabPage tabPage2_Work;
        private TabControl tabControl_Edit;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private FileSystemWatcher fileSystemWatcher1;
        private FactsControl factsControl1;
        private RulesControl rulesControl1;
        private ToolStripMenuItem modbusToolStripMenuItem;
        private InferenceEngine.InferenceControl inferenceControl1;
    }
}
