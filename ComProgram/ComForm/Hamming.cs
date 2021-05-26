using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComForm
{
    class Hamming
    {
        public static int ErorDigit(char[] Error)
        {


            int digit = 0;
            for (int i = Error.Length - 1; i >= 0; i--)
            {
                int s = int.Parse(Convert.ToString(Error[4 - i + -1]));
                digit += (s * (int)(Math.Pow(2, 4 - i + -1)));

            }
            //Console.WriteLine(digit);
            return digit - 1;
        }
        /// <summary>
        /// Кодирует один информационный байт в два кодированных
        /// </summary>
        /// <param name="ToBeEncoded">Байт который нужно закодировать</param>
        /// <returns>Массив из двух элементов</returns>
        public static char[] HamingEncode1511(char[] ToBeEncoded)
        {
            char[] Array = new char[7];
            int i = 0;
            int j = 0;
            StringBuilder temp = new StringBuilder(ToBeEncoded.ToString());


            //HalfByte=forHalfByte.ToString().b2();
            StringBuilder xxx = new StringBuilder(Array.ToString());
            Array[0] = ToBeEncoded[0];
            Array[1] = ToBeEncoded[1];
            Array[2] = ToBeEncoded[2];
            Array[4] = ToBeEncoded[3];

            Array[3] = Convert.ToChar(Array[0] ^ Array[1] ^ Array[2]);

            Array[5] = Convert.ToChar(Array[0] ^ Array[1] ^ Array[4]);

            Array[6] = Convert.ToChar(Array[0] ^ Array[2] ^ Array[4]);
            
            //for (j = 0; j < xxx.Length; j++)
            //{
            //    Array[j]=xxx[j];
            //}

            return Array;
        }
        public static char[] HamingDecode1511(char[] ToBeDecoded)
        {
            char[] Array = new char[11];
            StringBuilder temp = new StringBuilder(ToBeDecoded.ToString());
            Array[0] = ToBeDecoded[0];
            Array[1] = ToBeDecoded[1];
            Array[2] = ToBeDecoded[2];
            Array[3] = ToBeDecoded[4];


            return Array;
        }
        public static int HamingSindrome1511(char[] ToBeDecoded)
        {
            int[] Array = new int[3];
            int digit = 0;
            StringBuilder temp = new StringBuilder(ToBeDecoded.ToString());
            Console.WriteLine(ToBeDecoded);
            
            Array[2] = ((ToBeDecoded[3] ^ ToBeDecoded[2] ^ ToBeDecoded[1] ^ ToBeDecoded[0]));
            Array[1] = ((ToBeDecoded[5] ^ ToBeDecoded[4] ^ ToBeDecoded[1] ^ ToBeDecoded[0]));
            Array[0] = ((ToBeDecoded[6] ^ ToBeDecoded[4] ^ ToBeDecoded[2] ^ ToBeDecoded[0]));
            for (int i = 0; i < 3; i++)
            {

                digit += (Array[i] * (int)(Math.Pow(2, i)));

            }
            Console.WriteLine(Array[2]);
            Console.WriteLine(Array[1]);
            Console.WriteLine(Array[0]);
            return 15 - digit;
        }
        public static char[] HamingCorrection1511(char[] code, int number)
        {
            if (number == 0)
            {
                return code;
            }
            else
            {
                if (code[number - 1] == '0')
                {
                    code[number - 1] = '1';
                }
                else
                {
                    code[number - 1] = '0';
                }


            }
            return code;

        }
        public static char[] Decoded(char[] ToBeDecoded)
        {

            int Sindrome = Hamming.HamingSindrome1511(ToBeDecoded); // Определение синдрома
            char[] CorrectedCode;
            if (Sindrome == 7) // Если имеется ненулевой синдрома
            {
                CorrectedCode = Hamming.HamingCorrection1511(ToBeDecoded, (Sindrome)); // Корректируем
            }
            else
            {
                CorrectedCode = ToBeDecoded; // Не корректируем
            }
            char[] outgoing = Hamming.HamingDecode1511(CorrectedCode); // Декодируем

            return outgoing;
        }
    
    #region True
    public static int ErrorDigit(byte Error)
        {
            string tmp = Error.bin();
            int digit = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                digit += Int32.Parse(tmp[i].ToString());
            }
            return digit;
        }
        /// <summary>
        /// Кодирует один информационный байт в два кодированных
        /// </summary>
        /// <param name="ToBeEncoded">Байт который нужно закодировать</param>
        /// <returns>Массив из двух элементов</returns>
        public static byte[] HammingEncode1511(byte ToBeEncoded)
        {
            byte[] Array = new byte[2];
            int i = 0;
            int j = 0;
            StringBuilder temp = new StringBuilder(ToBeEncoded.bin());
            while (temp.Length < 8)
            {
                temp = new StringBuilder("0" + temp);
            }
            for (j = 0; j < 2; j++)
            {
                StringBuilder forHalfByte = new StringBuilder("0000");
                for (i = 0; i < 4; i++)
                {
                    forHalfByte[i] = temp[(j * 4) + i];
                }
                //HalfByte=forHalfByte.ToString().b2();
                StringBuilder xxx = new StringBuilder("000" + forHalfByte);
                xxx[0] = xxx[3];
                xxx[1] = xxx[4];
                xxx[2] = xxx[5];
                xxx[4] = xxx[6];
                xxx[3] = Convert.ToChar(xxx[0] ^ xxx[1] ^ xxx[2]);
                xxx[5] = Convert.ToChar(xxx[0] ^ xxx[1] ^ xxx[4]);
                xxx[6] = Convert.ToChar(xxx[0] ^ xxx[2] ^ xxx[4]);
                Array[j] = xxx.ToString().b2();
            }
            return Array;
        }
        public static string HammingDecode1511(byte ToBeDecoded)
        {
            StringBuilder temp = new StringBuilder("0000", 4);
            StringBuilder ToDecode = new StringBuilder(ToBeDecoded.bin());
            if (ToDecode.Length < 7)
                do
                {
                    ToDecode = new StringBuilder("0" + ToDecode.ToString());
                } while (ToDecode.Length < 7);
            temp[0] = ToDecode[0];
            temp[1] = ToDecode[1];
            temp[2] = ToDecode[2];
            temp[3] = ToDecode[4];
            return temp.ToString();
        }
        public static byte HammingSimptome1511(byte ToBeDecoded)
        {
            StringBuilder temp = new StringBuilder("000", 3);
            StringBuilder ToDecode = new StringBuilder(ToBeDecoded.bin());
            if (ToDecode.Length < 7)
                do
                {
                    ToDecode = new StringBuilder("0" + ToDecode.ToString());
                } while (ToDecode.Length < 7);
            temp[2] = Convert.ToChar(((ToDecode[0] ^ ToDecode[2]) ^ (ToDecode[4] ^ ToDecode[6])).ToString());
            temp[1] = Convert.ToChar(((ToDecode[0] ^ ToDecode[1]) ^ (ToDecode[4] ^ ToDecode[5])).ToString());
            temp[0] = Convert.ToChar(((ToDecode[0] ^ ToDecode[1]) ^ (ToDecode[2] ^ ToDecode[3])).ToString());
            return temp.ToString().b2();
        }
        public static byte HammingCorrection1511(byte code, int number)
        {
            StringBuilder temp = new StringBuilder(code.bin());
            if (temp.Length < 7)
                do
                {
                    temp = new StringBuilder("0" + temp.ToString());
                } while (temp.Length < 7);
            temp[7 - number] = (char)(temp[7 - number] ^ 1);
            return temp.ToString().b2();
        }
        public static byte Decode(byte[] OneEncodedByteInTwoBytes)
        {
            if (OneEncodedByteInTwoBytes.Length != 2)
            {
                return 0;
            }
            string outgoing = string.Empty;
            for (int i = 0; i < 2; i++)
            {
                byte AfterErrorCode = OneEncodedByteInTwoBytes[i];
                byte Symptom = Hamming.HammingSimptome1511(AfterErrorCode); // Определение симптома
                byte CorrectedCode; // Скорректированный код
                if (Convert.ToBoolean(Symptom)) // Если имеется ненулевой симптом
                {
                    CorrectedCode = Hamming.HammingCorrection1511(AfterErrorCode, Symptom); // Корректируем
                }
                else
                {
                    CorrectedCode = AfterErrorCode; // Не корректируем
                }
                outgoing += Hamming.HammingDecode1511(CorrectedCode); // Декодируем
            }
            return outgoing.b2();
        }
    }
    class MyStrComparer : IEqualityComparer<string>
    {
        public bool Equals(string s1, string s2)
        {
            if (s1.Contains(s2)) return true;
            else return false;
        }
        public int GetHashCode(string st)
        {
            return st.Length;
        }
    }
    static class MyExtensionClass
    {
        public static string bin(this Byte input)
        {
            return Convert.ToString(input, 2);
        }
        public static byte b2(this string input)
        {
            return Convert.ToByte(input, 2);
        }
        public static Int16 b22(this string input)
        {
            return Convert.ToInt16(input, 2);
        }
        #endregion
    }

}
