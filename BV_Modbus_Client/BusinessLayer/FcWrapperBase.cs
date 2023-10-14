using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    //[KnownType(typeof(FcWrapperFc3))] // Example: FcWrapperFc3
    [KnownType(typeof(MultipleCoils))] 
    [KnownType(typeof(MultipleHoldingRegisters))]
    [KnownType(typeof(ReadDiscreteInputs))]
    [KnownType(typeof(ReadInputRegisters))]
    internal abstract class FcWrapperBase :ICloneable
    {
        private string description;
        private byte slaveaddress = 1;
        //private List<FcWrapperBase> parent;
        [DataMember]
        public ushort startAddress;
        private bool isSelected1;
        private FormatConverter.FormatName displayType;
        private string[] fcAddressDescription;

        //[DataMember]
        //public FormatConverter.FormatName DisplayType { get => displayType; set { displayType = value; ForceDataRefresh(""); } }
        //[DataMember]
        //public bool SwapBytes { get; set; }
        //[DataMember]
        //public bool SwapRegisters { get; set; }
        [Browsable(false)]
        //public FormatConverter Format { get; set; }

        internal MbConnection mbCon { get; set; }
        [DataMember]
        public string Description { get { return description; } set { description = value; FcSettingsChangedEvent?.Invoke(); } }
        [DataMember]
        //[Display(Order = 1)]
        //[DisplayName("SlaveAddress"), Display(Order = 1)]
        [Category("Modbus")]
        public byte SlaveAddress { get => slaveaddress; set { slaveaddress = value; FcSettingsChangedEvent?.Invoke(); } }
        [Category("Modbus")]
        public ushort StartAddress
        {
            get
            {
                int indexAdjustment = GlobFcData.ZeroBasedAdresses ? 0 : 1;
                return (ushort)(startAddress + indexAdjustment);
            }
            set
            {
                int indexAdjustment = GlobFcData.ZeroBasedAdresses ? 0 : 1;
                startAddress = (ushort)(value - indexAdjustment);
                FcSettingsChangedEvent?.Invoke();
            }
        }
        [DataMember]
        //public bool FcTypeWrite { get; internal set; }
        //[DataMember]
        [Category("Modbus")]
        public virtual ushort NumberOfRegisters
        {
            get { return 1; }
            set { }
        }
        [Browsable(false)]
        public bool isSelected { get => isSelected1; set { isSelected1 = value; SelectedChanged?.Invoke(this, isSelected); } }

        [Browsable(false)]
        [DataMember]
        public Dictionary<ushort, ushort> DataBuffer { get; set; } // Databuffer contains the address read, the value and a description.
        [Browsable(false)]
        [DataMember] 
        public string[] FcAddressDescription { get => fcAddressDescription; set => fcAddressDescription = value; }
        //[Browsable(false)]
        //[DataMember]
        //public Dictionary<ushort, string> AddressDescription { get; set; } // Databuffer contains the address read, the value and a description.
        [Browsable(false)]
        public virtual string OperationReadDescription { get { return "Read"; } }
        [Browsable(false)]
        public virtual string OperationWriteDescription { get { return "Write"; } }
        [Browsable(false)]
        public GlobalFCdata GlobFcData { get; set; }
        [Browsable(false)]
        public int ReadCount { get; set; }
        [Browsable(false)]
        public int WriteCount { get; set; }
        [Browsable(false)]
        public double ResponseTimeMs { get; set; }

        [Browsable(false)]
        [DataMember]
        public int SavedPollOrder { get; set; } = -1; // -1 means not polled. Only used for saving and restoring applionstate. Not kept up to date during program execution.
        public FormatContainer formatContainer { get; set; } 
        //public string Type
        //{
        //    get { return this.GetType().Name; }

        //}
        public FcWrapperBase()
        {
            formatContainer = new FormatContainer(this);
        }


        public event Action<string> RefreshDataEvent;
        public event Action<string[]> FormatValidStateEvent;
        public event Action FcSettingsChangedEvent;
        public event Action<FcWrapperBase, bool> SelectedChanged;
        public event Action FcActivatedEvent;
        public event Action<bool> ActivePollingChangedEvent;

        public void UpdateFcSettings()
        {
            if (fcAddressDescription == null)
            {
                fcAddressDescription = new string[NumberOfRegisters];
            }
            else
            {
                Array.Resize<string>(ref fcAddressDescription, NumberOfRegisters);
            }
            formatContainer.UpdateRegisterCount(NumberOfRegisters);

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


        public virtual (string, string)[] GetDataAsString(bool UseRegOnMissingDescription=false) // Gui uses this to display the data.
        {
            //ushort[] databuffer = ReadFromBuffer(startAddress, NumberOfRegisters);

            string[] strvalues =  GetValueStrings();
            // string[] strvalues = FormatConverter.GetStringRepresentation(databuffer, DisplayType, SwapBytes, SwapRegisters);
            // Function translates Databuffer into a string array
            (string, string)[] strData = new (string, string)[NumberOfRegisters];
            for (int i = 0; i < NumberOfRegisters; i++)
            {
                ushort address = (ushort)(i + startAddress);
                //ushort datavalue;
                string dataDescription;
                //bool valueFound = DataBuffer.TryGetValue(address, out datavalue);
                //bool dscrFound = GlobFcData.AddressDescription.TryGetValue(address, out dataDescription); // Description

                /*if (valueFound) */
                strData[i].Item1 = strvalues[i];
                //else strData[i].Item1 = "";



                bool descriptionExists = false;
                if (FcAddressDescription.Length > i)
                {
                    if (FcAddressDescription[i] != null)
                    {
                        descriptionExists = FcAddressDescription[i].Length > 0;
                    }
                }
                if (descriptionExists)
                {
                    strData[i].Item2 = FcAddressDescription[i];
                }
                else
                {
                    strData[i].Item2 = "Reg" + address;
                }

            }

            return strData;
        }

        internal string[] GetValueStrings( bool onlyOneStringPerValue = false)
        {
            return formatContainer.BinaryToString(ReadCompleteBufferAsArray(), onlyOneStringPerValue);
        }
        internal void ForceFcActivatedEvent()
        {
            FcActivatedEvent?.Invoke();
        }



        //internal abstract void Execute();
        //internal abstract void ExecuteWrite();
        //internal abstract void ExecuteRead();
        internal abstract Task ExecuteReadAsync();
        internal abstract Task ExecuteWriteAsync();
        //internal abstract void SetFcData(string[] strings);
        internal virtual void SetFcData(string[] strings)  // Called when table is changed by the user. This function stores the data in AddressDescription and DataBuffer
        {

            ushort[] setData = formatContainer.StringToBinary(strings);
            string[] errors = formatContainer.GetErrorList(setData.Length);
                // = new string[strings.Length];

            // = new ushort[strings.Length];
            //setData = FormatConverter.GetBinaryRepresentation(strings, DisplayType, out errors, SwapBytes, SwapRegisters);
            // Store the valid numerical values.
            //string[] formatErrorMessages = new string[strings.Length];
            //bool formatValid = true;
            for (int i = 0; i < setData.Length; i++)
            {
                ushort address = (ushort)(startAddress + i);
                //try
                //{
                //bool shouldDelete = (errors[i] != null);
                bool shouldDelete = false;
                if (errors[i] != null)
                {
                    shouldDelete = errors[i].Length > 0;
                }
                //ushort datapoint = Format.GetBinaryRepresentation(strings[i]);
                bool keyExist = DataBuffer.ContainsKey(address);
                if (keyExist)
                {
                    if (shouldDelete)
                    {
                        //GlobFcData.AddressDescription.Remove(address);
                    }
                    else
                    {
                        DataBuffer[address] = setData[i];
                    }
                }
                else
                {
                    DataBuffer.Add(address, setData[i]);
                }
                //}
                //catch (Exception err)
                //{
                //    formatErrorMessages[i] = err.Message;
                //}
            }




            ForceDataRefresh("");
            UpdateFormatValidState(errors);
        }
        //internal virtual string[] GetFcData(int numberOfRegisters, int startRegister)
        //{
        //    List<string> strings = new List<string>();

        //    for (int i = 0; i < numberOfRegisters; i++)
        //    {
        //        ushort address = (ushort)(startRegister + i);
        //        if (DataBuffer.ContainsKey(address))
        //        {
        //            strings.Add(FormatConverter.GetStringRepresentation(DataBuffer[address], DisplayType, SwapBytes));
        //        }
        //        else
        //        {
        //            strings.Add(""); // Empty string if address not found in DataBuffer
        //        }
        //    }

        //    return strings.ToArray();
        //}

        internal void SetFcDescription(string[] strings)
        {

            FcAddressDescription = strings;

            // Store the Descriptions.
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    ushort address = (ushort)(StartAddress + i);

            //    bool shouldDelete = (strings[i].Length < 1);
            //    bool keyExist = GlobFcData.AddressDescription.ContainsKey(address);
            //    if (keyExist)
            //    {
            //        if (shouldDelete)
            //        {
            //            GlobFcData.AddressDescription.Remove(address);
            //        }
            //        else
            //        {

            //            GlobFcData.AddressDescription[address] = strings[i];
            //        }
            //    }
            //    else
            //    {
            //        GlobFcData.AddressDescription.Add(address, strings[i]);
            //    }
            //}
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
        internal ushort[] ReadCompleteBufferAsArray()
        {
            return ReadFromBuffer(startAddress, NumberOfRegisters);
        }

        internal void TriggerPollChangedEvent(bool pollEnabled)
        {
            GlobFcData.ReportActivePollingChanged(this, pollEnabled);
            //ActivePollingChangedEvent?.Invoke(pollEnabled);
        }

        public abstract object Clone();

        public FcWrapperBase CopyAllBaseProperties(FcWrapperBase next)
        {
            next.description = description;
            next.slaveaddress = slaveaddress;
            next.startAddress = startAddress;
            next.displayType = displayType;
            next.fcAddressDescription = fcAddressDescription;
            //next.SwapBytes = SwapBytes;
            //next.SwapRegisters = SwapRegisters;
            next.NumberOfRegisters = NumberOfRegisters;
            next.DataBuffer = DataBuffer;
            next.GlobFcData = GlobFcData;
            //next.isSelected = isSelected;
            //next.OperationReadDescription = OperationReadDescription;
            //next.OperationWriteDescription = OperationWriteDescription;

            return next;
        }

        //public object Clone()
        //{
        //    FcWrapperBase next = new FcWrapperBase();
        //}
    }
}
