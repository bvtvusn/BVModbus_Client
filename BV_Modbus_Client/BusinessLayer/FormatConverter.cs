using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class FormatConverter
    {
        public enum FormatName
        {
            Uint16,
            Int16,
            Float,
            Hex,
            Binary,
            Uint32,
            Int32,
            Double,
            Ascii,
            Boolean
        }
        public static  Dictionary<FormatName,int> FormatLengths { get;  } 
            = new Dictionary<FormatName, int>() {
            { FormatName.Ascii,-1},
            { FormatName.Binary,-1},
            { FormatName.Boolean,1},
            { FormatName.Double,2},
            { FormatName.Float,1},
            { FormatName.Hex,-1},
            { FormatName.Int16,1},
            { FormatName.Int32,2},
            { FormatName.Uint16,1},
            { FormatName.Uint32,2}
        };
        public bool ByteSwap { get; set; }
        public FormatName CurrentFormat { get; set; } = FormatName.Uint16;
        //internal static string[] GetStringRepresentation(ushort[] rawdata, FormatName format, bool swapBytes = false, bool swapRegisters = false)
        //{
        //    if (swapRegisters)
        //    {
        //        rawdata = rawdata.Zip(
        //            rawdata.Skip(1),
        //            (a, b) => new[] { b, a }).
        //            SelectMany(pair => pair).ToArray();

        //    }
        //    if (swapBytes)
        //    {
        //        rawdata = rawdata.Select(x => SwapBytes(x)).ToArray(); // Swap bytes if requested
        //    }


        //    if (format == FormatName.Uint16 || format == FormatName.Boolean)
        //    {
        //        return rawdata.Cast<ushort>().Select(x => x.ToString()).ToArray();
        //    }
        //    else if (format == FormatName.Int16)
        //    {
        //        return rawdata.Cast<short>().Select(x => x.ToString()).ToArray();
        //    }
        //    else if (format == FormatName.Float)
        //    {

        //        return rawdata.Select(x => FormatConverter.HalfToFloat(x).ToString()).ToArray();
        //    }
        //    else if (format == FormatName.Hex)
        //    {
        //        return rawdata.Select(x => x.ToString("X")).ToArray();
        //    }
        //    else if (format == FormatName.Binary)
        //    {
        //        return rawdata.Select(x => ConvertToBinaryString(x)).ToArray();
        //    }
        //    else if (format == FormatName.Uint32)
        //    {
        //        string[] result = new string[rawdata.Length];
        //        for (int i = 0; i < rawdata.Length; i++)
        //        {
        //            if (i % 2 == 0 && i < rawdata.Length - 1)
        //            {
        //                uint temp = ((uint)rawdata[i] << 16) | (uint)rawdata[i + 1];
        //                result[i] = temp.ToString();
        //            }
        //            else
        //            {
        //                result[i] = "-";
        //            }
        //        }
        //        return result;
        //    }
        //    else if (format == FormatName.Int32)
        //    {
        //        string[] result = new string[rawdata.Length];
        //        for (int i = 0; i < rawdata.Length; i++)
        //        {
        //            if (i % 2 == 0 && i < rawdata.Length - 1)
        //            {
        //                uint temp = ((uint)rawdata[i] << 16) | (uint)rawdata[i + 1];
        //                result[i] = ((int)temp).ToString();
        //            }
        //            else
        //            {
        //                result[i] = "-";
        //            }
        //        }
        //        return result;
        //    }
        //    else if (format == FormatName.Double)
        //    {
        //        string[] result = new string[rawdata.Length];
        //        for (int i = 0; i < rawdata.Length; i++)
        //        {
        //            if (i % 2 == 0 && i < rawdata.Length - 1)
        //            {
        //                //byte[] bytes = new byte[] {(byte)(rawdata[i] << 16),(byte)() };
        //                uint temp = ((uint)rawdata[i] << 16) | (uint)rawdata[i + 1];
        //                byte[] bytes = BitConverter.GetBytes(temp);
        //                float dval = BitConverter.ToSingle(bytes, 0);
        //                result[i] = dval.ToString();
        //            }
        //            else
        //            {
        //                result[i] = "-";
        //            }
        //        }
        //        return result;
        //    }
        //    else if (format == FormatName.Ascii)
        //    {
        //        byte[] bytesdd = rawdata.SelectMany(BitConverter.GetBytes).ToArray();
        //        string data = System.Text.Encoding.ASCII.GetString(bytesdd);

        //        string[] result = new string[rawdata.Length];
        //        for (int i = 0; i < result.Length; i++)
        //        {
        //            result[i] = data.Substring(i * 2, 2);
        //        }
        //        return result;
        //        //BitConverter.GetBytes(rawdata);
        //    }
        //    else
        //    {
        //        return rawdata.Cast<ushort>().Select(x => x.ToString()).ToArray();
        //    }

           
        //}
        internal static string GetStringRepresentation(ushort[] rawdata, FormatName format, bool swapBytes = false, bool swapRegisters = false)
        {
            if (swapRegisters)
            {
                rawdata = rawdata.Zip(
                    rawdata.Skip(1), 
                    (a, b) => new[] { b, a }).
                    SelectMany(pair => pair).ToArray();

            }
            if (swapBytes)
            {
                rawdata = rawdata.Select(x => SwapBytes(x)).ToArray(); // Swap bytes if requested
            }


            if (format == FormatName.Uint16 || format == FormatName.Boolean)
            {
                return ((ushort)rawdata[0]).ToString(); // .Cast<ushort>().Select(x => x.ToString());
            }
            else if (format == FormatName.Int16)
            {
                return ((short)rawdata[0]).ToString();
                //return rawdata.Cast<short>().Select(x => x.ToString()).ToArray();
            }
            else if (format == FormatName.Float)
            {
                return FormatConverter.HalfToFloat(rawdata[0]).ToString();
                //return rawdata.Select(x => FormatConverter.HalfToFloat(x).ToString()).ToArray();
            }
            else if (format == FormatName.Hex)
            {
                return string.Join("", rawdata.Select(x => x.ToString("X")).ToArray());
                //return rawdata.Select(x => x.ToString("X")).ToArray();
            }
            else if (format == FormatName.Binary)
            {
                return string.Join("", rawdata.Select(x => ConvertToBinaryString( x)).ToArray());
            }
            else if (format == FormatName.Uint32)
            {
                uint temp = ((uint)rawdata[0] << 16) | (uint)rawdata[0+ 1];
                return temp.ToString();
                                
            }
            else if (format == FormatName.Int32)
            {
                uint temp = ((uint)rawdata[0] << 16) | (uint)rawdata[1];
                return ((int)temp).ToString();

                
            }
            else if (format == FormatName.Double)
            {
                uint temp = ((uint)rawdata[0] << 16) | (uint)rawdata[1];
                byte[] bytes = BitConverter.GetBytes(temp);
                float dval = BitConverter.ToSingle(bytes, 0);
                return dval.ToString();

            }
            else if (format == FormatName.Ascii)
            {
                byte[] bytesdd = rawdata.SelectMany(BitConverter.GetBytes).ToArray();
                string data = System.Text.Encoding.ASCII.GetString(bytesdd);
                return data;
            }
            else
            {
                return ((ushort)rawdata[0]).ToString(); 
            }

            //rawdata.Cast<ushort>().Select(x => x.ToString()).ToArray();
            //string[] formatted = new string[rawdata.Length];
            //for (int i = 0; i < formatted.Length; i++)
            
            //{
            //    if (CurrentFormat == FormatName.Uint16)
            //    {
            //        ushort t = rawdata[i];
            //        formatted[i] = ((ushort)rawdata[i]).ToString();
            //    }
            //    else if  (CurrentFormat == FormatName.Int16)
            //    {
            //        short t = (short)rawdata[i];
            //        formatted[i] = ((short)rawdata[i]).ToString();
            //    }
            //    //formatted[i] = rawdata[i].ToString();
            //}
            //return formatted;
        }

        internal static ushort[] GetBinaryRepresentation(string rawString, FormatName format, int numRegisters, out string error)
        {
            error = ""; // new string[numRegisters];
            ushort[] result = new ushort[numRegisters];
            
            try
            {
                if (format == FormatName.Uint16 || format == FormatName.Boolean)
                {
                    result[0] = Convert.ToUInt16(rawString);
                }
                else if (format == FormatName.Int16)
                {
                    result[0] = (ushort)Convert.ToInt16(rawString);
                }
                else if (format == FormatName.Float)
                {
                    result[0] = FormatConverter.FloatToHalf(Convert.ToSingle(rawString));
                }
                else if (format == FormatName.Hex)
                {
                    if (rawString.Length > numRegisters * 4)
                    {
                        throw new FormatException("To many characters");
                    }
                    string[] groupedArray = Enumerable.Range(0, (int)Math.Ceiling((double)rawString.Length / 4))
            .Select(i => rawString.Substring(i * 4, Math.Min(4, rawString.Length - i * 4))).ToArray();

                    result = groupedArray.Select(x => Convert.ToUInt16(x, 16)).ToArray();

                    //groupedArray.Select(x => Convert.ToUInt16(rawString.Substring(x * 4, 4), 16)).ToArray();

                    //System.Collections.IEnumerable tmp = Enumerable.Range(0, (rawString.Length-1 / 4)+1);
                    //System.Collections.IEnumerable tmp2 = Enumerable.Range(0, rawString.Length / 4).Select(x => Convert.ToUInt16(rawString.Substring(x * 4, 4), 16));
                    //result = Enumerable.Range(0, rawString.Length / 4) // Divide by 4 since each ushort is represented by 4 hexadecimal characters
                    //.Select(x => Convert.ToUInt16(rawString.Substring(x * 4, 4), 16))
                    //.ToArray();



                    //var k = Enumerable.Range(0, rawString.Length)
                    // .Where(x => x % 2 == 0)
                    // .Select(x => Convert.ToByte(rawString.Substring(x, 2), 16))
                    // .ToArray();

                    //result[i] = Convert.ToUInt16(rawString[i], 16);
                }
                else if (format == FormatName.Binary)
                {
                    if (rawString.Length > numRegisters*16)
                    {
                        throw new FormatException("To many characters");
                    }
                    result = Enumerable.Range(0, rawString.Length / 16) // Divide by 16 since each ushort is represented by 16 binary digits
                        .Select(x => Convert.ToUInt16(rawString.Substring(x * 16, 16), 2))
                        .ToArray();

                    //result[0] = Convert.ToUInt16(rawString, 2);
                }


                else if (format == FormatName.Uint32)
                {
                    UInt32 number = UInt32.Parse(rawString);
                    result[0] = (UInt16)(number & 0xFFFF); // Store the lower 16 bits
                    result[1] = (UInt16)((number >> 16) & 0xFFFF); // Store the upper 16 bits

                    //if (i % 2 == 0)
                    //{
                    //    // Even, write first byte
                    //    uint startval = Convert.ToUInt16(rawString[i]);
                    //    ushort temp = (ushort)(startval >> 16);
                    //    result[i] = temp;
                    //}
                    //else
                    //{
                    //    uint startval = Convert.ToUInt16(rawString[i - 1]);
                    //    ushort temp = (ushort)(startval & 0x0000FFFF);
                    //    result[i] = temp;
                    //}
                }
                else if (format == FormatName.Int32)
                {
                    Int32 number = Int32.Parse(rawString);
                    result[0] = (UInt16)(number & 0xFFFF); // Store the lower 16 bits
                    result[1] = (UInt16)((number >> 16) & 0xFFFF); // Store the upper 16 bits

                }
                else if (format == FormatName.Double)
                {
                    float floatValue = float.Parse(rawString);
                    int intValue = BitConverter.ToInt32(BitConverter.GetBytes(floatValue), 0);
                    result[0] = (UInt16)(intValue & 0xFFFF);
                    result[1] = (UInt16)((intValue >> 16) & 0xFFFF);
                }
                else if (format == FormatName.Ascii)
                {
                    byte[] byteArray = Encoding.ASCII.GetBytes(rawString);

                    // Create a ushort array and initialize it by casting each byte to ushort
                    //ushort[] ushortArray = new ushort[byteArray.Length/2];
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (i * 2 + 1 < byteArray.Length)
                        {
                            result[i] = (ushort)((byteArray[i * 2] << 8) | byteArray[i * 2 + 1]);
                        }
                    }

                }
                else
                {
                    result[0] = Convert.ToUInt16(rawString);
                }
            }
            catch (Exception err)
            {
                result[0] = 0;
                error = err.Message;
            }
                //ushort result;

            return result;
        }

        internal static ushort[] GetBinaryRepresentation(string[] rawString, FormatName format, out string[] errors, bool swapBytes = false, bool swapRegisters = false)
        {
            errors = new string[rawString.Length];
            ushort[] result = new ushort[rawString.Length];
            for (int i = 0; i < rawString.Length; i++)
            {
                try
                {
                    if (format == FormatName.Uint16 || format == FormatName.Boolean)
                    {
                        result[i] = Convert.ToUInt16(rawString[i]);
                    }
                    else if (format == FormatName.Int16)
                    {
                        result[i] = (ushort)Convert.ToInt16(rawString[i]);
                    }
                    else if (format == FormatName.Float)
                    {
                        result[i] = FormatConverter.FloatToHalf(Convert.ToSingle(rawString[i]));
                    }
                    else if (format == FormatName.Hex)
                    {
                        result[i] = Convert.ToUInt16(rawString[i], 16);
                    }
                    else if (format == FormatName.Binary)
                    {
                        result[i] = ConvertFromBinaryString(rawString[i]);
                    }


                    else if (format == FormatName.Uint32)
                    {
                        if (i % 2 == 0)
                        {
                            // Even, write first byte
                            uint startval = Convert.ToUInt16(rawString[i]);
                            ushort temp = (ushort)(startval >> 16);
                            result[i] = temp;
                        }
                        else
                        {
                            uint startval = Convert.ToUInt16(rawString[i - 1]);
                            ushort temp = (ushort)(startval & 0x0000FFFF);
                            result[i] = temp;
                        }
                    }
                    else if (format == FormatName.Int32)
                    {
                        if (i % 2 == 0)
                        {
                            // Even, write first byte
                            int startval = Convert.ToInt16(rawString[i]);
                            ushort temp = (ushort)(startval >> 16);
                            result[i] = temp;
                        }
                        else
                        {
                            int startval = Convert.ToInt16(rawString[i - 1]);
                            ushort temp = (ushort)(startval & 0x0000FFFF);
                            result[i] = temp;
                        }
                    }
                    else if (format == FormatName.Double)
                    {
                        if (i % 2 == 0)
                        {
                            // Even, write first byte
                            float fval = Convert.ToSingle(rawString[i]);
                            uint rawbits = BitConverter.SingleToUInt32Bits(fval);
                            ushort temp = (ushort)(rawbits >> 16);
                            result[i] = temp;
                        }
                        else
                        {
                            float fval = Convert.ToSingle(rawString[i - 1]);
                            uint rawbits = BitConverter.SingleToUInt32Bits(fval);
                            ushort temp = (ushort)(rawbits & 0x0000FFFF);
                            result[i] = temp;
                        }
                    }
                    else if (format == FormatName.Ascii)
                    {
                        //for (int i = 0; i < rawString.Length; i++)

                        byte[] b = System.Text.Encoding.ASCII.GetBytes(rawString[i]);
                        result[i] = (ushort)BitConverter.ToInt16(b, 0);

                        //result[i] = ConvertFromBinaryString(rawString[i]);
                    }
                    else
                    {
                        result[i] = Convert.ToUInt16(rawString[i]);
                    }
                }
                catch (Exception err)
                {
                    result[i] = 0;
                    errors[i] = err.Message;
                }
                //ushort result;


                if (swapBytes)
                {
                    result[i] = SwapBytes(result[i]);
                }

            }

            //if (format == FormatName.Uint16)
            //{
            //    result =  rawString.Cast<ushort>().Select(x => Convert.ToUInt16(x)).ToArray();
            //}
            //else if (format == FormatName.Int16)
            //{
            //    result =  rawString.Cast<short>().Select(x => Convert.ToUInt16(x)).ToArray();
            //}
            //else if (format == FormatName.Float)
            //{
            //    result = rawString.Select(x => FormatConverter.FloatToHalf(Convert.ToSingle(x))).ToArray();
            //}
            //else if (format == FormatName.Hex)
            //{
            //    result = rawString.Select(x => Convert.ToUInt16(x,16)).ToArray();
            //}
            //else if (format == FormatName.Binary)
            //{
            //    result =  rawString.Select(x => ConvertFromBinaryString(x)).ToArray();
            //}
            //else if (format == FormatName.Uint32)
            //{
            //    //ushort[] result = new ushort[rawString.Length];
            //    for (int i = 0; i < rawString.Length; i++)
            //    {
            //        if (i % 2 == 0 )
            //        {
            //            // Even, write first byte
            //            uint startval = Convert.ToUInt16(rawString[i]);
            //            ushort  temp = (ushort)(startval >> 16);
            //            result[i] = temp;
            //        }
            //        else
            //        {
            //            uint startval = Convert.ToUInt16(rawString[i-1]);
            //            ushort temp = (ushort)(startval | 0x0000FFFF);
            //            result[i] = temp;
            //        }
            //    }
            //    //return result;
            //}
            //else
            //{
            //    result = rawString.Cast<ushort>().Select(x => Convert.ToUInt16(x)).ToArray();
            //}




            if (swapRegisters)
            {
                result = result.Zip(
                    result.Skip(1),
                    (a, b) => new[] { b, a }).SelectMany(pair => pair).ToArray();

            }
            //if (swapBytes)
            //{
            //    result = result.Select(x => SwapBytes(x)).ToArray(); // Swap bytes if requested
            //}

            return result;
        }
        private static string GetStringRepresentation(ushort rawdata, FormatName format, bool swapBytes = false)
        {
            if (swapBytes)
            {
                rawdata = SwapBytes(rawdata);
            }
            
            if (format == FormatName.Uint16)
            {
                return ((ushort)rawdata).ToString();
            }
            else if (format == FormatName.Int16)
            {
                return ((short)rawdata).ToString();
            }
            else if (format == FormatName.Float)
            {
                return FormatConverter.HalfToFloat(rawdata).ToString();
            }
            else if (format == FormatName.Hex)
            {
                return rawdata.ToString("X");
            }
            else if (format == FormatName.Binary)
            {
                return ConvertToBinaryString( rawdata);
            }
            
            else
            {
                return ((ushort)rawdata).ToString();
            }

           
        }
        private static ushort GetBinaryRepresentation(string rawdata, FormatName format , bool swapBytes = false)
        {
            ushort result;
            if (format == FormatName.Uint16)
            {
                result =  Convert.ToUInt16(rawdata);
            }
            else if (format == FormatName.Int16)
            {
                result = (ushort)Convert.ToInt16(rawdata);
            }
            else if (format == FormatName.Float)
            {
                result = FormatConverter.FloatToHalf(Convert.ToSingle(rawdata));
            }
            else if (format == FormatName.Hex)
            {
                result = Convert.ToUInt16(rawdata, 16);
            }
            else if (format == FormatName.Binary)
            {
                result = ConvertFromBinaryString(rawdata);
            }
            else
            {
                result = Convert.ToUInt16(rawdata);
            }

            if (swapBytes)
            {
                result = SwapBytes(result);
            }
            return result;

        }

        public static float HalfToFloat(ushort h)
        {
            int s = (h >> 15) & 0x00000001; // sign
            int e = (h >> 10) & 0x0000001F; // exponent
            int f = h & 0x000003FF; // fraction

            if (e == 0)
            {
                if (f == 0)
                {
                    return BitConverter.Int32BitsToSingle(s << 31);
                }
                else
                {
                    while ((f & 0x00000400) == 0)
                    {
                        f <<= 1;
                        e -= 1;
                    }
                    e += 1;
                    f &= ~0x00000400;
                }
            }
            else if (e == 31)
            {
                if (f == 0)
                {
                    return BitConverter.Int32BitsToSingle((s << 31) | 0x7F800000);
                }
                else
                {
                    return BitConverter.Int32BitsToSingle((s << 31) | 0x7F800000 | (f << 13));
                }
            }

            e = e + (127 - 15);
            f = f << 13;
            int bits = (s << 31) | (e << 23) | f;
            return BitConverter.Int32BitsToSingle(bits);
        }
        public static ushort FloatToHalf(float f)
        {
            int bits = BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
            int sign = (bits >> 16) & 0x8000; // sign
            int exponent = ((bits >> 23) & 0xFF) - (127 - 15); // exponent
            int mantissa = bits & 0x007FFFFF; // mantissa

            if (exponent <= 0)
            {
                return (ushort)sign;
            }
            else if (exponent >= 31)
            {
                return (ushort)(sign | 0x7C00 | (mantissa != 0 ? 1 : 0));
            }
            else
            {
                exponent <<= 10;
                mantissa >>= 13;
                return (ushort)(sign | exponent | mantissa);
            }

        }

        public static string ConvertToBinaryString(ushort value)
        {
            string binaryString = Convert.ToString(value, 2).PadLeft(16, '0');
            return binaryString;
        }
        public static ushort ConvertFromBinaryString(string binaryString)
        {
            ushort value = Convert.ToUInt16(binaryString, 2);
            return value;
        }
        public static ushort SwapBytes(ushort value)
        {
            return (ushort)((value << 8) | (value >> 8));
        }
        public static ushort[] SwapBytesInArray(ushort[] originalArray)
        {
            ushort[] swappedArray = new ushort[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                swappedArray[i] = (ushort)((originalArray[i] >> 8) | (originalArray[i] << 8));
            }

            return swappedArray;
        }

        //internal ushort[] GetBinaryRepresentation(string[] formattedText)
        //{
        //    ushort[] binaryData = new ushort[formattedText.Length];
        //    for (int i = 0; i < binaryData.Length; i++)
        //    {
        //        if (CurrentFormat == FormatName.Uint16)
        //        {
        //            binaryData[i] = Convert.ToUInt16( formattedText[i]);
        //        }

        //    }
        //    return binaryData;
        //}

        public static DataTable ArrayToDatatableRow(string[] mydata, bool showBoolean)
        {
            //Type CellType = typeof(string);
            //if (showBoolean)
            //{
            //    CellType = typeof(bool);
            //}
            if (showBoolean)
            {
DataTable dt = new DataTable();
            for (int i = 0; i < mydata.Length; i++)
            {
                //if (showBoolean)
                //{
                    dt.Columns.Add("Column" + (i + 1), typeof(bool));

                //}
                //else
                //{
                //    dt.Columns.Add("Column" + (i + 1));
                //}
            }
            DataRow dr = dt.NewRow();
            if (showBoolean)
            {
                    //dt.Rows.Add(true, true, true, true);
                    for (int i = 0; i < mydata.Length; i++)
                    {
                        dr.SetField(i, mydata[i] !="0" );
                    }
                    //dr.ItemArray = mydata.Select(i => (object)(i != "0")).ToArray();
                    //dr.SetField(0, true); //.ItemArray[0] = true; // .Add(false, true,false,true);
                    //dr.SetField(1, true);
                    //dr.SetField(2, true);
                    //dr.SetField(3, true);
                    //dr.ItemArray[1] = true;
                    //dr.ItemArray[2] = true;
                    //dr.ItemArray[3] = true;
                }
            else
            {
                //dr.ItemArray = mydata;
            }
            dt.Rows.Add(dr);

            //dataGridView1.DataSource = dt;
            return dt;
            }
            else
            {
                DataTable dt = new DataTable();
                for (int i = 0; i < mydata.Length; i++)
                {                    
                    dt.Columns.Add("Column" + (i + 1),typeof(string));
                }
                DataRow dr = dt.NewRow();
                if (showBoolean)
                {
                    for (int i = 0; i < mydata.Length; i++)
                    {
                        dr.SetField(i, mydata[i] );
                    }
                }
                dt.Rows.Add(dr);
                return dt;

            }
            
        }

        public static DataTable ArrayToDatatableColumn(string[] mydata)
        {
            int maxrows = 10;
            int nCols = (mydata.Length + maxrows -1) / maxrows;

            DataTable dt = new DataTable();
            for (int i = 0; i < nCols; i++)
            {
                dt.Columns.Add("" + (i * maxrows));
            }
            for (int i = 0; i < maxrows; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)
                {
                    int index = j * maxrows + i;
                    if (index < mydata.Length)
                    {
                        dr[j] = mydata[j * maxrows + i];
                    }
                    
                }
                //dr.
                //dr.ItemArray = mydata;
                dt.Rows.Add(dr);
            }
            

            //dataGridView1.DataSource = dt;
            return dt;
        }

        public static DataTable ArrayToDatatableColumn((string,string)[] mydata, int maxrows = 10)
        {
            //(string, string)[] empty = new (string, string)[emptyRows];
            //(string, string)[] mydata = empty.Concat(CommentAndAddr).ToArray();
            //int maxrows = 10;
            int nCols = ( (mydata.Length + maxrows - 1) / maxrows );

            DataTable dt = new DataTable();
            for (int i = 0; i < nCols; i++)
            {
                //dt.Columns.Add("Notes" + (i * maxrows));
                dt.Columns.Add();
                dt.Columns.Add("" + (i * maxrows));

                //dt.Columns[i*2]. = "Notes";
            }
            
            for (int i = 0; i < maxrows; i++)
            {
                DataRow dr = dt.NewRow();
                
                for (int j = 0; j < nCols; j++)
                {
                    int index = j * maxrows + i;
                    if (index < mydata.Length)
                    {
                        dr[j*2] = mydata[j * maxrows + i].Item2;
                        dr[j * 2 + 1] = mydata[j * maxrows + i].Item1;
                    }

                }
                //dr.
                //dr.ItemArray = mydata;
                dt.Rows.Add(dr);
            }


            //dataGridView1.DataSource = dt;
            return dt;
        }

        public static bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        //public static DataTable ArrayToDatatableColumn((string[] mydata))
        //{
        //    int maxrows = 10;
        //    int nCols = (mydata.Length + maxrows - 1) / maxrows;

        //    DataTable dt = new DataTable();
        //    for (int i = 0; i < nCols; i++)
        //    {
        //        dt.Columns.Add("" + (i * maxrows));
        //    }
        //    for (int i = 0; i < maxrows; i++)
        //    {
        //        DataRow dr = dt.NewRow();
        //        for (int j = 0; j < nCols; j++)
        //        {
        //            int index = j * maxrows + i;
        //            if (index < mydata.Length)
        //            {
        //                dr[j] = mydata[j * maxrows + i];
        //            }

        //        }
        //        //dr.
        //        //dr.ItemArray = mydata;
        //        dt.Rows.Add(dr);
        //    }


        //    //dataGridView1.DataSource = dt;
        //    return dt;
        //}

    }
}
