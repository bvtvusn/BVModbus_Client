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
    [KnownType(typeof(MultipleHoldingRegisters))] // Example: FcWrapperFc3
    internal abstract class FcWrapperBase
    {
        private string description;
        private byte slaveaddress;
        //private List<FcWrapperBase> parent;
        [DataMember]
        private ushort startAddress;
        private bool isSelected1;
        [DataMember]         
        public FormatConverter.FormatName DisplayType { get; set; }
        [DataMember]
        public bool SwapBytes { get; set; }
        [Browsable(false)]
        //public FormatConverter Format { get; set; }

        internal MbConnection mbCon { get; set; }
        [DataMember]
        public string Description { get { return description; } set { description = value; FcSettingsChangedEvent?.Invoke(); } }
        [DataMember]
        public byte SlaveAddress { get => slaveaddress; set { slaveaddress = value; FcSettingsChangedEvent?.Invoke(); } }
        
        public ushort StartAddress {
            get {
                int indexAdjustment = GlobFcData.ZeroBasedAdresses ? 0 : 1;
                return (ushort)(startAddress + indexAdjustment); } 
            set {
                int indexAdjustment = GlobFcData.ZeroBasedAdresses ? 0 : 1;
                startAddress = (ushort)(value - indexAdjustment); 
                FcSettingsChangedEvent?.Invoke();
            } }
        [DataMember]
        //public bool FcTypeWrite { get; internal set; }
        //[DataMember]
        public virtual ushort NumberOfRegisters
        {
            get { return 1; }
            set { }
        }
        [Browsable(false)]
        public bool isSelected { get => isSelected1; set { isSelected1 = value; SelectedChanged?.Invoke(this, isSelected); } }

        [Browsable(false)]
        [DataMember]
        public Dictionary< ushort,ushort> DataBuffer{ get; set; } // Databuffer contains the address read, the value and a description.
        //[Browsable(false)]
        //[DataMember]
        //public Dictionary<ushort, string> AddressDescription { get; set; } // Databuffer contains the address read, the value and a description.

        public virtual string OperationReadDescription { get { return "Read"; } }
        public virtual string OperationWriteDescription { get { return "Write"; } }
        public GlobalFCdata GlobFcData { get; set; }
        public string Type
        {
            get { return this.GetType().Name; }
            
        }


        public event Action<string> RefreshDataEvent;
        public event Action<string[]> FormatValidStateEvent;
        public event Action FcSettingsChangedEvent;
        public event Action<FcWrapperBase, bool> SelectedChanged;
        public event Action FcActivatedEvent;

        public void UpdateFcSettings()
        {
            FcSettingsChangedEvent?.Invoke();
        }
        protected virtual void UpdateFormatValidState(string[] errors)
        {
            FormatValidStateEvent?.Invoke(errors);
        }
        public virtual void ForceDataRefresh(string errormsg)
        {
            RefreshDataEvent?.Invoke(errormsg);
        }


        public virtual (string, string)[] GetDataAsString() // Gui uses this to display the data.
        {
            // Function translates Databuffer into a string array
            (string, string)[] strData = new (string, string)[NumberOfRegisters];
            for (int i = 0; i < NumberOfRegisters; i++)
            {
                ushort address = (ushort)(i + StartAddress);
                ushort datavalue;
                string dataDescription;
                bool valueFound = DataBuffer.TryGetValue(address, out datavalue);
                bool dscrFound =GlobFcData.AddressDescription.TryGetValue(address, out dataDescription); // Description

                if (valueFound) strData[i].Item1 = FormatConverter.GetStringRepresentation(datavalue,DisplayType,SwapBytes); // Value
                else strData[i].Item1 = "";

                if (dscrFound) strData[i].Item2 = dataDescription;
                else strData[i].Item2 = "";
                
            }


            return strData;
        }

        internal void ForceFcActivatedEvent()
        {
            FcActivatedEvent?.Invoke();
        }



        //internal abstract void Execute();
        internal abstract void ExecuteWrite();
        internal abstract void ExecuteRead();
        internal abstract Task ExecuteReadAsync();
        internal abstract Task ExecuteWriteAsync();
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
                    bool shouldDelete = (strings[i].Length < 1);
                    //ushort datapoint = Format.GetBinaryRepresentation(strings[i]);
                    bool keyExist = DataBuffer.ContainsKey(address);
                    if (keyExist)
                    {
                        if (shouldDelete)
                        {
                            GlobFcData.AddressDescription.Remove(address);
                        }
                        else
                        {
                            DataBuffer[address] = FormatConverter.GetBinaryRepresentation(strings[i],DisplayType,SwapBytes);
                        }
                    }
                    else
                    {
                        DataBuffer.Add(address, FormatConverter.GetBinaryRepresentation(strings[i],DisplayType,SwapBytes));
                    }
                }
                catch (Exception err)
                {
                    formatErrorMessages[i] = err.Message;
                }
            }




            ForceDataRefresh("");
            UpdateFormatValidState(formatErrorMessages);
        }

        internal void SetFcDescription(string[] strings)
        {
            // Store the Descriptions.
            for (int i = 0; i < strings.Length; i++)
            {
                ushort address = (ushort)(StartAddress + i);

                bool shouldDelete = (strings[i].Length < 1);
                bool keyExist = GlobFcData.AddressDescription.ContainsKey(address);
                if (keyExist)
                {
                    if (shouldDelete)
                    {
                        GlobFcData.AddressDescription.Remove(address);
                    }
                    else
                    {

                        GlobFcData.AddressDescription[address] = strings[i];
                    }
                }
                else
                {
                    GlobFcData.AddressDescription.Add(address, strings[i]);
                }               
            }
        }

        internal ushort[] ReadFromBuffer(int startaddress, int length)
        {
            ushort[] datapoints = new ushort[length]; //base.mbCon.Master.ReadHoldingRegisters(base.Slaveaddress, StartAddress, NumberOfPoints);
            for (int i = 0; i < datapoints.Length; i++)
            {
                ushort address = (ushort)(i + startaddress);
                ushort datavalue;
                //string dataDescription;
                bool valueFound = DataBuffer.TryGetValue(address, out datavalue);
                //bool dscrFound = AddressDescription.TryGetValue(address, out dataDescription); // Description

                if (valueFound) datapoints[i] = datavalue; // Value
                
                else datapoints[i] = 0; //Default value is 0 if nothing is stored.
            }
            return datapoints;
        }
       
    }
}
