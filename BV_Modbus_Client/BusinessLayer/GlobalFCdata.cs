using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    [KnownType(typeof(GlobalFCdata))]
    internal class GlobalFCdata
    {
        public GlobalFCdata()
        {
            //AddressDescription = new Dictionary<ushort, string>();
        }
        public event Action<FcWrapperBase, bool> ActivePollingChangedEvent;
        //public event Action<FcWrapperBase> DuplicateFcEvent;
        [DataMember]
        public bool ZeroBasedAdresses { get; set; } = true;
        
        [DataMember]
        public int MaxTableRows { get; set; } = 10;

        //[DataMember]
        /*public Dictionary<ushort, string> AddressDescription { get; set; }*/ // Databuffer contains the address read, the value and a description.

        internal void ReportActivePollingChanged(FcWrapperBase fcWrapperBase, bool pollEnabled)
        {
            ActivePollingChangedEvent?.Invoke(fcWrapperBase, pollEnabled);
        }

        //internal void Duplicate(FcWrapperBase fcView)
        //{
        //    DuplicateFcEvent?.Invoke(fcView);
        //}
    }
}
