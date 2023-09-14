using BV_Modbus_Client.BusinessLayer;
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
    internal partial class FcView : UserControl
    {
        private FcWrapperBase    fcCommand;
        private BLL bll;
        private bool refreshActiveFlag;
        private bool userEditActiveFlag;

        Color DefaultBackcolor = Color.White;
        Color HighlightedBackcolor = Color.FromArgb(246,246,246);
        

        //private FcWrapperBase? fcWrapperBase;

        //internal FcWrapperBase FcCommand
        //{
        //    get { return fcCommand; }
        //    set { fcCommand = value; }
        //}

        //public FcView()
        //{
        //}

        public FcView(FcWrapperBase? fcWrapperBase)
        {
            
        }

        public FcView(FcWrapperBase? fcWrapperBase, BLL bll)
        {
            this.bll = bll;
            InitializeComponent();
            this.fcCommand = fcWrapperBase;
            UpdateFcInfo();
            toolTip1.SetToolTip(btnExecuteRead, fcCommand.OperationReadDescription);
            toolTip1.SetToolTip(btnRunFc2, fcCommand.OperationWriteDescription);

            btnRunFc2.Visible = fcCommand.OperationWriteDescription != "Write"; // Hide button if no description is supplied
            //dataGridView2.ReadOnly = !fcCommand.FcTypeWrite;
            //if (fcCommand.FcTypeWrite)
            //{
            //    btnRunFc2.Text = "Write";
            //}
            //else
            //{
            //    btnRunFc2.Text = "Read";
            //}

            //DrawSelection(fcWrapperBase.isSelected);
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
            
            //dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44,54,79);
            fcCommand.FormatValidStateEvent += FcCommand_FormatValidStateEvent;
            fcCommand.FcSettingsChangedEvent += FcCommand_FcSettingsChangedEvent;
            fcCommand.SelectedChanged += FcCommand_SelectedChanged;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged; // Sends data to FC object
            fcCommand.RefreshDataEvent += FcWrapperBase_ResponseReceived; // Receives data from FC object. ( Do not receive updates to gui if we are sending data)
            fcCommand.FcActivatedEvent += FcCommand_FcActivatedEvent;  // Activated on FC read and write
            FillPreviewTable();
            fcCommand.ForceDataRefresh(""); // Makes fake event to force update

            DrawSelection(fcCommand.isSelected);

            WireMouseEvents(this);

        }
        void WireMouseEvents(Control container) // Attaches events to all children of the main control.
        {
            foreach (Control c in container.Controls)
            {
                c.Click += (s, e) => OnClick(e);
                c.DoubleClick += (s, e) => OnDoubleClick(e);
                c.MouseHover += (s, e) => OnMouseHover(e);
                c.MouseEnter += (s,e)=> OnMouseEnter(e);
                c.MouseLeave += (s, e) => OnMouseLeave(e);

                c.MouseClick += (s, e) => {
                    var p = PointToThis((Control)s, e.Location);
                    OnMouseClick(new MouseEventArgs(e.Button, e.Clicks, p.X, p.Y, e.Delta));
                };
                c.MouseDoubleClick += (s, e) => {
                    var p = PointToThis((Control)s, e.Location);
                    OnMouseDoubleClick(new MouseEventArgs(e.Button, e.Clicks, p.X, p.Y, e.Delta));
                };

                WireMouseEvents(c);
            };
        }
        Point PointToThis(Control c, Point p)
        {
            return PointToClient(c.PointToScreen(p));
        }
        private async void FcCommand_FcActivatedEvent()
        {
            await this.BlinkPanelAsync(dataGridView2, ColorPalette.Action, TimeSpan.FromSeconds(0.15));
        }

        #region Events
        private void FcCommand_FormatValidStateEvent(string[] errors)
        {
            int length = Math.Min(4, errors.Length);

            for (int i = 0; i < length; i++)
            {
                bool isError = false;
                if (errors[i] != null)
                {
                    if (errors[i].Length > 0)
                    {
                        isError = true;
                    }
                }

                if (isError)
                {
                    dataGridView2.Rows[0].Cells[i].Style.BackColor = Color.Red;

                }
                else
                {
                    dataGridView2.Rows[0].Cells[i].Style.BackColor = Color.White;
                }
            }

        }
        private void FcCommand_FcSettingsChangedEvent()
        {
            UpdateFcInfo();

            FillPreviewTable(); // Updates the values in case the start addr was changed.
        }
        private void FcCommand_SelectedChanged(FcWrapperBase arg1, bool isSelected)
        {
            DrawSelection(isSelected);
        }
        private void dataGridView2_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            userEditActiveFlag = true;
            //string[] frmDgv = (string[])(dataGridView2.DataSource as DataTable).Rows[0].ItemArray;
            if (refreshActiveFlag == false)
            {
                string[] tableData = ReadFirstRowFromDataGridView(dataGridView2);
                fcCommand.SetFcData(tableData);

            }
            userEditActiveFlag = false;
        }
        private void FcWrapperBase_ResponseReceived(string errormsg)
        {
            if (errormsg.Length == 0)
            {

                if (userEditActiveFlag == false)  // Prevents writing if event was triggered by user.
                {

                    refreshActiveFlag = true;

                    //if (this.InvokeRequired)
                    //{
                    //    this.Invoke(FillPreviewTable());
                    //}
                    ControlExtensions.UIThreadInvoke(this, delegate {
                        FillPreviewTable();
                    });
                    //FillPreviewTable();
                    refreshActiveFlag = false;
                }
                ControlExtensions.UIThreadInvoke(this, delegate {
                    picError.Visible = false;
                });
                //if (this.IsHandleCreated)
                //{
                //    picError.Invoke((MethodInvoker)(() => {
                //        picError.Visible = false;
                //    }));
                //}
                
                
                //picError.Visible = false;
            }
            else
            {
                if (this.IsHandleCreated)
                {
                    //picError.Invoke((MethodInvoker)(() => {
                    //    picError.Visible = true;
                    //}));
                    ControlExtensions.UIThreadInvoke(this, delegate {
                        picError.Visible = true;
                        toolTip1.SetToolTip(picError, errormsg);
                    });
                }
                
            }

        }

        

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (bll.Modbus_IsConnected)
            {
                fcCommand.ExecuteWriteAsync();
            }
            else
            {
                MessageBox.Show("Please connect to a Modbus slave");
            }

        }
        private void btnExecuteRead_Click(object sender, EventArgs e)
        {
            if (bll.Modbus_IsConnected)
            {
                fcCommand.ExecuteReadAsync();
            }
            else
            {
                MessageBox.Show("Please connect to a Modbus slave");
            }
        }

        private void btnSettings2_Click(object sender, EventArgs e)
        {

        }
        private void btnRemoveFc_Click(object sender, EventArgs e)
        {
            //bll.RemoveFC(fcCommand);
            
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            bll.SetSelectedCard(fcCommand);
        }
        #endregion
        #region Draw


        private void DrawSelection(bool isSelected)
        {
            if (isSelected)
            {
                //this.BackColor = Color.FromArgb(27, 188, 155);
                //panel1.BackColor = ColorPalette.Detail; // Color.FromArgb(27, 188, 155);
                //this.BackColor = Color.FromArgb(35, 172, 227);
                SelectedIndicatorPanel.BackColor = ColorPalette.Detail;
                this.BackColor = HighlightedBackcolor;
            }
            else
            {
                SelectedIndicatorPanel.BackColor = ColorPalette.Control;
                //this.BackColor = Color.FromArgb(240, 240, 240);
                //panel1.BackColor = ColorPalette.Header;
                this.BackColor = DefaultBackcolor;
            }
        }
        private void UpdateFcInfo()
        {
            bool onPoll = bll.UserConfig.pollTimer.CheckPollingEnabled(fcCommand);
            this.bToolStripMenuItem.Checked = onPoll; // Update the visible polling status in the menu
            lblHeader.Text = fcCommand.Description;
            if (fcCommand.NumberOfRegisters > 1)
            {
                lblAddress.Text = "" + fcCommand.StartAddress + " - " + (fcCommand.StartAddress+fcCommand.NumberOfRegisters-1);

            }
            else
            {
                lblAddress.Text = "" + fcCommand.StartAddress;
            }
        }
        private void FillPreviewTable()
        {
            bool chk = fcCommand.DisplayType == FormatConverter.FormatName.Boolean;
            int maxDisplayLength = 4;
            if (chk)
            {
                maxDisplayLength = 8;
            }

            (string, string)[] data = fcCommand.GetDataAsString();
            if (data.Length > maxDisplayLength)
            {
                data = ((string, string)[])data.Take(maxDisplayLength).ToArray();
            }
            string[] viewData = data.Select(x => x.Item1).ToArray();

            //DataTable testdt = new DataTable();
            //testdt.Columns.Add("t1", typeof(bool));
            //testdt.Columns.Add("t2", typeof(bool));
            //testdt.Rows.Add(false, true);
            //dataGridView2.DataSource = testdt;
            //try
            //{
            ////dataGridView2.Columns[0].ValueType = typeof(bool);

            //}
            //catch (Exception)
            //{

            //}     
            
            // dataGridView2.DataSource = FormatConverter.ArrayToDatatableRow(viewData,false);
            //dataGridView2.Columns[0].ValueType = typeof(DataGridViewCheckBoxColumn);
            dataGridView2.Columns.Clear();

            if (chk)
            {
                for (int i = 0; i < viewData.Length; i++)
                {
                    DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                    checkColumn.ReadOnly = false;
                    dataGridView2.Columns.Add(checkColumn);
                }
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView2);
                for (int i = 0; i < viewData.Length; i++)
                {
                    dr.Cells[i].Value = viewData[i] != "0";

                }
                dataGridView2.Rows.Add(dr);
            }
            else
            {
                for (int i = 0; i < viewData.Length; i++)
                {
                    DataGridViewTextBoxColumn checkColumn = new DataGridViewTextBoxColumn();
                    checkColumn.ReadOnly = false;
                    dataGridView2.Columns.Add(checkColumn);
                }
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView2);
                for (int i = 0; i < viewData.Length; i++)
                {
                    dr.Cells[i].Value = viewData[i] ;
                }
                dataGridView2.Rows.Add(dr);
            }

        }
        #endregion


        //private void InvokeControlSafely(Control control, Action action)
        //{
        //    if (control.IsHandleCreated)
        //    {
        //        if (control.InvokeRequired)
        //        {
        //            control.Invoke((MethodInvoker)action);
        //        }
        //        else
        //        {
        //            action.Invoke();
        //        }
        //    }
        //    else
        //    {
        //        // Handle not created yet, handle the case accordingly
        //    }
        //}

        private string[] ReadFirstRowFromDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                DataGridViewRow firstRow = dataGridView.Rows[0];
                int columnCount = firstRow.Cells.Count;
                string[] rowData = new string[columnCount];

                for (int i = 0; i < columnCount; i++)
                {
                    DataGridViewCell cell = firstRow.Cells[i];
                    if (cell is DataGridViewCheckBoxCell)
                    {
                        rowData[i] = cell.Value != null ? Convert.ToUInt16(cell.Value).ToString() : string.Empty;
                    }
                    else
                    {
                        rowData[i] = cell.Value != null ? cell.Value.ToString() : string.Empty;

                    }

                }

                return rowData;
            }

            return null; // Return null if the DataGridView is empty
        }

        private void btnContextMenu_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.RemoveFC(fcCommand);
        }
        public async Task BlinkPanelAsync(DataGridView panel, Color color, TimeSpan duration)
        {
            UpdateIndicatorStripColor(true);
            // Wait for the specified duration
            await Task.Delay(duration);
            UpdateIndicatorStripColor(false);
        }
        void UpdateIndicatorStripColor(bool blinkOn)
        {
            if (blinkOn)
            {
                //panel1.BackColor = ColorPalette.Action;

                dataGridView2.GridColor = ColorPalette.Action;
                ControlExtensions.UIThreadInvoke(this, delegate {
                panelActionIndicator.Visible = true;
                });
            }
            else
            {
                //if (fcCommand.isSelected)
                //{
                //    panel1.BackColor = ColorPalette.Detail;
                //}
                //else
                //{
                //    panel1.BackColor= ColorPalette.Header;
                //}
                //panel1.BackColor = this.BackColor;
                    //picError.Visible = false;

                ControlExtensions.UIThreadInvoke(this, delegate {
                    panelActionIndicator.Visible = false;
                });
                dataGridView2.GridColor = ColorPalette.Text;
            }
        }
        private void bToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            fcCommand.TriggerPollChangedEvent((sender as ToolStripMenuItem).Checked);
        }

        private void duplicateFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fcCommand.GlobFcData.Duplicate(fcCommand);
            bll.DuplicateFc(fcCommand);
        }

        private void FcView_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = HighlightedBackcolor;
        }

        private void FcView_MouseLeave(object sender, EventArgs e)
        {
            if (fcCommand.isSelected)
            {
                this.BackColor = HighlightedBackcolor;
            }
            else
            {
            this.BackColor = DefaultBackcolor;

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyDataToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (string, string)[] data = fcCommand.GetDataAsString();
            string[] viewData = data.Select(x => x.Item1).ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < viewData.Length; i++)
            {
                sb.AppendLine(viewData[i]);
            }
            Clipboard.SetText(sb.ToString());
            //fcCommand.
        }

        private void pasteDataFromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = Clipboard.GetText().Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
             //int entries = Math.Min(lines.Length, fcCommand.NumberOfRegisters);

            fcCommand.SetFcData(lines);
            //for (int i = 0; i < entries; i++)
            //{
            //    fcCommand.
            //}
        }

        //static public void UIThread(this Control control, Action code)
        //{
        //    if (control.InvokeRequired)
        //    {
        //        control.BeginInvoke(code);
        //        return;
        //    }
        //    code.Invoke();
        //}

        //static public void UIThreadInvoke(this Control control, Action code)
        //{
        //    if (control.InvokeRequired)
        //    {
        //        control.Invoke(code);
        //        return;
        //    }
        //    code.Invoke();
        //}


    }
}
