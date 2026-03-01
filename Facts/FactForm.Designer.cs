namespace ExpertBase
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
            numModbusReg = new NumericUpDown();
            labelModbusReg = new Label();
            labelModbusFun = new Label();
            cmbModbusFun = new ComboBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numModbusReg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTruth).BeginInit();
            SuspendLayout();
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(12, 6);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(50, 15);
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
            panel1.Location = new Point(12, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 412);
            panel1.TabIndex = 2;
            // 
            // numModbusReg
            // 
            numModbusReg.Location = new Point(12, 346);
            numModbusReg.Margin = new Padding(3, 2, 3, 2);
            numModbusReg.Name = "numModbusReg";
            numModbusReg.Size = new Size(290, 23);
            numModbusReg.TabIndex = 19;
            // 
            // labelModbusReg
            // 
            labelModbusReg.AutoSize = true;
            labelModbusReg.Location = new Point(12, 328);
            labelModbusReg.Name = "labelModbusReg";
            labelModbusReg.Size = new Size(53, 15);
            labelModbusReg.TabIndex = 18;
            labelModbusReg.Text = "Регистр:";
            // 
            // labelModbusFun
            // 
            labelModbusFun.AutoSize = true;
            labelModbusFun.Location = new Point(11, 283);
            labelModbusFun.Name = "labelModbusFun";
            labelModbusFun.Size = new Size(105, 15);
            labelModbusFun.TabIndex = 16;
            labelModbusFun.Text = "Modbus функция:";
            // 
            // cmbModbusFun
            // 
            cmbModbusFun.FormattingEnabled = true;
            cmbModbusFun.Location = new Point(11, 299);
            cmbModbusFun.Margin = new Padding(3, 2, 3, 2);
            cmbModbusFun.Name = "cmbModbusFun";
            cmbModbusFun.Size = new Size(290, 23);
            cmbModbusFun.TabIndex = 15;
            // 
            // cmbAtribute
            // 
            cmbAtribute.FormattingEnabled = true;
            cmbAtribute.Location = new Point(12, 115);
            cmbAtribute.Margin = new Padding(3, 2, 3, 2);
            cmbAtribute.Name = "cmbAtribute";
            cmbAtribute.Size = new Size(291, 23);
            cmbAtribute.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(159, 379);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(12, 68);
            cmbUnit.Margin = new Padding(3, 2, 3, 2);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(291, 23);
            cmbUnit.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(72, 379);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 22);
            btnOk.TabIndex = 13;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // cmbObject
            // 
            cmbObject.FormattingEnabled = true;
            cmbObject.Location = new Point(12, 22);
            cmbObject.Margin = new Padding(3, 2, 3, 2);
            cmbObject.Name = "cmbObject";
            cmbObject.Size = new Size(291, 23);
            cmbObject.TabIndex = 3;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 237);
            labelType.Name = "labelType";
            labelType.Size = new Size(31, 15);
            labelType.TabIndex = 12;
            labelType.Text = "Тип:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(12, 253);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(290, 23);
            cmbType.TabIndex = 11;
            // 
            // numTruth
            // 
            numTruth.Location = new Point(11, 207);
            numTruth.Margin = new Padding(3, 2, 3, 2);
            numTruth.Name = "numTruth";
            numTruth.Size = new Size(290, 23);
            numTruth.TabIndex = 10;
            // 
            // labelTruth
            // 
            labelTruth.AutoSize = true;
            labelTruth.Location = new Point(12, 189);
            labelTruth.Name = "labelTruth";
            labelTruth.Size = new Size(93, 15);
            labelTruth.TabIndex = 9;
            labelTruth.Text = "Достоверность:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(12, 143);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(63, 15);
            labelValue.TabIndex = 7;
            labelValue.Text = "Значение:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(11, 161);
            txtValue.Margin = new Padding(3, 2, 3, 2);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(291, 23);
            txtValue.TabIndex = 6;
            // 
            // labelAtribute
            // 
            labelAtribute.AutoSize = true;
            labelAtribute.Location = new Point(12, 98);
            labelAtribute.Name = "labelAtribute";
            labelAtribute.Size = new Size(55, 15);
            labelAtribute.TabIndex = 5;
            labelAtribute.Text = "Атрибут:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(12, 52);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(35, 15);
            labelUnit.TabIndex = 3;
            labelUnit.Text = "Узел:";
            // 
            // FactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(334, 430);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FactForm";
            Text = "Добавление факта";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numModbusReg).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTruth).EndInit();
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