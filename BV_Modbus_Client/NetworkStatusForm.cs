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

        public NetworkStatusForm()
        {
            InitializeComponent();

            
        }

        internal NetworkStatusForm(BLL bll)
        {
            InitializeComponent();
            this.bll = bll;
            txtHostname.Text = bll.UserConfig.Network_RemoteHostname;
            numPort.Value = Convert.ToDecimal(bll.UserConfig.Network_RemotePort);
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
            bll.ConnectServer();
        }

        private void btvClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
