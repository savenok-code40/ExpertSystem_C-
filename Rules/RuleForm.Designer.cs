namespace ExpertBase_v1.Правила
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
            btnCancel = new Button();
            cmbValue = new ComboBox();
            labelValue = new Label();
            cmbAttribute = new ComboBox();
            cmbUnit = new ComboBox();
            cmbObject = new ComboBox();
            labelAtribute = new Label();
            labelUnit = new Label();
            labelObject = new Label();
            btnAddConsequence = new Button();
            richBoxConsequence = new RichTextBox();
            labelConsequence = new Label();
            btnEqual = new Button();
            btnLess = new Button();
            btnMore = new Button();
            btnNot = new Button();
            btnOr = new Button();
            btnAnd = new Button();
            btnAddCondition = new Button();
            richBoxCondition = new RichTextBox();
            numTruth = new NumericUpDown();
            textBoxDescription = new TextBox();
            btnOkRule = new Button();
            labelFact = new Label();
            labelCondition = new Label();
            labelTruth = new Label();
            labelDescription = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTruth).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cmbValue);
            panel1.Controls.Add(labelValue);
            panel1.Controls.Add(cmbAttribute);
            panel1.Controls.Add(cmbUnit);
            panel1.Controls.Add(cmbObject);
            panel1.Controls.Add(labelAtribute);
            panel1.Controls.Add(labelUnit);
            panel1.Controls.Add(labelObject);
            panel1.Controls.Add(btnAddConsequence);
            panel1.Controls.Add(richBoxConsequence);
            panel1.Controls.Add(labelConsequence);
            panel1.Controls.Add(btnEqual);
            panel1.Controls.Add(btnLess);
            panel1.Controls.Add(btnMore);
            panel1.Controls.Add(btnNot);
            panel1.Controls.Add(btnOr);
            panel1.Controls.Add(btnAnd);
            panel1.Controls.Add(btnAddCondition);
            panel1.Controls.Add(richBoxCondition);
            panel1.Controls.Add(numTruth);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(btnOkRule);
            panel1.Controls.Add(labelFact);
            panel1.Controls.Add(labelCondition);
            panel1.Controls.Add(labelTruth);
            panel1.Controls.Add(labelDescription);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 730);
            panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(620, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Закрыть";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbValue
            // 
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(15, 646);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(446, 28);
            cmbValue.TabIndex = 37;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(15, 623);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 20);
            labelValue.TabIndex = 36;
            labelValue.Text = "Значение:";
            // 
            // cmbAttribute
            // 
            cmbAttribute.FormattingEnabled = true;
            cmbAttribute.Location = new Point(14, 585);
            cmbAttribute.Name = "cmbAttribute";
            cmbAttribute.Size = new Size(446, 28);
            cmbAttribute.TabIndex = 33;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(14, 525);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(446, 28);
            cmbUnit.TabIndex = 32;
            // 
            // cmbObject
            // 
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(14, 465);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(446, 28);
            cmbObject.TabIndex = 30;
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(14, 562);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(68, 20);
            labelAtribute.TabIndex = 34;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(14, 502);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(44, 20);
            labelUnit.TabIndex = 31;
            labelUnit.Text = "Узел:";
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(14, 442);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(62, 20);
            labelObject.TabIndex = 29;
            labelObject.Text = "Объект:";
            // 
            // btnAddConsequence
            // 
            btnAddConsequence.Location = new Point(484, 546);
            btnAddConsequence.Name = "btnAddConsequence";
            btnAddConsequence.Size = new Size(130, 52);
            btnAddConsequence.TabIndex = 28;
            btnAddConsequence.Text = "Добавить в заключение";
            btnAddConsequence.UseVisualStyleBackColor = true;
            btnAddConsequence.Click += btnAddConsequence_Click;
            // 
            // richBoxConsequence
            // 
            richBoxConsequence.Location = new Point(14, 321);
            richBoxConsequence.Name = "richBoxConsequence";
            richBoxConsequence.Size = new Size(600, 80);
            richBoxConsequence.TabIndex = 27;
            richBoxConsequence.Text = "";
            // 
            // labelConsequence
            // 
            labelConsequence.AutoSize = true;
            labelConsequence.Location = new Point(14, 298);
            labelConsequence.Name = "labelConsequence";
            labelConsequence.Size = new Size(97, 20);
            labelConsequence.TabIndex = 26;
            labelConsequence.Text = "Заключение:";
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(686, 221);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(60, 30);
            btnEqual.TabIndex = 25;
            btnEqual.Text = "\"==\"";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnLess
            // 
            btnLess.Location = new Point(686, 185);
            btnLess.Name = "btnLess";
            btnLess.Size = new Size(60, 30);
            btnLess.TabIndex = 24;
            btnLess.Text = "\"<\"";
            btnLess.UseVisualStyleBackColor = true;
            btnLess.Click += btnLess_Click;
            // 
            // btnMore
            // 
            btnMore.Location = new Point(686, 149);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(60, 30);
            btnMore.TabIndex = 23;
            btnMore.Text = "\">\"";
            btnMore.UseVisualStyleBackColor = true;
            btnMore.Click += btnMore_Click;
            // 
            // btnNot
            // 
            btnNot.Location = new Point(620, 221);
            btnNot.Name = "btnNot";
            btnNot.Size = new Size(60, 30);
            btnNot.TabIndex = 22;
            btnNot.Text = "\"НЕ\"";
            btnNot.UseVisualStyleBackColor = true;
            btnNot.Click += btnNot_Click;
            // 
            // btnOr
            // 
            btnOr.Location = new Point(620, 185);
            btnOr.Name = "btnOr";
            btnOr.Size = new Size(60, 30);
            btnOr.TabIndex = 21;
            btnOr.Text = "\"ИЛИ\"";
            btnOr.UseVisualStyleBackColor = true;
            btnOr.Click += btnOr_Click;
            // 
            // btnAnd
            // 
            btnAnd.Location = new Point(620, 149);
            btnAnd.Name = "btnAnd";
            btnAnd.Size = new Size(60, 30);
            btnAnd.TabIndex = 20;
            btnAnd.Text = "\"И\"";
            btnAnd.UseVisualStyleBackColor = true;
            btnAnd.Click += btnAnd_Click;
            // 
            // btnAddCondition
            // 
            btnAddCondition.Location = new Point(484, 465);
            btnAddCondition.Name = "btnAddCondition";
            btnAddCondition.Size = new Size(130, 52);
            btnAddCondition.TabIndex = 19;
            btnAddCondition.Text = "Добавить в посылку";
            btnAddCondition.UseVisualStyleBackColor = true;
            btnAddCondition.Click += btnAddCondition_Click;
            // 
            // richBoxCondition
            // 
            richBoxCondition.Location = new Point(14, 149);
            richBoxCondition.Name = "richBoxCondition";
            richBoxCondition.Size = new Size(600, 140);
            richBoxCondition.TabIndex = 18;
            richBoxCondition.Text = "";
            // 
            // numTruth
            // 
            numTruth.Location = new Point(14, 89);
            numTruth.Name = "numTruth";
            numTruth.Size = new Size(700, 27);
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
            btnOkRule.Location = new Point(620, 319);
            btnOkRule.Name = "btnOkRule";
            btnOkRule.Size = new Size(120, 30);
            btnOkRule.TabIndex = 13;
            btnOkRule.Text = "Сохранить";
            btnOkRule.UseVisualStyleBackColor = true;
            btnOkRule.Click += btnOkRule_Click;
            // 
            // labelFact
            // 
            labelFact.AutoSize = true;
            labelFact.Location = new Point(14, 413);
            labelFact.Name = "labelFact";
            labelFact.Size = new Size(44, 20);
            labelFact.TabIndex = 12;
            labelFact.Text = "Факт:";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(14, 126);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(73, 20);
            labelCondition.TabIndex = 5;
            labelCondition.Text = "Посылка:";
            // 
            // labelTruth
            // 
            labelTruth.AutoSize = true;
            labelTruth.Location = new Point(14, 66);
            labelTruth.Name = "labelTruth";
            labelTruth.Size = new Size(117, 20);
            labelTruth.TabIndex = 3;
            labelTruth.Text = "Достоверность:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(14, 6);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(80, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Название:";
            // 
            // RuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(panel1);
            Name = "RuleForm";
            Text = "Добавление правил";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTruth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOkRule;
        private Label labelFact;
        private Label labelCondition;
        private Label labelTruth;
        private Label labelDescription;
        private NumericUpDown numTruth;
        private TextBox textBoxDescription;
        private Button btnAnd;
        private Button btnAddCondition;
        private RichTextBox richBoxCondition;
        private Button btnEqual;
        private Button btnLess;
        private Button btnMore;
        private Button btnNot;
        private Button btnOr;
        private RichTextBox richBoxConsequence;
        private Label labelConsequence;
        private Button btnAddConsequence;
        private ComboBox cmbAttribute;
        private ComboBox cmbUnit;
        private ComboBox cmbObject;
        private Label labelAtribute;
        private Label labelUnit;
        private Label labelObject;
        private Label labelValue;
        private ComboBox cmbValue;
        private Button btnCancel;
    }
}