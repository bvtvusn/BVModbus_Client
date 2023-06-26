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
            Hex
        }
        public bool ByteSwap { get; set; }
        public FormatName CurrentFormat { get; set; } = FormatName.Uint16;
        internal static string[] GetStringRepresentation(ushort[] rawdata, FormatName format, bool swapBytes = false)
        {
            if (swapBytes)
            {
                rawdata = rawdata.Select(x => SwapBytes(x)).ToArray(); // Swap bytes if requested
            }
            if (format == FormatName.Uint16)
            {
                return rawdata.Cast<ushort>().Select(x => x.ToString()).ToArray();
            }
            else if (format == FormatName.Int16)
            {
                return rawdata.Cast<short>().Select(x => x.ToString()).ToArray();
            }
            else if (format == FormatName.Float)
            {
                //Half[] formatted = new Half[rawdata.Length];
                //Half.
                ////flo[] formatted = new float[rawdata.Length];
                //Buffer.BlockCopy(rawdata, 0, formatted, 0, rawdata.Length);
                //return formatted.Select(x => x.ToString()).ToArray();
                //BìtConverter.
                //ushort o = 2;
                //BitConverter.ToSingle(new ReadOnlySpan<byte>(o));
                //BitConverter.ToSingle(new byte[] { 1, 1 });
                //return rawdata.Select(x => x.ToString()).ToArray();
                return rawdata.Select(x => FormatConverter.HalfToFloat(x).ToString()).ToArray();
            }
            else if (format == FormatName.Hex)
            {
                return rawdata.Select(x => x.ToString("X")).ToArray();
            }
            else
            {
                return rawdata.Cast<ushort>().Select(x => x.ToString()).ToArray();
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

        internal static string GetStringRepresentation(ushort rawdata, FormatName format , bool swapBytes = false)
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
            else
            {
                return ((ushort)rawdata).ToString();
            }

           
        }
        internal static ushort GetBinaryRepresentation(string rawdata, FormatName format , bool swapBytes = false)
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

        public static ushort SwapBytes(ushort value)
        {
            return (ushort)((value << 8) | (value >> 8));
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

        public static DataTable ArrayToDatatableRow(string[] mydata)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < mydata.Length; i++)
            {
                dt.Columns.Add("Column" + (i + 1));
            }
            DataRow dr = dt.NewRow();
            dr.ItemArray = mydata;
            dt.Rows.Add(dr);

            //dataGridView1.DataSource = dt;
            return dt;
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

        public static DataTable ArrayToDatatableColumn((string,string)[] mydata)
        {
            int maxrows = 10;
            int nCols = ( (mydata.Length + maxrows - 1) / maxrows );

            DataTable dt = new DataTable();
            for (int i = 0; i < nCols; i++)
            {
                dt.Columns.Add("Notes" + (i * maxrows));
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
