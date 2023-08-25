using System.Runtime.Serialization;
using System.Text;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    [KnownType(typeof(PollLogger))]
    internal class PollLogger
    {
        private string separatorCharacter = "\t";

        public bool LoggingEnabled { get; set; } = false;
        [DataMember]
        public string LogFilePath { get => logFilePath; set { logFilePath = value; HeaderNeededFlag = true; } }
        [DataMember]
        public string SeparatorCharacter
        {
            get { return separatorCharacter.Replace("\t", "\\t");  /*if(separatorCharacter == "\t") return "\\t";  else return separatorCharacter;*/ }
            set { separatorCharacter = value.Replace("\\t", "\t");/*if (value == "\\t") separatorCharacter = "\t"; else separatorCharacter = value;*/ }
        }
        [DataMember]
        public bool QuoteEnabled { get; internal set; }

        public static string GenerateLine(string[] data, string separatorChar)
        {
            string view = "";
            foreach (string item in data)
            {
                view += item + separatorChar;

            }
            view = view.Remove(Math.Max(0, view.Length - separatorChar.Length));

            return view;
        }

        bool HeaderNeededFlag = true;
        private string logFilePath = Properties.Settings.Default.SaveFolder + "\\Logfile.txt";

        internal (bool, bool) CheckLoggingNeeded((string, string)[] data, bool pollitemsChanged)
        
        {
            if (pollitemsChanged)
            {
                HeaderNeededFlag = true;
            }
            var result = (LoggingEnabled, HeaderNeededFlag && LoggingEnabled);
            if (LoggingEnabled)
            {
                HeaderNeededFlag = false;
            }

            return result;
        }

        public string GenerateDataLine(string[] data)
        {
            string[] lineElements = new string[data.Length + 1];
            lineElements[0] = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");                                // Add time
            Array.Copy(data, 0, lineElements, 1, data.Length);
            return GenerateLine(lineElements);
        }
        public string GenerateHeaderLine(string[] data)
        {
            string[] lineElements = new string[data.Length + 1];
            lineElements[0] = "Time";                                // Add time
            Array.Copy(data, 0, lineElements, 1, data.Length);
            return GenerateLine(lineElements);
        }

        public string GenerateLine(string[] data)
        {
            string quoteChar = @"";
            if (QuoteEnabled)
            {
                quoteChar = "\"";
            }
            StringBuilder builder = new StringBuilder();
            //builder.Append(quoteChar + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff") + quoteChar + separatorCharacter);
            //string view = quoteChar + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff") + quoteChar + separatorCharacter;
            foreach (string item in data)
            {
                builder.Append(quoteChar + item + quoteChar + separatorCharacter);
            }
            return builder.ToString().Remove(Math.Max(0, builder.Length - separatorCharacter.Length)); ;
        }

        //internal void PollTimer_PollFinishedEvent(string[] obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}