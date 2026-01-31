namespace ExpertBase_v1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnMoveDownFact = new Button();
            btnMoveUpFact = new Button();
            btnDeleteFact = new Button();
            btnAddFact = new Button();
            dataGridFacts = new DataGridView();
            btnEditFact = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridFacts).BeginInit();
            SuspendLayout();
            // 
            // btnMoveDownFact
            // 
            btnMoveDownFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoveDownFact.Location = new Point(1068, 111);
            btnMoveDownFact.Name = "btnMoveDownFact";
            btnMoveDownFact.Size = new Size(120, 30);
            btnMoveDownFact.TabIndex = 7;
            btnMoveDownFact.Text = "Вниз";
            btnMoveDownFact.UseVisualStyleBackColor = true;
            btnMoveDownFact.Click += btnMoveDownFact_Click;
            // 
            // btnMoveUpFact
            // 
            btnMoveUpFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoveUpFact.Location = new Point(1068, 75);
            btnMoveUpFact.Name = "btnMoveUpFact";
            btnMoveUpFact.Size = new Size(120, 30);
            btnMoveUpFact.TabIndex = 6;
            btnMoveUpFact.Text = "Вверх";
            btnMoveUpFact.UseVisualStyleBackColor = true;
            btnMoveUpFact.Click += btnMoveUpFact_Click;
            // 
            // btnDeleteFact
            // 
            btnDeleteFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteFact.Location = new Point(1068, 169);
            btnDeleteFact.Name = "btnDeleteFact";
            btnDeleteFact.Size = new Size(120, 30);
            btnDeleteFact.TabIndex = 3;
            btnDeleteFact.Text = "Удалить факт";
            btnDeleteFact.UseVisualStyleBackColor = true;
            btnDeleteFact.Click += btnDeleteFact_Click;
            // 
            // btnAddFact
            // 
            btnAddFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddFact.Location = new Point(1068, 3);
            btnAddFact.Name = "btnAddFact";
            btnAddFact.Size = new Size(120, 30);
            btnAddFact.TabIndex = 0;
            btnAddFact.Text = "Добавить факт";
            btnAddFact.UseVisualStyleBackColor = true;
            btnAddFact.Click += btnAddFact_Click;
            // 
            // dataGridFacts
            // 
            dataGridFacts.AllowUserToAddRows = false;
            dataGridFacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridFacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFacts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridFacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridFacts.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridFacts.Location = new Point(3, 3);
            dataGridFacts.Name = "dataGridFacts";
            dataGridFacts.RowHeadersWidth = 51;
            dataGridFacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFacts.Size = new Size(1050, 794);
            dataGridFacts.TabIndex = 0;
            // 
            // btnEditFact
            // 
            btnEditFact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditFact.Location = new Point(1068, 39);
            btnEditFact.Name = "btnEditFact";
            btnEditFact.Size = new Size(120, 30);
            btnEditFact.TabIndex = 8;
            btnEditFact.Text = "Редактировать";
            btnEditFact.UseVisualStyleBackColor = true;
            btnEditFact.Click += btnEditFact_Click;
            // 
            // FactsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnEditFact);
            Controls.Add(dataGridFacts);
            Controls.Add(btnMoveDownFact);
            Controls.Add(btnMoveUpFact);
            Controls.Add(btnDeleteFact);
            Controls.Add(btnAddFact);
            Name = "FactsControl";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridFacts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMoveDownFact;
        private Button btnMoveUpFact;
        private Button btnDeleteFact;
        private Button btnAddFact;
        private DataGridView dataGridFacts;
        private Button btnEditFact;
    }
}
