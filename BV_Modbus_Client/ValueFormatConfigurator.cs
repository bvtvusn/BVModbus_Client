using BV_Modbus_Client.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV_Modbus_Client
{
    public partial class ValueFormatConfigurator : Form
    {
        public ValueFormatConfigurator(BLL bll)
        {
            InitializeComponent();
            this.Bll = bll;
        }

        private BLL Bll { get; }

        private void btnSetType_Click(object sender, EventArgs e)
        {
            Button? myButton = sender as Button;
            int register = Convert.ToInt32(numRegIndex.Value);
            int length = 2;
            if ((string)myButton.Tag == "ascii")
            {
                
                FormatConverter.FormatName type = FormatConverter.FormatName.Ascii;
               

                Bll.SelectedFcRequest.formatContainer.SetFormat(register, type, length);
            }
            else if ((string)myButton.Tag == "uint16")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Uint16;
                Bll.SelectedFcRequest.formatContainer.SetFormat(register, type, length);
            }

            RefreshDataGrid();
        }

        void RefreshDataGrid()
        {
            dataGridView1.Columns.Clear();

            int nColumns = 2;
            List<ValueFormat> formats =  Bll.SelectedFcRequest.formatContainer.valueFormats;
            string[] convertedValues = Bll.SelectedFcRequest.GetStrings();

            for (int i = 0; i < nColumns; i++)
            {
                DataGridViewTextBoxColumn checkColumn = new DataGridViewTextBoxColumn();
                checkColumn.ReadOnly = false;
                dataGridView1.Columns.Add(checkColumn);
            }

            int rowCounter = 0;
            for (int i = 0; i < formats.Count; i++)
            {

            
                while (dataGridView1.Rows.Count-1 < formats[i].Register)
                {
                    DataGridViewRow dr1 = new DataGridViewRow();
                    dr1.CreateCells(dataGridView1);
                    dr1.Cells[0].Value ="";
                    dataGridView1.Rows.Add(dr1);
                    rowCounter++;
                }
                for (int j = 0; j < formats[i].Length; j++)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dataGridView1);
                    dr.Cells[0].Value = formats[i].FormatType.ToString();
                    dr.Cells[1].Value = convertedValues[rowCounter];

                    if (i % 2 == 0)
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.FromArgb(245,245,245);
                        style.ForeColor = Color.Black;
                        dr.Cells[0].Style = style;
                    }
                    else
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.FromArgb(230, 230, 230);
                        style.ForeColor = Color.Black;
                        dr.Cells[0].Style = style;
                    }
                    dataGridView1.Rows.Add(dr);
                    rowCounter++;
                }
                
            }
            //DataGridViewRow dr = new DataGridViewRow();
            //dr.CreateCells(dataGridView1);
            //for (int i = 0; i < viewData.Length; i++)
            //{
            //    dr.Cells[i].Value = viewData[i] != "0";

            //}
            //dataGridView1.Rows.Add(dr);
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var  strLines = Bll.SelectedFcRequest.formatContainer.BinaryToString(Bll.SelectedFcRequest.ReadCompleteBufferAsArray(), false, false);
            foreach (var item in strLines)
            {
                txtShow.AppendText(item + "\r\n");
            }
        }
    }
}
