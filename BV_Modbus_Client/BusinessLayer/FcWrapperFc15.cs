using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    internal class FcWrapperFc15:FcWrapperBase
    {
        private ushort[] data;

        public FcWrapperFc15(MbConnection mbCon) // Write multiple coils
        {
            base.mbCon = mbCon;
           
            //base.FcTypeWrite = true;
            Description = "FC 15 - Write multiple Coils";

            //Initialization
            base.SlaveAddress = 1;
            StartAddress = 0;
            NumberOfRegisters = 4;

            //AddressDescription = new Dictionary<ushort, string>();
            DataBuffer = new Dictionary<ushort, ushort>();
            //DataBuffer.Add(0, 0);
            //DataBuffer.Add(1, 0);
            //DataBuffer.Add(2, 0);
            //DataBuffer.Add(3, 0);

        }

        [DataMember]
        public override ushort NumberOfRegisters { get; set; }

        internal override void ExecuteRead()
        {
            throw new NotImplementedException();
        }

        internal override void ExecuteWrite()
        {
            throw new NotImplementedException();
        }
        //public ushort StartAddress { get; set; }

        //internal override void DeleteThis()
        //{
        //    parent.Remove(this);
        //}

        //internal override void Execute()
        //{

        //    ushort[] sendData = ReadFromBuffer(StartAddress, NumberOfRegisters);




        //    base.mbCon.Master.WriteMultipleRegisters(base.SlaveAddress, StartAddress, sendData);            
        //}

        //internal override void SetFcData(string[] strings)  // Called when table is changed by the user. This function stores the data in AddressDescription and DataBuffer
        //{


        //    // Store the valid numerical values.
        //    string[] formatErrorMessages = new string[strings.Length];
        //    bool formatValid = true;
        //    for (int i = 0; i < strings.Length; i++)
        //    {
        //        ushort address = (ushort)(StartAddress + i);
        //        try
        //        {
        //            bool shouldDelete = (strings[i].Length > 0);
        //            //ushort datapoint = Format.GetBinaryRepresentation(strings[i]);
        //            bool keyExist = DataBuffer.ContainsKey(address);
        //            if (keyExist)
        //            {
        //                if (shouldDelete)
        //                {
        //                    AddressDescription.Remove(address);
        //                }
        //                else
        //                {
        //                    DataBuffer[address] = Format.GetBinaryRepresentation(strings[i]);
        //                }
        //            }
        //            else
        //            {
        //                DataBuffer.Add(address, Format.GetBinaryRepresentation(strings[i]));
        //            }
        //        }
        //        catch (Exception err)
        //        {
        //            formatErrorMessages[i] = err.Message;
        //        }
        //    }




        //    OnResponseReceived();
        //    base.UpdateFormatValidState(formatErrorMessages);
        //}
    }
}
