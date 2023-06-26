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
    public partial class AddFcButton : UserControl
    {
        public AddFcButton()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            //toolTip1.SetToolTip(pictureBox2, FcDescription);

        }
        [Description("Short text"), Category("Data")]
        public string FcName
        {
            get => label3.Text;
            set => label3.Text = value;
        }
        [Description("Long description"), Category("Data")]
        private string fcDescription2;

        public string FcDescription
        {
            get { return fcDescription2; }
            set { fcDescription2 = value; toolTip1.SetToolTip(pictureBox2, FcDescription); toolTip1.SetToolTip(label3, FcDescription);  }
        }

        public event EventHandler ButtonClicked;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.ButtonClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
