﻿using BV_Modbus_Client.BusinessLayer;
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
    public partial class PropertiesWindow : Form
    {
        internal PropertiesWindow(FcWrapperBase fcobj)
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = fcobj;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
