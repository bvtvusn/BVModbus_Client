using BV_Modbus_Client.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV_Modbus_Client
{
    public partial class NetworkStatusForm : Form
    {
        private BLL bll;

        //public NetworkStatusForm()
        //{
        //    InitializeComponent();

        //    lblConnectionStatus.Text = bll.mbCon.GetConnectionStatus();
            
        //}

        internal NetworkStatusForm(BLL bll)
        {
            InitializeComponent();
            if (bll.mbCon.IsTcp)
            {
                cmbConType.SelectedIndex = 0;
            }
            else cmbConType.SelectedIndex = 1;

            cmbSerialPorts.DataSource = SerialPort.GetPortNames();
            int baudindex = cmbSerialPorts.Items.IndexOf(bll.mbCon.RTU_SerialPortName);
            if (baudindex == -1 && cmbSerialPorts.Items.Count > 0)
            {
                baudindex = 0;
            }
            cmbSerialPorts.SelectedIndex = Math.Min(0, baudindex);

            //cmbDataBits.DataSource = Enum.GetValues(typeof( Parity));
            cmbStopBits.DataSource = Enum.GetValues(typeof(StopBits));
            cmbStopBits.SelectedItem = bll.mbCon.RTU_StopBits;

            cmbParity.DataSource = Enum.GetValues(typeof(Parity));
            cmbParity.SelectedItem = bll.mbCon.RTU_Parity;

            cmbBaud.SelectedIndex = cmbBaud.Items.IndexOf(bll.mbCon.RTU_BaudRate.ToString());

            numDataBits.Value = bll.mbCon.RTU_DataBits;




            this.bll = bll;
            txtHostname.Text = bll.UserConfig.Network_RemoteHostname;
            numPort.Value = Convert.ToDecimal(bll.UserConfig.Network_RemotePort);
            lblConnectionStatus.Text = bll.mbCon.GetConnectionStatus();

        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            bll.UserConfig.Network_RemotePort = Convert.ToInt32(numPort.Value);
        }

        private void txtHostname_TextChanged(object sender, EventArgs e)
        {
            bll.UserConfig.Network_RemoteHostname = txtHostname.Text;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


            switch (cmbConType.SelectedItem.ToString())
            {
                case "Modbus TCP":
                    bll.mbCon.TCP_Hostname = bll.UserConfig.Network_RemoteHostname;
                    bll.mbCon.TCP_Port = bll.UserConfig.Network_RemotePort;
                    bll.mbCon.IsTcp = true;
                    try
                    {
                        bll.mbCon.ConnectToSlave();

                    }
                    catch (Exception err)
                    {

                        MessageBox.Show("Connection error: \r\n" + err.Message);
                    }

                    break;
                case "Modbus RTU":
                    
                    try
                    {
                        bll.mbCon.IsTcp = false;
                        bll.mbCon.RTU_SerialPortName = cmbSerialPorts.SelectedItem.ToString();
                        bll.mbCon.RTU_BaudRate = Convert.ToInt32(cmbBaud.SelectedItem);
                        bll.mbCon.RTU_Parity = (Parity)cmbParity.SelectedItem;
                        bll.mbCon.RTU_StopBits = (StopBits)cmbStopBits.SelectedItem;
                        bll.mbCon.RTU_DataBits = Convert.ToInt32(numDataBits.Value);

                        bll.mbCon.ConnectToSlave();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Connection error: \r\n" + err.Message);
                    }


                    break;
                
            }

            //bll.ConnectServer();

            
            

            lblConnectionStatus.Text = bll.mbCon.GetConnectionStatus();
        }

        private void btvClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            bll.mbCon.DisconnectToSlave();

            lblConnectionStatus.Text = bll.mbCon.GetConnectionStatus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedItem.ToString())
            {
                case "Modbus TCP":
                    grpTCP.Enabled = true;
                    grpRtu.Enabled = false;
                    break;
                case "Modbus RTU":
                    grpTCP.Enabled = false;
                    grpRtu.Enabled = true;
                    break;
                default:
                    grpTCP.Enabled = false;
                    grpRtu.Enabled = false;
                    break;
            }
            
        }
    }
}
