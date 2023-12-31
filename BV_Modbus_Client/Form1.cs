using BV_Modbus_Client.BusinessLayer;
using BV_Modbus_Client.DataAccessLayer;
using BV_Modbus_Client.GUI;
//using NModbus;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using static BV_Modbus_Client.BusinessLayer.FormatConverter;
using FluentModbus;
using OxyPlot;
using OxyPlot.Series;

namespace BV_Modbus_Client
{
    public partial class Form1 : Form
    {
        BLL bll; // Business layer
        private bool userEditActiveFlag;
        private bool refreshActiveFlag;

        //private EventBatcher eb;

        // To do
        // Timer function to activate FCs
        // Use semaphore on shared FC list?? Foreach function gets problems if collection is changed.
        // Dropdown to change FC type. 
        // Duplicate FC option
        // Store to file functionality? CSV file Using address names as header. Can combine multiple FCs and save to file.

        // DONE:
        // Context menu on FC?
        // Async FCs
        // View as hex, float int and uint (and bool)
        // Add Grid for viewing lots of data.
        // Ability to save configuration.
        // Indicate errors.
        // Adjust the number of write columns in FC15
        public Form1()
        {

            //ushort temp = FormatConverter.FloatToHalf((float)1000.2);
            //float res = FormatConverter.HalfToFloat(temp);

            bll = new BLL();
            InitializeComponent();
            valueFormatPanel1.Visible = false;
            //valueFormatPanel1.Bll = bll;


            //bll.OnFcObjectAdded += Bll_OnFcObjectAdded;
            bll.FcListChangedEvent += Bll_FcListChangedEvent;
            //bll.SelectedDataRecevivedEvent += Bll_SelectedDataRecevivedEvent;
            //bll.SelectedFormatValidStateEvent += Bll_SelectedFormatValidStateEvent;
            //bll.SelectedFcSettingsChangedEvent += Bll_SelectedFcSettingsChangedEvent;
            //bll.UserConfig.pollTimer.PollFinishedEvent += PollTimer_PollFinishedEvent;
            bll.FcSettingsChangedEvent += Bll_FcSettingsChangedEvent;

            bll.SelectedFcActivatedEvent += Bll_SelectedFcActivatedEvent; // Read or write operation was performed

            bll.UserConfigLoadedEvent += DisplayValFromConfig;
            
            //comboBox1.DataSource = System.Enum.GetValues(typeof(FormatName));
            RefreshGUI();
            //numPollInterval.Value = Convert.ToDecimal(bll.UserConfig.Timer_PollInterval);
            DisplayValFromConfig();
            //TestSerial();
            UpdateConnectionStatus();


            //eb = new EventBatcher(1000);
            //eb.BatchedEvent += Eb_BatchedEvent;
            //TestOxyplot();
        }

        //private void TestOxyplot()
        //{
        //    var plotModel = new PlotModel();
        //    var lineSeries1 = new LineSeries { Title = "Series 1" };
        //    var lineSeries2 = new LineSeries { Title = "Series 2" };

        //    lineSeries1.Points.Add(new DataPoint(1, 10));
        //    lineSeries1.Points.Add(new DataPoint(2, 20));
        //    lineSeries1.Points.Add(new DataPoint(3, 30));

        //    lineSeries2.Points.Add(new DataPoint(1, 5));
        //    lineSeries2.Points.Add(new DataPoint(2, 15));
        //    lineSeries2.Points.Add(new DataPoint(3, 25));

        //    plotModel.Series.Add(lineSeries1);
        //    plotModel.Series.Add(lineSeries2);

        //    plotView1.Model = plotModel;
        //}

        //private void Eb_BatchedEvent(object? sender, EventArgs e)
        //{
        //    lblResponseTime.Invoke(new Action(() =>
        //    {
        //        // This code runs on the UI thread
        //        lblResponseTime.Text = lblResponseTime.Text + ".";
        //    }));
        //    //lblResponseTime.Invoke(delegate => {lblResponseTime.Text = lblResponseTime.Text + ".";});

        //}

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        private void TestSerial()
        {
            SerialPort port = new SerialPort("COM8");

            // configure serial port
            port.BaudRate = 115200;
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.Open();

            // create modbus master
            byte[] outbytes = StringToByteArray("010300000002C40B");
            port.Write(outbytes, 0, outbytes.Length);

            byte[] recv = new byte[100];
            port.Read(recv,0,port.BytesToRead);
            MessageBox.Show(recv.ToString());

            //var factory = new ModbusFactory();
            //master1 = factory.CreateRtuMaster(new RtuPortAdapterBv(port));
        }

        private void DisplayValFromConfig()
        {
            bll.UserConfig.pollTimer.PollFinishedEvent += PollTimer_PollFinishedEvent;


            numPollInterval.Value = Convert.ToDecimal(bll.UserConfig.Timer_PollInterval);

            chkLogToFile.Checked = bll.UserConfig.pollLoggerSettings.LoggingEnabled;
            txtLogPath.Text = bll.UserConfig.pollLoggerSettings.LogFilePath;
            txtSeparator.Text = bll.UserConfig.pollLoggerSettings.SeparatorCharacter;
            chkQuote.Checked = bll.UserConfig.pollLoggerSettings.QuoteEnabled;
        }

        private void Bll_SelectedFcActivatedEvent()
        {
            
            DisplayAllFCInfo();
        }

        private void DisplayAllFCInfo()
        {
            lblWriteCounter.Invoke(delegate {
                lblWriteCounter.Text = bll.SelectedFcRequest.WriteCount.ToString();
            });
            lblReadCounter.Invoke(delegate {
                lblReadCounter.Text = bll.SelectedFcRequest.ReadCount.ToString();
            });
            lblErrorCount.Invoke(delegate {
                lblErrorCount.Text = bll.SelectedFcRequest.ErrorCount.ToString();
            });
            lblResponseTime.Invoke(delegate {
                lblResponseTime.Text = bll.SelectedFcRequest.ResponseTimeMs.ToString("0.0") +" ms";
            });

        }

        //private void Bll_SelectedFcSettingsChangedEvent()
        //{
        //    // Update the register tables after for example change of start address.
        //    Bll_SelectedDataRecevivedEvent("");
        //}

        private void Bll_FcSettingsChangedEvent()
        {
            propGridFc.SelectedObject = bll.SelectedFcRequest;
            //MessageBox.Show("FcSettingsChangedEvent");
            UpdateVisibilityOfDataArea();
        }

        private void PollTimer_PollFinishedEvent((string, string)[] data, bool PollItemsChanged)
        {
            if (bll.UserConfig != null)
            {
                string[] viewData = data.Select(x => x.Item1).ToArray();
                string line = bll.UserConfig.pollLoggerSettings.GenerateDataLine(viewData,false);

                txtPolledData.Invoke(delegate { 
                    txtPolledData.Text = line;  
                });

            }
        }
        #region EventsFromApplication
        private void Bll_FcListChangedEvent(object? sender, EventArgs e) // Updates the list of FCs.
        {
            RefreshGUI();

            //MessageBox.Show("FCLISTChangedEvent");
            UpdateVisibilityOfDataArea();
        }
        private void UpdateVisibilityOfDataArea()
        {
            if (bll.SelectedFcRequest != valueFormatPanel1.Fc)
            {
                if (bll.SelectedFcRequest == null)
                {
                    trendlineControl1.Fc = null;
                    valueFormatPanel1.Fc = null;
                    valueFormatPanel1.Visible = false;
                }
                else
                {
                    trendlineControl1.Fc = bll.SelectedFcRequest;
                    valueFormatPanel1.Fc = bll.SelectedFcRequest;
                    valueFormatPanel1.Visible = true;
                }
            }
           
        }
        //private void Bll_SelectedDataRecevivedEvent(string errorMsg)
        //{
        //    ControlExtensions.UIThreadInvoke(this, delegate {
                

        //    if (userEditActiveFlag == false)
        //    {
        //        refreshActiveFlag = true;

        //            (string, string)[] receiveddata = bll.SelectedFcRequest.GetDataAsString();
        //            int maxtableRows = bll.UserConfig.GlobFcData.MaxTableRows;

        //            int StartdisplayingRegister = (bll.SelectedFcRequest.StartAddress / 10) * 10;
        //            int emptyStartRows = bll.SelectedFcRequest.StartAddress - StartdisplayingRegister;



        //            (string, string)[] empty = new (string, string)[emptyStartRows];
        //            (string, string)[] dispdata = empty.Concat(receiveddata).ToArray();

        //            dataGridView1.DataSource = FormatConverter.ArrayToDatatableColumn(dispdata, maxtableRows);
                    
                    
        //            // Add numbers to each row:
        //            for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //            {
        //                dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
        //            }

        //            // Change text on column headers
        //            for (int i = 0; i < dataGridView1.Columns.Count; i+=2)
        //            {
        //                dataGridView1.Columns[i].HeaderText = "Notes";
        //            }
        //            // Change text on column headers
        //            for (int i = 1; i < dataGridView1.Columns.Count; i += 2)
        //            {
        //                dataGridView1.Columns[i].HeaderText = (StartdisplayingRegister + maxtableRows * (i-1)/2).ToString();
        //            }


        //            refreshActiveFlag = false;
        //    }
        //    });

        //}
        //private void Bll_SelectedFormatValidStateEvent(string[] errors)
        //{
        //    int nrows = dataGridView1.RowCount;
        //    int ncols = dataGridView1.ColumnCount / 2;

        //    for (int i = 0; i < errors.Length; i++)
        //    {
        //        int colindex = i / nrows;
        //        int rowindex = i % nrows;
        //        bool isError = false;
        //        if (errors[i] != null)
        //        {
        //            if (errors[i].Length > 0)
        //            {
        //                isError = true;
        //            }
        //        }

        //        if (isError)
        //        {
        //            dataGridView1.Rows[rowindex].Cells[1 + colindex * 2].Style.BackColor = Color.Red;

        //        }
        //        else
        //        {
        //            dataGridView1.Rows[rowindex].Cells[1 + colindex * 2].Style.BackColor = Color.White;
        //        }
        //    }
        //}
        #endregion
        #region UserActions
        private void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.SaveAs();
        }

        private void loadConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.LoadConfig();
        }


        private void addFcButton1_ButtonClicked(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuAddFC.Show(ptLowerLeft);


            //bll.AddMultiHR_FC();
        }

        private void addFcButton2_ButtonClicked(object sender, EventArgs e)
        {
            //bll.AddFc15();
            bll.AddFunctionCode(typeof(MultipleHoldingRegisters));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //NetworkStatusForm fom = new NetworkStatusForm(bll);
            //fom.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bll.formatConverter.CurrentFormat = (FormatName)comboBox1.SelectedItem;
        }

        //private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (bll.SelectedFcRequest != null)
        //    {

        //        userEditActiveFlag = true;
        //        //string[] frmDgv = (string[])(dataGridView1.DataSource as DataTable).Rows[0].ItemArray;
        //        if (refreshActiveFlag == false)
        //        {
        //            string[] tableData = ReadValuesFromDGV(dataGridView1);

        //            // Remove empty start rows:
        //            //int StartdisplayingRegister = (bll.SelectedFcRequest.StartAddress / 10) * 10;
        //            //int emptyStartRows = bll.SelectedFcRequest.StartAddress - StartdisplayingRegister;
        //            //string[] trimmedData = new string[tableData.Length-emptyStartRows];
        //            //Array.Copy(tableData,emptyStartRows, trimmedData, 0, trimmedData.Length);


        //            bll.SelectedFcRequest.SetFcData(tableData);

        //            string[] addressDescriptions = ReadDescriptionsFromDGV(dataGridView1);
        //            bll.SelectedFcRequest.SetFcDescription(addressDescriptions);

        //        }
        //        userEditActiveFlag = false;
        //    }
        //}
        #endregion
        #region ReadFromForm

        
        private string[] ReadDescriptionsFromDGV(DataGridView dataGridView1)
        {
            string[] values = new string[bll.SelectedFcRequest.NumberOfRegisters];
            int nrows = dataGridView1.RowCount;
            int ncols = dataGridView1.ColumnCount / 2;

            for (int i = 0; i < bll.SelectedFcRequest.NumberOfRegisters; i++)
            {
                int colindex = i / nrows;
                int rowindex = i % nrows;

                values[i] = dataGridView1.Rows[rowindex].Cells[+colindex * 2].Value.ToString();
            }
            return values;
        }

        //private string[] ReadValuesFromDGV(DataGridView dataGridView)
        //{
        //    // Remove empty start rows:
        //    int StartdisplayingRegister = (bll.SelectedFcRequest.StartAddress / 10) * 10;
        //    int emptyStartRows = bll.SelectedFcRequest.StartAddress - StartdisplayingRegister;
        //    //string[] trimmedData = new string[tableData.Length-emptyStartRows];
        //    //Array.Copy(tableData,emptyStartRows, trimmedData, 0, trimmedData.Length);



        //    string[] values = new string[bll.SelectedFcRequest.NumberOfRegisters];
        //    int nrows = dataGridView1.RowCount;
        //    int ncols = dataGridView1.ColumnCount / 2;

        //    for (int i = 0; i < bll.SelectedFcRequest.NumberOfRegisters; i++)
        //    {
        //        int colindex = (i+ emptyStartRows) / nrows;
        //        int rowindex = (i + emptyStartRows) % nrows;

        //        values[i] = dataGridView1.Rows[rowindex].Cells[1 + colindex * 2].Value.ToString();
        //    }
        //    return values;

        //}

        #endregion



        void RefreshGUI()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (FcWrapperBase fc in bll.UserConfig.FcWrappers)
            {
                FcView fcView = new FcView(fc, bll);
                flowLayoutPanel1.Controls.Add(fcView);
            }
        }

        public static DataTable ArraytoDatatable(Object[,] numbers)
    {
        DataTable dt = new DataTable();
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            dt.Columns.Add("Column" + (i + 1));
        }

        for (var i = 0; i < numbers.GetLength(0); ++i)
        {
            DataRow row = dt.NewRow();
            for (var j = 0; j < numbers.GetLength(1); ++j)
            {
                row[j] = numbers[i, j];
            }
            dt.Rows.Add(row);
        }
        return dt;
    }

        private void button1_Click(object sender, EventArgs e)
        {


            //using (TcpClient client = new TcpClient("127.0.0.1", 502))
            //{
            //    var factory = new ModbusFactory();
            //    IModbusMaster master = factory.CreateMaster(client);


            //    byte slaveId = 1;
            //    ushort startAddress = 100;

            //    master.WriteSingleRegister(slaveId, startAddress, 22);
            //    ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, 3);
            //    for (int i = 0; i < 3; i++)
            //    {
            //        //Console.WriteLine($"Input {(startAddress + i)}={registers[i]}");
            //        //txtShow.AppendText( $"Input {(startAddress + i)}={registers[i]}");
            //    }


            //}


        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            //PasteExcelDataToDataGridView(dataGridView1);
        }
        private void PasteExcelDataToDataGridView(DataGridView dataGridView)
        {
            try
            {
                // Get the text from the clipboard
                string clipboardText = Clipboard.GetText();

                // Split the text into rows based on newline characters
                string[] rows = clipboardText.Split('\n');

                // Get the starting row and column index of the selected cells in the DataGridView
                int startRowIndex = dataGridView.SelectedCells[0].RowIndex;
                int startColumnIndex = dataGridView.SelectedCells[0].ColumnIndex;

                // Loop through the rows
                for (int i = 0; i < rows.Length; i++)
                {
                    // Skip empty rows
                    if (string.IsNullOrWhiteSpace(rows[i]))
                        continue;

                    // Split the row text into cells based on tab characters
                    string[] cells = rows[i].Split('\t');

                    // Loop through the cells
                    for (int j = 0; j < cells.Length; j++)
                    {
                        // Skip cells that exceed the column count of the DataGridView
                        if (startColumnIndex + j >= dataGridView.ColumnCount)
                            continue;

                        // Get the cell at the current row and column index
                        DataGridViewCell cell = dataGridView.Rows[startRowIndex + i].Cells[startColumnIndex + j];

                        // Set the value of the cell to the corresponding Excel data
                        cell.Value = cells[j].Trim();
                    }
                }

                Console.WriteLine("Data pasted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to paste data. Error: " + ex.Message);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectSettings form = new ProjectSettings(bll);
            form.ShowDialog();
            bll.UpdateFCList();
            //bll.UserConfig.GlobFcData.
        }

        private void saveConfigAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.Save();
        }

        private void btnTestPoll_Click(object sender, EventArgs e)
        {
            bll.UserConfig.pollTimer.PollAll();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };

            Tuple<int, int>[] tupleArray = originalArray
                .Zip(originalArray.Skip(1), (a, b) => Tuple.Create(a, b))
                .ToArray();

            foreach (var tuple in tupleArray)
            {
                Console.WriteLine(tuple);
            }
        }

        

        

        private void configureConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkStatusForm fom = new NetworkStatusForm(bll);
            fom.ShowDialog();
            UpdateConnectionStatus();
        }

        private void multipleHoldingRegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bll.AddMultiHR_FC();
            bll.AddFunctionCode(typeof(MultipleHoldingRegisters));
        }

        //private void miPasteData_Click(object sender, EventArgs e)
        //{
        //    PasteExcelDataToDataGridView(dataGridView1);
        //}

        private void numPollInterval_ValueChanged(object sender, EventArgs e)
        {
            bll.UserConfig.Timer_PollInterval = Convert.ToDouble(numPollInterval.Value);
            bll.UserConfig.pollTimer.SetInterval(bll.UserConfig.Timer_PollInterval);
        }

        private void txtSeparator_TextChanged(object sender, EventArgs e)
        {
            bll.UserConfig.pollLoggerSettings.SeparatorCharacter = (sender as TextBox).Text;
        }

        private void chkLogToFile_CheckedChanged(object sender, EventArgs e)
        {
            bll.UserConfig.pollLoggerSettings.LoggingEnabled = chkLogToFile.Checked;
        }

        private void txtLogPath_TextChanged(object sender, EventArgs e)
        {
            bll.UserConfig.pollLoggerSettings.LogFilePath = txtLogPath.Text;

            //bll.UserConfig.pollLogger.SeparatorCharacter = (sender as TextBox).Text;
            //bll.UserConfig.pollLogger.LoggingEnabled = chkLogToFile.Checked;
        }

        private void btnLogPath_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;
                saveFileDialog.Title = "Select File Path";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bll.UserConfig.pollLoggerSettings.LogFilePath = saveFileDialog.FileName;
                    txtLogPath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void chkQuote_CheckedChanged(object sender, EventArgs e)
        {
            bll.UserConfig.pollLoggerSettings.QuoteEnabled = chkQuote.Checked;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //bll.SelectedFcRequest.mbCon.Master.Transport.ReadTimeout = 1000;
            //bll.SelectedFcRequest.ExecuteRead();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //RtuPortAdapterBv myPort = new RtuPortAdapterBv(bll.mbCon.port);

            //var factory = new ModbusFactory();
            //IModbusSerialMaster master = factory.CreateRtuMaster(myPort);

            //bll.mbCon.Master

            //ushort[] registers = bll.mbCon.Master.ReadHoldingRegisters(1, 1, 1);
            //ushort[] registers = bll.SelectedFcRequest.mbCon.Master.ReadHoldingRegisters(1, 1, 1);
            //bll.SelectedFcRequest.ExecuteRead(); // mbCon.Master.ReadHoldingRegisters(1, 1, 1);


            //string str = "";
            //for (int i = 0; i < registers.Length; i++)
            //{
            //    str += registers[i].ToString() + ", ";
            //}
            //MessageBox.Show(str);
        }

        void UpdateConnectionStatus()
        {
            //ModbusMaster d = new 
            bool _isConnected = false;
            string transport = "";
            if (bll.mbCon.Master is ModbusTcpClient)
            {
                _isConnected = (bll.mbCon.Master as ModbusTcpClient).IsConnected;
                transport = bll.mbCon.conData.TCP_Hostname + ":" + bll.mbCon.conData.TCP_Port;
            }
            else if (bll.mbCon.Master is ModbusRtuClient)
            {
                _isConnected = (bll.mbCon.Master as ModbusRtuClient).IsConnected;
                transport = bll.mbCon.conData.RTU_SerialPortName;
            }

            if (_isConnected)
            {
                panelConnectionIndicator.BackColor = Color.Green;
                lblConnectionStatus.Text = "Connected to: " + transport;
            }
            else
            {
                panelConnectionIndicator.BackColor = Color.Red;
                lblConnectionStatus.Text = "Disconnected";
            }
        }

        private void lblConnectionStatus_Click(object sender, EventArgs e)
        {
            UpdateConnectionStatus();
            NetworkStatusForm fom = new NetworkStatusForm(bll);
            fom.ShowDialog();
            UpdateConnectionStatus();
        }

        private void multipleCoilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.AddFunctionCode(typeof(MultipleCoils));
        }

        private void readInputRegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.AddFunctionCode(typeof(ReadInputRegisters));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.AddFunctionCode(typeof(ReadDiscreteInputs));
        }

        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AboutWindow();
            form.ShowDialog();
        }

        //private void test_timer1_Tick(object sender, EventArgs e)
        //{
        //    eb.TriggerEvent();
        //}
    }
}