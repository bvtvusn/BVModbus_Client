﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    [DataContract]
    internal class ValueFormat
    {

        //FormatContainer container;
        //int registerNumber;
        //[IgnoreDataMember]
        //private FormatContainer formatContainer;
        private int register;
        private string strToBinError;

        //private FormatConverter.FormatName type;
        
        public string StrToBinError { get => strToBinError; set => strToBinError = value; }
        [DataMember]
        public int Length { get; set; }
        [DataMember]
        public FormatConverter.FormatName FormatType { get; set; } = FormatConverter.FormatName.Uint16;
        [DataMember]
        public int Register { get => register; set => register = value; }

        public (DateTime, float)[] valueHistory { get; internal set; }
        public int historyIndex { get; internal set; }
        public bool isVisibleInPlot { get; set; }

        //public int RegisterNumber { get => registerNumber; set => registerNumber = value; }
        //internal FormatConverter.FormatName Type { get => type; set => type = value; }

        //public ValueFormat(FormatContainer container, int registerNumber, int Length)
        //{
        //    this.container = container;
        //    this.RegisterNumber = registerNumber;
        //    this.Length = Length;
        //}

        public ValueFormat(FormatContainer formatContainer, int register, FormatConverter.FormatName type, int length)
        {
            //this.formatContainer = formatContainer;
            this.Register = register;
            this.FormatType = type;
            Length = length;

            valueHistory = new (DateTime, float)[100];
            isVisibleInPlot = true;
        }

        internal string BinaryToString(ushort[] singlevalueData, bool logValue = false, string floatFormat = "")
        {
            string value = FormatConverter.GetStringRepresentation(singlevalueData, FormatType, floatFormat);
            if (logValue)
            {
                
                try
                {
                    HistoryAdd(Convert.ToSingle(value));
                }
                catch (Exception)
                {


                }
            }
            return value;
        }
        internal ushort[] StringToBinary(string strData, bool logValue = false)
        {
            if (logValue)
            {
                try
                {
                    HistoryAdd(Convert.ToSingle(strData));
                }
                catch (Exception)
                {

                    
                }
                
            }
            return FormatConverter.GetBinaryRepresentation(strData, FormatType, Length, out strToBinError);
        }

        public void HistoryAdd(float value)
        {
            valueHistory[historyIndex] = (DateTime.Now, value);
            historyIndex = (historyIndex + 1)%valueHistory.Length;
            
        }
    }
}
