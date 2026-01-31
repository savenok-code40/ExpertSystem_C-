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
            ((System.ComponentModel.ISupportInitialize)dataGridRules).BeginInit();
            SuspendLayout();
            // 
            // btnEditRules
            // 
            btnEditRules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditRules.Location = new Point(1073, 75);
            btnEditRules.Name = "btnEditRules";
            btnEditRules.Size = new Size(120, 30);
            btnEditRules.TabIndex = 14;
            btnEditRules.Text = "Редактировать";
            btnEditRules.UseVisualStyleBackColor = true;
            btnEditRules.Click += btnEditRules_Click;
            // 
            // dataGridRules
            // 
            dataGridRules.AllowUserToAddRows = false;
            dataGridRules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridRules.Location = new Point(8, 3);
            dataGridRules.Name = "dataGridRules";
            dataGridRules.RowHeadersWidth = 51;
            dataGridRules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRules.Size = new Size(1050, 794);
            dataGridRules.TabIndex = 9;
            // 
            // btnDeleteRules
            // 
            btnDeleteRules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteRules.Location = new Point(1073, 39);
            btnDeleteRules.Name = "btnDeleteRules";
            btnDeleteRules.Size = new Size(120, 30);
            btnDeleteRules.TabIndex = 11;
            btnDeleteRules.Text = "Удалить";
            btnDeleteRules.UseVisualStyleBackColor = true;
            btnDeleteRules.Click += btnDeleteRules_Click;
            // 
            // btnAddRules
            // 
            btnAddRules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRules.Location = new Point(1073, 3);
            btnAddRules.Name = "btnAddRules";
            btnAddRules.Size = new Size(120, 30);
            btnAddRules.TabIndex = 10;
            btnAddRules.Text = "Добавить";
            btnAddRules.UseVisualStyleBackColor = true;
            btnAddRules.Click += btnAddRules_Click;
            // 
            // RulesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnEditRules);
            Controls.Add(dataGridRules);
            Controls.Add(btnDeleteRules);
            Controls.Add(btnAddRules);
            Name = "RulesControl";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridRules).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditRules;
        private DataGridView dataGridRules;
        private Button btnDeleteRules;
        private Button btnAddRules;
    }
}
