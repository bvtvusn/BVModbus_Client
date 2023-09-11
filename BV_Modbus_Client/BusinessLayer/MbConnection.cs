//using NModbus;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
//using NModbus.IO;
using FluentModbus;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class MbConnection
    {
        //public SerialPort port;
        //TcpClient cli;
        private int TCP_port;
        private bool isFake;

        //private IModbusMaster master1;
        private ModbusClient master1;

        private bool isTCP = false;
        public string RTU_SerialPortName { get; set; }
        public Parity RTU_Parity { get; set; } = Parity.None;
        public StopBits RTU_StopBits { get; set; } = StopBits.One;
        public int RTU_DataBits { get; set; } = 8;
        public int RTU_BaudRate { get; set; } = 115200;
        public bool IsTcp
        {
            get { return isTCP; }
            set { isTCP = value; }
        }

        public ModbusClient Master
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
                //master1 = new DummyModbus();
            }
            else if (IsTcp)
            {
                master1 = new ModbusTcpClient();
                (master1 as ModbusTcpClient).Connect(TCP_Hostname + ":" + TCP_port);
                //cli = new TcpClient(TCP_Hostname, TCP_port);
                //var factory = new ModbusFactory();
                ////factory.CreateMaster()
                //master1 = factory.CreateMaster(cli);
            }
            else
            {
                // RTU
                master1 = new ModbusRtuClient()
                {
                    BaudRate = RTU_BaudRate,
                    Parity = RTU_Parity,
                    StopBits = RTU_StopBits
                    // Databits
                };
                (master1 as ModbusRtuClient).Connect(RTU_SerialPortName);




                //if (port != null)
                //{
                //    port.Close();
                //    port.Dispose();
                //}
                //port = new SerialPort(RTU_SerialPortName, RTU_BaudRate, RTU_Parity, RTU_DataBits, RTU_StopBits);
                ////port = new SerialPort("COM8");

                //// configure serial port
                ////port.BaudRate = 115200;
                ////port.DataBits = 8;
                ////port.Parity = Parity.None;
                ////port.StopBits = StopBits.One;
                //port.ReadTimeout = 1000;
                //port.DtrEnable = true;

                //port.Open();
                //port.BaseStream.ReadTimeout = 1000;
                //port.BaseStream.WriteTimeout = 1000;

                //port.BaseStream. = 1000;

                // create modbus master


                //var factory = new ModbusFactory();
                //master1 = factory.CreateRtuMaster(new RtuPortAdapterBv(port));
                //master1.Transport.ReadTimeout = 500;
                //master1.Transport.Retries = 1;




                //var factory = new ModbusFactory();
                //IModbusRtuTransport tr = factory.CreateRtuTransport(new RtuPortAdapterBv(port));
                //master1 =  factory.CreateRtuMaster(tr.StreamResource);
                //master1.Transport.ReadTimeout = 500;
                //master1.Transport.Retries = 1;
                //tr.IgnoreResponse();
                //master1.Transport.
                // master1. = 0;

            }

        }

        internal void DisconnectToSlave()
        {
            if (master1 is ModbusRtuClient)
            {
                (master1 as ModbusRtuClient).Close();

                (master1 as ModbusRtuClient).Dispose();
            }
            else if (master1 is ModbusTcpClient)
            {
                (master1 as ModbusTcpClient).Disconnect();
                (master1 as ModbusTcpClient).Dispose();
            }
            //master1.Dispose();
            //cli.Close();
            //cli.Dispose();
        }

        public string GetConnectionStatus()
        {
            if (isFake)
            {
                return "Dummy connection";
            }
            else if (IsTcp)
            {
                return GetStatusTcp();
            }
            else
            {
                return GetStatusRtu();
            }
        }
        string GetStatusTcp()
        {
            
            if (master1 != null)
            {
                if ((master1 as ModbusTcpClient).IsConnected)
                {
                    return "Connected";
                    //if (IsSocketConnected(cli.Client))
                    //{
                    //    return "Connected";
                    //}
                    //else
                    //{
                    //    return "Disconnected";
                    //}
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


        private string GetStatusRtu()
        {
            if (master1 == null)
            {
                return "Connection Closed";
            }
            else if ((master1 as ModbusRtuClient).IsConnected)
            {
                return "Serial open";
            }
            else 
            {
                return "Serial closed";
            }
            

        }
    }
}
