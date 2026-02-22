namespace ExpertBase.InferenceEngine
{
    partial class InferenceControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheckTarget = new Button();
            cmbChooseTarget = new ComboBox();
            lbChooseBox = new Label();
            listBoxFactsInit = new ListBox();
            lbFactsInit = new Label();
            lbFactsWork = new Label();
            listBoxFactsWork = new ListBox();
            ritchBoxOutputChain = new RichTextBox();
            lbOutputChain = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckTarget
            // 
            btnCheckTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckTarget.Location = new Point(289, 8);
            btnCheckTarget.Name = "btnCheckTarget";
            btnCheckTarget.Size = new Size(164, 37);
            btnCheckTarget.TabIndex = 0;
            btnCheckTarget.Text = "Проверить цель";
            btnCheckTarget.UseVisualStyleBackColor = true;
            btnCheckTarget.Click += btnCheckTarget_Click;
            // 
            // cmbChooseTarget
            // 
            cmbChooseTarget.FormattingEnabled = true;
            cmbChooseTarget.Location = new Point(3, 8);
            cmbChooseTarget.Name = "cmbChooseTarget";
            cmbChooseTarget.Size = new Size(280, 23);
            cmbChooseTarget.TabIndex = 1;
            // 
            // lbChooseBox
            // 
            lbChooseBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbChooseBox.AutoSize = true;
            lbChooseBox.Location = new Point(3, 15);
            lbChooseBox.Name = "lbChooseBox";
            lbChooseBox.Size = new Size(86, 15);
            lbChooseBox.TabIndex = 2;
            lbChooseBox.Text = "Выбрать цель:";
            // 
            // listBoxFactsInit
            // 
            listBoxFactsInit.Dock = DockStyle.Fill;
            listBoxFactsInit.FormattingEnabled = true;
            listBoxFactsInit.ItemHeight = 15;
            listBoxFactsInit.Location = new Point(3, 169);
            listBoxFactsInit.Name = "listBoxFactsInit";
            listBoxFactsInit.Size = new Size(458, 123);
            listBoxFactsInit.TabIndex = 3;
            // 
            // lbFactsInit
            // 
            lbFactsInit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbFactsInit.AutoSize = true;
            lbFactsInit.Location = new Point(3, 151);
            lbFactsInit.Name = "lbFactsInit";
            lbFactsInit.Size = new Size(131, 15);
            lbFactsInit.TabIndex = 4;
            lbFactsInit.Text = "База исходных фактов:";
            // 
            // lbFactsWork
            // 
            lbFactsWork.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbFactsWork.AutoSize = true;
            lbFactsWork.Location = new Point(3, 310);
            lbFactsWork.Name = "lbFactsWork";
            lbFactsWork.Size = new Size(147, 15);
            lbFactsWork.TabIndex = 6;
            lbFactsWork.Text = "Факты в рабочей памяти:";
            // 
            // listBoxFactsWork
            // 
            listBoxFactsWork.Dock = DockStyle.Fill;
            listBoxFactsWork.FormattingEnabled = true;
            listBoxFactsWork.ItemHeight = 15;
            listBoxFactsWork.Location = new Point(3, 328);
            listBoxFactsWork.Name = "listBoxFactsWork";
            listBoxFactsWork.Size = new Size(458, 124);
            listBoxFactsWork.TabIndex = 5;
            // 
            // ritchBoxOutputChain
            // 
            ritchBoxOutputChain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ritchBoxOutputChain.Location = new Point(3, 33);
            ritchBoxOutputChain.Name = "ritchBoxOutputChain";
            ritchBoxOutputChain.ScrollBars = RichTextBoxScrollBars.Vertical;
            ritchBoxOutputChain.Size = new Size(470, 419);
            ritchBoxOutputChain.TabIndex = 7;
            ritchBoxOutputChain.Text = "";
            // 
            // lbOutputChain
            // 
            lbOutputChain.AutoSize = true;
            lbOutputChain.Dock = DockStyle.Fill;
            lbOutputChain.Location = new Point(3, 0);
            lbOutputChain.Name = "lbOutputChain";
            lbOutputChain.Padding = new Padding(8);
            lbOutputChain.Size = new Size(470, 30);
            lbOutputChain.TabIndex = 8;
            lbOutputChain.Text = "Цепочка вывода:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Padding = new Padding(5, 0, 0, 5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Padding = new Padding(0, 0, 5, 5);
            splitContainer1.Size = new Size(954, 460);
            splitContainer1.SplitterDistance = 469;
            splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lbChooseBox, 0, 0);
            tableLayoutPanel2.Controls.Add(listBoxFactsWork, 0, 5);
            tableLayoutPanel2.Controls.Add(lbFactsWork, 0, 4);
            tableLayoutPanel2.Controls.Add(lbFactsInit, 0, 2);
            tableLayoutPanel2.Controls.Add(listBoxFactsInit, 0, 3);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(464, 455);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cmbChooseTarget);
            flowLayoutPanel1.Controls.Add(btnCheckTarget);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel1.Size = new Size(458, 100);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ritchBoxOutputChain, 1, 0);
            tableLayoutPanel1.Controls.Add(lbOutputChain, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(476, 455);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // InferenceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(splitContainer1);
            Name = "InferenceControl";
            Size = new Size(954, 460);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckTarget;
        private ComboBox cmbChooseTarget;
        private Label lbChooseBox;
        private ListBox listBoxFactsInit;
        private Label lbFactsInit;
        private Label lbFactsWork;
        private ListBox listBoxFactsWork;
        private RichTextBox ritchBoxOutputChain;
        private Label lbOutputChain;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
