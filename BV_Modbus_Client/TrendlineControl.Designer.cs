namespace BV_Modbus_Client
{
    partial class TrendlineControl
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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.chkPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.Color.White;
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(140, 0);
            this.plotView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(615, 264);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // chkPanel
            // 
            this.chkPanel.BackColor = System.Drawing.Color.White;
            this.chkPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkPanel.Location = new System.Drawing.Point(0, 0);
            this.chkPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPanel.Name = "chkPanel";
            this.chkPanel.Size = new System.Drawing.Size(140, 264);
            this.chkPanel.TabIndex = 1;
            // 
            // TrendlineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.chkPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrendlineControl";
            this.Size = new System.Drawing.Size(755, 264);
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private Panel chkPanel;
    }
}
