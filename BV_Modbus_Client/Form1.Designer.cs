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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TopContainer = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTestPoll = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Panel();
            this.propGridFc = new System.Windows.Forms.PropertyGrid();
            this.DarkPanel = new System.Windows.Forms.Panel();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.addFcButton2 = new BV_Modbus_Client.AddFcButton();
            this.addFcButton1 = new BV_Modbus_Client.AddFcButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TopContainer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Settings.SuspendLayout();
            this.DarkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 485);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(73, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigToolStripMenuItem,
            this.loadConfigToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.saveConfigAsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config As";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // loadConfigToolStripMenuItem
            // 
            this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadConfigToolStripMenuItem.Text = "Load Config";
            this.loadConfigToolStripMenuItem.Click += new System.EventHandler(this.loadConfigToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // saveConfigAsToolStripMenuItem
            // 
            this.saveConfigAsToolStripMenuItem.Name = "saveConfigAsToolStripMenuItem";
            this.saveConfigAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveConfigAsToolStripMenuItem.Text = "Save Config";
            this.saveConfigAsToolStripMenuItem.Click += new System.EventHandler(this.saveConfigAsToolStripMenuItem_Click);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(675, 216);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.SystemColors.Control;
            this.TopContainer.Controls.Add(this.tabControl1);
            this.TopContainer.Controls.Add(this.Settings);
            this.TopContainer.Controls.Add(this.flowLayoutPanel1);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContainer.Location = new System.Drawing.Point(73, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(1009, 485);
            this.TopContainer.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(320, 197);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 288);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(681, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selected request";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 40);
            this.panel1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnTestPoll);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(681, 260);
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
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.Control;
            this.Settings.Controls.Add(this.propGridFc);
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.Location = new System.Drawing.Point(320, 0);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(689, 197);
            this.Settings.TabIndex = 10;
            // 
            // propGridFc
            // 
            this.propGridFc.Dock = System.Windows.Forms.DockStyle.Right;
            this.propGridFc.HelpVisible = false;
            this.propGridFc.Location = new System.Drawing.Point(339, 0);
            this.propGridFc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propGridFc.Name = "propGridFc";
            this.propGridFc.Size = new System.Drawing.Size(350, 197);
            this.propGridFc.TabIndex = 0;
            // 
            // DarkPanel
            // 
            this.DarkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.DarkPanel.Controls.Add(this.btnViewTable);
            this.DarkPanel.Controls.Add(this.menuStrip1);
            this.DarkPanel.Controls.Add(this.addFcButton2);
            this.DarkPanel.Controls.Add(this.addFcButton1);
            this.DarkPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DarkPanel.Location = new System.Drawing.Point(0, 0);
            this.DarkPanel.Name = "DarkPanel";
            this.DarkPanel.Size = new System.Drawing.Size(73, 485);
            this.DarkPanel.TabIndex = 10;
            // 
            // btnViewTable
            // 
            this.btnViewTable.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.ConnectGreen;
            this.btnViewTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewTable.FlatAppearance.BorderSize = 0;
            this.btnViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTable.Location = new System.Drawing.Point(11, 41);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(50, 50);
            this.btnViewTable.TabIndex = 18;
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addFcButton2
            // 
            this.addFcButton2.BackColor = System.Drawing.Color.Transparent;
            this.addFcButton2.FcDescription = "Write Holding Registers";
            this.addFcButton2.FcName = "FC15";
            this.addFcButton2.Location = new System.Drawing.Point(0, 205);
            this.addFcButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFcButton2.Name = "addFcButton2";
            this.addFcButton2.Size = new System.Drawing.Size(60, 20);
            this.addFcButton2.TabIndex = 15;
            this.addFcButton2.ButtonClicked += new System.EventHandler(this.addFcButton2_ButtonClicked);
            // 
            // addFcButton1
            // 
            this.addFcButton1.BackColor = System.Drawing.Color.Transparent;
            this.addFcButton1.FcDescription = "Multiple Holding Registers";
            this.addFcButton1.FcName = "HR[]";
            this.addFcButton1.Location = new System.Drawing.Point(5, 125);
            this.addFcButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFcButton1.Name = "addFcButton1";
            this.addFcButton1.Size = new System.Drawing.Size(60, 20);
            this.addFcButton1.TabIndex = 15;
            this.addFcButton1.ButtonClicked += new System.EventHandler(this.addFcButton1_ButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1082, 485);
            this.Controls.Add(this.TopContainer);
            this.Controls.Add(this.DarkPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TopContainer.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.DarkPanel.ResumeLayout(false);
            this.DarkPanel.PerformLayout();
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
        private Panel DarkPanel;
        private AddFcButton addFcButton1;
        private AddFcButton addFcButton2;
        private Button btnViewTable;
        private DataGridView dataGridView1;
        private Button btnPaste;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem saveConfigAsToolStripMenuItem;
        private Button btnTestPoll;
        private Panel Settings;
        private PropertyGrid propGridFc;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
    }
}