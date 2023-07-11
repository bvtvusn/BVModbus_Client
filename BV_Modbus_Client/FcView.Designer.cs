﻿namespace BV_Modbus_Client
{
    partial class FcView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFCTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateFCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecuteRead = new System.Windows.Forms.Button();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.picError = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnContextMenu = new System.Windows.Forms.Button();
            this.btnRunFc2 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 67);
            this.panel1.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.changeFCTypeToolStripMenuItem,
            this.duplicateFCToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 92);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aToolStripMenuItem.Text = "Remove";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.CheckOnClick = true;
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bToolStripMenuItem.Text = "Polling";
            this.bToolStripMenuItem.CheckedChanged += new System.EventHandler(this.bToolStripMenuItem_CheckedChanged);
            // 
            // changeFCTypeToolStripMenuItem
            // 
            this.changeFCTypeToolStripMenuItem.Name = "changeFCTypeToolStripMenuItem";
            this.changeFCTypeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.changeFCTypeToolStripMenuItem.Text = "Change FC Type";
            // 
            // duplicateFCToolStripMenuItem
            // 
            this.duplicateFCToolStripMenuItem.Name = "duplicateFCToolStripMenuItem";
            this.duplicateFCToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.duplicateFCToolStripMenuItem.Text = "Duplicate";
            this.duplicateFCToolStripMenuItem.Click += new System.EventHandler(this.duplicateFCToolStripMenuItem_Click);
            // 
            // btnExecuteRead
            // 
            this.btnExecuteRead.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.ReadData;
            this.btnExecuteRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecuteRead.FlatAppearance.BorderSize = 0;
            this.btnExecuteRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteRead.Location = new System.Drawing.Point(38, 38);
            this.btnExecuteRead.Name = "btnExecuteRead";
            this.btnExecuteRead.Size = new System.Drawing.Size(17, 17);
            this.btnExecuteRead.TabIndex = 21;
            this.btnExecuteRead.UseVisualStyleBackColor = true;
            this.btnExecuteRead.Click += new System.EventHandler(this.btnExecuteRead_Click);
            // 
            // btnViewTable
            // 
            this.btnViewTable.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.Table;
            this.btnViewTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewTable.FlatAppearance.BorderSize = 0;
            this.btnViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTable.Location = new System.Drawing.Point(339, 45);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(29, 30);
            this.btnViewTable.TabIndex = 20;
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // picError
            // 
            this.picError.Image = global::BV_Modbus_Client.Properties.Resources.ErrorTriangle;
            this.picError.Location = new System.Drawing.Point(272, 22);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(22, 20);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 22;
            this.picError.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblAddress.Location = new System.Drawing.Point(35, 5);
            this.lblAddress.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 12);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "label1";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContextMenu
            // 
            this.btnContextMenu.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.MenuIcon;
            this.btnContextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContextMenu.FlatAppearance.BorderSize = 0;
            this.btnContextMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContextMenu.Location = new System.Drawing.Point(244, 12);
            this.btnContextMenu.Name = "btnContextMenu";
            this.btnContextMenu.Size = new System.Drawing.Size(20, 20);
            this.btnContextMenu.TabIndex = 19;
            this.btnContextMenu.UseVisualStyleBackColor = true;
            // 
            // btnRunFc2
            // 
            this.btnRunFc2.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.SendData;
            this.btnRunFc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRunFc2.FlatAppearance.BorderSize = 0;
            this.btnRunFc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunFc2.Location = new System.Drawing.Point(248, 38);
            this.btnRunFc2.Name = "btnRunFc2";
            this.btnRunFc2.Size = new System.Drawing.Size(17, 17);
            this.btnRunFc2.TabIndex = 18;
            this.btnRunFc2.UseVisualStyleBackColor = true;
            this.btnRunFc2.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblHeader.Location = new System.Drawing.Point(34, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(238, 20);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "My FC label - writing multiple registers";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(36, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 2);
            this.panel2.TabIndex = 24;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.Location = new System.Drawing.Point(59, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(186, 23);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // FcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExecuteRead);
            this.Controls.Add(this.btnViewTable);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnContextMenu);
            this.Controls.Add(this.btnRunFc2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FcView";
            this.Size = new System.Drawing.Size(357, 67);
            this.MouseEnter += new System.EventHandler(this.FcView_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FcView_MouseLeave);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private ToolTip toolTip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem changeFCTypeToolStripMenuItem;
        private ToolStripMenuItem duplicateFCToolStripMenuItem;
        private Button btnExecuteRead;
        private Button btnViewTable;
        private PictureBox picError;
        private Label lblAddress;
        private Button btnContextMenu;
        private Button btnRunFc2;
        private Label lblHeader;
        private Panel panel2;
        private DataGridView dataGridView2;
    }
}
