using NModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class MbConnection
    {
        TcpClient cli;
        private int port;
        private bool isFake;
        
        private IModbusMaster master1;

        public IModbusMaster Master
        {
            get { return master1; }
        }


        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        private string hostname;

        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; }
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
            else
            {
                cli = new TcpClient(Hostname, port);
                var factory = new ModbusFactory();
                master1 = factory.CreateMaster(cli);
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
