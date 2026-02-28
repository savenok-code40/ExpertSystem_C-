namespace ExpertBase
{
    partial class RecommendControl
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
            splitContainer1 = new SplitContainer();
            dataGridRecommend = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddRecommend = new Button();
            btnEditRecommend = new Button();
            btnDeleteRecommend = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRecommend).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(dataGridRecommend);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(1050, 600);
            splitContainer1.SplitterDistance = 915;
            splitContainer1.TabIndex = 16;
            // 
            // dataGridRecommend
            // 
            dataGridRecommend.AllowUserToAddRows = false;
            dataGridRecommend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRecommend.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridRecommend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridRecommend.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridRecommend.Dock = DockStyle.Fill;
            dataGridRecommend.Location = new Point(0, 0);
            dataGridRecommend.Margin = new Padding(3, 2, 3, 2);
            dataGridRecommend.Name = "dataGridRecommend";
            dataGridRecommend.RowHeadersWidth = 51;
            dataGridRecommend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRecommend.Size = new Size(915, 600);
            dataGridRecommend.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddRecommend);
            flowLayoutPanel1.Controls.Add(btnEditRecommend);
            flowLayoutPanel1.Controls.Add(btnDeleteRecommend);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(131, 600);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddRecommend
            // 
            btnAddRecommend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRecommend.Location = new Point(13, 12);
            btnAddRecommend.Margin = new Padding(3, 2, 3, 2);
            btnAddRecommend.Name = "btnAddRecommend";
            btnAddRecommend.Size = new Size(105, 22);
            btnAddRecommend.TabIndex = 10;
            btnAddRecommend.Text = "Добавить";
            btnAddRecommend.UseVisualStyleBackColor = true;
            btnAddRecommend.Click += btnAddRecommend_Click_1;
            // 
            // btnEditRecommend
            // 
            btnEditRecommend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditRecommend.Location = new Point(13, 38);
            btnEditRecommend.Margin = new Padding(3, 2, 3, 2);
            btnEditRecommend.Name = "btnEditRecommend";
            btnEditRecommend.Size = new Size(105, 22);
            btnEditRecommend.TabIndex = 14;
            btnEditRecommend.Text = "Редактировать";
            btnEditRecommend.UseVisualStyleBackColor = true;
            btnEditRecommend.Click += btnEditRecommend_Click;
            // 
            // btnDeleteRecommend
            // 
            btnDeleteRecommend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteRecommend.Location = new Point(13, 64);
            btnDeleteRecommend.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRecommend.Name = "btnDeleteRecommend";
            btnDeleteRecommend.Size = new Size(105, 22);
            btnDeleteRecommend.TabIndex = 11;
            btnDeleteRecommend.Text = "Удалить";
            btnDeleteRecommend.UseVisualStyleBackColor = true;
            btnDeleteRecommend.Click += btnDeleteRecommend_Click;
            // 
            // RecommendControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(splitContainer1);
            Name = "RecommendControl";
            Size = new Size(1050, 600);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridRecommend).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridRecommend;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAddRecommend;
        private Button btnEditRecommend;
        private Button btnDeleteRecommend;
    }
}
