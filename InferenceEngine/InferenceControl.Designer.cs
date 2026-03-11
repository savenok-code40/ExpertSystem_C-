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
            РабочаяПамять = new Label();
            listBoxFactsWork = new ListBox();
            ritchBoxOutputChain = new RichTextBox();
            lbOutputChain = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnAddFact = new Button();
            labelObject = new Label();
            labelUnit = new Label();
            labelAtribute = new Label();
            labelValue = new Label();
            cmbValue = new ComboBox();
            cmbAtribute = new ComboBox();
            cmbUnit = new ComboBox();
            cmbObject = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            Рекомендации = new Label();
            richBoxRecommend = new RichTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckTarget
            // 
            btnCheckTarget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckTarget.Location = new Point(326, 24);
            btnCheckTarget.Margin = new Padding(3, 24, 3, 4);
            btnCheckTarget.Name = "btnCheckTarget";
            btnCheckTarget.Size = new Size(144, 41);
            btnCheckTarget.TabIndex = 0;
            btnCheckTarget.Text = "Проверить цель";
            btnCheckTarget.UseVisualStyleBackColor = true;
            btnCheckTarget.Click += btnCheckTarget_Click;
            // 
            // cmbChooseTarget
            // 
            cmbChooseTarget.Dock = DockStyle.Fill;
            cmbChooseTarget.FormattingEnabled = true;
            cmbChooseTarget.Location = new Point(3, 24);
            cmbChooseTarget.Margin = new Padding(3, 24, 3, 4);
            cmbChooseTarget.Name = "cmbChooseTarget";
            cmbChooseTarget.Size = new Size(317, 28);
            cmbChooseTarget.TabIndex = 1;
            // 
            // РабочаяПамять
            // 
            РабочаяПамять.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            РабочаяПамять.AutoSize = true;
            РабочаяПамять.Location = new Point(3, 120);
            РабочаяПамять.MinimumSize = new Size(343, 0);
            РабочаяПамять.Name = "РабочаяПамять";
            РабочаяПамять.Size = new Size(343, 40);
            РабочаяПамять.TabIndex = 6;
            РабочаяПамять.Text = "Рабочая память:";
            // 
            // listBoxFactsWork
            // 
            listBoxFactsWork.Dock = DockStyle.Fill;
            listBoxFactsWork.FormattingEnabled = true;
            listBoxFactsWork.Location = new Point(3, 164);
            listBoxFactsWork.Margin = new Padding(3, 4, 3, 4);
            listBoxFactsWork.Name = "listBoxFactsWork";
            listBoxFactsWork.Size = new Size(588, 438);
            listBoxFactsWork.TabIndex = 5;
            listBoxFactsWork.MouseDoubleClick += listBoxFactsWork_MouseDoubleClick;
            // 
            // ritchBoxOutputChain
            // 
            ritchBoxOutputChain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ritchBoxOutputChain.Location = new Point(3, 124);
            ritchBoxOutputChain.Margin = new Padding(3, 4, 3, 4);
            ritchBoxOutputChain.Name = "ritchBoxOutputChain";
            ritchBoxOutputChain.ScrollBars = RichTextBoxScrollBars.Vertical;
            ritchBoxOutputChain.Size = new Size(473, 195);
            ritchBoxOutputChain.TabIndex = 7;
            ritchBoxOutputChain.Text = "";
            // 
            // lbOutputChain
            // 
            lbOutputChain.AutoSize = true;
            lbOutputChain.Location = new Point(3, 69);
            lbOutputChain.Name = "lbOutputChain";
            lbOutputChain.Padding = new Padding(9, 11, 9, 11);
            lbOutputChain.Size = new Size(211, 42);
            lbOutputChain.TabIndex = 8;
            lbOutputChain.Text = "Цепочка прямого вывода:";
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
            splitContainer1.SplitterDistance = 600;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel2.Controls.Add(РабочаяПамять, 0, 4);
            tableLayoutPanel2.Controls.Add(listBoxFactsWork, 0, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(594, 606);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel4.Controls.Add(btnAddFact, 4, 1);
            tableLayoutPanel4.Controls.Add(labelObject, 0, 0);
            tableLayoutPanel4.Controls.Add(labelUnit, 1, 0);
            tableLayoutPanel4.Controls.Add(labelAtribute, 2, 0);
            tableLayoutPanel4.Controls.Add(labelValue, 3, 0);
            tableLayoutPanel4.Controls.Add(cmbValue, 3, 1);
            tableLayoutPanel4.Controls.Add(cmbAtribute, 2, 1);
            tableLayoutPanel4.Controls.Add(cmbUnit, 1, 1);
            tableLayoutPanel4.Controls.Add(cmbObject, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(588, 114);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // btnAddFact
            // 
            btnAddFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddFact.Location = new Point(471, 24);
            btnAddFact.Margin = new Padding(3, 4, 3, 4);
            btnAddFact.Name = "btnAddFact";
            btnAddFact.Size = new Size(114, 80);
            btnAddFact.TabIndex = 46;
            btnAddFact.Text = "Добавить в рабочую память";
            btnAddFact.UseVisualStyleBackColor = true;
            btnAddFact.Click += btnAddFact_Click;
            // 
            // labelObject
            // 
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
            labelUnit.Location = new Point(120, 0);
            labelUnit.MinimumSize = new Size(126, 0);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(126, 20);
            labelUnit.TabIndex = 40;
            labelUnit.Text = "Узел:";
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(237, 0);
            labelAtribute.MinimumSize = new Size(126, 0);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(126, 20);
            labelAtribute.TabIndex = 43;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(354, 0);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 20);
            labelValue.TabIndex = 44;
            labelValue.Text = "Значение:";
            // 
            // cmbValue
            // 
            cmbValue.Dock = DockStyle.Fill;
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(354, 23);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(111, 28);
            cmbValue.TabIndex = 45;
            // 
            // cmbAtribute
            // 
            cmbAtribute.Dock = DockStyle.Fill;
            cmbAtribute.FormattingEnabled = true;
            cmbAtribute.Location = new Point(237, 23);
            cmbAtribute.Name = "cmbAtribute";
            cmbAtribute.Size = new Size(111, 28);
            cmbAtribute.TabIndex = 42;
            cmbAtribute.SelectedIndexChanged += cmbAttribute_SelectedIndexChanged;
            // 
            // cmbUnit
            // 
            cmbUnit.Dock = DockStyle.Fill;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(120, 23);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(111, 28);
            cmbUnit.TabIndex = 41;
            cmbUnit.SelectedIndexChanged += cmbUnit_SelectedIndexChanged;
            // 
            // cmbObject
            // 
            cmbObject.Dock = DockStyle.Fill;
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(3, 23);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(111, 28);
            cmbObject.TabIndex = 39;
            cmbObject.SelectedIndexChanged += cmbObject_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(ritchBoxOutputChain, 0, 1);
            tableLayoutPanel1.Controls.Add(Рекомендации, 0, 2);
            tableLayoutPanel1.Controls.Add(richBoxRecommend, 0, 3);
            tableLayoutPanel1.Controls.Add(button1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(479, 606);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(btnCheckTarget, 1, 0);
            tableLayoutPanel3.Controls.Add(cmbChooseTarget, 0, 0);
            tableLayoutPanel3.Controls.Add(lbOutputChain, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.Size = new Size(473, 114);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // Рекомендации
            // 
            Рекомендации.AutoSize = true;
            Рекомендации.Location = new Point(3, 323);
            Рекомендации.Name = "Рекомендации";
            Рекомендации.Padding = new Padding(9, 11, 9, 11);
            Рекомендации.Size = new Size(133, 40);
            Рекомендации.TabIndex = 9;
            Рекомендации.Text = "Рекомендации:";
            // 
            // richBoxRecommend
            // 
            richBoxRecommend.Dock = DockStyle.Fill;
            richBoxRecommend.Location = new Point(3, 367);
            richBoxRecommend.Margin = new Padding(3, 4, 3, 4);
            richBoxRecommend.Name = "richBoxRecommend";
            richBoxRecommend.ScrollBars = RichTextBoxScrollBars.Vertical;
            richBoxRecommend.Size = new Size(473, 195);
            richBoxRecommend.TabIndex = 9;
            richBoxRecommend.Text = "";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(258, 566);
            button1.Margin = new Padding(0, 0, 0, 3);
            button1.Name = "button1";
            button1.Size = new Size(221, 37);
            button1.TabIndex = 9;
            button1.Text = "Обновить рекомендации";
            button1.UseVisualStyleBackColor = true;
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
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckTarget;
        private ComboBox cmbChooseTarget;
        private Label РабочаяПамять;
        private ListBox listBoxFactsWork;
        private RichTextBox ritchBoxOutputChain;
        private Label lbOutputChain;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox richBoxRecommend;
        private Label labelAtribute;
        private Label labelUnit;
        private Label labelObject;
        private Label labelValue;
        private ComboBox cmbAtribute;
        private ComboBox cmbValue;
        private ComboBox cmbUnit;
        private ComboBox cmbObject;
        private Button btnAddFact;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label Рекомендации;
        private Button button1;
    }
}
