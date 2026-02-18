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
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 548);
            panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(542, 278);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 22);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Закрыть";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbValue
            // 
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(13, 484);
            cmbValue.Margin = new Padding(3, 2, 3, 2);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(391, 23);
            cmbValue.TabIndex = 37;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(13, 467);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(63, 15);
            labelValue.TabIndex = 36;
            labelValue.Text = "Значение:";
            // 
            // cmbAttribute
            // 
            cmbAttribute.FormattingEnabled = true;
            cmbAttribute.Location = new Point(12, 439);
            cmbAttribute.Margin = new Padding(3, 2, 3, 2);
            cmbAttribute.Name = "cmbAttribute";
            cmbAttribute.Size = new Size(391, 23);
            cmbAttribute.TabIndex = 33;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(12, 394);
            cmbUnit.Margin = new Padding(3, 2, 3, 2);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(391, 23);
            cmbUnit.TabIndex = 32;
            // 
            // cmbObject
            // 
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(12, 349);
            cmbObject.Margin = new Padding(3, 2, 3, 2);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(391, 23);
            cmbObject.TabIndex = 30;
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(12, 422);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(55, 15);
            labelAtribute.TabIndex = 34;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(12, 376);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(35, 15);
            labelUnit.TabIndex = 31;
            labelUnit.Text = "Узел:";
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(12, 332);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(50, 15);
            labelObject.TabIndex = 29;
            labelObject.Text = "Объект:";
            // 
            // btnAddConsequence
            // 
            btnAddConsequence.Location = new Point(424, 410);
            btnAddConsequence.Margin = new Padding(3, 2, 3, 2);
            btnAddConsequence.Name = "btnAddConsequence";
            btnAddConsequence.Size = new Size(114, 39);
            btnAddConsequence.TabIndex = 28;
            btnAddConsequence.Text = "Заключение";
            btnAddConsequence.UseVisualStyleBackColor = true;
            btnAddConsequence.Click += btnAddConsequence_Click;
            // 
            // richBoxConsequence
            // 
            richBoxConsequence.Location = new Point(12, 241);
            richBoxConsequence.Margin = new Padding(3, 2, 3, 2);
            richBoxConsequence.Name = "richBoxConsequence";
            richBoxConsequence.Size = new Size(526, 61);
            richBoxConsequence.TabIndex = 27;
            richBoxConsequence.Text = "";
            // 
            // labelConsequence
            // 
            labelConsequence.AutoSize = true;
            labelConsequence.Location = new Point(12, 224);
            labelConsequence.Name = "labelConsequence";
            labelConsequence.Size = new Size(79, 15);
            labelConsequence.TabIndex = 26;
            labelConsequence.Text = "Заключение:";
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(600, 166);
            btnEqual.Margin = new Padding(3, 2, 3, 2);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(52, 22);
            btnEqual.TabIndex = 25;
            btnEqual.Text = "\"==\"";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnLess
            // 
            btnLess.Location = new Point(600, 139);
            btnLess.Margin = new Padding(3, 2, 3, 2);
            btnLess.Name = "btnLess";
            btnLess.Size = new Size(52, 22);
            btnLess.TabIndex = 24;
            btnLess.Text = "\"<\"";
            btnLess.UseVisualStyleBackColor = true;
            btnLess.Click += btnLess_Click;
            // 
            // btnMore
            // 
            btnMore.Location = new Point(600, 112);
            btnMore.Margin = new Padding(3, 2, 3, 2);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(52, 22);
            btnMore.TabIndex = 23;
            btnMore.Text = "\">\"";
            btnMore.UseVisualStyleBackColor = true;
            btnMore.Click += btnMore_Click;
            // 
            // btnNot
            // 
            btnNot.Location = new Point(542, 166);
            btnNot.Margin = new Padding(3, 2, 3, 2);
            btnNot.Name = "btnNot";
            btnNot.Size = new Size(52, 22);
            btnNot.TabIndex = 22;
            btnNot.Text = "\"НЕ\"";
            btnNot.UseVisualStyleBackColor = true;
            btnNot.Click += btnNot_Click;
            // 
            // btnOr
            // 
            btnOr.Location = new Point(542, 139);
            btnOr.Margin = new Padding(3, 2, 3, 2);
            btnOr.Name = "btnOr";
            btnOr.Size = new Size(52, 22);
            btnOr.TabIndex = 21;
            btnOr.Text = "\"ИЛИ\"";
            btnOr.UseVisualStyleBackColor = true;
            btnOr.Click += btnOr_Click;
            // 
            // btnAnd
            // 
            btnAnd.Location = new Point(542, 112);
            btnAnd.Margin = new Padding(3, 2, 3, 2);
            btnAnd.Name = "btnAnd";
            btnAnd.Size = new Size(52, 22);
            btnAnd.TabIndex = 20;
            btnAnd.Text = "\"И\"";
            btnAnd.UseVisualStyleBackColor = true;
            btnAnd.Click += btnAnd_Click;
            // 
            // btnAddCondition
            // 
            btnAddCondition.Location = new Point(424, 349);
            btnAddCondition.Margin = new Padding(3, 2, 3, 2);
            btnAddCondition.Name = "btnAddCondition";
            btnAddCondition.Size = new Size(114, 39);
            btnAddCondition.TabIndex = 19;
            btnAddCondition.Text = "Посылка";
            btnAddCondition.UseVisualStyleBackColor = true;
            btnAddCondition.Click += btnAddCondition_Click;
            // 
            // richBoxCondition
            // 
            richBoxCondition.Location = new Point(12, 112);
            richBoxCondition.Margin = new Padding(3, 2, 3, 2);
            richBoxCondition.Name = "richBoxCondition";
            richBoxCondition.Size = new Size(526, 106);
            richBoxCondition.TabIndex = 18;
            richBoxCondition.Text = "";
            // 
            // numTruth
            // 
            numTruth.Location = new Point(12, 67);
            numTruth.Margin = new Padding(3, 2, 3, 2);
            numTruth.Name = "numTruth";
            numTruth.Size = new Size(612, 23);
            numTruth.TabIndex = 16;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 22);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(613, 23);
            textBoxDescription.TabIndex = 15;
            // 
            // btnOkRule
            // 
            btnOkRule.Location = new Point(542, 239);
            btnOkRule.Margin = new Padding(3, 2, 3, 2);
            btnOkRule.Name = "btnOkRule";
            btnOkRule.Size = new Size(105, 22);
            btnOkRule.TabIndex = 13;
            btnOkRule.Text = "Сохранить";
            btnOkRule.UseVisualStyleBackColor = true;
            btnOkRule.Click += btnOkRule_Click;
            // 
            // labelFact
            // 
            labelFact.AutoSize = true;
            labelFact.Location = new Point(12, 310);
            labelFact.Name = "labelFact";
            labelFact.Size = new Size(36, 15);
            labelFact.TabIndex = 12;
            labelFact.Text = "Факт:";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(12, 94);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(60, 15);
            labelCondition.TabIndex = 5;
            labelCondition.Text = "Посылка:";
            // 
            // labelTruth
            // 
            labelTruth.AutoSize = true;
            labelTruth.Location = new Point(12, 50);
            labelTruth.Name = "labelTruth";
            labelTruth.Size = new Size(93, 15);
            labelTruth.TabIndex = 3;
            labelTruth.Text = "Достоверность:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 4);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(62, 15);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Название:";
            // 
            // RuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 565);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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