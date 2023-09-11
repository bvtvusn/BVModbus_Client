﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class SingleHoldingRegister : FcWrapperBase
    {
        private ushort[] data;
        private ushort numberOfRegisters;

        public SingleHoldingRegister(MbConnection mbCon) // Read multiple coils
        {
            base.mbCon = mbCon;
            Description = "Single Holding Register";
            NumberOfRegisters = 1;
            DataBuffer = new Dictionary<ushort, ushort>();
        }
        public override string OperationReadDescription { get { return "FC?: Read???"; } }
        public override string OperationWriteDescription { get { return "FC06: Write Single Register"; } }
        public override object Clone()
        {
            SingleHoldingRegister next = new SingleHoldingRegister(mbCon);

            return this.CopyAllBaseProperties(next); //new NotImplementedException();
        }


        internal override void ExecuteRead()
        {
            throw new NotImplementedException();
        }

        internal override async Task ExecuteReadAsync()
        {
            try
            {
                if (base.mbCon.Master == null)
                {
                    throw new NullReferenceException("Not connected to server");
                }

                var stopwatch = Stopwatch.StartNew();
                ushort[] rawData = await base.mbCon.Master.ReadHoldingRegistersAsync(base.SlaveAddress, startAddress, NumberOfRegisters);
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

        internal override void ExecuteWrite()
        {
            throw new NotImplementedException();
        }

        internal override async Task ExecuteWriteAsync()
        {
            try
            {

                ushort[] sendData = ReadFromBuffer(StartAddress, NumberOfRegisters);



                var stopwatch = Stopwatch.StartNew();
                base.mbCon.Master.WriteSingleRegister(base.SlaveAddress, StartAddress, sendData[0]);
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
    }
}