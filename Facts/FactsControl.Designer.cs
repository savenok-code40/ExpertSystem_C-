namespace ExpertBase
{
    partial class FactsControl
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnMoveDownFact = new Button();
            btnMoveUpFact = new Button();
            btnDeleteFact = new Button();
            btnAddFact = new Button();
            dataGridFacts = new DataGridView();
            btnEditFact = new Button();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridFacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMoveDownFact
            // 
            btnMoveDownFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoveDownFact.Location = new Point(14, 121);
            btnMoveDownFact.Name = "btnMoveDownFact";
            btnMoveDownFact.Size = new Size(120, 29);
            btnMoveDownFact.TabIndex = 7;
            btnMoveDownFact.Text = "Вниз";
            btnMoveDownFact.UseVisualStyleBackColor = true;
            btnMoveDownFact.Click += btnMoveDownFact_Click;
            // 
            // btnMoveUpFact
            // 
            btnMoveUpFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoveUpFact.Location = new Point(14, 86);
            btnMoveUpFact.Name = "btnMoveUpFact";
            btnMoveUpFact.Size = new Size(120, 29);
            btnMoveUpFact.TabIndex = 6;
            btnMoveUpFact.Text = "Вверх";
            btnMoveUpFact.UseVisualStyleBackColor = true;
            btnMoveUpFact.Click += btnMoveUpFact_Click;
            // 
            // btnDeleteFact
            // 
            btnDeleteFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteFact.BackColor = SystemColors.ButtonFace;
            btnDeleteFact.Location = new Point(14, 156);
            btnDeleteFact.Name = "btnDeleteFact";
            btnDeleteFact.Size = new Size(120, 29);
            btnDeleteFact.TabIndex = 3;
            btnDeleteFact.Text = "Удалить факт";
            btnDeleteFact.UseVisualStyleBackColor = false;
            btnDeleteFact.Click += btnDeleteFact_Click;
            // 
            // btnAddFact
            // 
            btnAddFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddFact.BackColor = SystemColors.ButtonFace;
            btnAddFact.Location = new Point(14, 16);
            btnAddFact.Name = "btnAddFact";
            btnAddFact.Size = new Size(120, 29);
            btnAddFact.TabIndex = 0;
            btnAddFact.Text = "Добавить факт";
            btnAddFact.UseVisualStyleBackColor = false;
            btnAddFact.Click += btnAddFact_Click;
            // 
            // dataGridFacts
            // 
            dataGridFacts.AllowUserToAddRows = false;
            dataGridFacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFacts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridFacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridFacts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridFacts.Dock = DockStyle.Fill;
            dataGridFacts.Location = new Point(0, 0);
            dataGridFacts.Name = "dataGridFacts";
            dataGridFacts.RowHeadersWidth = 51;
            dataGridFacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFacts.Size = new Size(1040, 800);
            dataGridFacts.TabIndex = 0;
            // 
            // btnEditFact
            // 
            btnEditFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditFact.Location = new Point(14, 51);
            btnEditFact.Name = "btnEditFact";
            btnEditFact.Size = new Size(120, 29);
            btnEditFact.TabIndex = 8;
            btnEditFact.Text = "Редактировать";
            btnEditFact.UseVisualStyleBackColor = true;
            btnEditFact.Click += btnEditFact_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridFacts);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(1200, 800);
            splitContainer1.SplitterDistance = 1040;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddFact);
            flowLayoutPanel1.Controls.Add(btnEditFact);
            flowLayoutPanel1.Controls.Add(btnMoveUpFact);
            flowLayoutPanel1.Controls.Add(btnMoveDownFact);
            flowLayoutPanel1.Controls.Add(btnDeleteFact);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            flowLayoutPanel1.Size = new Size(155, 800);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // FactsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(splitContainer1);
            Name = "FactsControl";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridFacts).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnMoveDownFact;
        private Button btnMoveUpFact;
        private Button btnDeleteFact;
        private Button btnAddFact;
        private DataGridView dataGridFacts;
        private Button btnEditFact;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
