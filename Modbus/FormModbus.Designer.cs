namespace ExpertBase_v1

{
    partial class FormModbus
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridReg = new DataGridView();
            txtIpAddress = new TextBox();
            numPort = new NumericUpDown();
            labelAddrIP = new Label();
            labelPort = new Label();
            btnConnect = new Button();
            btnDisconnect = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridReg);
            panel1.Location = new Point(12, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 626);
            panel1.TabIndex = 0;
            // 
            // dataGridReg
            // 
            dataGridReg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridReg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridReg.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridReg.Dock = DockStyle.Fill;
            dataGridReg.Location = new Point(0, 0);
            dataGridReg.Name = "dataGridReg";
            dataGridReg.RowHeadersWidth = 51;
            dataGridReg.Size = new Size(958, 626);
            dataGridReg.TabIndex = 0;
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(24, 38);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(300, 27);
            txtIpAddress.TabIndex = 1;
            // 
            // numPort
            // 
            numPort.Location = new Point(379, 38);
            numPort.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(150, 27);
            numPort.TabIndex = 2;
            // 
            // labelAddrIP
            // 
            labelAddrIP.AutoSize = true;
            labelAddrIP.Location = new Point(24, 15);
            labelAddrIP.Name = "labelAddrIP";
            labelAddrIP.Size = new Size(126, 20);
            labelAddrIP.TabIndex = 3;
            labelAddrIP.Text = "IP адрес сервера";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(379, 15);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(44, 20);
            labelPort.TabIndex = 4;
            labelPort.Text = "Порт";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(596, 36);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(708, 37);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 6;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // FormModbus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(labelPort);
            Controls.Add(labelAddrIP);
            Controls.Add(numPort);
            Controls.Add(txtIpAddress);
            Controls.Add(panel1);
            Name = "FormModbus";
            Text = "Modbus";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridReg).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridReg;
        private TextBox txtIpAddress;
        private NumericUpDown numPort;
        private Label labelAddrIP;
        private Label labelPort;
        private Button btnConnect;
        private Button btnDisconnect;
    }
}