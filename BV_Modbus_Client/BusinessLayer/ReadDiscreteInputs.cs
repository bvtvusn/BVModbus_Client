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
    internal class ReadDiscreteInputs: FcWrapperBase
    {
        [DataMember]
        private ushort numberOfRegisters;

        public ReadDiscreteInputs(MbConnection mbCon) : base()// Read multiple coils
        {

            base.mbCon = mbCon;
            Description = "Read Discrete Inputs";
            formatContainer.DefaultFormat = FormatConverter.FormatName.Boolean;
            NumberOfRegisters = 4;

            DataBuffer = new Dictionary<ushort, ushort>();

        }
        public override string OperationReadDescription { get { return "FC2: Read Discrete Inputs"; } }
        //public override string OperationWriteDescription { get { return "FC5: Write SingleCoil (for each)"; } }
        
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
                Memory<byte> _bitData = await base.mbCon.Master.ReadDiscreteInputsAsync(base.SlaveAddress, startAddress, NumberOfRegisters);
                byte[] bitData = _bitData.ToArray();
                stopwatch.Stop();
                ResponseTimeMs = stopwatch.Elapsed.TotalMilliseconds;
                ReadCount++;


                DataBuffer.Clear();
                for (ushort i = 0; i < NumberOfRegisters; i++)
                {
                    int bytenum = i / 8;
                    int bIndex = i % 8;
                    bool coil = FormatConverter.IsBitSet(bitData[bytenum], bIndex);
                    ushort address = (ushort)(i + startAddress);
                    DataBuffer.Add(address, (Convert.ToUInt16(coil)));

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
            
                base.ForceDataRefresh("Can not write to discrete inputs");

            
        }


        public override object Clone()
        {
            ReadDiscreteInputs next = new ReadDiscreteInputs(mbCon);

            return this.CopyAllBaseProperties(next);
        }
    }
}
