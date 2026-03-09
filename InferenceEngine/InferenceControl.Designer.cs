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
            lbFactsWork = new Label();
            listBoxFactsWork = new ListBox();
            ritchBoxOutputChain = new RichTextBox();
            lbOutputChain = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelObject = new Label();
            labelUnit = new Label();
            labelAtribute = new Label();
            labelValue = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            cmbObject = new ComboBox();
            cmbUnit = new ComboBox();
            cmbAtribute = new ComboBox();
            cmbValue = new ComboBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnAddFact = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            richBoxRecommend = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckTarget
            // 
            btnCheckTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckTarget.Location = new Point(328, 11);
            btnCheckTarget.Margin = new Padding(3, 4, 3, 4);
            btnCheckTarget.Name = "btnCheckTarget";
            btnCheckTarget.Size = new Size(187, 49);
            btnCheckTarget.TabIndex = 0;
            btnCheckTarget.Text = "Проверить цель";
            btnCheckTarget.UseVisualStyleBackColor = true;
            btnCheckTarget.Click += btnCheckTarget_Click;
            // 
            // cmbChooseTarget
            // 
            cmbChooseTarget.FormattingEnabled = true;
            cmbChooseTarget.Location = new Point(3, 11);
            cmbChooseTarget.Margin = new Padding(3, 4, 3, 4);
            cmbChooseTarget.Name = "cmbChooseTarget";
            cmbChooseTarget.Size = new Size(319, 28);
            cmbChooseTarget.TabIndex = 1;
            // 
            // lbChooseBox
            // 
            lbChooseBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbChooseBox.AutoSize = true;
            lbChooseBox.Location = new Point(3, 20);
            lbChooseBox.Name = "lbChooseBox";
            lbChooseBox.Size = new Size(109, 20);
            lbChooseBox.TabIndex = 2;
            lbChooseBox.Text = "Выбрать цель:";
            // 
            // lbFactsWork
            // 
            lbFactsWork.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbFactsWork.AutoSize = true;
            lbFactsWork.Location = new Point(3, 0);
            lbFactsWork.MinimumSize = new Size(343, 0);
            lbFactsWork.Name = "lbFactsWork";
            lbFactsWork.Size = new Size(343, 39);
            lbFactsWork.TabIndex = 6;
            lbFactsWork.Text = "Рабочая памяти:";
            // 
            // listBoxFactsWork
            // 
            listBoxFactsWork.Dock = DockStyle.Fill;
            listBoxFactsWork.FormattingEnabled = true;
            listBoxFactsWork.Location = new Point(3, 373);
            listBoxFactsWork.Margin = new Padding(3, 4, 3, 4);
            listBoxFactsWork.Name = "listBoxFactsWork";
            listBoxFactsWork.Size = new Size(523, 229);
            listBoxFactsWork.TabIndex = 5;
            listBoxFactsWork.MouseDoubleClick += listBoxFactsWork_MouseDoubleClick;
            // 
            // ritchBoxOutputChain
            // 
            ritchBoxOutputChain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ritchBoxOutputChain.Location = new Point(3, 44);
            ritchBoxOutputChain.Margin = new Padding(3, 4, 3, 4);
            ritchBoxOutputChain.Name = "ritchBoxOutputChain";
            ritchBoxOutputChain.ScrollBars = RichTextBoxScrollBars.Vertical;
            ritchBoxOutputChain.Size = new Size(538, 275);
            ritchBoxOutputChain.TabIndex = 7;
            ritchBoxOutputChain.Text = "";
            // 
            // lbOutputChain
            // 
            lbOutputChain.AutoSize = true;
            lbOutputChain.Dock = DockStyle.Fill;
            lbOutputChain.Location = new Point(3, 0);
            lbOutputChain.Name = "lbOutputChain";
            lbOutputChain.Padding = new Padding(9, 11, 9, 11);
            lbOutputChain.Size = new Size(538, 40);
            lbOutputChain.TabIndex = 8;
            lbOutputChain.Text = "Цепочка вывода:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Padding = new Padding(6, 0, 0, 7);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Padding = new Padding(0, 0, 6, 7);
            splitContainer1.Size = new Size(1090, 613);
            splitContainer1.SplitterDistance = 535;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lbChooseBox, 0, 0);
            tableLayoutPanel2.Controls.Add(listBoxFactsWork, 0, 5);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 0, 3);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel4, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.4299068F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.9719639F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.59813F));
            tableLayoutPanel2.Size = new Size(529, 606);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cmbChooseTarget);
            flowLayoutPanel1.Controls.Add(btnCheckTarget);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 44);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 7, 0, 0);
            flowLayoutPanel1.Size = new Size(523, 101);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(labelObject);
            flowLayoutPanel2.Controls.Add(labelUnit);
            flowLayoutPanel2.Controls.Add(labelAtribute);
            flowLayoutPanel2.Controls.Add(labelValue);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 153);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(523, 32);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // labelObject
            // 
            labelObject.Anchor = AnchorStyles.Bottom;
            labelObject.AutoSize = true;
            labelObject.Location = new Point(3, 0);
            labelObject.MinimumSize = new Size(126, 0);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(126, 20);
            labelObject.TabIndex = 38;
            labelObject.Text = "Объект:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(135, 0);
            labelUnit.MinimumSize = new Size(126, 0);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(126, 20);
            labelUnit.TabIndex = 40;
            labelUnit.Text = "Узел:";
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(267, 0);
            labelAtribute.MinimumSize = new Size(126, 0);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(126, 20);
            labelAtribute.TabIndex = 43;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(399, 0);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 20);
            labelValue.TabIndex = 44;
            labelValue.Text = "Значение:";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(cmbObject);
            flowLayoutPanel3.Controls.Add(cmbUnit);
            flowLayoutPanel3.Controls.Add(cmbAtribute);
            flowLayoutPanel3.Controls.Add(cmbValue);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 193);
            flowLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(523, 132);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // cmbObject
            // 
            cmbObject.Dock = DockStyle.Fill;
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(3, 3);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(125, 28);
            cmbObject.TabIndex = 39;
            cmbObject.SelectedIndexChanged += cmbObject_SelectedIndexChanged;
            // 
            // cmbUnit
            // 
            cmbUnit.Dock = DockStyle.Fill;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(134, 3);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(125, 28);
            cmbUnit.TabIndex = 41;
            cmbUnit.SelectedIndexChanged += cmbUnit_SelectedIndexChanged;
            // 
            // cmbAtribute
            // 
            cmbAtribute.Dock = DockStyle.Fill;
            cmbAtribute.FormattingEnabled = true;
            cmbAtribute.Location = new Point(265, 3);
            cmbAtribute.Name = "cmbAtribute";
            cmbAtribute.Size = new Size(118, 28);
            cmbAtribute.TabIndex = 42;
            cmbAtribute.SelectedIndexChanged += cmbAttribute_SelectedIndexChanged;
            // 
            // cmbValue
            // 
            cmbValue.Dock = DockStyle.Fill;
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(389, 3);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(125, 28);
            cmbValue.TabIndex = 45;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(lbFactsWork);
            flowLayoutPanel4.Controls.Add(btnAddFact);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 333);
            flowLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(523, 32);
            flowLayoutPanel4.TabIndex = 9;
            // 
            // btnAddFact
            // 
            btnAddFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddFact.Location = new Point(352, 4);
            btnAddFact.Margin = new Padding(3, 4, 3, 4);
            btnAddFact.Name = "btnAddFact";
            btnAddFact.Size = new Size(120, 31);
            btnAddFact.TabIndex = 46;
            btnAddFact.Text = "Добавить факт";
            btnAddFact.UseVisualStyleBackColor = true;
            btnAddFact.Click += btnAddFact_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(richBoxRecommend, 0, 2);
            tableLayoutPanel1.Controls.Add(ritchBoxOutputChain, 1, 0);
            tableLayoutPanel1.Controls.Add(lbOutputChain, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(544, 606);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // richBoxRecommend
            // 
            richBoxRecommend.Dock = DockStyle.Fill;
            richBoxRecommend.Location = new Point(3, 327);
            richBoxRecommend.Margin = new Padding(3, 4, 3, 4);
            richBoxRecommend.Name = "richBoxRecommend";
            richBoxRecommend.ScrollBars = RichTextBoxScrollBars.Vertical;
            richBoxRecommend.Size = new Size(538, 275);
            richBoxRecommend.TabIndex = 9;
            richBoxRecommend.Text = "";
            // 
            // InferenceControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InferenceControl";
            Size = new Size(1090, 613);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckTarget;
        private ComboBox cmbChooseTarget;
        private Label lbChooseBox;
        private Label lbFactsWork;
        private ListBox listBoxFactsWork;
        private RichTextBox ritchBoxOutputChain;
        private Label lbOutputChain;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private RichTextBox richBoxRecommend;
        private Label labelAtribute;
        private Label labelUnit;
        private Label labelObject;
        private Label labelValue;
        private ComboBox cmbAtribute;
        private ComboBox cmbValue;
        private ComboBox cmbUnit;
        private ComboBox cmbObject;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAddFact;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
    }
}
