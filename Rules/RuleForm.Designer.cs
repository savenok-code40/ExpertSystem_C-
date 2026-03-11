namespace ExpertBase.Правила
{
    partial class RuleForm
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
            panel1 = new Panel();
            btnClearConclusion = new Button();
            btnClearPremise = new Button();
            label1 = new Label();
            btnCancel = new Button();
            cmbValue = new ComboBox();
            labelValue = new Label();
            cmbAttribute = new ComboBox();
            cmbUnit = new ComboBox();
            cmbObject = new ComboBox();
            labelAtribute = new Label();
            labelUnit = new Label();
            labelObject = new Label();
            richBoxConclusion = new RichTextBox();
            labelConclusion = new Label();
            btnEqual = new Button();
            btnLess = new Button();
            btnMore = new Button();
            btnNot = new Button();
            btnOr = new Button();
            btnAnd = new Button();
            panel2 = new Panel();
            btnAddConclusion = new Button();
            btnAddPremises = new Button();
            richBoxCondition = new RichTextBox();
            numTruth = new NumericUpDown();
            textBoxDescription = new TextBox();
            btnOkRule = new Button();
            labelFact = new Label();
            labelPremise = new Label();
            labelTruth = new Label();
            labelDescription = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTruth).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClearConclusion);
            panel1.Controls.Add(btnClearPremise);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cmbValue);
            panel1.Controls.Add(labelValue);
            panel1.Controls.Add(cmbAttribute);
            panel1.Controls.Add(cmbUnit);
            panel1.Controls.Add(cmbObject);
            panel1.Controls.Add(labelAtribute);
            panel1.Controls.Add(labelUnit);
            panel1.Controls.Add(labelObject);
            panel1.Controls.Add(richBoxConclusion);
            panel1.Controls.Add(labelConclusion);
            panel1.Controls.Add(btnEqual);
            panel1.Controls.Add(btnLess);
            panel1.Controls.Add(btnMore);
            panel1.Controls.Add(btnNot);
            panel1.Controls.Add(btnOr);
            panel1.Controls.Add(btnAnd);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(richBoxCondition);
            panel1.Controls.Add(numTruth);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(btnOkRule);
            panel1.Controls.Add(labelFact);
            panel1.Controls.Add(labelPremise);
            panel1.Controls.Add(labelTruth);
            panel1.Controls.Add(labelDescription);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 855);
            panel1.TabIndex = 3;
            // 
            // btnClearConclusion
            // 
            btnClearConclusion.Location = new Point(622, 419);
            btnClearConclusion.Name = "btnClearConclusion";
            btnClearConclusion.Size = new Size(114, 40);
            btnClearConclusion.TabIndex = 41;
            btnClearConclusion.Text = "Очистить";
            btnClearConclusion.UseVisualStyleBackColor = true;
            btnClearConclusion.Click += btnClearConclusion_Click;
            // 
            // btnClearPremise
            // 
            btnClearPremise.Location = new Point(619, 281);
            btnClearPremise.Name = "btnClearPremise";
            btnClearPremise.Size = new Size(114, 40);
            btnClearPremise.TabIndex = 29;
            btnClearPremise.Text = "Очистить";
            btnClearPremise.UseVisualStyleBackColor = true;
            btnClearPremise.Click += btnClearPremise_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 499);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 40;
            label1.Text = "Добавить факт:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(403, 764);
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
            cmbValue.Location = new Point(15, 701);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(446, 28);
            cmbValue.TabIndex = 37;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(15, 679);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 20);
            labelValue.TabIndex = 36;
            labelValue.Text = "Значение:";
            // 
            // cmbAttribute
            // 
            cmbAttribute.FormattingEnabled = true;
            cmbAttribute.Location = new Point(14, 641);
            cmbAttribute.Name = "cmbAttribute";
            cmbAttribute.Size = new Size(446, 28);
            cmbAttribute.TabIndex = 33;
            cmbAttribute.SelectedIndexChanged += cmbAttribute_SelectedIndexChanged;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(14, 581);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(446, 28);
            cmbUnit.TabIndex = 32;
            cmbUnit.SelectedIndexChanged += cmbUnit_SelectedIndexChanged;
            // 
            // cmbObject
            // 
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(14, 521);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(446, 28);
            cmbObject.TabIndex = 30;
            cmbObject.SelectedIndexChanged += cmbObject_SelectedIndexChanged;
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(14, 619);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(68, 20);
            labelAtribute.TabIndex = 34;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(14, 557);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(44, 20);
            labelUnit.TabIndex = 31;
            labelUnit.Text = "Узел:";
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(14, 499);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(62, 20);
            labelObject.TabIndex = 29;
            labelObject.Text = "Объект:";
            // 
            // richBoxConclusion
            // 
            richBoxConclusion.Location = new Point(14, 377);
            richBoxConclusion.Name = "richBoxConclusion";
            richBoxConclusion.ReadOnly = true;
            richBoxConclusion.Size = new Size(601, 80);
            richBoxConclusion.TabIndex = 27;
            richBoxConclusion.Text = "";
            // 
            // labelConclusion
            // 
            labelConclusion.AutoSize = true;
            labelConclusion.Location = new Point(14, 355);
            labelConclusion.Name = "labelConclusion";
            labelConclusion.Size = new Size(97, 20);
            labelConclusion.TabIndex = 26;
            labelConclusion.Text = "Заключение:";
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(686, 221);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(59, 29);
            btnEqual.TabIndex = 25;
            btnEqual.Text = "\"==\"";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnLess
            // 
            btnLess.Location = new Point(686, 185);
            btnLess.Name = "btnLess";
            btnLess.Size = new Size(59, 29);
            btnLess.TabIndex = 24;
            btnLess.Text = "\"<\"";
            btnLess.UseVisualStyleBackColor = true;
            btnLess.Click += btnLess_Click;
            // 
            // btnMore
            // 
            btnMore.Location = new Point(686, 149);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(59, 29);
            btnMore.TabIndex = 23;
            btnMore.Text = "\">\"";
            btnMore.UseVisualStyleBackColor = true;
            btnMore.Click += btnMore_Click;
            // 
            // btnNot
            // 
            btnNot.Location = new Point(619, 221);
            btnNot.Name = "btnNot";
            btnNot.Size = new Size(59, 29);
            btnNot.TabIndex = 22;
            btnNot.Text = "\"НЕ\"";
            btnNot.UseVisualStyleBackColor = true;
            btnNot.Click += btnNot_Click;
            // 
            // btnOr
            // 
            btnOr.Location = new Point(619, 185);
            btnOr.Name = "btnOr";
            btnOr.Size = new Size(59, 29);
            btnOr.TabIndex = 21;
            btnOr.Text = "\"ИЛИ\"";
            btnOr.UseVisualStyleBackColor = true;
            btnOr.Click += btnOr_Click;
            // 
            // btnAnd
            // 
            btnAnd.Location = new Point(619, 149);
            btnAnd.Name = "btnAnd";
            btnAnd.Size = new Size(59, 29);
            btnAnd.TabIndex = 20;
            btnAnd.Text = "\"И\"";
            btnAnd.UseVisualStyleBackColor = true;
            btnAnd.Click += btnAnd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddConclusion);
            panel2.Controls.Add(btnAddPremises);
            panel2.Location = new Point(485, 521);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 151);
            panel2.TabIndex = 39;
            // 
            // btnAddConclusion
            // 
            btnAddConclusion.Location = new Point(80, 85);
            btnAddConclusion.Name = "btnAddConclusion";
            btnAddConclusion.Size = new Size(114, 40);
            btnAddConclusion.TabIndex = 28;
            btnAddConclusion.Text = "Заключение";
            btnAddConclusion.UseVisualStyleBackColor = true;
            btnAddConclusion.Click += btnAddConsequence_Click;
            // 
            // btnAddPremises
            // 
            btnAddPremises.Location = new Point(80, 24);
            btnAddPremises.Name = "btnAddPremises";
            btnAddPremises.Size = new Size(114, 40);
            btnAddPremises.TabIndex = 19;
            btnAddPremises.Text = "Посылка";
            btnAddPremises.UseVisualStyleBackColor = true;
            btnAddPremises.Click += btnAddCondition_Click;
            // 
            // richBoxCondition
            // 
            richBoxCondition.Location = new Point(14, 149);
            richBoxCondition.Name = "richBoxCondition";
            richBoxCondition.ReadOnly = true;
            richBoxCondition.Size = new Size(594, 185);
            richBoxCondition.TabIndex = 18;
            richBoxCondition.Text = "";
            // 
            // numTruth
            // 
            numTruth.Location = new Point(14, 89);
            numTruth.Name = "numTruth";
            numTruth.Size = new Size(699, 27);
            numTruth.TabIndex = 16;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(14, 29);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(700, 27);
            textBoxDescription.TabIndex = 15;
            // 
            // btnOkRule
            // 
            btnOkRule.Location = new Point(241, 764);
            btnOkRule.Name = "btnOkRule";
            btnOkRule.Size = new Size(120, 60);
            btnOkRule.TabIndex = 13;
            btnOkRule.Text = "Сохранить праило";
            btnOkRule.UseVisualStyleBackColor = true;
            btnOkRule.Click += btnOkRule_Click;
            // 
            // labelFact
            // 
            labelFact.AutoSize = true;
            labelFact.Location = new Point(14, 469);
            labelFact.Name = "labelFact";
            labelFact.Size = new Size(44, 20);
            labelFact.TabIndex = 12;
            labelFact.Text = "Факт:";
            // 
            // labelPremise
            // 
            labelPremise.AutoSize = true;
            labelPremise.Location = new Point(14, 125);
            labelPremise.Name = "labelPremise";
            labelPremise.Size = new Size(73, 20);
            labelPremise.TabIndex = 5;
            labelPremise.Text = "Посылка:";
            // 
            // labelTruth
            // 
            labelTruth.AutoSize = true;
            labelTruth.Location = new Point(14, 67);
            labelTruth.Name = "labelTruth";
            labelTruth.Size = new Size(117, 20);
            labelTruth.TabIndex = 3;
            labelTruth.Text = "Достоверность:";
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
            // RuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(782, 881);
            Controls.Add(panel1);
            Name = "RuleForm";
            Text = "Добавление правил";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numTruth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOkRule;
        private Label labelFact;
        private Label labelPremise;
        private Label labelTruth;
        private Label labelDescription;
        private NumericUpDown numTruth;
        private TextBox textBoxDescription;
        private Button btnAnd;
        private Button btnAddPremises;
        private RichTextBox richBoxCondition;
        private Button btnEqual;
        private Button btnLess;
        private Button btnMore;
        private Button btnNot;
        private Button btnOr;
        private RichTextBox richBoxConclusion;
        private Label labelConclusion;
        private Button btnAddConclusion;
        private ComboBox cmbAttribute;
        private ComboBox cmbUnit;
        private ComboBox cmbObject;
        private Label labelAtribute;
        private Label labelUnit;
        private Label labelObject;
        private Label labelValue;
        private ComboBox cmbValue;
        private Button btnCancel;
        private Panel panel2;
        private Button btnClearPremise;
        private Label label1;
        private Button btnClearConclusion;
    }
}