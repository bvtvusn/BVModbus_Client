using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class RtuPortAdapterBv //: NModbus.IO.IStreamResource
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

         async Task<int> Readerd(byte[] buffer, int offset, int count)
        {
            Task<int> readtask = port.BaseStream.ReadAsync(buffer, offset, count);
           Task winner = await Task.WhenAny(readtask, Task.Delay(TimeSpan.FromSeconds(1)));
            if (winner == readtask)
            {
                return ((Task<int>)winner).Result;
            }
            return 0;

        }
        public int Read(byte[] buffer, int offset, int count)
        {

            //Task<int> mytask = Task.Run(() => port.BaseStream.ReadAsync(buffer, offset, count));
            //return mytask.Result;
                //return port.BaseStream.Read(buffer, offset, count);
            //return Task.Run(() => port.BaseStream.ReadAsync(buffer, offset, count)).Result;

            //var winner = await Task.WhenAny(port.BaseStream.ReadAsync(buffer, offset, count),    Task.Delay(TimeSpan.FromSeconds(1)));
            return Readerd(buffer, offset, count).Result;

            //try
            //{
            //}
            //catch (Exception)
            //{
            //    return -1;
            //    //throw;
            //}
            



            //port.BaseStream.Length;
            //return port.BaseStream.Read(buffer,offset,count);

            ////buffer = new byte[blockLimit];
            //Action kickoffRead = null;
            //kickoffRead = delegate {
            //    port.BaseStream.BeginRead(buffer, 0, buffer.Length, delegate (IAsyncResult ar) {
            //        try
            //        {
            //            int actualLength = port.BaseStream.Read(buffer,);
            //            byte[] received = new byte[actualLength];
            //            Buffer.BlockCopy(buffer, 0, received, 0, actualLength);
            //            //raiseAppSerialDataEvent(received);
            //        }
            //        catch (IOException exc)
            //        {
            //            handleAppSerialError(exc);
            //        }
            //        kickoffRead();
            //    }, null);
            //};
            //kickoffRead();


            //Thread.Sleep(300);
            ////int cn = Math.Min(port.BytesToRead,count);
            //port.
            //return port.Read(buffer, offset, count);
            //return 0;

        }

        public void Write(byte[] buffer, int offset, int count)
        {
            Task.Run(() => port.BaseStream.WriteAsync(buffer, offset, count));

            //AsyncContext.RunTask
            //await sp.BaseStream.WriteAsync(buffer, offset, buffer.Length);
            //port.Write(buffer, offset, count);
        }
    }
}
