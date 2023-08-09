﻿using BV_Modbus_Client.DataAccessLayer;


namespace BV_Modbus_Client.BusinessLayer
{

    internal class BLL
    {
        internal MbConnection mbCon;
        UserConfiguration userConfig;
        Dal dal;
        //internal FormatConverter formatConverter;
        internal UserConfiguration UserConfig { get => userConfig; set => userConfig = value; }
        public bool Modbus_IsConnected { get { return (mbCon.Master != null); } }
        public event Action FcSettingsChangedEvent;


        public event EventHandler FcListChangedEvent;

        public BLL()
        {
            UserConfig = new UserConfiguration();
            dal = new Dal();
            mbCon = new MbConnection(false);

            UserConfig.GlobFcData.ActivePollingChangedEvent += GlobFcData_ActivePollingChangedEvent;
            //formatConverter = new FormatConverter();
            //FcWrappers = new List<FcWrapperBase>();
        }

        private void GlobFcData_ActivePollingChangedEvent(FcWrapperBase fc, bool pollingEnabled)
        {
            UserConfig.pollTimer.UpdatePollList(fc, pollingEnabled);
        }


        #region SelectedFc
        public event Action<string> SelectedDataRecevivedEvent;
        public event Action<string[]> SelectedFormatValidStateEvent;
        public event Action SelectedFcSettingsChangedEvent;
        private FcWrapperBase selectedFcRequest;
        private void SelectedFcRequest_ResponseReceived(string errorMsg)
        {
            SelectedDataRecevivedEvent?.Invoke(errorMsg); // Resending the data received event.
        }
        private void SelectedFcRequest_FormatValidStateEvent(string[] errors)
        {
            SelectedFormatValidStateEvent?.Invoke(errors);
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

        

        public FcWrapperBase SelectedFcRequest
        {
            get => selectedFcRequest;
            private set
            {
                if (selectedFcRequest != null)
                {
                    selectedFcRequest.RefreshDataEvent -= SelectedFcRequest_ResponseReceived;
                    selectedFcRequest.FormatValidStateEvent -= SelectedFcRequest_FormatValidStateEvent;
                    selectedFcRequest.FcSettingsChangedEvent -= SelectedFcRequest_FcSettingsChangedEvent;
                }
                selectedFcRequest = value;
                if (selectedFcRequest != null)
                {
                    selectedFcRequest.RefreshDataEvent += SelectedFcRequest_ResponseReceived;
                    selectedFcRequest.FormatValidStateEvent += SelectedFcRequest_FormatValidStateEvent;
                    selectedFcRequest.FcSettingsChangedEvent += SelectedFcRequest_FcSettingsChangedEvent;

                    SelectedDataRecevivedEvent?.Invoke("");  //mAKING fAKE dete received event to opdate the new table.
                }


            }
        }
        #endregion
        #region FcRelated
        internal void AddMultiHR_FC()
        {

            MultipleHoldingRegisters fcobj = new MultipleHoldingRegisters(mbCon);
            //fcobj.Format = this.formatConverter;  // Set the format converter object
            UserConfig.FcWrappers.Add(fcobj);
            //protected virtual void FcObjectAdded
            //OnFcObjectAdded?.Invoke(fcobj, new EventArgs());
            UpdateFCList();
        }

        internal void AddFc15()
        {
            FcWrapperFc15 fcobj = new FcWrapperFc15(mbCon);
            //fcobj.Format = this.formatConverter;  // Set the format converter object
            UserConfig.FcWrappers.Add(fcobj);
            //protected virtual void FcObjectAdded
            //OnFcObjectAdded?.Invoke(fcobj, new EventArgs());
            UpdateFCList();
        }
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
            UserConfig = dal.LoadFromFile();
            UserConfig.pollTimer = new PollTimer();
            //foreach (FcWrapperBase item in UserConfig.FcWrappers)
            //{
            //    item.Format = this.formatConverter;
            //}
            UpdateFCList();
        }
        internal void SaveAs()
        {
            dal.SaveAs_ToFile(UserConfig);
        }

        internal void Save()
        {
            dal.OnSaveButton(UserConfig);
        }
    }
}