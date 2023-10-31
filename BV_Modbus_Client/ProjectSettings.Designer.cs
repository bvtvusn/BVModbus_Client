namespace BV_Modbus_Client
{
    partial class ProjectSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAddressingZeroBased = new System.Windows.Forms.RadioButton();
            this.rdoAddressingOneBased = new System.Windows.Forms.RadioButton();
            this.cboFloatFormat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAddressingZeroBased);
            this.groupBox1.Controls.Add(this.rdoAddressingOneBased);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Addressing";
            // 
            // rdoAddressingZeroBased
            // 
            this.rdoAddressingZeroBased.AutoSize = true;
            this.rdoAddressingZeroBased.Location = new System.Drawing.Point(6, 22);
            this.rdoAddressingZeroBased.Name = "rdoAddressingZeroBased";
            this.rdoAddressingZeroBased.Size = new System.Drawing.Size(83, 19);
            this.rdoAddressingZeroBased.TabIndex = 1;
            this.rdoAddressingZeroBased.TabStop = true;
            this.rdoAddressingZeroBased.Text = "Zero Based";
            this.rdoAddressingZeroBased.UseVisualStyleBackColor = true;
            this.rdoAddressingZeroBased.CheckedChanged += new System.EventHandler(this.rdoAddressingZeroBased_CheckedChanged);
            // 
            // rdoAddressingOneBased
            // 
            this.rdoAddressingOneBased.AutoSize = true;
            this.rdoAddressingOneBased.Location = new System.Drawing.Point(6, 47);
            this.rdoAddressingOneBased.Name = "rdoAddressingOneBased";
            this.rdoAddressingOneBased.Size = new System.Drawing.Size(81, 19);
            this.rdoAddressingOneBased.TabIndex = 1;
            this.rdoAddressingOneBased.TabStop = true;
            this.rdoAddressingOneBased.Text = "One Based";
            this.rdoAddressingOneBased.UseVisualStyleBackColor = true;
            this.rdoAddressingOneBased.Click += new System.EventHandler(this.rdoAddressingZeroBased_CheckedChanged);
            // 
            // cboFloatFormat
            // 
            this.cboFloatFormat.FormattingEnabled = true;
            this.cboFloatFormat.Location = new System.Drawing.Point(161, 39);
            this.cboFloatFormat.Name = "cboFloatFormat";
            this.cboFloatFormat.Size = new System.Drawing.Size(121, 23);
            this.cboFloatFormat.TabIndex = 1;
            this.cboFloatFormat.Text = "0.0";
            // 
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 113);
            this.Controls.Add(this.cboFloatFormat);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectSettings";
            this.Text = "ProjectSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoAddressingZeroBased;
        private RadioButton rdoAddressingOneBased;
        private ComboBox cboFloatFormat;
    }
}