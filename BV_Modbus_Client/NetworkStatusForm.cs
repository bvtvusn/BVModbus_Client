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
            //bll.ConnectServer();

            bll.mbCon.Hostname = bll.UserConfig.Network_RemoteHostname;
            bll.mbCon.Port = bll.UserConfig.Network_RemotePort;
            try
            {
            bll.mbCon.ConnectToSlave();

            }
            catch (Exception err)
            {

                MessageBox.Show("Connection error: \r\n" + err.Message);
            }

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
    }
}
