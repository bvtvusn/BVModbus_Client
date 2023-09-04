using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class RtuPortAdapterBv : NModbus.IO.IStreamResource
    {
        SerialPort port; // = new SerialPort("COM3")
        public RtuPortAdapterBv(SerialPort port)
        {
            this.port = port;
            //port = new SerialPort(portname);
            //port.WriteTimeout = 3;
        }
        public int InfiniteTimeout => throw new NotImplementedException();

        public int ReadTimeout { get => port.ReadTimeout; set { port.ReadTimeout = value ; } }
        public int WriteTimeout { get => port.WriteTimeout; set { port.WriteTimeout = value; } }

        public void DiscardInBuffer()
        {
            port.DiscardInBuffer();
        }

        public void Dispose()
        {
            port.Dispose();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return port.Read(buffer, offset, count);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            port.Write(buffer, offset, count);
        }
    }
}
