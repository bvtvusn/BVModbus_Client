using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class ValueFormat
    {
        FormatContainer container;
        //int registerNumber;
        private FormatContainer formatContainer;
        private int register;
        //private FormatConverter.FormatName type;

        public int Length { get; set; }
        public FormatConverter.FormatName FormatType { get; set; } = FormatConverter.FormatName.Uint16;
        public int Register { get => register; set => register = value; }

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
            this.formatContainer = formatContainer;
            this.Register = register;
            this.FormatType = type;
            Length = length;
        }
    }
}
