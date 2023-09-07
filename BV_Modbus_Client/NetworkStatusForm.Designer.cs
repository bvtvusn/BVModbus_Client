namespace BV_Modbus_Client
{
    partial class NetworkStatusForm
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
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.btvClose = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.grpTCP = new System.Windows.Forms.GroupBox();
            this.grpRtu = new System.Windows.Forms.GroupBox();
            this.numDataBits = new System.Windows.Forms.NumericUpDown();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbConType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.grpTCP.SuspendLayout();
            this.grpRtu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataBits)).BeginInit();
            this.SuspendLayout();
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(121, 23);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(58, 23);
            this.numPort.TabIndex = 10;
            this.numPort.Value = new decimal(new int[] {
            502,
            0,
            0,
            0});
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 283);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(15, 22);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(100, 23);
            this.txtHostname.TabIndex = 11;
            this.txtHostname.Text = "127.0.0.1";
            this.txtHostname.TextChanged += new System.EventHandler(this.txtHostname_TextChanged);
            // 
            // btvClose
            // 
            this.btvClose.Location = new System.Drawing.Point(247, 333);
            this.btvClose.Name = "btvClose";
            this.btvClose.Size = new System.Drawing.Size(75, 23);
            this.btvClose.TabIndex = 9;
            this.btvClose.Text = "Close";
            this.btvClose.UseVisualStyleBackColor = true;
            this.btvClose.Click += new System.EventHandler(this.btvClose_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(90, 283);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(171, 287);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(101, 15);
            this.lblConnectionStatus.TabIndex = 12;
            this.lblConnectionStatus.Text = "ConnectionStatus";
            // 
            // grpTCP
            // 
            this.grpTCP.Controls.Add(this.txtHostname);
            this.grpTCP.Controls.Add(this.numPort);
            this.grpTCP.Location = new System.Drawing.Point(9, 43);
            this.grpTCP.Name = "grpTCP";
            this.grpTCP.Size = new System.Drawing.Size(314, 58);
            this.grpTCP.TabIndex = 13;
            this.grpTCP.TabStop = false;
            this.grpTCP.Text = "Modbus TCP";
            // 
            // grpRtu
            // 
            this.grpRtu.Controls.Add(this.numDataBits);
            this.grpRtu.Controls.Add(this.cmbStopBits);
            this.grpRtu.Controls.Add(this.cmbParity);
            this.grpRtu.Controls.Add(this.label4);
            this.grpRtu.Controls.Add(this.label3);
            this.grpRtu.Controls.Add(this.label2);
            this.grpRtu.Controls.Add(this.label5);
            this.grpRtu.Controls.Add(this.label1);
            this.grpRtu.Controls.Add(this.cmbSerialPorts);
            this.grpRtu.Controls.Add(this.cmbBaud);
            this.grpRtu.Location = new System.Drawing.Point(9, 118);
            this.grpRtu.Name = "grpRtu";
            this.grpRtu.Size = new System.Drawing.Size(314, 158);
            this.grpRtu.TabIndex = 14;
            this.grpRtu.TabStop = false;
            this.grpRtu.Text = "Modbus RTU";
            // 
            // numDataBits
            // 
            this.numDataBits.Location = new System.Drawing.Point(89, 120);
            this.numDataBits.Name = "numDataBits";
            this.numDataBits.Size = new System.Drawing.Size(120, 23);
            this.numDataBits.TabIndex = 3;
            this.numDataBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(88, 95);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 23);
            this.cmbStopBits.TabIndex = 2;
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(88, 70);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 23);
            this.cmbParity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stop Bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Serial port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baud rate:";
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cmbSerialPorts.Location = new System.Drawing.Point(88, 19);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 23);
            this.cmbSerialPorts.TabIndex = 0;
            this.cmbSerialPorts.Text = "115200";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cmbBaud.Location = new System.Drawing.Point(88, 45);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 23);
            this.cmbBaud.TabIndex = 0;
            this.cmbBaud.Text = "115200";
            // 
            // cmbConType
            // 
            this.cmbConType.FormattingEnabled = true;
            this.cmbConType.Items.AddRange(new object[] {
            "Modbus TCP",
            "Modbus RTU"});
            this.cmbConType.Location = new System.Drawing.Point(9, 9);
            this.cmbConType.Name = "cmbConType";
            this.cmbConType.Size = new System.Drawing.Size(121, 23);
            this.cmbConType.TabIndex = 15;
            this.cmbConType.Text = "Modbus TCP_";
            this.cmbConType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NetworkStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 368);
            this.Controls.Add(this.cmbConType);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.grpRtu);
            this.Controls.Add(this.grpTCP);
            this.Controls.Add(this.btvClose);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "NetworkStatusForm";
            this.Text = "NetworkStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.grpTCP.ResumeLayout(false);
            this.grpTCP.PerformLayout();
            this.grpRtu.ResumeLayout(false);
            this.grpRtu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataBits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numPort;
        private Button btnConnect;
        private TextBox txtHostname;
        private Button btvClose;
        private Button btnDisconnect;
        private Label lblConnectionStatus;
        private GroupBox grpTCP;
        private GroupBox grpRtu;
        private ComboBox cmbConType;
        private ComboBox cmbStopBits;
        private ComboBox cmbParity;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbBaud;
        private NumericUpDown numDataBits;
        private Label label5;
        private ComboBox cmbSerialPorts;
    }
}