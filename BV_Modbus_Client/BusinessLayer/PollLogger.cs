namespace BV_Modbus_Client.BusinessLayer
{
    internal class PollLogger
    {
        private string separatorCharacter = "\t";

        public bool LoggingEnabled { get; set; }
        public string LogFilePath { get; set; } = Properties.Settings.Default.SaveFolder + "\\Logfile.txt";
        public string SeparatorCharacter { 
            get { if (separatorCharacter == "\t") return "\\t";  else return separatorCharacter; } 
            set { if (value == "\\t") separatorCharacter = "\t"; else separatorCharacter = value; } 
        }

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

        public string GenerateLine(string[] data)
        {
            string quoteChar = @"";
            if (QuoteEnabled)
            {
                quoteChar = "\"";
            }

            string view = quoteChar + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff") + quoteChar + separatorCharacter;
            foreach (string item in data)
            {
                
                    view += quoteChar + item+ quoteChar + separatorCharacter;
                
                

            }
            view = view.Remove(Math.Max(0, view.Length - separatorCharacter.Length));

            return view;
        }
        //internal void PollTimer_PollFinishedEvent(string[] obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}