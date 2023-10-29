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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.trendlineControl1 = new BV_Modbus_Client.TrendlineControl();
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
            this.menuStrip1.SuspendLayout();
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
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 610);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(357, 32);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config As";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // loadConfigToolStripMenuItem
            // 
            this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loadConfigToolStripMenuItem.Text = "Load Config";
            this.loadConfigToolStripMenuItem.Click += new System.EventHandler(this.loadConfigToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // saveConfigAsToolStripMenuItem
            // 
            this.saveConfigAsToolStripMenuItem.Name = "saveConfigAsToolStripMenuItem";
            this.saveConfigAsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveConfigAsToolStripMenuItem.Text = "Save Config";
            this.saveConfigAsToolStripMenuItem.Click += new System.EventHandler(this.saveConfigAsToolStripMenuItem_Click);
            // 
            // configureConnectionToolStripMenuItem
            // 
            this.configureConnectionToolStripMenuItem.Name = "configureConnectionToolStripMenuItem";
            this.configureConnectionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.configureConnectionToolStripMenuItem.Text = "Configure Connection";
            this.configureConnectionToolStripMenuItem.Click += new System.EventHandler(this.configureConnectionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dgvContext
            // 
            this.dgvContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPasteData});
            this.dgvContext.Name = "dgvContext";
            this.dgvContext.Size = new System.Drawing.Size(129, 26);
            // 
            // miPasteData
            // 
            this.miPasteData.Name = "miPasteData";
            this.miPasteData.Size = new System.Drawing.Size(128, 22);
            this.miPasteData.Text = "Paste data";
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.SystemColors.Control;
            this.TopContainer.Controls.Add(this.mainBottomPanel);
            this.TopContainer.Controls.Add(this.MainTopPanel);
            this.TopContainer.Controls.Add(this.mainHeader);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContainer.Location = new System.Drawing.Point(357, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(620, 607);
            this.TopContainer.TabIndex = 12;
            // 
            // mainBottomPanel
            // 
            this.mainBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.mainBottomPanel.Controls.Add(this.tabControl1);
            this.mainBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBottomPanel.Location = new System.Drawing.Point(0, 241);
            this.mainBottomPanel.Name = "mainBottomPanel";
            this.mainBottomPanel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.mainBottomPanel.Size = new System.Drawing.Size(620, 366);
            this.mainBottomPanel.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(30, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 336);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.valueFormatPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(552, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Request Data";
            // 
            // valueFormatPanel1
            // 
            this.valueFormatPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueFormatPanel1.Location = new System.Drawing.Point(0, 0);
            this.valueFormatPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueFormatPanel1.Name = "valueFormatPanel1";
            this.valueFormatPanel1.Size = new System.Drawing.Size(552, 308);
            this.valueFormatPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numPollInterval);
            this.tabPage2.Controls.Add(this.btnTestPoll);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(552, 308);
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
            this.groupBox1.Location = new System.Drawing.Point(25, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log to File";
            // 
            // chkQuote
            // 
            this.chkQuote.AutoSize = true;
            this.chkQuote.Location = new System.Drawing.Point(219, 18);
            this.chkQuote.Name = "chkQuote";
            this.chkQuote.Size = new System.Drawing.Size(95, 19);
            this.chkQuote.TabIndex = 12;
            this.chkQuote.Text = "Quote values";
            this.chkQuote.UseVisualStyleBackColor = true;
            this.chkQuote.CheckedChanged += new System.EventHandler(this.chkQuote_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Log file path:";
            // 
            // btnLogPath
            // 
            this.btnLogPath.Location = new System.Drawing.Point(468, 92);
            this.btnLogPath.Name = "btnLogPath";
            this.btnLogPath.Size = new System.Drawing.Size(24, 23);
            this.btnLogPath.TabIndex = 8;
            this.btnLogPath.Text = "...";
            this.btnLogPath.UseVisualStyleBackColor = true;
            this.btnLogPath.Click += new System.EventHandler(this.btnLogPath_Click);
            // 
            // txtPolledData
            // 
            this.txtPolledData.Location = new System.Drawing.Point(16, 41);
            this.txtPolledData.Multiline = true;
            this.txtPolledData.Name = "txtPolledData";
            this.txtPolledData.Size = new System.Drawing.Size(476, 24);
            this.txtPolledData.TabIndex = 5;
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(91, 92);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.ReadOnly = true;
            this.txtLogPath.Size = new System.Drawing.Size(371, 23);
            this.txtLogPath.TabIndex = 7;
            this.txtLogPath.TextChanged += new System.EventHandler(this.txtLogPath_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Separator character:";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(461, 16);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(31, 23);
            this.txtSeparator.TabIndex = 9;
            this.txtSeparator.Text = "\\t";
            this.txtSeparator.TextChanged += new System.EventHandler(this.txtSeparator_TextChanged);
            // 
            // chkLogToFile
            // 
            this.chkLogToFile.AutoSize = true;
            this.chkLogToFile.Location = new System.Drawing.Point(17, 72);
            this.chkLogToFile.Name = "chkLogToFile";
            this.chkLogToFile.Size = new System.Drawing.Size(101, 19);
            this.chkLogToFile.TabIndex = 6;
            this.chkLogToFile.Text = "Append to file";
            this.chkLogToFile.UseVisualStyleBackColor = true;
            this.chkLogToFile.CheckedChanged += new System.EventHandler(this.chkLogToFile_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Polled data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Polling interval in seconds:";
            // 
            // numPollInterval
            // 
            this.numPollInterval.DecimalPlaces = 3;
            this.numPollInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPollInterval.Location = new System.Drawing.Point(187, 15);
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
            this.numPollInterval.Size = new System.Drawing.Size(86, 23);
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
            this.btnTestPoll.Location = new System.Drawing.Point(290, 15);
            this.btnTestPoll.Name = "btnTestPoll";
            this.btnTestPoll.Size = new System.Drawing.Size(100, 23);
            this.btnTestPoll.TabIndex = 0;
            this.btnTestPoll.Text = "Manual poll";
            this.btnTestPoll.UseVisualStyleBackColor = true;
            this.btnTestPoll.Click += new System.EventHandler(this.btnTestPoll_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trendlineControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(552, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trend line";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // trendlineControl1
            // 
            this.trendlineControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trendlineControl1.Location = new System.Drawing.Point(0, 0);
            this.trendlineControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trendlineControl1.Name = "trendlineControl1";
            this.trendlineControl1.Size = new System.Drawing.Size(552, 308);
            this.trendlineControl1.TabIndex = 15;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.MainTopPanel.Controls.Add(this.StatisticsPanel);
            this.MainTopPanel.Controls.Add(this.SettingsPanel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 30);
            this.MainTopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(620, 211);
            this.MainTopPanel.TabIndex = 10;
            // 
            // StatisticsPanel
            // 
            this.StatisticsPanel.Controls.Add(this.panel2);
            this.StatisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsPanel.Location = new System.Drawing.Point(0, 0);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Padding = new System.Windows.Forms.Padding(30, 30, 0, 15);
            this.StatisticsPanel.Size = new System.Drawing.Size(245, 211);
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
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 166);
            this.panel2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(21, 19);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(176, 36);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Statistics:\t\t\t";
            // 
            // lblResponseTime
            // 
            this.lblResponseTime.AutoSize = true;
            this.lblResponseTime.Location = new System.Drawing.Point(119, 104);
            this.lblResponseTime.Name = "lblResponseTime";
            this.lblResponseTime.Size = new System.Drawing.Size(13, 15);
            this.lblResponseTime.TabIndex = 2;
            this.lblResponseTime.Text = "0";
            // 
            // lblWriteCounter
            // 
            this.lblWriteCounter.AutoSize = true;
            this.lblWriteCounter.Location = new System.Drawing.Point(119, 80);
            this.lblWriteCounter.Name = "lblWriteCounter";
            this.lblWriteCounter.Size = new System.Drawing.Size(13, 15);
            this.lblWriteCounter.TabIndex = 2;
            this.lblWriteCounter.Text = "0";
            // 
            // lblReadCounter
            // 
            this.lblReadCounter.AutoSize = true;
            this.lblReadCounter.Location = new System.Drawing.Point(119, 55);
            this.lblReadCounter.Name = "lblReadCounter";
            this.lblReadCounter.Size = new System.Drawing.Size(13, 15);
            this.lblReadCounter.TabIndex = 2;
            this.lblReadCounter.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Response time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Error count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Write operations:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Read operations:";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.propGridFc);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsPanel.Location = new System.Drawing.Point(245, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.SettingsPanel.Size = new System.Drawing.Size(375, 211);
            this.SettingsPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(114, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Request settings";
            // 
            // propGridFc
            // 
            this.propGridFc.AccessibleDescription = "Settings on request";
            this.propGridFc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridFc.HelpVisible = false;
            this.propGridFc.Location = new System.Drawing.Point(30, 30);
            this.propGridFc.Margin = new System.Windows.Forms.Padding(20);
            this.propGridFc.Name = "propGridFc";
            this.propGridFc.Size = new System.Drawing.Size(315, 166);
            this.propGridFc.TabIndex = 0;
            this.propGridFc.Tag = "s";
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.mainHeader.Controls.Add(this.panel3);
            this.mainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeader.Location = new System.Drawing.Point(0, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(620, 30);
            this.mainHeader.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblConnectionStatus);
            this.panel3.Controls.Add(this.panelConnectionIndicator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(381, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 30);
            this.panel3.TabIndex = 2;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnectionStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConnectionStatus.Location = new System.Drawing.Point(30, 5);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(178, 20);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "label11sss";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConnectionStatus.Click += new System.EventHandler(this.lblConnectionStatus_Click);
            // 
            // panelConnectionIndicator
            // 
            this.panelConnectionIndicator.BackColor = System.Drawing.Color.LimeGreen;
            this.panelConnectionIndicator.Location = new System.Drawing.Point(220, 10);
            this.panelConnectionIndicator.Name = "panelConnectionIndicator";
            this.panelConnectionIndicator.Size = new System.Drawing.Size(10, 10);
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
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(357, 607);
            this.leftPanel.TabIndex = 13;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.BackColor = System.Drawing.Color.White;
            this.scrollPanel.Controls.Add(this.flowLayoutPanel1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 59);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(357, 548);
            this.scrollPanel.TabIndex = 10;
            // 
            // FCHeader
            // 
            this.FCHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.FCHeader.Controls.Add(this.button2);
            this.FCHeader.Controls.Add(this.label1);
            this.FCHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FCHeader.Location = new System.Drawing.Point(0, 32);
            this.FCHeader.Name = "FCHeader";
            this.FCHeader.Size = new System.Drawing.Size(357, 27);
            this.FCHeader.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.add_white;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(312, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.addFcButton1_ButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modbus Function Codes:";
            // 
            // leftHeader
            // 
            this.leftHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.leftHeader.Controls.Add(this.menuStrip1);
            this.leftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftHeader.Location = new System.Drawing.Point(0, 0);
            this.leftHeader.Name = "leftHeader";
            this.leftHeader.Size = new System.Drawing.Size(357, 32);
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
            this.contextMenuAddFC.Size = new System.Drawing.Size(215, 92);
            // 
            // multipleHoldingRegistersToolStripMenuItem
            // 
            this.multipleHoldingRegistersToolStripMenuItem.Name = "multipleHoldingRegistersToolStripMenuItem";
            this.multipleHoldingRegistersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.multipleHoldingRegistersToolStripMenuItem.Text = "Multiple Holding Registers";
            this.multipleHoldingRegistersToolStripMenuItem.Click += new System.EventHandler(this.multipleHoldingRegistersToolStripMenuItem_Click);
            // 
            // multipleCoilsToolStripMenuItem
            // 
            this.multipleCoilsToolStripMenuItem.Name = "multipleCoilsToolStripMenuItem";
            this.multipleCoilsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.multipleCoilsToolStripMenuItem.Text = "Multiple Coils";
            this.multipleCoilsToolStripMenuItem.Click += new System.EventHandler(this.multipleCoilsToolStripMenuItem_Click);
            // 
            // readInputRegistersToolStripMenuItem
            // 
            this.readInputRegistersToolStripMenuItem.Name = "readInputRegistersToolStripMenuItem";
            this.readInputRegistersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.readInputRegistersToolStripMenuItem.Text = "Read Input Registers";
            this.readInputRegistersToolStripMenuItem.Click += new System.EventHandler(this.readInputRegistersToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.readToolStripMenuItem.Text = "Read Discrete Inputs";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(977, 607);
            this.Controls.Add(this.TopContainer);
            this.Controls.Add(this.leftPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}