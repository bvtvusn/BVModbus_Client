﻿using System;
using System.Collections.Generic;
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
        private ushort numberOfRegisters;

        public MultipleHoldingRegisters(MbConnection mbCon) // Read multiple coils
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
        [DataMember]
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

        internal override void ExecuteRead()
        {
            ushort[] rawData = base.mbCon.Master.ReadHoldingRegisters(base.SlaveAddress, startAddress, NumberOfRegisters);
            
            DataBuffer.Clear();
            for (ushort i = 0; i < rawData.Length; i++)
            {
                ushort address = (ushort)(i + startAddress);
                DataBuffer.Add(address, (rawData[i]));

            }
            base.ForceDataRefresh("");
        }
        internal override async Task ExecuteReadAsync()
        {
            try
            {
                if (base.mbCon.Master == null)
                {
                    throw new NullReferenceException("Not connected to server");
                }
                ushort[] rawData = await base.mbCon.Master.ReadHoldingRegistersAsync(base.SlaveAddress, startAddress, NumberOfRegisters);
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
            try
            {

                ushort[] sendData = ReadFromBuffer(StartAddress, NumberOfRegisters);
                await base.mbCon.Master.WriteMultipleRegistersAsync(base.SlaveAddress, StartAddress, sendData);

                base.ForceFcActivatedEvent();                
                base.ForceDataRefresh("");
            }
            catch (Exception e)
            {
                base.ForceDataRefresh(e.Message);

            }
        }
        internal override void ExecuteWrite()
        {
            ushort[] sendData = ReadFromBuffer(StartAddress, NumberOfRegisters);
            base.mbCon.Master.WriteMultipleRegisters(base.SlaveAddress, StartAddress, sendData);
        }


    }
}
