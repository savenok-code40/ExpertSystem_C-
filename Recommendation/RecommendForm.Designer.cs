namespace ExpertBase
{
    partial class RecommendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            cmbValue = new ComboBox();
            labelValue = new Label();
            cmbAtribute = new ComboBox();
            cmbUnit = new ComboBox();
            cmbObject = new ComboBox();
            labelAtribute = new Label();
            labelUnit = new Label();
            labelObject = new Label();
            richTextRecommendation = new RichTextBox();
            numPriority = new NumericUpDown();
            textBoxName = new TextBox();
            btnSaveRecommend = new Button();
            labelFact = new Label();
            labelPremise = new Label();
            labelTruth = new Label();
            labelDescription = new Label();
            panel1 = new Panel();
            btnConfirm = new Button();
            txtTargetFact = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPriority).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(240, 772);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 60);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Закрыть";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbValue
            // 
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(15, 716);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(294, 28);
            cmbValue.TabIndex = 37;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(15, 693);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 20);
            labelValue.TabIndex = 36;
            labelValue.Text = "Значение:";
            // 
            // cmbAtribute
            // 
            cmbAtribute.FormattingEnabled = true;
            cmbAtribute.Location = new Point(14, 656);
            cmbAtribute.Name = "cmbAtribute";
            cmbAtribute.Size = new Size(295, 28);
            cmbAtribute.TabIndex = 33;
            cmbAtribute.SelectedIndexChanged += cmbAtribute_SelectedIndexChanged;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(14, 596);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(295, 28);
            cmbUnit.TabIndex = 32;
            cmbUnit.SelectedIndexChanged += cmbUnit_SelectedIndexChanged;
            // 
            // cmbObject
            // 
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(14, 536);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(295, 28);
            cmbObject.TabIndex = 30;
            cmbObject.SelectedIndexChanged += cmbObject_SelectedIndexChanged;
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(14, 633);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(68, 20);
            labelAtribute.TabIndex = 34;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(14, 572);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(44, 20);
            labelUnit.TabIndex = 31;
            labelUnit.Text = "Узел:";
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(14, 513);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(62, 20);
            labelObject.TabIndex = 29;
            labelObject.Text = "Объект:";
            // 
            // richTextRecommendation
            // 
            richTextRecommendation.Location = new Point(14, 149);
            richTextRecommendation.Name = "richTextRecommendation";
            richTextRecommendation.Size = new Size(447, 223);
            richTextRecommendation.TabIndex = 18;
            richTextRecommendation.Text = "";
            // 
            // numPriority
            // 
            numPriority.Location = new Point(14, 89);
            numPriority.Name = "numPriority";
            numPriority.Size = new Size(447, 27);
            numPriority.TabIndex = 16;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(14, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(446, 27);
            textBoxName.TabIndex = 15;
            // 
            // btnSaveRecommend
            // 
            btnSaveRecommend.Location = new Point(101, 772);
            btnSaveRecommend.Name = "btnSaveRecommend";
            btnSaveRecommend.Size = new Size(120, 60);
            btnSaveRecommend.TabIndex = 13;
            btnSaveRecommend.Text = "Сохранить рекомендацию";
            btnSaveRecommend.UseVisualStyleBackColor = true;
            btnSaveRecommend.Click += btnSaveRecommend_Click;
            // 
            // labelFact
            // 
            labelFact.AutoSize = true;
            labelFact.Location = new Point(14, 484);
            labelFact.Name = "labelFact";
            labelFact.Size = new Size(306, 20);
            labelFact.TabIndex = 12;
            labelFact.Text = "Выбрать факт связанный с рекомендации:";
            // 
            // labelPremise
            // 
            labelPremise.AutoSize = true;
            labelPremise.Location = new Point(14, 125);
            labelPremise.Name = "labelPremise";
            labelPremise.Size = new Size(156, 20);
            labelPremise.TabIndex = 5;
            labelPremise.Text = "Текст рекомендации:";
            // 
            // labelTruth
            // 
            labelTruth.AutoSize = true;
            labelTruth.Location = new Point(14, 67);
            labelTruth.Name = "labelTruth";
            labelTruth.Size = new Size(88, 20);
            labelTruth.TabIndex = 3;
            labelTruth.Text = "Приоритет:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(14, 5);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(80, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Название:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(txtTargetFact);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cmbValue);
            panel1.Controls.Add(labelValue);
            panel1.Controls.Add(cmbAtribute);
            panel1.Controls.Add(cmbUnit);
            panel1.Controls.Add(cmbObject);
            panel1.Controls.Add(labelAtribute);
            panel1.Controls.Add(labelUnit);
            panel1.Controls.Add(labelObject);
            panel1.Controls.Add(richTextRecommendation);
            panel1.Controls.Add(numPriority);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(btnSaveRecommend);
            panel1.Controls.Add(labelFact);
            panel1.Controls.Add(labelPremise);
            panel1.Controls.Add(labelTruth);
            panel1.Controls.Add(labelDescription);
            panel1.Location = new Point(14, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 855);
            panel1.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(341, 536);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 60);
            btnConfirm.TabIndex = 41;
            btnConfirm.Text = "Подтвердить факт";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtTargetFact
            // 
            txtTargetFact.Location = new Point(17, 424);
            txtTargetFact.Name = "txtTargetFact";
            txtTargetFact.ReadOnly = true;
            txtTargetFact.Size = new Size(446, 27);
            txtTargetFact.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 400);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 39;
            label1.Text = "Связанный факт:";
            // 
            // RecommendForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(510, 881);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecommendForm";
            Text = "RecommendForm";
            ((System.ComponentModel.ISupportInitialize)numPriority).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancel;
        private ComboBox cmbValue;
        private Label labelValue;
        private ComboBox cmbAtribute;
        private ComboBox cmbUnit;
        private ComboBox cmbObject;
        private Label labelAtribute;
        private Label labelUnit;
        private Label labelObject;
        private RichTextBox richTextRecommendation;
        private NumericUpDown numPriority;
        private TextBox textBoxName;
        private Button btnSaveRecommend;
        private Label labelFact;
        private Label labelPremise;
        private Label labelTruth;
        private Label labelDescription;
        private Panel panel1;
        private TextBox txtTargetFact;
        private Label label1;
        private Button btnConfirm;
    }
}