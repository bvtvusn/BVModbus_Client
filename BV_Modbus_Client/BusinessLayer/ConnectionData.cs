using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    internal class ConnectionData
    {
        [DataMember]
        public bool isFake;
        [DataMember]
        public string RTU_SerialPortName { get; set; }
        [DataMember]
        public Parity RTU_Parity { get; set; } = Parity.None;
        [DataMember]
        public StopBits RTU_StopBits { get; set; } = StopBits.One;
        [DataMember]
        public int RTU_DataBits { get; set; } = 8;
        [DataMember]
        public int RTU_BaudRate { get; set; } = 115200;
        [DataMember]
        public bool IsTcp
        {
            get ;
            set;
        }
        [DataMember]
        public int TCP_Port
        {
            get; 
            set; 
        }
        public string TCP_Hostname { get; set; }
    }
}
