using BV_Modbus_Client.BusinessLayer;
using BV_Modbus_Client.DataAccessLayer;
using BV_Modbus_Client.GUI;
using NModbus;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Net.Sockets;
using static BV_Modbus_Client.BusinessLayer.FormatConverter;

namespace BV_Modbus_Client
{
    public partial class Form1 : Form
    {
        BLL bll; // Business layer
        private bool userEditActiveFlag;
        private bool refreshActiveFlag;


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

            //bll.OnFcObjectAdded += Bll_OnFcObjectAdded;
            bll.FcListChangedEvent += Bll_FcListChangedEvent;
            bll.SelectedDataRecevivedEvent += Bll_SelectedDataRecevivedEvent;
            bll.SelectedFormatValidStateEvent += Bll_SelectedFormatValidStateEvent;
            bll.UserConfig.pollTimer.PollFinishedEvent += PollTimer_PollFinishedEvent;

            
            //comboBox1.DataSource = System.Enum.GetValues(typeof(FormatName));
            RefreshGUI();

        }

        private void PollTimer_PollFinishedEvent()
        {
            //throw new NotImplementedException();
        }
        #region EventsFromApplication
        private void Bll_FcListChangedEvent(object? sender, EventArgs e) // Updates the list of FCs.
        {
            RefreshGUI();
        }
        private void Bll_SelectedDataRecevivedEvent(string errorMsg)
        {
            ControlExtensions.UIThreadInvoke(this, delegate {
                

            if (userEditActiveFlag == false)
            {
                refreshActiveFlag = true;

                (string, string)[] receiveddata = bll.SelectedFcRequest.GetDataAsString();
                dataGridView1.DataSource = FormatConverter.ArrayToDatatableColumn(receiveddata);

                refreshActiveFlag = false;
            }
            });

        }
        private void Bll_SelectedFormatValidStateEvent(string[] errors)
        {
            int nrows = dataGridView1.RowCount;
            int ncols = dataGridView1.ColumnCount / 2;

            for (int i = 0; i < errors.Length; i++)
            {
                int colindex = i / nrows;
                int rowindex = i % nrows;
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
                    dataGridView1.Rows[rowindex].Cells[1 + colindex * 2].Style.BackColor = Color.Red;

                }
                else
                {
                    dataGridView1.Rows[rowindex].Cells[1 + colindex * 2].Style.BackColor = Color.White;
                }
            }
        }
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
            bll.AddMultiHR_FC();
        }

        private void addFcButton2_ButtonClicked(object sender, EventArgs e)
        {
            bll.AddFc15();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NetworkStatusForm fom = new NetworkStatusForm(bll);
            fom.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bll.formatConverter.CurrentFormat = (FormatName)comboBox1.SelectedItem;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            userEditActiveFlag = true;
            //string[] frmDgv = (string[])(dataGridView1.DataSource as DataTable).Rows[0].ItemArray;
            if (refreshActiveFlag == false)
            {
                string[] tableData = ReadValuesFromDGV(dataGridView1);
                bll.SelectedFcRequest.SetFcData(tableData);

                string[] addressDescriptions = ReadDescriptionsFromDGV(dataGridView1);
                bll.SelectedFcRequest.SetFcDescription(addressDescriptions);

            }
            userEditActiveFlag = false;
        }
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

        private string[] ReadValuesFromDGV(DataGridView dataGridView)
        {
            string[] values = new string[bll.SelectedFcRequest.NumberOfRegisters];
            int nrows = dataGridView1.RowCount;
            int ncols = dataGridView1.ColumnCount / 2;

            for (int i = 0; i < bll.SelectedFcRequest.NumberOfRegisters; i++)
            {
                int colindex = i / nrows;
                int rowindex = i % nrows;

                values[i] = dataGridView1.Rows[rowindex].Cells[1 + colindex * 2].Value.ToString();
            }
            return values;

        }

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


            using (TcpClient client = new TcpClient("127.0.0.1", 502))
            {
                var factory = new ModbusFactory();
                IModbusMaster master = factory.CreateMaster(client);


                byte slaveId = 1;
                ushort startAddress = 100;

                master.WriteSingleRegister(slaveId, startAddress, 22);
                ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, 3);
                for (int i = 0; i < 3; i++)
                {
                    //Console.WriteLine($"Input {(startAddress + i)}={registers[i]}");
                    //txtShow.AppendText( $"Input {(startAddress + i)}={registers[i]}");
                }


            }


        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            PasteExcelDataToDataGridView(dataGridView1);
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
    }
}