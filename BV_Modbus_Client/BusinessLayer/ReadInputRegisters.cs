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
    internal class ReadInputRegisters : FcWrapperBase
    {
        //private ushort[] data;
        private ushort numberOfRegisters;

        public ReadInputRegisters(MbConnection mbCon) : base() // Read multiple coils
        {
            //base.Parent = parent;

            base.mbCon = mbCon;
            Description = "Read Input Registers";
            //base.DisplayType = FormatConverter.FormatName.Boolean;

            
            NumberOfRegisters = 4;
            DataBuffer = new Dictionary<ushort, ushort>();

        }
        public override string OperationReadDescription { get { return "FC4: Read Input Registers"; } }
        //public override string OperationWriteDescription { get { return ""; } }
        [DataMember]
        public override ushort NumberOfRegisters { get { return numberOfRegisters; } set { numberOfRegisters = value; UpdateFcSettings(); } }

       
        internal override async Task ExecuteReadAsync()
        {
            try
            {
                if (base.mbCon.Master == null)
                {
                    throw new NullReferenceException("Not connected to server");
                }

                var stopwatch = Stopwatch.StartNew();
                Memory<ushort> memData = await base.mbCon.Master.ReadInputRegistersAsync<ushort>(base.SlaveAddress, startAddress, NumberOfRegisters);
                ushort[] rawData = memData.ToArray();

                stopwatch.Stop();
                ResponseTimeMs = stopwatch.Elapsed.TotalMilliseconds;



                ReadCount++;
                DataBuffer.Clear();
                for (ushort i = 0; i < rawData.Length; i++)
                {
                    ushort address = (ushort)(i + startAddress);
                    DataBuffer.Add(address, (rawData[i]));

                }
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
            base.ForceDataRefresh("Can not write to Input registers");
        }


        public override object Clone()
        {
            ReadInputRegisters next = new ReadInputRegisters(mbCon);

            return this.CopyAllBaseProperties(next);
        }
    }
}
