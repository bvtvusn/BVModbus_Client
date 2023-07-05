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
            //dataGridView1.ReadOnly = !fcCommand.FcTypeWrite;
            //if (fcCommand.FcTypeWrite)
            //{
            //    btnRunFc2.Text = "Write";
            //}
            //else
            //{
            //    btnRunFc2.Text = "Read";
            //}

            //DrawSelection(fcWrapperBase.isSelected);
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44,54,79);
            fcCommand.FormatValidStateEvent += FcCommand_FormatValidStateEvent;
            fcCommand.FcSettingsChangedEvent += FcCommand_FcSettingsChangedEvent;
            fcCommand.SelectedChanged += FcCommand_SelectedChanged;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged; // Sends data to FC object
            fcCommand.RefreshDataEvent += FcWrapperBase_ResponseReceived; // Receives data from FC object. ( Do not receive updates to gui if we are sending data)
            fcCommand.FcActivatedEvent += FcCommand_FcActivatedEvent;
            FillPreviewTable();
            fcCommand.ForceDataRefresh(""); // Makes fake event to force update

        }

        private async void FcCommand_FcActivatedEvent()
        {
            await this.BlinkPanelAsync(panel1, ColorPalette.Action, TimeSpan.FromSeconds(0.15));
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
                    dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Red;

                }
                else
                {
                    dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.White;
                }
            }

        }
        private void FcCommand_FcSettingsChangedEvent()
        {
            UpdateFcInfo();
        }
        private void FcCommand_SelectedChanged(FcWrapperBase arg1, bool isSelected)
        {
            DrawSelection(isSelected);
        }
        private void DataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            userEditActiveFlag = true;
            //string[] frmDgv = (string[])(dataGridView1.DataSource as DataTable).Rows[0].ItemArray;
            if (refreshActiveFlag == false)
            {
                string[] tableData = ReadFirstRowFromDataGridView(dataGridView1);
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
            using (Form frm = new PropertiesWindow(fcCommand))
            {
                frm.ShowDialog();
            }
            fcCommand.ForceDataRefresh(""); // Generating fake respopnse recevide event to forace an update.
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
                panel1.BackColor = ColorPalette.Detail; // Color.FromArgb(27, 188, 155);
                //this.BackColor = Color.FromArgb(35, 172, 227);
            }
            else
            {
                //this.BackColor = Color.FromArgb(240, 240, 240);
                panel1.BackColor = ColorPalette.Header;
            }
        }
        private void UpdateFcInfo()
        {
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
            


            (string, string)[] data = fcCommand.GetDataAsString();
            if (data.Length > 4)
            {
                data = ((string, string)[])data.Take(4).ToArray();
            }
            string[] viewData = data.Select(x => x.Item1).ToArray();
            dataGridView1.DataSource = FormatConverter.ArrayToDatatableRow(viewData);
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
                    rowData[i] = cell.Value != null ? cell.Value.ToString() : string.Empty;
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
        public async Task BlinkPanelAsync(Panel panel, Color color, TimeSpan duration)
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
                panel1.BackColor = ColorPalette.Action;
            }
            else
            {
                if (fcCommand.isSelected)
                {
                    panel1.BackColor = ColorPalette.Detail;
                }
                else
                {
                    panel1.BackColor= ColorPalette.Header;
                }
            }
        }
        private void bToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            fcCommand.TriggerPollChangedEvent((sender as ToolStripMenuItem).Checked);
        }

        private void duplicateFCToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
