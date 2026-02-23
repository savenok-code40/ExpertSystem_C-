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
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 641);
            panel1.TabIndex = 3;
            // 
            // btnClearConclusion
            // 
            btnClearConclusion.Location = new Point(544, 314);
            btnClearConclusion.Margin = new Padding(3, 2, 3, 2);
            btnClearConclusion.Name = "btnClearConclusion";
            btnClearConclusion.Size = new Size(100, 30);
            btnClearConclusion.TabIndex = 41;
            btnClearConclusion.Text = "Очистить";
            btnClearConclusion.UseVisualStyleBackColor = true;
            btnClearConclusion.Click += btnClearConclusion_Click;
            // 
            // btnClearPremise
            // 
            btnClearPremise.Location = new Point(542, 211);
            btnClearPremise.Margin = new Padding(3, 2, 3, 2);
            btnClearPremise.Name = "btnClearPremise";
            btnClearPremise.Size = new Size(100, 30);
            btnClearPremise.TabIndex = 29;
            btnClearPremise.Text = "Очистить";
            btnClearPremise.UseVisualStyleBackColor = true;
            btnClearPremise.Click += btnClearPremise_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 374);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 40;
            label1.Text = "Добавить факт:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(353, 573);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 45);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Закрыть";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbValue
            // 
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(13, 526);
            cmbValue.Margin = new Padding(3, 2, 3, 2);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(391, 23);
            cmbValue.TabIndex = 37;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(13, 509);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(63, 15);
            labelValue.TabIndex = 36;
            labelValue.Text = "Значение:";
            // 
            // cmbAttribute
            // 
            cmbAttribute.FormattingEnabled = true;
            cmbAttribute.Location = new Point(12, 481);
            cmbAttribute.Margin = new Padding(3, 2, 3, 2);
            cmbAttribute.Name = "cmbAttribute";
            cmbAttribute.Size = new Size(391, 23);
            cmbAttribute.TabIndex = 33;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(12, 436);
            cmbUnit.Margin = new Padding(3, 2, 3, 2);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(391, 23);
            cmbUnit.TabIndex = 32;
            // 
            // cmbObject
            // 
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(12, 391);
            cmbObject.Margin = new Padding(3, 2, 3, 2);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(391, 23);
            cmbObject.TabIndex = 30;
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(12, 464);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(55, 15);
            labelAtribute.TabIndex = 34;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(12, 418);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(35, 15);
            labelUnit.TabIndex = 31;
            labelUnit.Text = "Узел:";
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(12, 374);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(50, 15);
            labelObject.TabIndex = 29;
            labelObject.Text = "Объект:";
            // 
            // richBoxConclusion
            // 
            richBoxConclusion.Location = new Point(12, 283);
            richBoxConclusion.Margin = new Padding(3, 2, 3, 2);
            richBoxConclusion.Name = "richBoxConclusion";
            richBoxConclusion.ReadOnly = true;
            richBoxConclusion.Size = new Size(526, 61);
            richBoxConclusion.TabIndex = 27;
            richBoxConclusion.Text = "";
            // 
            // labelConclusion
            // 
            labelConclusion.AutoSize = true;
            labelConclusion.Location = new Point(12, 266);
            labelConclusion.Name = "labelConclusion";
            labelConclusion.Size = new Size(79, 15);
            labelConclusion.TabIndex = 26;
            labelConclusion.Text = "Заключение:";
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
            // panel2
            // 
            panel2.Controls.Add(btnAddConclusion);
            panel2.Controls.Add(btnAddPremises);
            panel2.Location = new Point(424, 391);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 113);
            panel2.TabIndex = 39;
            // 
            // btnAddConclusion
            // 
            btnAddConclusion.Location = new Point(70, 64);
            btnAddConclusion.Margin = new Padding(3, 2, 3, 2);
            btnAddConclusion.Name = "btnAddConclusion";
            btnAddConclusion.Size = new Size(100, 30);
            btnAddConclusion.TabIndex = 28;
            btnAddConclusion.Text = "Заключение";
            btnAddConclusion.UseVisualStyleBackColor = true;
            btnAddConclusion.Click += btnAddConsequence_Click;
            // 
            // btnAddPremises
            // 
            btnAddPremises.Location = new Point(70, 18);
            btnAddPremises.Margin = new Padding(3, 2, 3, 2);
            btnAddPremises.Name = "btnAddPremises";
            btnAddPremises.Size = new Size(100, 30);
            btnAddPremises.TabIndex = 19;
            btnAddPremises.Text = "Посылка";
            btnAddPremises.UseVisualStyleBackColor = true;
            btnAddPremises.Click += btnAddCondition_Click;
            // 
            // richBoxCondition
            // 
            richBoxCondition.Location = new Point(12, 112);
            richBoxCondition.Margin = new Padding(3, 2, 3, 2);
            richBoxCondition.Name = "richBoxCondition";
            richBoxCondition.ReadOnly = true;
            richBoxCondition.Size = new Size(520, 140);
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
            btnOkRule.Location = new Point(211, 573);
            btnOkRule.Margin = new Padding(3, 2, 3, 2);
            btnOkRule.Name = "btnOkRule";
            btnOkRule.Size = new Size(105, 45);
            btnOkRule.TabIndex = 13;
            btnOkRule.Text = "Сохранить праило";
            btnOkRule.UseVisualStyleBackColor = true;
            btnOkRule.Click += btnOkRule_Click;
            // 
            // labelFact
            // 
            labelFact.AutoSize = true;
            labelFact.Location = new Point(12, 352);
            labelFact.Name = "labelFact";
            labelFact.Size = new Size(36, 15);
            labelFact.TabIndex = 12;
            labelFact.Text = "Факт:";
            // 
            // labelPremise
            // 
            labelPremise.AutoSize = true;
            labelPremise.Location = new Point(12, 94);
            labelPremise.Name = "labelPremise";
            labelPremise.Size = new Size(60, 15);
            labelPremise.TabIndex = 5;
            labelPremise.Text = "Посылка:";
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
            ClientSize = new Size(684, 661);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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