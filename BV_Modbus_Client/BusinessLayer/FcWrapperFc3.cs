using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    internal class FcWrapperFc3 : FcWrapperBase
    {
        private ushort[] data;

        public FcWrapperFc3(MbConnection mbCon) // Read multiple coils
        {
            //base.Parent = parent;
            
            base.mbCon = mbCon;
            Description = "FC 3 - Read multiple Coils";

            //Testing
            StartAddress = 0;
            base.SlaveAddress = 1;
            NumberOfRegisters = 4;

            AddressDescription = new Dictionary<ushort, string>();
            DataBuffer = new Dictionary<ushort, ushort>();
            //DataBuffer.Add(0, 0);
            //DataBuffer.Add(1, 0);
            //DataBuffer.Add(2, 0);
            //DataBuffer.Add(3, 0);
        }
        [DataMember]
        public override ushort NumberOfRegisters { get;  set; }
        //[DataMember]
        //public ushort StartAddress { get;  set; }
        
        internal override void Execute()
        {
            ushort[] rawData = base.mbCon.Master.ReadHoldingRegisters(base.SlaveAddress, StartAddress, NumberOfRegisters);
            DataBuffer.Clear();
            for (ushort i = 0; i < rawData.Length; i++)
            {
                ushort address = (ushort)(i + StartAddress);
                DataBuffer.Add(address, (rawData[i]));

            }
            //Databuffer = rawData.ToDictionary<ushort, (ushort, string)>(item => item.Value);
            
            //string[] sData = Format.GetStringRepresentation(rawData);
            base.OnResponseReceived();

        }
        //internal override void SetFcData(string[] strings)
        //{
        //    data = new ushort[strings.Length];
        //    for (int i = 0; i < strings.Length; i++)
        //    {
        //        data[i] = Convert.ToUInt16(strings[i]);
        //    }
        //}
        
    }
}
