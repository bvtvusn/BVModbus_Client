﻿using System;
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
        bool swapBytes;
        bool swapRegisters;

        public FormatContainer(FcWrapperBase fcWrapperBase)
        {
            this.fcWrapperBase = fcWrapperBase;
            valueFormats = new List<ValueFormat>();
        }

        internal int SetFormat(int register, FormatConverter.FormatName type, int customLength)
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
            return DataLength;

        }

        internal string[] BinaryToString(ushort[] rawData)
        {
            string[] stringValues = new string[rawData.Length];

            //int regCounter = 0;
            //int dtIndex = 0; // datatypeConverterIndex //
            foreach (ValueFormat item in valueFormats)
            {
                if (item.Register < rawData.Length)
                {
                    ushort[] singlevalueData = new ushort[item.Length];

                    int missingLength = (item.Register + item.Length) - rawData.Length; // In the rare case where the source area is not long enough.
                    if (missingLength > 0) Array.Resize(ref rawData, missingLength + rawData.Length); // Extend the array with zeros
                    Array.Copy(rawData, item.Register, singlevalueData, 0, item.Length);
                    if (swapRegisters)
                    {
                        Array.Reverse(singlevalueData);
                    }
                    if (swapBytes)
                    {
                        singlevalueData = FormatConverter.SwapBytesInArray(singlevalueData);
                    }
                    stringValues[item.Register] = item.BinaryToString(singlevalueData);
                }
            }
            return stringValues;
        }


        internal ushort[] StringToBinary(string[] stringValues)
        {
            int maxlength = 0;
            foreach (ValueFormat item in valueFormats)
            {
               int g =  item.Register + item.Length;
                if (g > maxlength)
                {
                    maxlength = g;
                }
            }
            ushort[] ushorts = new ushort[maxlength];
                //string[] stringValues = new string[rawData.Length];
                //List<ushort> stringValuesList = new List<ushort>();
            //int regCounter = 0;
            //int dtIndex = 0; // datatypeConverterIndex //
            foreach (ValueFormat item in valueFormats)
            {
                if (item.Register < stringValues.Length)
                {
                    string stringValue = stringValues[item.Register];
                    ushort[] valueData = item.StringToBinary(stringValue);

                    if (swapRegisters)
                    {
                        Array.Reverse(valueData);
                    }
                    if (swapBytes)
                    {
                        valueData = FormatConverter.SwapBytesInArray(valueData);
                    }
                    Array.Copy(valueData,0, ushorts, item.Register, item.Length);

                }

            }
            return ushorts;
        }

        internal string[] GetErrorList()
        {
            return new string[10];
        }
    }
}
