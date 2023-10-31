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
    internal class MultipleHoldingRegisters : FcWrapperBase
    {

        private ushort[] data;
        [DataMember]
        private ushort numberOfRegisters;

        public MultipleHoldingRegisters(MbConnection mbCon) :base() // Read multiple coils
        {
            //base.Parent = parent;

            base.mbCon = mbCon;
            Description = "Multiple Holding Registers";

            //Testing
            //startAddress = 0;
            //base.SlaveAddress = 1;
            NumberOfRegisters = 4;

            //AddressDescription = new Dictionary<ushort, string>();
            DataBuffer = new Dictionary<ushort, ushort>();
            //DataBuffer.Add(0, 0);
            //DataBuffer.Add(1, 0);
            //DataBuffer.Add(2, 0);
            //DataBuffer.Add(3, 0);
        }
        public override string OperationReadDescription { get { return "FC3: Read Multiple Holding Registers"; } }
        public override string OperationWriteDescription { get { return "FC15: Write Multiple Holding Registers"; } }
        
        
        public override ushort NumberOfRegisters { get {   return numberOfRegisters;  } set {  numberOfRegisters = value; UpdateFcSettings(); } } 
        //[DataMember]
        //public ushort StartAddress { get;  set; }

        //internal override void Execute()
        //{
        //    ushort[] rawData = base.mbCon.Master.ReadHoldingRegisters(base.SlaveAddress, StartAddress, NumberOfRegisters);
        //    DataBuffer.Clear();
        //    for (ushort i = 0; i < rawData.Length; i++)
        //    {
        //        ushort address = (ushort)(i + StartAddress);
        //        DataBuffer.Add(address, (rawData[i]));

        //    }
        //    //Databuffer = rawData.ToDictionary<ushort, (ushort, string)>(item => item.Value);

        //    //string[] sData = Format.GetStringRepresentation(rawData);
        //    base.OnResponseReceived();

        //}

        //internal override void ExecuteRead()
        //{
        //    //base.mbCon.Master.ReadHoldingRegisters()
        //    Span<ushort> spandata   = base.mbCon.Master.ReadHoldingRegisters<ushort>(base.SlaveAddress, startAddress, NumberOfRegisters);
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
                Memory<ushort> memData= await base.mbCon.Master.ReadHoldingRegistersAsync<ushort>(base.SlaveAddress, startAddress, NumberOfRegisters);
                ushort[] rawData = memData.ToArray();

                stopwatch.Stop();
                ResponseTimeMs = stopwatch.Elapsed.TotalMilliseconds;



                ReadCount++;
                //DataBuffer.Clear();
                //for (ushort i = 0; i < rawData.Length; i++)
                //{
                //    ushort address = (ushort)(i + startAddress);
                //    DataBuffer.Add(address, (rawData[i]));

                //}
                SetDatabuffer(rawData);
                base.ForceDataRefresh("");
            }
            catch (Exception e)
            {
                ErrorCount++;
                base.ForceDataRefresh(e.Message);
                
            }
            base.ForceFcActivatedEvent();
        }
        internal override async Task ExecuteWriteAsync()
        {
            try
            {

                ushort[] sendData = ReadFromBuffer(StartAddress, NumberOfRegisters);



                var stopwatch = Stopwatch.StartNew();
                await base.mbCon.Master.WriteMultipleRegistersAsync(base.SlaveAddress, StartAddress, sendData);
                stopwatch.Stop();
                ResponseTimeMs = stopwatch.Elapsed.TotalMilliseconds;


                WriteCount++;
                base.ForceDataRefresh("");
            }
            catch (Exception e)
            {
                ErrorCount++;
                base.ForceDataRefresh(e.Message);

            }
                base.ForceFcActivatedEvent();                
        }
        //internal override void ExecuteWrite()
        //{
        //    ushort[] sendData = ReadFromBuffer(StartAddress, NumberOfRegisters);
        //    base.mbCon.Master.WriteMultipleRegisters(base.SlaveAddress, StartAddress, sendData);
        //    WriteCount++;
        //}

        public override object Clone()
        {
            MultipleHoldingRegisters next = new MultipleHoldingRegisters(mbCon);
            
            return this.CopyAllBaseProperties(next); //new NotImplementedException();
        }
    }
}
