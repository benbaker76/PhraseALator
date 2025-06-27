using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Threading;

namespace PhraseALator
{
    public class Strings
    {
        public static string Mid(string str, int start, int length, string val)
        {
            int minTmp = Math.Min(length, Math.Min(val.Length, str.Length - (start - 1)));

            return str.Substring(0, start - 1) + val.Substring(0, minTmp) + str.Substring(start - 1 + minTmp);
        }

        public static char Chr(int CharCode)
        {
            if (CharCode < (int)short.MinValue || CharCode > (int)ushort.MaxValue)
                throw new ArgumentException();
            if (CharCode >= 0 && CharCode <= (int)sbyte.MaxValue)
                return Convert.ToChar(CharCode);
            try
            {
                Encoding encoding = Encoding.GetEncoding(Thread.CurrentThread.CurrentCulture.TextInfo.ANSICodePage);
                if (encoding.IsSingleByte && (CharCode < 0 || CharCode > (int)byte.MaxValue))
                    throw new ArgumentException();
                char[] chars = new char[2];
                byte[] bytes = new byte[2];
                Decoder decoder = encoding.GetDecoder();
                if (CharCode >= 0 && CharCode <= (int)byte.MaxValue)
                {
                    bytes[0] = checked((byte)(CharCode & (int)byte.MaxValue));
                    decoder.GetChars(bytes, 0, 1, chars, 0);
                }
                else
                {
                    bytes[0] = checked((byte)((CharCode & 65280) >> 8));
                    bytes[1] = checked((byte)(CharCode & (int)byte.MaxValue));
                    decoder.GetChars(bytes, 0, 2, chars, 0);
                }
                return chars[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Asc(char String)
        {
            int num1 = Convert.ToInt32(String);
            if (num1 < 128)
                return num1;
            try
            {
                Encoding fileIoEncoding = Encoding.Default;
                char[] chars = new char[1]
                {
                    String
                };
                if (fileIoEncoding.IsSingleByte)
                {
                    byte[] bytes = new byte[1];
                    fileIoEncoding.GetBytes(chars, 0, 1, bytes, 0);
                    return (int)bytes[0];
                }
                byte[] bytes1 = new byte[2];
                if (fileIoEncoding.GetBytes(chars, 0, 1, bytes1, 0) == 1)
                    return (int)bytes1[0];
                if (BitConverter.IsLittleEndian)
                {
                    byte num2 = bytes1[0];
                    bytes1[0] = bytes1[1];
                    bytes1[1] = num2;
                }
                return (int)BitConverter.ToInt16(bytes1, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Asc(string String)
        {
            if (String == null || String.Length == 0)
                throw new ArgumentException();
            return Asc(String[0]);
        }
    }
}
