namespace BV_Modbus_Client
{
    partial class ValueFormatPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnApplyFloatFormatting = new System.Windows.Forms.Button();
            this.cboFloatFormat = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSwapRegisters = new System.Windows.Forms.CheckBox();
            this.chkSwapBytes = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnASCII = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUint16 = new System.Windows.Forms.Button();
            this.numBinary = new System.Windows.Forms.NumericUpDown();
            this.numAscii = new System.Windows.Forms.NumericUpDown();
            this.numHex = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAscii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHex)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(319, 366);
            this.dataGridView1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyValuesToolStripMenuItem,
            this.pasteValuesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // copyValuesToolStripMenuItem
            // 
            this.copyValuesToolStripMenuItem.Name = "copyValuesToolStripMenuItem";
            this.copyValuesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyValuesToolStripMenuItem.Text = "Copy values";
            this.copyValuesToolStripMenuItem.Click += new System.EventHandler(this.copyValuesToolStripMenuItem_Click);
            // 
            // pasteValuesToolStripMenuItem
            // 
            this.pasteValuesToolStripMenuItem.Name = "pasteValuesToolStripMenuItem";
            this.pasteValuesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pasteValuesToolStripMenuItem.Text = "Paste values";
            this.pasteValuesToolStripMenuItem.Click += new System.EventHandler(this.pasteValuesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(319, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 366);
            this.panel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnApplyFloatFormatting);
            this.groupBox3.Controls.Add(this.cboFloatFormat);
            this.groupBox3.Location = new System.Drawing.Point(15, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 47);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Floating point formatting";
            // 
            // btnApplyFloatFormatting
            // 
            this.btnApplyFloatFormatting.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.RefreshIconTransparent;
            this.btnApplyFloatFormatting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApplyFloatFormatting.FlatAppearance.BorderSize = 0;
            this.btnApplyFloatFormatting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFloatFormatting.Location = new System.Drawing.Point(167, 18);
            this.btnApplyFloatFormatting.Name = "btnApplyFloatFormatting";
            this.btnApplyFloatFormatting.Size = new System.Drawing.Size(20, 20);
            this.btnApplyFloatFormatting.TabIndex = 20;
            this.btnApplyFloatFormatting.UseVisualStyleBackColor = true;
            this.btnApplyFloatFormatting.Click += new System.EventHandler(this.btnApplyFloatFormatting_Click);
            // 
            // cboFloatFormat
            // 
            this.cboFloatFormat.FormattingEnabled = true;
            this.cboFloatFormat.Items.AddRange(new object[] {
            "G",
            "E",
            "N2",
            "F2",
            "0.###",
            "0.0",
            "0.00",
            "0.000",
            "0.0E+0",
            "0.00 \'m/s^2\'"});
            this.cboFloatFormat.Location = new System.Drawing.Point(17, 17);
            this.cboFloatFormat.Name = "cboFloatFormat";
            this.cboFloatFormat.Size = new System.Drawing.Size(147, 23);
            this.cboFloatFormat.TabIndex = 6;
            this.cboFloatFormat.Text = "0.0";
            this.cboFloatFormat.TextUpdate += new System.EventHandler(this.cboFloatFormat_TextUpdate);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSwapRegisters);
            this.groupBox2.Controls.Add(this.chkSwapBytes);
            this.groupBox2.Location = new System.Drawing.Point(15, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endian";
            // 
            // chkSwapRegisters
            // 
            this.chkSwapRegisters.AutoSize = true;
            this.chkSwapRegisters.Location = new System.Drawing.Point(19, 36);
            this.chkSwapRegisters.Name = "chkSwapRegisters";
            this.chkSwapRegisters.Size = new System.Drawing.Size(101, 19);
            this.chkSwapRegisters.TabIndex = 0;
            this.chkSwapRegisters.Tag = "registerOrder";
            this.chkSwapRegisters.Text = "SwapRegisters";
            this.chkSwapRegisters.UseVisualStyleBackColor = true;
            this.chkSwapRegisters.CheckedChanged += new System.EventHandler(this.ByteOrder_CheckedChanged);
            // 
            // chkSwapBytes
            // 
            this.chkSwapBytes.AutoSize = true;
            this.chkSwapBytes.Location = new System.Drawing.Point(19, 18);
            this.chkSwapBytes.Name = "chkSwapBytes";
            this.chkSwapBytes.Size = new System.Drawing.Size(81, 19);
            this.chkSwapBytes.TabIndex = 0;
            this.chkSwapBytes.Tag = "byteOrder";
            this.chkSwapBytes.Text = "swapBytes";
            this.chkSwapBytes.UseVisualStyleBackColor = true;
            this.chkSwapBytes.CheckedChanged += new System.EventHandler(this.ByteOrder_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnASCII);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnUint16);
            this.groupBox1.Controls.Add(this.numBinary);
            this.groupBox1.Controls.Add(this.numAscii);
            this.groupBox1.Controls.Add(this.numHex);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Datatype Of Register";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(16, 98);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(83, 23);
            this.btnASCII.TabIndex = 2;
            this.btnASCII.Tag = "ascii";
            this.btnASCII.Text = "ASCII";
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(16, 173);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 23);
            this.button8.TabIndex = 0;
            this.button8.Tag = "boolean";
            this.button8.Text = "Boolean";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(130, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 23);
            this.button9.TabIndex = 0;
            this.button9.Tag = "double";
            this.button9.Text = "Double";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(73, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 23);
            this.button6.TabIndex = 0;
            this.button6.Tag = "float";
            this.button6.Text = "Float";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(102, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 23);
            this.button7.TabIndex = 0;
            this.button7.Tag = "int32";
            this.button7.Text = "Int32";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 23);
            this.button5.TabIndex = 0;
            this.button5.Tag = "uint32";
            this.button5.Text = "Uint32";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 0;
            this.button4.Tag = "binary";
            this.button4.Text = "Binary";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 0;
            this.button3.Tag = "hex";
            this.button3.Text = "Hex";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 0;
            this.button2.Tag = "half";
            this.button2.Text = "Half Float";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 0;
            this.button1.Tag = "int16";
            this.button1.Text = "Int16";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // btnUint16
            // 
            this.btnUint16.Location = new System.Drawing.Point(16, 22);
            this.btnUint16.Name = "btnUint16";
            this.btnUint16.Size = new System.Drawing.Size(83, 23);
            this.btnUint16.TabIndex = 0;
            this.btnUint16.Tag = "uint16";
            this.btnUint16.Text = "Uint16";
            this.btnUint16.UseVisualStyleBackColor = true;
            this.btnUint16.Click += new System.EventHandler(this.btnSetDatatype_Click);
            // 
            // numBinary
            // 
            this.numBinary.BackColor = System.Drawing.Color.White;
            this.numBinary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBinary.Location = new System.Drawing.Point(102, 126);
            this.numBinary.Name = "numBinary";
            this.numBinary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numBinary.Size = new System.Drawing.Size(60, 19);
            this.numBinary.TabIndex = 3;
            this.numBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBinary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numAscii
            // 
            this.numAscii.BackColor = System.Drawing.Color.White;
            this.numAscii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAscii.Location = new System.Drawing.Point(102, 100);
            this.numAscii.Name = "numAscii";
            this.numAscii.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numAscii.Size = new System.Drawing.Size(60, 19);
            this.numAscii.TabIndex = 3;
            this.numAscii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAscii.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHex
            // 
            this.numHex.BackColor = System.Drawing.Color.White;
            this.numHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numHex.Location = new System.Drawing.Point(102, 151);
            this.numHex.Name = "numHex";
            this.numHex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numHex.Size = new System.Drawing.Size(60, 19);
            this.numHex.TabIndex = 3;
            this.numHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ValueFormatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ValueFormatPanel";
            this.Size = new System.Drawing.Size(550, 366);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAscii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnUint16;
        private Button btnASCII;
        private NumericUpDown numHex;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private NumericUpDown numBinary;
        private NumericUpDown numAscii;
        private Button button8;
        private Button button7;
        private GroupBox groupBox2;
        private CheckBox chkSwapRegisters;
        private CheckBox chkSwapBytes;
        private Button button9;
        private ComboBox cboFloatFormat;
        private GroupBox groupBox3;
        private Button btnApplyFloatFormatting;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyValuesToolStripMenuItem;
        private ToolStripMenuItem pasteValuesToolStripMenuItem;
    }
}
