using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class FormatContainer
    {
        private FcWrapperBase fcWrapperBase;
        public List<ValueFormat> valueFormats;

        public FormatContainer(FcWrapperBase fcWrapperBase)
        {
            this.fcWrapperBase = fcWrapperBase;
            valueFormats = new List<ValueFormat>();
        }

        internal void SetFormat(int register, FormatConverter.FormatName type, int customLength)
        {
            int DataLength = 0;
            FormatConverter.FormatLengths.TryGetValue(type, out DataLength);
            if (DataLength < 0)
            {
                DataLength = customLength;
            }
            //valueFormats.RemoveAll(x => x.Register >= register && x.Register < register+ DataLength  || x.Register+x.Length >= register && x.Register + x.Length < register + DataLength);
            valueFormats.RemoveAll(x => x.Register < register+ DataLength  && register < x.Register+x.Length);

            valueFormats.Add(new ValueFormat(this,register,type, DataLength));
            valueFormats =  valueFormats.OrderBy(x => x.Register).ToList();

        }
    }
}
