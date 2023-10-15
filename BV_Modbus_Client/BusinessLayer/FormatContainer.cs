using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    internal class FormatContainer
    {
        [IgnoreDataMember]
        private FcWrapperBase fcWrapperBase;
        [DataMember]
        public List<ValueFormat> valueFormats;
        [DataMember]
        bool swapBytes;
        [DataMember]
        bool swapRegisters;

        public FormatContainer(FcWrapperBase fcWrapperBase)
        {
            this.fcWrapperBase = fcWrapperBase;
            valueFormats = new List<ValueFormat>();
        }
        [DataMember]
        public FormatConverter.FormatName DefaultFormat { get; internal set; }
        public bool SwapRegisters { get => swapRegisters; set => swapRegisters = value; }
        public bool SwapBytes { get => swapBytes; set => swapBytes = value; }

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

        internal string[] BinaryToString(ushort[] rawData, bool onlyOnestringPerValue = false)
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

            if (onlyOnestringPerValue)
            {
                string[] tmp = new string[valueFormats.Count];
                int indexCounter = 0;
                for (int i = 0; i < valueFormats.Count; i++)
                {
                    tmp[i] = stringValues[indexCounter];

                    indexCounter += valueFormats[i].Length;
                }
                stringValues = tmp;
            }
            return stringValues;
        }
        internal int[] GetValueIndexes()
        {
            int[] tmp = new int[valueFormats.Count];
            int indexCounter = 0;
            for (int i = 0; i < valueFormats.Count; i++)
            {
                tmp[i] = indexCounter;

                indexCounter += valueFormats[i].Length;
            }
            return tmp;
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
            int valueCounter = 0;
            foreach (ValueFormat item in valueFormats)
            {
                if (valueCounter < stringValues.Length)
                {
                    string stringValue = stringValues[valueCounter];
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
                valueCounter++;

            }
            return ushorts;
        }

        internal string[] GetErrorList(int length)
        {
            string[] errors = new string[length];
            for (int i = 0; i < valueFormats.Count; i++)
            {
                string errMsg = valueFormats[i].StrToBinError;
                int index = valueFormats[i].Register;
                errors[index] = errMsg;
            }
            return errors;
        }

        internal void UpdateRegisterCount(ushort numberOfRegisters)
        {
            List<int> removeIndexes = new List<int>();
            bool[] registersOccupied = new bool[numberOfRegisters];
            for (int i = 0; i < valueFormats.Count; i++)
            {

                if (valueFormats[i].Register + valueFormats[i].Length > numberOfRegisters || valueFormats[i].Register < 0)  // Removing the ones exceeding the max length
                {
                    removeIndexes.Add(i);
                }
            }
            removeIndexes.Reverse();
            removeIndexes.ForEach(i => valueFormats.RemoveAt(i));
            //removeIndexes.Select(i => valueFormats.RemoveAt(i));

            for (int i = 0; i < valueFormats.Count; i++)
            {
                for (int j = 0; j < valueFormats[i].Length; j++)
                {
                    registersOccupied[j + valueFormats[i].Register] = true;
                }
            }

            for (int i = 0; i < registersOccupied.Length; i++)
            {
                if (!registersOccupied[i])
                {
                    valueFormats.Add(new ValueFormat(this, i, DefaultFormat, 1));
                }
            }

        }

        //internal FormatContainer Clone()
        //{
        //    //FormatContainer clone = new FormatContainer(fcWrapperBase);
        //    //clone.SwapBytes = SwapBytes;
        //    //clone.SwapRegisters = SwapRegisters;
        //    //clone.DefaultFormat = DefaultFormat;
        //    //clone.valueFormats = valueFormats.

            
        //}

        //public FormatContainer DeepClone()
        //{
        //    using (MemoryStream memoryStream = new MemoryStream())
        //    {
        //        IFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(memoryStream, this);
        //        memoryStream.Seek(0, SeekOrigin.Begin);
        //        return (FormatContainer)formatter.Deserialize(memoryStream);
        //    }
        //}
        //public YourClass DeepClone()
        //{
        //    using (MemoryStream memoryStream = new MemoryStream())
        //    {
        //        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(YourClass));
        //        serializer.WriteObject(memoryStream, this);
        //        memoryStream.Position = 0;
        //        return (YourClass)serializer.ReadObject(memoryStream);
        //    }
        //}
        public FormatContainer DeepClone()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(FormatContainer));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                serializer.WriteObject(memoryStream, this);
                memoryStream.Position = 0;
                return (FormatContainer)serializer.ReadObject(memoryStream);
            }
        }
    }
}
