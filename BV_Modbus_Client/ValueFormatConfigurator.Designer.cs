namespace BV_Modbus_Client
{
    partial class ValueFormatConfigurator
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
            this.btnUint16 = new System.Windows.Forms.Button();
            this.btnASCII = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numRegIndex = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUint16
            // 
            this.btnUint16.Location = new System.Drawing.Point(90, 40);
            this.btnUint16.Name = "btnUint16";
            this.btnUint16.Size = new System.Drawing.Size(114, 23);
            this.btnUint16.TabIndex = 0;
            this.btnUint16.Tag = "uint16";
            this.btnUint16.Text = "Uint16";
            this.btnUint16.UseVisualStyleBackColor = true;
            this.btnUint16.Click += new System.EventHandler(this.btnSetType_Click);
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(90, 69);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(114, 23);
            this.btnASCII.TabIndex = 2;
            this.btnASCII.Tag = "ascii";
            this.btnASCII.Text = "ASCII";
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnSetType_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(20, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRegIndex
            // 
            this.numRegIndex.Location = new System.Drawing.Point(122, 178);
            this.numRegIndex.Name = "numRegIndex";
            this.numRegIndex.Size = new System.Drawing.Size(120, 23);
            this.numRegIndex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Register index";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 205);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(104, 114);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(100, 23);
            this.txtShow.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(23, 114);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ValueFormatConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 217);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRegIndex);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnASCII);
            this.Controls.Add(this.btnUint16);
            this.Name = "ValueFormatConfigurator";
            this.Text = "ValueFormatConfigurator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUint16;
        private Button btnASCII;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numRegIndex;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtShow;
        private Button btnTest;
    }
}