using NModbus;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using NModbus.IO;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class MbConnection
    {
        TcpClient cli;
        private int TCP_port;
        private bool isFake;
        
        private IModbusMaster master1;

        private bool isTCP = false;

        public bool IsTcp
        {
            get { return isTCP; }
            set { isTCP = value; }
        }

        public IModbusMaster Master
        {
            get { return master1; }
        }


        public int TCP_Port
        {
            get { return TCP_port; }
            set { TCP_port = value; }
        }

        private string TCP_hostname;

        public string TCP_Hostname
        {
            get { return TCP_hostname; }
            set { TCP_hostname = value; }
        }

        public MbConnection()
        {
            
        }
        public MbConnection(bool fakeConnection)
        {
            isFake = fakeConnection;
        }
        public void ConnectToSlave()
        {
            if (isFake)
            {
                master1 = new DummyModbus();
            }
            else if (IsTcp)
            {
                cli = new TcpClient(TCP_Hostname, TCP_port);
                var factory = new ModbusFactory();
                //factory.CreateMaster()
                master1 = factory.CreateMaster(cli);
            }
            else
            {
                // RTU
                try
                {
                    SerialPort port = new SerialPort("COM8");

                    // configure serial port
                    port.BaudRate = 9600;
                    port.DataBits = 8;
                    port.Parity = Parity.Even;
                    port.StopBits = StopBits.One;
                    port.Open();

                    // create modbus master


                    var factory = new ModbusFactory();
                    master1 = factory.CreateRtuMaster(new RtuPortAdapterBv(port));
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            
        }

        internal void DisconnectToSlave()
        {

            master1.Dispose();
            cli.Close();
            cli.Dispose();
        }

        public string GetConnectionStatus()
        {
            if (cli != null)
            {
            if (cli.Connected)
                {
                    if (IsSocketConnected(cli.Client))
                    {
                        return "Connected";
                    }
                    else
                    {
                        return "Disconnected";
                    }
                }
                else
                {
                    return "Not connected";
                }
            }
            else
            {
                return "Not connected";
            }
            
        }
        private bool IsSocketConnected(Socket socket)
        {
            try
            {
                // Check if the socket is connected by sending a test message
                bool isSocketConnected = !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
                return isSocketConnected;
            }
            catch
            {
                return false;
            }
        }
    }
}
