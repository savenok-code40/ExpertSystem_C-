namespace ExpertBase.InferenceEngine
{
    partial class InferenceEngineControl
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
            cmbSelectTarget = new ComboBox();
            label1 = new Label();
            lsbInitFacts = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lsbWorkFacts = new ListBox();
            rtbOutputChain = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCheckTarget
            // 
            btnCheckTarget.Location = new Point(297, 30);
            btnCheckTarget.Name = "btnCheckTarget";
            btnCheckTarget.Size = new Size(130, 40);
            btnCheckTarget.TabIndex = 0;
            btnCheckTarget.Text = "Проверить цель";
            btnCheckTarget.UseVisualStyleBackColor = true;
            // 
            // cmbSelectTarget
            // 
            cmbSelectTarget.FormattingEnabled = true;
            cmbSelectTarget.Location = new Point(16, 30);
            cmbSelectTarget.Name = "cmbSelectTarget";
            cmbSelectTarget.Size = new Size(260, 23);
            cmbSelectTarget.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 8);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Выбрать цель:";
            // 
            // lsbInitFacts
            // 
            lsbInitFacts.FormattingEnabled = true;
            lsbInitFacts.ItemHeight = 15;
            lsbInitFacts.Location = new Point(16, 101);
            lsbInitFacts.Name = "lsbInitFacts";
            lsbInitFacts.Size = new Size(466, 124);
            lsbInitFacts.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 4;
            label2.Text = "База исходных фактов:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 247);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 6;
            label3.Text = "Факты в рабочей памяти:";
            // 
            // lsbWorkFacts
            // 
            lsbWorkFacts.FormattingEnabled = true;
            lsbWorkFacts.ItemHeight = 15;
            lsbWorkFacts.Location = new Point(18, 265);
            lsbWorkFacts.Name = "lsbWorkFacts";
            lsbWorkFacts.Size = new Size(464, 319);
            lsbWorkFacts.TabIndex = 5;
            // 
            // rtbOutputChain
            // 
            rtbOutputChain.Location = new Point(504, 30);
            rtbOutputChain.Name = "rtbOutputChain";
            rtbOutputChain.Size = new Size(522, 557);
            rtbOutputChain.TabIndex = 7;
            rtbOutputChain.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 10);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 8;
            label4.Text = "Цепочка вывода:";
            // 
            // InferenceEngineControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label4);
            Controls.Add(rtbOutputChain);
            Controls.Add(label3);
            Controls.Add(lsbWorkFacts);
            Controls.Add(label2);
            Controls.Add(lsbInitFacts);
            Controls.Add(label1);
            Controls.Add(cmbSelectTarget);
            Controls.Add(btnCheckTarget);
            Name = "InferenceEngineControl";
            Size = new Size(1050, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheckTarget;
        private ComboBox cmbSelectTarget;
        private Label label1;
        private ListBox lsbInitFacts;
        private Label label2;
        private Label label3;
        private ListBox lsbWorkFacts;
        private RichTextBox rtbOutputChain;
        private Label label4;
    }
}
