using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    [KnownType(typeof(UserConfiguration))]
    internal class UserConfiguration
    {
        public UserConfiguration()
        {
            FcWrappers = new List<FcWrapperBase>();
            GlobFcData = new GlobalFCdata();
            pollTimer = new PollTimer(Timer_PollInterval);
            Network_RemotePort = 502;
            Network_RemoteHostname = "127.0.0.1";
        }
        [DataMember]
        public List<FcWrapperBase> FcWrappers { get; set; }
        
        public PollTimer pollTimer;
        [DataMember]
        public double Timer_PollInterval { get; set; } = 1000.0;

        [DataMember]
        public int Network_RemotePort { get; set; }
        [DataMember]
        public string Network_RemoteHostname { get; set; }
        [DataMember]
        public GlobalFCdata GlobFcData { get; internal set; }
    }
}
