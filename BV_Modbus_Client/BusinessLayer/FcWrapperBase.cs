using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    [KnownType(typeof(FcWrapperFc3))] // Example: FcWrapperFc3
    [KnownType(typeof(FcWrapperFc15))] // Example: FcWrapperFc3
    internal abstract class FcWrapperBase
    {
        private string description;
        private byte slaveaddress;
        //private List<FcWrapperBase> parent;
        private ushort startAddress;
        private bool isSelected1;
        [Browsable(false)]
        public FormatConverter Format { get; set; }

        internal MbConnection mbCon { get; set; }
        [DataMember]
        public string Description { get { return description; } set { description = value; FcSettingsChangedEvent?.Invoke(); } }
        [DataMember]
        public byte Slaveaddress { get => slaveaddress; set { slaveaddress = value; FcSettingsChangedEvent?.Invoke(); } }
        [DataMember]
        public ushort StartAddress { get => startAddress; set { startAddress = value; FcSettingsChangedEvent?.Invoke(); } }
        [DataMember]
        public bool FcTypeWrite { get; internal set; }
        [DataMember]
        public virtual ushort NumberOfPoints
        {
            get { return 1; }
            set { }
        }
        [Browsable(false)]
        public bool isSelected { get => isSelected1; set { isSelected1 = value; SelectedChanged?.Invoke(this, isSelected); } }

        [Browsable(false)]
        [DataMember]
        public Dictionary< ushort,ushort> DataBuffer{ get; set; } // Databuffer contains the address read, the value and a description.
        [Browsable(false)]
        [DataMember]
        public Dictionary<ushort, string> AddressDescription { get; set; } // Databuffer contains the address read, the value and a description.

        public event Action ResponseReceived;
        public event Action<string[]> FormatValidStateEvent;
        public event Action FcSettingsChangedEvent;
        public event Action<FcWrapperBase, bool> SelectedChanged;

        protected virtual void UpdateFormatValidState(string[] errors)
        {
            FormatValidStateEvent?.Invoke(errors);
        }
        public virtual void OnResponseReceived()
        {
            ResponseReceived?.Invoke();
        }


        public virtual (string, string)[] GetDataAsString()
        {
            // Function translates Databuffer into a string array
            (string, string)[] strData = new (string, string)[NumberOfPoints];
            for (int i = 0; i < NumberOfPoints; i++)
            {
                ushort address = (ushort)(i + StartAddress);
                ushort datavalue;
                string dataDescription;
                bool valueFound = DataBuffer.TryGetValue(address, out datavalue);
                bool dscrFound = AddressDescription.TryGetValue(address, out dataDescription); // Description

                if (valueFound) strData[i].Item1 = Format.GetStringRepresentation(datavalue); // Value
                else strData[i].Item1 = "";

                if (dscrFound) strData[i].Item2 = dataDescription;
                else strData[i].Item2 = "";
                
            }


            return strData;
        }
        


        internal abstract void Execute();
        //internal abstract void SetFcData(string[] strings);
        internal virtual void SetFcData(string[] strings)  // Called when table is changed by the user. This function stores the data in AddressDescription and DataBuffer
        {


            // Store the valid numerical values.
            string[] formatErrorMessages = new string[strings.Length];
            bool formatValid = true;
            for (int i = 0; i < strings.Length; i++)
            {
                ushort address = (ushort)(StartAddress + i);
                try
                {
                    bool shouldDelete = (strings[i].Length > 0);
                    //ushort datapoint = Format.GetBinaryRepresentation(strings[i]);
                    bool keyExist = DataBuffer.ContainsKey(address);
                    if (keyExist)
                    {
                        if (shouldDelete)
                        {
                            AddressDescription.Remove(address);
                        }
                        else
                        {
                            DataBuffer[address] = Format.GetBinaryRepresentation(strings[i]);
                        }
                    }
                    else
                    {
                        DataBuffer.Add(address, Format.GetBinaryRepresentation(strings[i]));
                    }
                }
                catch (Exception err)
                {
                    formatErrorMessages[i] = err.Message;
                }
            }




            OnResponseReceived();
            UpdateFormatValidState(formatErrorMessages);
        }

        internal void SetFcDescription(string[] strings)
        {
            // Store the Descriptions.
            for (int i = 0; i < strings.Length; i++)
            {
                ushort address = (ushort)(StartAddress + i);

                bool shouldDelete = (strings[i].Length > 0);
                bool keyExist = AddressDescription.ContainsKey(address);
                if (keyExist)
                {
                    if (shouldDelete)
                    {
                        AddressDescription.Remove(address);
                    }
                    else
                    {
                        
                    AddressDescription[address] = strings[i];
                    }
                }
                else
                {
                    AddressDescription.Add(address, strings[i]);
                }               
            }
        }
    }
}
