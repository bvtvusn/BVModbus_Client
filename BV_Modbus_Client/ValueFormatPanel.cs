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
    public partial class ValueFormatPanel : UserControl
    {
        private BLL bll;

        public BLL Bll
        {
            get => bll; set
            {
                bll = value;
                Bll.SelectedDataRecevivedEvent += Bll_SelectedDataRecevivedEvent;
            }
        }
        public ValueFormatPanel()
        {
            InitializeComponent();
            
        }

        private void Bll_SelectedDataRecevivedEvent(string obj)
        {
            RefreshDataGrid();
        }

        void RefreshDataGrid()
        {
            dataGridView1.Columns.Clear();

            List<ValueFormat> formats = Bll.SelectedFcRequest.formatContainer.valueFormats;
            //string[] convertedValues = Bll.SelectedFcRequest.GetStrings();
            var dataPoints = Bll.SelectedFcRequest.GetDataAsString(true);

            int nColumns = 3;
            for (int i = 0; i < nColumns; i++)
            {
                DataGridViewTextBoxColumn checkColumn = new DataGridViewTextBoxColumn();
                checkColumn.ReadOnly = false;
                checkColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                dataGridView1.Columns.Add(checkColumn);
            }
            dataGridView1.Columns[0].HeaderText = "Datatype";
            dataGridView1.Columns[1].HeaderText = "Value";
            dataGridView1.Columns[2].HeaderText = "Description";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            int rowCounter = 0;
            for (int i = 0; i < formats.Count; i++)
            {
                
                
                // ADD EMPTY CELLS BEFORE
                while (dataGridView1.Rows.Count < formats[i].Register && dataGridView1.Rows.Count < dataPoints.Length)
                {
                    DataGridViewRow dr1 = new DataGridViewRow();
                    dr1.CreateCells(dataGridView1);
                    dr1.Cells[0].Value = "";
                    dr1.Cells[1].Value = dataPoints[rowCounter].Item1;
                    dr1.Cells[2].Value = dataPoints[rowCounter].Item2;
                    dataGridView1.Rows.Add(dr1);
                    rowCounter++;
                }
                if (dataGridView1.Rows.Count < dataPoints.Length)
                {
                    for (int j = 0; j < formats[i].Length; j++)
                    {
                        //if (rowCounter < dataPoints.Length) break;
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(dataGridView1);
                        dr.Cells[0].Value = formats[i].FormatType.ToString();
                        //dr.Cells[1].Value = convertedValues[rowCounter];
                        if (rowCounter < dataPoints.Length)
                        {

                            dr.Cells[1].Value = dataPoints[rowCounter].Item1;
                            dr.Cells[2].Value = dataPoints[rowCounter].Item2;
                        }

                        if (i % 2 == 0)
                        {
                            DataGridViewCellStyle style = new DataGridViewCellStyle();
                            style.BackColor = Color.FromArgb(221, 237, 255);
                            // style.BackColor = Color.FromArgb(86, 165, 255);
                            style.ForeColor = Color.Black;
                            dr.Cells[0].Style = style;
                        }
                        else
                        {
                            DataGridViewCellStyle style = new DataGridViewCellStyle();
                            style.BackColor = Color.FromArgb(187, 219, 255);
                            //style.BackColor = Color.FromArgb(0, 195, 255);
                            style.ForeColor = Color.Black;
                            dr.Cells[0].Style = style;
                        }
                        dataGridView1.Rows.Add(dr);
                        rowCounter++;
                    }
                }
                

            }

            // ADD EMPTY CELLS AFTER
            while (dataGridView1.Rows.Count < dataPoints.Length)
            {
                DataGridViewRow dr1 = new DataGridViewRow();
                dr1.CreateCells(dataGridView1);
                dr1.Cells[0].Value = "";
                dr1.Cells[1].Value = dataPoints[rowCounter].Item1;
                dr1.Cells[2].Value = dataPoints[rowCounter].Item2;
                dataGridView1.Rows.Add(dr1);
                rowCounter++;
            }


            //DataGridViewRow dr = new DataGridViewRow();
            //dr.CreateCells(dataGridView1);
            //for (int i = 0; i < viewData.Length; i++)
            //{
            //    dr.Cells[i].Value = viewData[i] != "0";

            //}
            //dataGridView1.Rows.Add(dr);

        }

        private void btnSetDatatype_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            if (dataGridView1.CurrentCell != null)
            {
                rowIndex = dataGridView1.CurrentCell.RowIndex;
            }
            
            Button? myButton = sender as Button;
            //int register = Convert.ToInt32(numRegIndex.Value);
            int length = 2;
            int numberOfRegisters_returned = 0; // Initial
            if ((string)myButton.Tag == "ascii")
            {

                FormatConverter.FormatName type = FormatConverter.FormatName.Ascii;


                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "uint16")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Uint16;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }

            RefreshDataGrid();

            int nextIndex = rowIndex + numberOfRegisters_returned;
            if (nextIndex < dataGridView1.Rows.Count)
            {
                //dataGridView1.Rows[nextIndex].Selected = true;
                dataGridView1.Rows[nextIndex].Cells[0].Selected = true;
            }
            
        }
    }
}
