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

        internal string[] BinaryToString(ushort[] rawData, bool SwapBytes, bool SwapRegisters)
        {
            string[] stringValues = new string[rawData.Length];

            //int regCounter = 0;
            //int dtIndex = 0; // datatypeConverterIndex //


            foreach (ValueFormat item in valueFormats)
            {
                if (item.Register < rawData.Length)
                {
                    ushort[] singlevalueData = new ushort[item.Length];
                    Array.Copy(rawData, item.Register, singlevalueData, 0, item.Length);
                    if (SwapRegisters)
                    {
                        Array.Reverse(singlevalueData);
                    }
                    if (SwapBytes)
                    {
                        singlevalueData = FormatConverter.SwapBytesInArray(singlevalueData);
                    }
                    stringValues[item.Register] = item.BinaryToString(singlevalueData);
                }
               

            }


            //while (regCounter < rawData.Length)
            //{
            //    if(regCounter == valueFormats[dtIndex].Register)
            //    {

            //    }
            //    int dtLen = valueFormats[dtIndex].Length;
            //    ushort[] singlevalueData = new ushort[dtLen];
            //    Array.Copy(rawData, regCounter, singlevalueData, 0, dtLen);
            //    if (SwapRegisters)
            //    {
            //        Array.Reverse(singlevalueData);
            //    }
            //    if (SwapBytes)
            //    {
            //        singlevalueData = FormatConverter.SwapBytesInArray(singlevalueData);
            //    }
            //    stringValues[regCounter] = valueFormats[dtIndex].BinaryToString(singlevalueData);

            //    int endReg = valueFormats[dtIndex].Length + dtIndex;
            //    dtIndex++;
            //    regCounter += dtLen;
            //}
            return stringValues;
        }
    }
}
