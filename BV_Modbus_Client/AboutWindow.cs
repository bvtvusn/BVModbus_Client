using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV_Modbus_Client
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
            //Assembly ass = Assembly.GetExecutingAssembly();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            string softwareVersion = "v.1.2.2"; //version.ToString();
            lblVersion.Text = $"{softwareVersion}";
            //lblVersion.Text =  ass.GetName().Version.ToString();
            lblAuthor.Text = "Bjørn Vegard Tveraaen";
            lblDescription.Text = "A program acting as a modbus master. Used to read and write to modbus slaves. Supporting both Modbus TCP and modbus RTU. Can view several different data types. Includes function for continuously storing data to csv file. Historical data is plotted.";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the "About" window
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
