namespace ExpertBase_v1
{
    partial class RulesControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnEditRules = new Button();
            dataGridRules = new DataGridView();
            btnDeleteRules = new Button();
            btnAddRules = new Button();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridRules).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditRules
            // 
            btnEditRules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditRules.Location = new Point(13, 38);
            btnEditRules.Margin = new Padding(3, 2, 3, 2);
            btnEditRules.Name = "btnEditRules";
            btnEditRules.Size = new Size(105, 22);
            btnEditRules.TabIndex = 14;
            btnEditRules.Text = "Редактировать";
            btnEditRules.UseVisualStyleBackColor = true;
            btnEditRules.Click += btnEditRules_Click;
            // 
            // dataGridRules
            // 
            dataGridRules.AllowUserToAddRows = false;
            dataGridRules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRules.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridRules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridRules.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridRules.Dock = DockStyle.Fill;
            dataGridRules.Location = new Point(0, 0);
            dataGridRules.Margin = new Padding(3, 2, 3, 2);
            dataGridRules.Name = "dataGridRules";
            dataGridRules.RowHeadersWidth = 51;
            dataGridRules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRules.Size = new Size(915, 600);
            dataGridRules.TabIndex = 9;
            // 
            // btnDeleteRules
            // 
            btnDeleteRules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteRules.Location = new Point(13, 64);
            btnDeleteRules.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRules.Name = "btnDeleteRules";
            btnDeleteRules.Size = new Size(105, 22);
            btnDeleteRules.TabIndex = 11;
            btnDeleteRules.Text = "Удалить";
            btnDeleteRules.UseVisualStyleBackColor = true;
            btnDeleteRules.Click += btnDeleteRules_Click;
            // 
            // btnAddRules
            // 
            btnAddRules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRules.Location = new Point(13, 12);
            btnAddRules.Margin = new Padding(3, 2, 3, 2);
            btnAddRules.Name = "btnAddRules";
            btnAddRules.Size = new Size(105, 22);
            btnAddRules.TabIndex = 10;
            btnAddRules.Text = "Добавить";
            btnAddRules.UseVisualStyleBackColor = true;
            btnAddRules.Click += btnAddRules_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridRules);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(1050, 600);
            splitContainer1.SplitterDistance = 915;
            splitContainer1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddRules);
            flowLayoutPanel1.Controls.Add(btnEditRules);
            flowLayoutPanel1.Controls.Add(btnDeleteRules);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(131, 600);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // RulesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RulesControl";
            Size = new Size(1050, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridRules).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditRules;
        private DataGridView dataGridRules;
        private Button btnDeleteRules;
        private Button btnAddRules;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
