namespace BV_Modbus_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miPasteData = new System.Windows.Forms.ToolStripMenuItem();
            this.TopContainer = new System.Windows.Forms.Panel();
            this.mainBottomPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.valueFormatPanel1 = new BV_Modbus_Client.ValueFormatPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkQuote = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLogPath = new System.Windows.Forms.Button();
            this.txtPolledData = new System.Windows.Forms.TextBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.chkLogToFile = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numPollInterval = new System.Windows.Forms.NumericUpDown();
            this.btnTestPoll = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.StatisticsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblResponseTime = new System.Windows.Forms.Label();
            this.lblWriteCounter = new System.Windows.Forms.Label();
            this.lblReadCounter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.propGridFc = new System.Windows.Forms.PropertyGrid();
            this.mainHeader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.panelConnectionIndicator = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.FCHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leftHeader = new System.Windows.Forms.Panel();
            this.contextMenuAddFC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.multipleHoldingRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleCoilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readInputRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendlineControl1 = new BV_Modbus_Client.TrendlineControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dgvContext.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.mainBottomPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPollInterval)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.MainTopPanel.SuspendLayout();
            this.StatisticsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.mainHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.FCHeader.SuspendLayout();
            this.leftHeader.SuspendLayout();
            this.contextMenuAddFC.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(389, 813);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(408, 43);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigToolStripMenuItem,
            this.loadConfigToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.saveConfigAsToolStripMenuItem,
            this.configureConnectionToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 37);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.saveConfigToolStripMenuItem.Text = "Save Config As";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // loadConfigToolStripMenuItem
            // 
            this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.loadConfigToolStripMenuItem.Text = "Load Config";
            this.loadConfigToolStripMenuItem.Click += new System.EventHandler(this.loadConfigToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // saveConfigAsToolStripMenuItem
            // 
            this.saveConfigAsToolStripMenuItem.Name = "saveConfigAsToolStripMenuItem";
            this.saveConfigAsToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.saveConfigAsToolStripMenuItem.Text = "Save Config";
            this.saveConfigAsToolStripMenuItem.Click += new System.EventHandler(this.saveConfigAsToolStripMenuItem_Click);
            // 
            // configureConnectionToolStripMenuItem
            // 
            this.configureConnectionToolStripMenuItem.Name = "configureConnectionToolStripMenuItem";
            this.configureConnectionToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.configureConnectionToolStripMenuItem.Text = "Configure Connection";
            this.configureConnectionToolStripMenuItem.Click += new System.EventHandler(this.configureConnectionToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.dgvContext;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(242, 182);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // dgvContext
            // 
            this.dgvContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPasteData});
            this.dgvContext.Name = "dgvContext";
            this.dgvContext.Size = new System.Drawing.Size(147, 28);
            // 
            // miPasteData
            // 
            this.miPasteData.Name = "miPasteData";
            this.miPasteData.Size = new System.Drawing.Size(146, 24);
            this.miPasteData.Text = "Paste data";
            this.miPasteData.Click += new System.EventHandler(this.miPasteData_Click);
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.SystemColors.Control;
            this.TopContainer.Controls.Add(this.mainBottomPanel);
            this.TopContainer.Controls.Add(this.MainTopPanel);
            this.TopContainer.Controls.Add(this.mainHeader);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContainer.Location = new System.Drawing.Point(408, 0);
            this.TopContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(709, 872);
            this.TopContainer.TabIndex = 12;
            // 
            // mainBottomPanel
            // 
            this.mainBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.mainBottomPanel.Controls.Add(this.tabControl1);
            this.mainBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBottomPanel.Location = new System.Drawing.Point(0, 321);
            this.mainBottomPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainBottomPanel.Name = "mainBottomPanel";
            this.mainBottomPanel.Padding = new System.Windows.Forms.Padding(34, 0, 34, 40);
            this.mainBottomPanel.Size = new System.Drawing.Size(709, 551);
            this.mainBottomPanel.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(34, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 511);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.valueFormatPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(633, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Request Data";
            // 
            // valueFormatPanel1
            // 
            this.valueFormatPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueFormatPanel1.Location = new System.Drawing.Point(0, 0);
            this.valueFormatPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.valueFormatPanel1.Name = "valueFormatPanel1";
            this.valueFormatPanel1.Size = new System.Drawing.Size(633, 478);
            this.valueFormatPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numPollInterval);
            this.tabPage2.Controls.Add(this.btnTestPoll);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polling settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkQuote);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnLogPath);
            this.groupBox1.Controls.Add(this.txtPolledData);
            this.groupBox1.Controls.Add(this.txtLogPath);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSeparator);
            this.groupBox1.Controls.Add(this.chkLogToFile);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(29, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(574, 171);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log to File";
            // 
            // chkQuote
            // 
            this.chkQuote.AutoSize = true;
            this.chkQuote.Location = new System.Drawing.Point(250, 24);
            this.chkQuote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkQuote.Name = "chkQuote";
            this.chkQuote.Size = new System.Drawing.Size(117, 24);
            this.chkQuote.TabIndex = 12;
            this.chkQuote.Text = "Quote values";
            this.chkQuote.UseVisualStyleBackColor = true;
            this.chkQuote.CheckedChanged += new System.EventHandler(this.chkQuote_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Log file path:";
            // 
            // btnLogPath
            // 
            this.btnLogPath.Location = new System.Drawing.Point(535, 123);
            this.btnLogPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogPath.Name = "btnLogPath";
            this.btnLogPath.Size = new System.Drawing.Size(27, 31);
            this.btnLogPath.TabIndex = 8;
            this.btnLogPath.Text = "...";
            this.btnLogPath.UseVisualStyleBackColor = true;
            this.btnLogPath.Click += new System.EventHandler(this.btnLogPath_Click);
            // 
            // txtPolledData
            // 
            this.txtPolledData.Location = new System.Drawing.Point(18, 55);
            this.txtPolledData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPolledData.Multiline = true;
            this.txtPolledData.Name = "txtPolledData";
            this.txtPolledData.Size = new System.Drawing.Size(543, 31);
            this.txtPolledData.TabIndex = 5;
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(104, 123);
            this.txtLogPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.ReadOnly = true;
            this.txtLogPath.Size = new System.Drawing.Size(423, 27);
            this.txtLogPath.TabIndex = 7;
            this.txtLogPath.TextChanged += new System.EventHandler(this.txtLogPath_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Separator character:";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(527, 21);
            this.txtSeparator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(35, 27);
            this.txtSeparator.TabIndex = 9;
            this.txtSeparator.Text = "\\t";
            this.txtSeparator.TextChanged += new System.EventHandler(this.txtSeparator_TextChanged);
            // 
            // chkLogToFile
            // 
            this.chkLogToFile.AutoSize = true;
            this.chkLogToFile.Location = new System.Drawing.Point(19, 96);
            this.chkLogToFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLogToFile.Name = "chkLogToFile";
            this.chkLogToFile.Size = new System.Drawing.Size(127, 24);
            this.chkLogToFile.TabIndex = 6;
            this.chkLogToFile.Text = "Append to file";
            this.chkLogToFile.UseVisualStyleBackColor = true;
            this.chkLogToFile.CheckedChanged += new System.EventHandler(this.chkLogToFile_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Polled data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Polling interval in seconds:";
            // 
            // numPollInterval
            // 
            this.numPollInterval.DecimalPlaces = 3;
            this.numPollInterval.Location = new System.Drawing.Point(214, 20);
            this.numPollInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPollInterval.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPollInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numPollInterval.Name = "numPollInterval";
            this.numPollInterval.Size = new System.Drawing.Size(98, 27);
            this.numPollInterval.TabIndex = 2;
            this.numPollInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPollInterval.ValueChanged += new System.EventHandler(this.numPollInterval_ValueChanged);
            // 
            // btnTestPoll
            // 
            this.btnTestPoll.Location = new System.Drawing.Point(331, 20);
            this.btnTestPoll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestPoll.Name = "btnTestPoll";
            this.btnTestPoll.Size = new System.Drawing.Size(114, 31);
            this.btnTestPoll.TabIndex = 0;
            this.btnTestPoll.Text = "Manual poll";
            this.btnTestPoll.UseVisualStyleBackColor = true;
            this.btnTestPoll.Click += new System.EventHandler(this.btnTestPoll_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trendlineControl1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(633, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Set Data types";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.MainTopPanel.Controls.Add(this.StatisticsPanel);
            this.MainTopPanel.Controls.Add(this.SettingsPanel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 40);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(709, 281);
            this.MainTopPanel.TabIndex = 10;
            // 
            // StatisticsPanel
            // 
            this.StatisticsPanel.Controls.Add(this.panel2);
            this.StatisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsPanel.Location = new System.Drawing.Point(0, 0);
            this.StatisticsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Padding = new System.Windows.Forms.Padding(34, 40, 0, 20);
            this.StatisticsPanel.Size = new System.Drawing.Size(280, 281);
            this.StatisticsPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.lblResponseTime);
            this.panel2.Controls.Add(this.lblWriteCounter);
            this.panel2.Controls.Add(this.lblReadCounter);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(34, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 221);
            this.panel2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(24, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(201, 48);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Statistics:\t\t\t";
            // 
            // lblResponseTime
            // 
            this.lblResponseTime.AutoSize = true;
            this.lblResponseTime.Location = new System.Drawing.Point(136, 139);
            this.lblResponseTime.Name = "lblResponseTime";
            this.lblResponseTime.Size = new System.Drawing.Size(17, 20);
            this.lblResponseTime.TabIndex = 2;
            this.lblResponseTime.Text = "0";
            // 
            // lblWriteCounter
            // 
            this.lblWriteCounter.AutoSize = true;
            this.lblWriteCounter.Location = new System.Drawing.Point(136, 107);
            this.lblWriteCounter.Name = "lblWriteCounter";
            this.lblWriteCounter.Size = new System.Drawing.Size(17, 20);
            this.lblWriteCounter.TabIndex = 2;
            this.lblWriteCounter.Text = "0";
            // 
            // lblReadCounter
            // 
            this.lblReadCounter.AutoSize = true;
            this.lblReadCounter.Location = new System.Drawing.Point(136, 73);
            this.lblReadCounter.Name = "lblReadCounter";
            this.lblReadCounter.Size = new System.Drawing.Size(17, 20);
            this.lblReadCounter.TabIndex = 2;
            this.lblReadCounter.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Response time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Error count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Write operations:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Read operations:";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.propGridFc);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsPanel.Location = new System.Drawing.Point(280, 0);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Padding = new System.Windows.Forms.Padding(34, 40, 34, 20);
            this.SettingsPanel.Size = new System.Drawing.Size(429, 281);
            this.SettingsPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(130, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Request settings";
            // 
            // propGridFc
            // 
            this.propGridFc.AccessibleDescription = "Settings on request";
            this.propGridFc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridFc.HelpVisible = false;
            this.propGridFc.Location = new System.Drawing.Point(34, 40);
            this.propGridFc.Margin = new System.Windows.Forms.Padding(23, 27, 23, 27);
            this.propGridFc.Name = "propGridFc";
            this.propGridFc.Size = new System.Drawing.Size(361, 221);
            this.propGridFc.TabIndex = 0;
            this.propGridFc.Tag = "s";
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.mainHeader.Controls.Add(this.panel3);
            this.mainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeader.Location = new System.Drawing.Point(0, 0);
            this.mainHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(709, 40);
            this.mainHeader.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblConnectionStatus);
            this.panel3.Controls.Add(this.panelConnectionIndicator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(436, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 40);
            this.panel3.TabIndex = 2;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnectionStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConnectionStatus.Location = new System.Drawing.Point(34, 7);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(203, 27);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "label11sss";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConnectionStatus.Click += new System.EventHandler(this.lblConnectionStatus_Click);
            // 
            // panelConnectionIndicator
            // 
            this.panelConnectionIndicator.BackColor = System.Drawing.Color.LimeGreen;
            this.panelConnectionIndicator.Location = new System.Drawing.Point(251, 13);
            this.panelConnectionIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelConnectionIndicator.Name = "panelConnectionIndicator";
            this.panelConnectionIndicator.Size = new System.Drawing.Size(11, 13);
            this.panelConnectionIndicator.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.scrollPanel);
            this.leftPanel.Controls.Add(this.FCHeader);
            this.leftPanel.Controls.Add(this.leftHeader);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(408, 872);
            this.leftPanel.TabIndex = 13;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.BackColor = System.Drawing.Color.White;
            this.scrollPanel.Controls.Add(this.flowLayoutPanel1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 79);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(408, 793);
            this.scrollPanel.TabIndex = 10;
            // 
            // FCHeader
            // 
            this.FCHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.FCHeader.Controls.Add(this.button2);
            this.FCHeader.Controls.Add(this.label1);
            this.FCHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FCHeader.Location = new System.Drawing.Point(0, 43);
            this.FCHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FCHeader.Name = "FCHeader";
            this.FCHeader.Size = new System.Drawing.Size(408, 36);
            this.FCHeader.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.add_white;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(357, -1);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 37);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.addFcButton1_ButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modbus Function Codes:";
            // 
            // leftHeader
            // 
            this.leftHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.leftHeader.Controls.Add(this.menuStrip1);
            this.leftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftHeader.Location = new System.Drawing.Point(0, 0);
            this.leftHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftHeader.Name = "leftHeader";
            this.leftHeader.Size = new System.Drawing.Size(408, 43);
            this.leftHeader.TabIndex = 0;
            // 
            // contextMenuAddFC
            // 
            this.contextMenuAddFC.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuAddFC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multipleHoldingRegistersToolStripMenuItem,
            this.multipleCoilsToolStripMenuItem,
            this.readInputRegistersToolStripMenuItem,
            this.readToolStripMenuItem});
            this.contextMenuAddFC.Name = "contextMenuStrip1";
            this.contextMenuAddFC.Size = new System.Drawing.Size(256, 100);
            // 
            // multipleHoldingRegistersToolStripMenuItem
            // 
            this.multipleHoldingRegistersToolStripMenuItem.Name = "multipleHoldingRegistersToolStripMenuItem";
            this.multipleHoldingRegistersToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.multipleHoldingRegistersToolStripMenuItem.Text = "Multiple Holding Registers";
            this.multipleHoldingRegistersToolStripMenuItem.Click += new System.EventHandler(this.multipleHoldingRegistersToolStripMenuItem_Click);
            // 
            // multipleCoilsToolStripMenuItem
            // 
            this.multipleCoilsToolStripMenuItem.Name = "multipleCoilsToolStripMenuItem";
            this.multipleCoilsToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.multipleCoilsToolStripMenuItem.Text = "Multiple Coils";
            this.multipleCoilsToolStripMenuItem.Click += new System.EventHandler(this.multipleCoilsToolStripMenuItem_Click);
            // 
            // readInputRegistersToolStripMenuItem
            // 
            this.readInputRegistersToolStripMenuItem.Name = "readInputRegistersToolStripMenuItem";
            this.readInputRegistersToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.readInputRegistersToolStripMenuItem.Text = "Read Input Registers";
            this.readInputRegistersToolStripMenuItem.Click += new System.EventHandler(this.readInputRegistersToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.readToolStripMenuItem.Text = "Read Discrete Inputs";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // trendlineControl1
            // 
            this.trendlineControl1.Location = new System.Drawing.Point(20, 205);
            this.trendlineControl1.Name = "trendlineControl1";
            this.trendlineControl1.Size = new System.Drawing.Size(593, 259);
            this.trendlineControl1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1117, 872);
            this.Controls.Add(this.TopContainer);
            this.Controls.Add(this.leftPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dgvContext.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            this.mainBottomPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPollInterval)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.MainTopPanel.ResumeLayout(false);
            this.StatisticsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.mainHeader.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.FCHeader.ResumeLayout(false);
            this.FCHeader.PerformLayout();
            this.leftHeader.ResumeLayout(false);
            this.leftHeader.PerformLayout();
            this.contextMenuAddFC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FcView fcView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveConfigToolStripMenuItem;
        private ToolStripMenuItem loadConfigToolStripMenuItem;
        private Panel TopContainer;
        private DataGridView dataGridView1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem saveConfigAsToolStripMenuItem;
        private Button btnTestPoll;
        private Panel MainTopPanel;
        private PropertyGrid propGridFc;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel leftPanel;
        private Panel mainHeader;
        private Panel FCHeader;
        private Panel leftHeader;
        private Panel mainBottomPanel;
        private Panel StatisticsPanel;
        private Panel SettingsPanel;
        private ToolStripMenuItem configureConnectionToolStripMenuItem;
        private Panel scrollPanel;
        private Label label1;
        private Panel panel2;
        private ContextMenuStrip contextMenuAddFC;
        private ToolStripMenuItem multipleHoldingRegistersToolStripMenuItem;
        private Button button2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label lblWriteCounter;
        private Label lblReadCounter;
        private Label label7;
        private Label label6;
        private RichTextBox richTextBox1;
        private Label lblResponseTime;
        private ContextMenuStrip dgvContext;
        private ToolStripMenuItem miPasteData;
        private Label label5;
        private NumericUpDown numPollInterval;
        private Label label8;
        private TextBox txtPolledData;
        private GroupBox groupBox1;
        private Label label10;
        private Button btnLogPath;
        private TextBox txtLogPath;
        private Label label9;
        private TextBox txtSeparator;
        private CheckBox chkLogToFile;
        private CheckBox chkQuote;
        private Panel panelConnectionIndicator;
        private Label lblConnectionStatus;
        private Panel panel3;
        private ToolStripMenuItem multipleCoilsToolStripMenuItem;
        private ToolStripMenuItem readInputRegistersToolStripMenuItem;
        private ToolStripMenuItem readToolStripMenuItem;
        private TabPage tabPage3;
        private ValueFormatPanel valueFormatPanel1;
        private TrendlineControl trendlineControl1;
    }
}