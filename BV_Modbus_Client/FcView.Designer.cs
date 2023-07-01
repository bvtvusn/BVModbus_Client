namespace BV_Modbus_Client
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRunFc2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings2 = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel2b = new System.Windows.Forms.Panel();
            this.picError = new System.Windows.Forms.PictureBox();
            this.btnExecuteRead = new System.Windows.Forms.Button();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.btnContextMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(5, 31);
            this.lblHeader.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(167, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "My FC label - writing multiple registers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(5, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(186, 23);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnRunFc2
            // 
            this.btnRunFc2.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.SendData;
            this.btnRunFc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRunFc2.FlatAppearance.BorderSize = 0;
            this.btnRunFc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunFc2.Location = new System.Drawing.Point(126, 4);
            this.btnRunFc2.Name = "btnRunFc2";
            this.btnRunFc2.Size = new System.Drawing.Size(17, 17);
            this.btnRunFc2.TabIndex = 8;
            this.btnRunFc2.UseVisualStyleBackColor = true;
            this.btnRunFc2.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 3);
            this.panel1.TabIndex = 9;
            // 
            // btnSettings2
            // 
            this.btnSettings2.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.Settings;
            this.btnSettings2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings2.FlatAppearance.BorderSize = 0;
            this.btnSettings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings2.Location = new System.Drawing.Point(152, 4);
            this.btnSettings2.Name = "btnSettings2";
            this.btnSettings2.Size = new System.Drawing.Size(17, 17);
            this.btnSettings2.TabIndex = 10;
            this.btnSettings2.UseVisualStyleBackColor = true;
            this.btnSettings2.Click += new System.EventHandler(this.btnSettings2_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(6, 7);
            this.lblAddress.MaximumSize = new System.Drawing.Size(51, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(14, 15);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "1";
            // 
            // panel2b
            // 
            this.panel2b.BackColor = System.Drawing.Color.White;
            this.panel2b.Controls.Add(this.picError);
            this.panel2b.Controls.Add(this.btnExecuteRead);
            this.panel2b.Controls.Add(this.btnViewTable);
            this.panel2b.Controls.Add(this.lblHeader);
            this.panel2b.Controls.Add(this.lblAddress);
            this.panel2b.Controls.Add(this.dataGridView1);
            this.panel2b.Controls.Add(this.btnContextMenu);
            this.panel2b.Controls.Add(this.btnSettings2);
            this.panel2b.Controls.Add(this.btnRunFc2);
            this.panel2b.Controls.Add(this.panel1);
            this.panel2b.Location = new System.Drawing.Point(5, 5);
            this.panel2b.Name = "panel2b";
            this.panel2b.Size = new System.Drawing.Size(204, 100);
            this.panel2b.TabIndex = 13;
            // 
            // picError
            // 
            this.picError.Image = global::BV_Modbus_Client.Properties.Resources.ErrorTriangle;
            this.picError.Location = new System.Drawing.Point(176, 28);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(22, 20);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 15;
            this.picError.TabStop = false;
            // 
            // btnExecuteRead
            // 
            this.btnExecuteRead.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.ReadData;
            this.btnExecuteRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecuteRead.FlatAppearance.BorderSize = 0;
            this.btnExecuteRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteRead.Location = new System.Drawing.Point(71, 4);
            this.btnExecuteRead.Name = "btnExecuteRead";
            this.btnExecuteRead.Size = new System.Drawing.Size(17, 17);
            this.btnExecuteRead.TabIndex = 14;
            this.btnExecuteRead.UseVisualStyleBackColor = true;
            this.btnExecuteRead.Click += new System.EventHandler(this.btnExecuteRead_Click);
            // 
            // btnViewTable
            // 
            this.btnViewTable.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.Table;
            this.btnViewTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewTable.FlatAppearance.BorderSize = 0;
            this.btnViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTable.Location = new System.Drawing.Point(92, -2);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(29, 30);
            this.btnViewTable.TabIndex = 13;
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // btnContextMenu
            // 
            this.btnContextMenu.BackgroundImage = global::BV_Modbus_Client.Properties.Resources.MenuIcon;
            this.btnContextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContextMenu.FlatAppearance.BorderSize = 0;
            this.btnContextMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContextMenu.Location = new System.Drawing.Point(177, 3);
            this.btnContextMenu.Name = "btnContextMenu";
            this.btnContextMenu.Size = new System.Drawing.Size(20, 20);
            this.btnContextMenu.TabIndex = 10;
            this.btnContextMenu.UseVisualStyleBackColor = true;
            this.btnContextMenu.Click += new System.EventHandler(this.btnContextMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aToolStripMenuItem.Text = "Remove";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.CheckOnClick = true;
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.bToolStripMenuItem.Text = "Polling";
            this.bToolStripMenuItem.CheckedChanged += new System.EventHandler(this.bToolStripMenuItem_CheckedChanged);
            // 
            // FcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2b);
            this.Name = "FcView";
            this.Size = new System.Drawing.Size(214, 110);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2b.ResumeLayout(false);
            this.panel2b.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblHeader;
        private DataGridView dataGridView1;
        private Button btnRunFc2;
        private Panel panel1;
        private Button btnSettings2;
        private Label lblAddress;
        private Panel panel2b;
        private Button btnViewTable;
        private Button btnExecuteRead;
        private ToolTip toolTip1;
        private PictureBox picError;
        private Button btnContextMenu;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
    }
}
