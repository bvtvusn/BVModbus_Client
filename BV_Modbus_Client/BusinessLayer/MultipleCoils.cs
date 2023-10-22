using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    internal class MultipleCoils : FcWrapperBase
    {
        [DataMember]
       
        private ushort numberOfRegisters;

        public MultipleCoils(MbConnection mbCon) : base() // Read multiple coils
        {
            //base.Parent = parent;

            base.mbCon = mbCon;
            Description = "Multiple Coils";
            //base.DisplayType = FormatConverter.FormatName.Boolean;
            formatContainer.DefaultFormat = FormatConverter.FormatName.Boolean;

            //Testing
            //startAddress = 0;
            //base.SlaveAddress = 1;
            NumberOfRegisters = 4;

            //AddressDescription = new Dictionary<ushort, string>();
            DataBuffer = new Dictionary<ushort, ushort>();
           
        }
        public override string OperationReadDescription { get { return "FC1: Read Coils"; } }
        public override string OperationWriteDescription { get { return "FC5: Write SingleCoil (for each)"; } }
        
        public override ushort NumberOfRegisters { get { return numberOfRegisters; } set { numberOfRegisters = value; UpdateFcSettings(); } }
       
        //internal override void ExecuteRead()
        //{
        //    //base.mbCon.Master.ReadCoilsAsync(base.SlaveAddress, startAddress, NumberOfRegisters)

        //    Span<ushort> spandata = base.mbCon.Master.ReadHoldingRegisters<ushort>(base.SlaveAddress, startAddress, NumberOfRegisters);
        //    ushort[] rawData = spandata.ToArray();
        //    ReadCount++;
        //    DataBuffer.Clear();
        //    for (ushort i = 0; i < rawData.Length; i++)
        //    {
        //        ushort address = (ushort)(i + startAddress);
        //        DataBuffer.Add(address, (rawData[i]));

        //    }
        //    base.ForceDataRefresh("");
        //}
        internal override async Task ExecuteReadAsync()
        {
            try
            {
                if (base.mbCon.Master == null)
                {
                    throw new NullReferenceException("Not connected to server");
                }

                var stopwatch = Stopwatch.StartNew();
                Memory<byte> _bitData = await base.mbCon.Master.ReadCoilsAsync(base.SlaveAddress, startAddress, NumberOfRegisters);
                byte[] bitData = _bitData.ToArray();
                stopwatch.Stop();
                ResponseTimeMs = stopwatch.Elapsed.TotalMilliseconds;
                ReadCount++;


                //DataBuffer.Clear();
                ushort[] rawdata = new ushort[NumberOfRegisters];
                for (ushort i = 0; i < NumberOfRegisters; i++)
                {
                    int bytenum = i / 8;
                    int bIndex = i % 8;
                    bool coil = FormatConverter.IsBitSet(bitData[bytenum], bIndex);
                    //ushort address = (ushort)(i + startAddress);
                    //DataBuffer.Add(address, (Convert.ToUInt16(coil)));
                    rawdata[i] = (Convert.ToUInt16(coil));
                }
                SetDatabuffer(rawdata);
                base.ForceFcActivatedEvent();
                base.ForceDataRefresh("");
            }
            catch (Exception e)
            {
                base.ForceDataRefresh(e.Message);

            }
        }
        internal override async Task ExecuteWriteAsync()
        {
            try
            {

                ushort[] sendData = ReadFromBuffer(StartAddress, NumberOfRegisters);                
                var tasks = new List<Task>();
                var stopwatch = Stopwatch.StartNew();
               
                for (int i = 0; i < NumberOfRegisters; i++)
                {
                   bool value = Convert.ToBoolean(sendData[i]);
                   await base.mbCon.Master.WriteSingleCoilAsync(base.SlaveAddress, StartAddress + i, value); // Waiting for response before next request is sent.
                }                
                stopwatch.Stop();
                
                ResponseTimeMs = stopwatch.Elapsed.TotalMilliseconds;

                WriteCount++;
                base.ForceFcActivatedEvent();
                base.ForceDataRefresh("");
            }
            catch (Exception e)
            {
                base.ForceDataRefresh(e.Message);

            }
        }
        

        public override object Clone()
        {
            MultipleCoils next = new MultipleCoils(mbCon);

            return this.CopyAllBaseProperties(next); 
        }
    }
}
