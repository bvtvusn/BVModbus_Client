using BV_Modbus_Client.DataAccessLayer;


namespace BV_Modbus_Client.BusinessLayer
{
    //Modbus info
//-ReadHoldingRegisters
//-WriteMultipleRegisters
    
//-WriteSingleCoil
//-Read Coils

//-ReadDiscrete inputs

//-ReadinputRegisters

//-ReadWriteMultipleRegisters

//-WriteSingleRegister


//Holding are 16-bit(readWrite)
//Coils are 1-bit registers(readWrite)
//Input registers are 16-bit registers used for input, and may only be read
//Discrete Inputs are 1-bit registers used as inputs, and may only be read
    public class BLL
    {
        internal MbConnection mbCon;
        UserConfiguration userConfig;
        Dal dal;
        
        //internal FormatConverter formatConverter;
        internal UserConfiguration UserConfig { get => userConfig; set => userConfig = value; }
        public bool Modbus_IsConnected { get { return (mbCon.Master != null); } }
        public event Action FcSettingsChangedEvent;
        public event Action UserConfigLoadedEvent;


        public event EventHandler FcListChangedEvent;

        public BLL()
        {
            UserConfig = new UserConfiguration();
            dal = new Dal();
            mbCon = new MbConnection(false);

            UserConfig.GlobFcData.ActivePollingChangedEvent += GlobFcData_ActivePollingChangedEvent;
            //formatConverter = new FormatConverter();
            //FcWrappers = new List<FcWrapperBase>();
            userConfig.pollTimer.PollFinishedEvent += PollTimer_PollFinishedEvent;
        }

        private void PollTimer_PollFinishedEvent((string, string)[] data, bool PollitemsChanged)
        {
            if (UserConfig == null) { return; }
            var flags = UserConfig.pollLoggerSettings.CheckLoggingNeeded(data, PollitemsChanged);
            bool linelogNeeded = flags.Item1;
            bool headerNeeded = flags.Item2;

            if (linelogNeeded)
            {
                if (!dal.FileExists(UserConfig.pollLoggerSettings.LogFilePath))
                {
                    headerNeeded = true; // Header must be made if the file does not exist yet.
                }
            }
            
            if (headerNeeded)
            {
                string[] HeaderData = data.Select(x => x.Item2).ToArray();
                string header = UserConfig.pollLoggerSettings.GenerateHeaderLine(HeaderData);

                dal.AppendToFile(header, UserConfig.pollLoggerSettings.LogFilePath);
            }
            if (linelogNeeded)
            {
                string[] viewData = data.Select(x => x.Item1).ToArray();
                string line = UserConfig.pollLoggerSettings.GenerateDataLine(viewData);
                dal.AppendToFile(line, UserConfig.pollLoggerSettings.LogFilePath);
            }
            

            

            //if (UserConfig.pollLoggerSettings.LoggingEnabled)
            //{
            //    if (PollitemsChanged)
            //    {
                    
                     
            //    }
                

            //}
        }

        private void GlobFcData_ActivePollingChangedEvent(FcWrapperBase fc, bool pollingEnabled)
        {
            UserConfig.pollTimer.UpdatePollList(fc, pollingEnabled);
        }


        #region SelectedFc
        public event Action<string> SelectedDataRecevivedEvent;
        public event Action<string[]> SelectedFormatValidStateEvent;
        public event Action SelectedFcSettingsChangedEvent;
        public event Action SelectedFcActivatedEvent;
        private FcWrapperBase selectedFcRequest;
        private void SelectedFcRequest_ResponseReceived(string errorMsg)
        {
            SelectedDataRecevivedEvent?.Invoke(errorMsg); // Resending the data received event.
        }
        private void SelectedFcRequest_FormatValidStateEvent(string[] errors)
        {
            SelectedFormatValidStateEvent?.Invoke(errors);
        }
        private void SelectedFcRequest_FcActivatedEvent()
        {
            SelectedFcActivatedEvent?.Invoke();
        }
        private void SelectedFcRequest_FcSettingsChangedEvent()
        {
            SelectedFcSettingsChangedEvent?.Invoke();
        }
        internal void SetSelectedCard(FcWrapperBase fcCommand)
        {
            this.SelectedFcRequest = fcCommand;
            foreach (FcWrapperBase item in userConfig.FcWrappers)
            {
                item.isSelected = Object.ReferenceEquals(item, fcCommand); // Only the correct object is set to true
            }
            FcSettingsChangedEvent?.Invoke();
        }

        

        internal FcWrapperBase SelectedFcRequest
        {
            get => selectedFcRequest;
            private set
            {
                if (selectedFcRequest != null)
                {
                    selectedFcRequest.RefreshDataEvent -= SelectedFcRequest_ResponseReceived;
                    selectedFcRequest.FormatValidStateEvent -= SelectedFcRequest_FormatValidStateEvent;
                    selectedFcRequest.FcSettingsChangedEvent -= SelectedFcRequest_FcSettingsChangedEvent;
                    selectedFcRequest.FcActivatedEvent -= SelectedFcRequest_FcActivatedEvent; //                   SelectedFcRequest_FcActivatedEvent
                }
                selectedFcRequest = value;
                if (selectedFcRequest != null)
                {
                    selectedFcRequest.RefreshDataEvent += SelectedFcRequest_ResponseReceived;
                    selectedFcRequest.FormatValidStateEvent += SelectedFcRequest_FormatValidStateEvent;
                    selectedFcRequest.FcSettingsChangedEvent += SelectedFcRequest_FcSettingsChangedEvent;
                    selectedFcRequest.FcActivatedEvent += SelectedFcActivatedEvent;
                    //SelectedFcRequest_FcActivatedEvent

                    SelectedDataRecevivedEvent?.Invoke("");  //mAKING fAKE data received event to opdate the new table.
                }


            }
        }
        #endregion
        #region FcRelated
        //internal void AddMultiHR_FC()
        //{

        //    MultipleHoldingRegisters fcobj = new MultipleHoldingRegisters(mbCon);
        //    //fcobj.Format = this.formatConverter;  // Set the format converter object
        //    UserConfig.FcWrappers.Add(fcobj);
        //    //protected virtual void FcObjectAdded
        //    //OnFcObjectAdded?.Invoke(fcobj, new EventArgs());
        //    UpdateFCList();
        //}
        internal void AddFunctionCode(Type type)
        {
            FcWrapperBase fc;
            if (type == typeof(MultipleCoils))
            {
                fc = new MultipleCoils(mbCon);
                UserConfig.FcWrappers.Add(fc);
            }
            else if (type == typeof(MultipleHoldingRegisters))
            {
                fc = new MultipleHoldingRegisters(mbCon);
                UserConfig.FcWrappers.Add(fc);
            }
            else if (type == typeof(ReadInputRegisters))
            {
                fc = new ReadInputRegisters(mbCon);
                UserConfig.FcWrappers.Add(fc);
            }
            else if (type == typeof(ReadDiscreteInputs))
            {
                fc = new ReadDiscreteInputs(mbCon);
                UserConfig.FcWrappers.Add(fc);
            }
            //
            UpdateFCList();
        }

        //internal void AddFc15()
        //{
        //    FcWrapperFc15 fcobj = new FcWrapperFc15(mbCon);
        //    //fcobj.Format = this.formatConverter;  // Set the format converter object
        //    UserConfig.FcWrappers.Add(fcobj);
        //    //protected virtual void FcObjectAdded
        //    //OnFcObjectAdded?.Invoke(fcobj, new EventArgs());
        //    UpdateFCList();
        //}
        internal void RemoveFC(FcWrapperBase fcCommand)
        {
            UserConfig.pollTimer.UpdatePollList(fcCommand, false); // Removing the item from the list.

            if (Object.ReferenceEquals(fcCommand, SelectedFcRequest)) // If removing the selected, also reomove the object from "Selected object"
            {
                selectedFcRequest.RefreshDataEvent -= SelectedFcRequest_ResponseReceived;
                selectedFcRequest.FormatValidStateEvent -= SelectedFcRequest_FormatValidStateEvent;
                this.SelectedFcRequest = null;
            }

            UserConfig.FcWrappers.Remove(fcCommand);
            UpdateFCList();
        }
        internal void UpdateFCList()
        {
            foreach (FcWrapperBase item in UserConfig.FcWrappers)
            {
                item.GlobFcData = UserConfig.GlobFcData;
            }
            FcListChangedEvent?.Invoke(this, new EventArgs());
        }
        #endregion



        //public void ConnectServer()
        //{
        //    mbCon.Hostname = UserConfig.Network_RemoteHostname;
        //    mbCon.Port = UserConfig.Network_RemotePort;
        //    mbCon.ConnectToSlave();

        //}
        


        //internal void AddFc(FcWrapperBase fc)
        //{

        //    fcWrappers.Add(fc);
        //    //fc.Parent = fcWrappers; // Must be set here because it is not known after importing from file.
        //    //protected virtual void FcObjectAdded
        //    //OnFcObjectAdded?.Invoke(fc, new EventArgs());
        //    UpdateFCList();
        //}

        internal void LoadConfig()
        {
            UserConfig.pollTimer.TimerEnabled = false;
            UserConfig.pollTimer = null;
            UserConfig.FcWrappers.Clear();
            UserConfig.FcWrappers = null;
            UserConfig.pollLoggerSettings = null;
            UserConfig.GlobFcData = null;
            UserConfig = null;
           


            UserConfig = dal.LoadFromFile();

            UserConfig.GlobFcData.ActivePollingChangedEvent += GlobFcData_ActivePollingChangedEvent; // used for starting and stopping polling
            
            //UserConfig.FcWrappers[0].m
            foreach (FcWrapperBase item in UserConfig.FcWrappers)
            {
                item.mbCon = this.mbCon; // All share the same instance of the connection
                item.InitializeObject();
            }
            UpdateFCList();
            UserConfigLoadedEvent?.Invoke();
            userConfig.pollTimer.PollFinishedEvent += PollTimer_PollFinishedEvent; // Reattach eventhandler to the polltimer after it is swithched out. 
        }
        internal void SaveAs()
        {
            dal.SaveAs_ToFile(UserConfig);
        }

        internal void Save()
        {
            dal.OnSaveButton(UserConfig);
        }

        internal void DuplicateFc(FcWrapperBase fcCommand)
        {
            //fcCommand.
            //var next = new FcWrapperBase(fcCommand);

            UserConfig.FcWrappers.Add((FcWrapperBase)fcCommand.Clone());
            UpdateFCList();
        }
    }
}