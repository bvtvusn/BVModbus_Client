﻿using BV_Modbus_Client.BusinessLayer;
using BV_Modbus_Client.GUI;
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

    // Future work:
    // Add show errors in grid using datagridview.errortext
    // Fix byte order
    // Allow change of Description from dgv
    public partial class ValueFormatPanel : UserControl
    {
        private BLL bll;
        private bool userEditActiveFlag;
        private bool refreshActiveFlag;

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
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void DataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (bll.SelectedFcRequest != null)
            {

                userEditActiveFlag = true;
                
                if (refreshActiveFlag == false)
                {

                    string[] tableData = GetColumnData(dataGridView1, 1);
                    string[] addressDescriptions = GetColumnData(dataGridView1, 2);

                    bll.SelectedFcRequest.SetFcData(tableData);
                    bll.SelectedFcRequest.SetFcDescription(addressDescriptions);

                }
                userEditActiveFlag = false;
            }
        }

        private string[] GetColumnData(DataGridView dgv, int columnIndex)
        {
            List<string> columnData = new List<string>();

            // Check if the specified column exists
            if (dgv.Columns.Count > columnIndex)
            {
                // Iterate through the rows and add the cell values from the specified column
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[columnIndex].Value != null)
                    {
                        columnData.Add(row.Cells[columnIndex].Value.ToString());
                    }
                }
            }

            return columnData.ToArray();
        }

        private void Bll_SelectedDataRecevivedEvent(string obj)
        {
            ControlExtensions.UIThreadInvoke(this, delegate {

                if (userEditActiveFlag == false)
                {
                    refreshActiveFlag = true;

                    RefreshDataGrid();

                    refreshActiveFlag = false;
                }
            });
        }

        void RefreshDataGrid()
        {
            //dataGridView1.Columns.Clear();

            List<ValueFormat> formats = Bll.SelectedFcRequest.formatContainer.valueFormats;
            var dataPoints = Bll.SelectedFcRequest.GetDataAsString(true);
            //string[] convertedValues = Bll.SelectedFcRequest.GetStrings();

            // CREATE COLUMNS IF NOT ALREADY CREATED
            int nColumns = 3;
            if (dataGridView1.Columns.Count < nColumns)
            {

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
                dataGridView1.Columns[0].ReadOnly = true;
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[0].Value = "";
                item.Cells[1].Value = "";
                item.Cells[2].Value = "";
                item.Cells[0].Style = null; // style;
            }
            // Create correct number of rows in datagridview
            int rowNumberToAdd = dataPoints.Length - dataGridView1.Rows.Count;
            // Adding rows
            for (int i = 0; i < rowNumberToAdd; i++)
            {
                DataGridViewRow dr1 = new DataGridViewRow();
                dr1.CreateCells(dataGridView1);
                dr1.Cells[0].Value = "";
                dr1.Cells[1].Value = "";
                dr1.Cells[2].Value = "";
                dataGridView1.Rows.Add(dr1);
            }
            //Removing rows if necessary:
            for (int i = rowNumberToAdd; i < 0; i++)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count-1);
            }

            int rowCounter = 0;
            for (int i = 0; i < formats.Count; i++)
            {


                // ADD EMPTY CELLS BEFORE
                //while (dataGridView1.Rows.Count < formats[i].Register && dataGridView1.Rows.Count < dataPoints.Length)
                //{
                //    DataGridViewRow dr1 = new DataGridViewRow();
                //    dr1.CreateCells(dataGridView1);
                //    dr1.Cells[0].Value = "";
                //    dr1.Cells[1].Value = dataPoints[rowCounter].Item1;
                //    dr1.Cells[2].Value = dataPoints[rowCounter].Item2;
                //    dataGridView1.Rows.Add(dr1);
                //    rowCounter++;
                //}
                //if (dataGridView1.Rows.Count < dataPoints.Length)
                //{
                for (int j = 0; j < formats[i].Length; j++)
                {

                    //DataGridViewRow dr = new DataGridViewRow();
                    //dr.CreateCells(dataGridView1);


                    //dr.Cells[0].Value = formats[i].FormatType.ToString();

                    int row = formats[i].Register + j;
                    if (row < dataGridView1.Rows.Count)
                    {

                        if (rowCounter < dataPoints.Length)
                        {
                            dataGridView1.Rows[row].Cells[0].Value = formats[i].FormatType.ToString();
                            dataGridView1.Rows[row].Cells[1].Value = dataPoints[row].Item1;
                            dataGridView1.Rows[row].Cells[2].Value = dataPoints[row].Item2;
                            //dr.Cells[1].Value = dataPoints[rowCounter].Item1;
                            //dr.Cells[2].Value = dataPoints[rowCounter].Item2;
                        }

                        if (i % 2 == 0)
                        {
                            DataGridViewCellStyle style = new DataGridViewCellStyle();
                            style.BackColor = Color.FromArgb(221, 237, 255);
                            // style.BackColor = Color.FromArgb(86, 165, 255);
                            style.ForeColor = Color.Black;
                            dataGridView1.Rows[row].Cells[0].Style = style;
                        }
                        else
                        {
                            DataGridViewCellStyle style = new DataGridViewCellStyle();
                            style.BackColor = Color.FromArgb(187, 219, 255);
                            //style.BackColor = Color.FromArgb(0, 195, 255);
                            style.ForeColor = Color.Black;
                            dataGridView1.Rows[row].Cells[0].Style = style;
                        }
                    }

                } //dataGridView1.Rows.Add(dr);
                  //rowCounter++;
            }
                
                

            

            // ADD EMPTY CELLS AFTER
            //while (dataGridView1.Rows.Count < dataPoints.Length)
            //{
            //    DataGridViewRow dr1 = new DataGridViewRow();
            //    dr1.CreateCells(dataGridView1);
            //    dr1.Cells[0].Value = "";
            //    dr1.Cells[1].Value = dataPoints[rowCounter].Item1;
            //    dr1.Cells[2].Value = dataPoints[rowCounter].Item2;
            //    dataGridView1.Rows.Add(dr1);
            //    rowCounter++;
            //}


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
                length = (int)numAscii.Value;
                FormatConverter.FormatName type = FormatConverter.FormatName.Ascii;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "uint16")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Uint16;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "int16")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Int16;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "uint32")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Uint32;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "int32")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Int32;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "float")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Float;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "double")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Double;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "boolean")
            {
                FormatConverter.FormatName type = FormatConverter.FormatName.Boolean;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "binary")
            {
                length = (int)numBinary.Value;
                FormatConverter.FormatName type = FormatConverter.FormatName.Binary;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }
            else if ((string)myButton.Tag == "hex")
            {
                length = (int)numHex.Value;
                FormatConverter.FormatName type = FormatConverter.FormatName.Hex;
                numberOfRegisters_returned = Bll.SelectedFcRequest.formatContainer.SetFormat(rowIndex, type, length);
            }

            refreshActiveFlag = true;
            RefreshDataGrid();
            refreshActiveFlag = false;

            int nextIndex = rowIndex + numberOfRegisters_returned;
            if (nextIndex < dataGridView1.Rows.Count)
            {
                //dataGridView1.Rows[nextIndex].Selected = true;
                dataGridView1.Rows[nextIndex].Cells[0].Selected = true;
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
