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
    internal partial class ProjectSettings : Form
    {
        private BLL bll;

        //public ProjectSettings()
        //{
        //}

        public ProjectSettings(BLL bll)
        {
            InitializeComponent();
            this.bll = bll;


            rdoAddressingOneBased.Checked = !bll.UserConfig.GlobFcData.ZeroBasedAdresses;
            rdoAddressingZeroBased.Checked = bll.UserConfig.GlobFcData.ZeroBasedAdresses;

            //cboFloatFormat.Text = bll.UserConfig.
        }

        private void rdoAddressingZeroBased_CheckedChanged(object sender, EventArgs e)
        {
            bll.UserConfig.GlobFcData.ZeroBasedAdresses = rdoAddressingZeroBased.Checked;
        }
    }
}
