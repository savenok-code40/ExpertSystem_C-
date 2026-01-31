namespace ExpertBase_v1
{
    partial class FactForm
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
            labelObject = new Label();
            panel1 = new Panel();
            cmbAtribute = new ComboBox();
            btnCancel = new Button();
            cmbUnit = new ComboBox();
            btnOk = new Button();
            cmbObject = new ComboBox();
            labelType = new Label();
            cmbType = new ComboBox();
            numTruth = new NumericUpDown();
            labelTruth = new Label();
            labelValue = new Label();
            txtValue = new TextBox();
            labelAtribute = new Label();
            labelUnit = new Label();
            labelModbusFun = new Label();
            cmbModbusFun = new ComboBox();
            labelModbusReg = new Label();
            numModbusReg = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTruth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numModbusReg).BeginInit();
            SuspendLayout();
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(14, 8);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(62, 20);
            labelObject.TabIndex = 1;
            labelObject.Text = "Объект:";
            // 
            // panel1
            // 
            panel1.Controls.Add(numModbusReg);
            panel1.Controls.Add(labelModbusReg);
            panel1.Controls.Add(labelModbusFun);
            panel1.Controls.Add(cmbModbusFun);
            panel1.Controls.Add(cmbAtribute);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cmbUnit);
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(cmbObject);
            panel1.Controls.Add(labelType);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(numTruth);
            panel1.Controls.Add(labelTruth);
            panel1.Controls.Add(labelValue);
            panel1.Controls.Add(txtValue);
            panel1.Controls.Add(labelAtribute);
            panel1.Controls.Add(labelUnit);
            panel1.Controls.Add(labelObject);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 550);
            panel1.TabIndex = 2;
            // 
            // cmbAtribute
            // 
            cmbAtribute.FormattingEnabled = true;
            cmbAtribute.Location = new Point(14, 153);
            cmbAtribute.Name = "cmbAtribute";
            cmbAtribute.Size = new Size(332, 28);
            cmbAtribute.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(182, 505);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(14, 91);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(332, 28);
            cmbUnit.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(82, 505);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 13;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // cmbObject
            // 
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(14, 29);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(332, 28);
            cmbObject.TabIndex = 3;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(14, 316);
            labelType.Name = "labelType";
            labelType.Size = new Size(38, 20);
            labelType.TabIndex = 12;
            labelType.Text = "Тип:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(14, 337);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(331, 28);
            cmbType.TabIndex = 11;
            // 
            // numTruth
            // 
            numTruth.Location = new Point(13, 276);
            numTruth.Name = "numTruth";
            numTruth.Size = new Size(332, 27);
            numTruth.TabIndex = 10;
            // 
            // labelTruth
            // 
            labelTruth.AutoSize = true;
            labelTruth.Location = new Point(14, 252);
            labelTruth.Name = "labelTruth";
            labelTruth.Size = new Size(117, 20);
            labelTruth.TabIndex = 9;
            labelTruth.Text = "Достоверность:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(14, 191);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 20);
            labelValue.TabIndex = 7;
            labelValue.Text = "Значение:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(13, 215);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(332, 27);
            txtValue.TabIndex = 6;
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(14, 130);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(68, 20);
            labelAtribute.TabIndex = 5;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(14, 69);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(44, 20);
            labelUnit.TabIndex = 3;
            labelUnit.Text = "Узел:";
            // 
            // labelModbusFun
            // 
            labelModbusFun.AutoSize = true;
            labelModbusFun.Location = new Point(13, 377);
            labelModbusFun.Name = "labelModbusFun";
            labelModbusFun.Size = new Size(129, 20);
            labelModbusFun.TabIndex = 16;
            labelModbusFun.Text = "Modbus функция:";
            // 
            // cmbModbusFun
            // 
            cmbModbusFun.FormattingEnabled = true;
            cmbModbusFun.Location = new Point(13, 399);
            cmbModbusFun.Name = "cmbModbusFun";
            cmbModbusFun.Size = new Size(331, 28);
            cmbModbusFun.TabIndex = 15;
            // 
            // labelModbusReg
            // 
            labelModbusReg.AutoSize = true;
            labelModbusReg.Location = new Point(14, 438);
            labelModbusReg.Name = "labelModbusReg";
            labelModbusReg.Size = new Size(65, 20);
            labelModbusReg.TabIndex = 18;
            labelModbusReg.Text = "Регистр:";
            // 
            // numModbusReg
            // 
            numModbusReg.Location = new Point(14, 461);
            numModbusReg.Name = "numModbusReg";
            numModbusReg.Size = new Size(332, 27);
            numModbusReg.TabIndex = 19;
            // 
            // FactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 573);
            Controls.Add(panel1);
            Name = "FactForm";
            Text = "Добавление факта";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTruth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numModbusReg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelObject;
        private Panel panel1;
        private Label labelType;
        private ComboBox cmbType;
        private NumericUpDown numTruth;
        private Label labelTruth;
        private Label labelValue;
        private TextBox txtValue;
        private Label labelAtribute;
        private Label labelUnit;
        private Button btnCancel;
        private Button btnOk;
        private ComboBox cmbObject;
        private ComboBox cmbUnit;
        private ComboBox cmbAtribute;
        private Label labelModbusReg;
        private Label labelModbusFun;
        private ComboBox cmbModbusFun;
        private NumericUpDown numModbusReg;
    }
}