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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TopContainer = new System.Windows.Forms.Panel();
            this.mainBottomPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTestPoll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.StatisticsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.propGridFc = new System.Windows.Forms.PropertyGrid();
            this.mainHeader = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.FCHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leftHeader = new System.Windows.Forms.Panel();
            this.contextMenuAddFC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.multipleHoldingRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleHoldingRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TopContainer.SuspendLayout();
            this.mainBottomPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.MainTopPanel.SuspendLayout();
            this.StatisticsPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
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
            this.fileToolStripMenuItem});
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
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(18, 9);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 15;
            this.btnPaste.Text = "PasteData";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
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
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(657, 259);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
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
            this.TopContainer.Size = new System.Drawing.Size(725, 654);
            this.TopContainer.TabIndex = 12;
            // 
            // mainBottomPanel
            // 
            this.mainBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.mainBottomPanel.Controls.Add(this.tabControl1);
            this.mainBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBottomPanel.Location = new System.Drawing.Point(0, 297);
            this.mainBottomPanel.Name = "mainBottomPanel";
            this.mainBottomPanel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.mainBottomPanel.Size = new System.Drawing.Size(725, 357);
            this.mainBottomPanel.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(30, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 327);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(657, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Request Data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 40);
            this.panel1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnTestPoll);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(657, 201);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Polling settings";
            // 
            // btnTestPoll
            // 
            this.btnTestPoll.Location = new System.Drawing.Point(19, 16);
            this.btnTestPoll.Name = "btnTestPoll";
            this.btnTestPoll.Size = new System.Drawing.Size(100, 23);
            this.btnTestPoll.TabIndex = 0;
            this.btnTestPoll.Text = "Manual poll";
            this.btnTestPoll.UseVisualStyleBackColor = true;
            this.btnTestPoll.Click += new System.EventHandler(this.btnTestPoll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.MainTopPanel.Size = new System.Drawing.Size(725, 267);
            this.MainTopPanel.TabIndex = 10;
            // 
            // StatisticsPanel
            // 
            this.StatisticsPanel.Controls.Add(this.panel2);
            this.StatisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsPanel.Location = new System.Drawing.Point(0, 0);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Padding = new System.Windows.Forms.Padding(30, 30, 0, 15);
            this.StatisticsPanel.Size = new System.Drawing.Size(379, 267);
            this.StatisticsPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 222);
            this.panel2.TabIndex = 0;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.propGridFc);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsPanel.Location = new System.Drawing.Point(379, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.SettingsPanel.Size = new System.Drawing.Size(346, 267);
            this.SettingsPanel.TabIndex = 2;
            // 
            // propGridFc
            // 
            this.propGridFc.AccessibleDescription = "Settings on request";
            this.propGridFc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridFc.HelpVisible = false;
            this.propGridFc.Location = new System.Drawing.Point(30, 30);
            this.propGridFc.Margin = new System.Windows.Forms.Padding(20);
            this.propGridFc.Name = "propGridFc";
            this.propGridFc.Size = new System.Drawing.Size(286, 222);
            this.propGridFc.TabIndex = 0;
            this.propGridFc.Tag = "s";
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.mainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeader.Location = new System.Drawing.Point(0, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(725, 30);
            this.mainHeader.TabIndex = 18;
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
            this.leftPanel.Size = new System.Drawing.Size(357, 654);
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
            this.scrollPanel.Size = new System.Drawing.Size(357, 595);
            this.scrollPanel.TabIndex = 10;
            // 
            // FCHeader
            // 
            this.FCHeader.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.button2.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.Add;
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
            this.label1.Location = new System.Drawing.Point(107, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
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
            this.contextMenuAddFC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multipleHoldingRegistersToolStripMenuItem,
            this.singleHoldingRegisterToolStripMenuItem});
            this.contextMenuAddFC.Name = "contextMenuStrip1";
            this.contextMenuAddFC.Size = new System.Drawing.Size(215, 48);
            // 
            // multipleHoldingRegistersToolStripMenuItem
            // 
            this.multipleHoldingRegistersToolStripMenuItem.Name = "multipleHoldingRegistersToolStripMenuItem";
            this.multipleHoldingRegistersToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.multipleHoldingRegistersToolStripMenuItem.Text = "Multiple Holding Registers";
            this.multipleHoldingRegistersToolStripMenuItem.Click += new System.EventHandler(this.multipleHoldingRegistersToolStripMenuItem_Click);
            // 
            // singleHoldingRegisterToolStripMenuItem
            // 
            this.singleHoldingRegisterToolStripMenuItem.Name = "singleHoldingRegisterToolStripMenuItem";
            this.singleHoldingRegisterToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.singleHoldingRegisterToolStripMenuItem.Text = "Single Holding Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1082, 654);
            this.Controls.Add(this.TopContainer);
            this.Controls.Add(this.leftPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TopContainer.ResumeLayout(false);
            this.mainBottomPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.MainTopPanel.ResumeLayout(false);
            this.StatisticsPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
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
        private Button btnPaste;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem saveConfigAsToolStripMenuItem;
        private Button btnTestPoll;
        private Panel MainTopPanel;
        private PropertyGrid propGridFc;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button button1;
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
        private ToolStripMenuItem singleHoldingRegisterToolStripMenuItem;
        private Button button2;
    }
}