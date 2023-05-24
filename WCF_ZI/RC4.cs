//using System.Security.Cryptography.Xml;
using System;
using System.Text;

namespace WCF_ZI
{
    public class RC4
    {
        public static RC4 instance = null;
        public string key;
        public string latestData;
        public readonly byte[] s = new byte[256];



        #region Constructor
        public RC4()
        {
            key = null;
            latestData = null;

            for (int i = 0; i < 256; i++)
                s[i] = (byte)i;
        }
        #endregion

        #region Instance
        public static RC4 GetInstance()
        {
            if (instance != null)
                return instance;
            instance = new RC4();
            return instance;
        }
        #endregion

        #region Properties
        public string Key
        {
            get { return key; }
            set
            {
                byte[] asciiByteKey = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, Encoding.Unicode.GetBytes(value));
                char[] asciiCharsKey = new char[Encoding.ASCII.GetCharCount(asciiByteKey)];
                Encoding.ASCII.GetChars(asciiByteKey, 0, asciiCharsKey.Length);
                key = value;

                for (int i = 0; i < 256; i++){
                    s[i] = (byte)i; 
                }

                Shuffle(value);  
            }
        }

        public string LatestData
        {
            get { return latestData; }
        }
        #endregion

        #region Methods
        public void Shuffle(string key)
        {
            int j = 0;

            for (int i = 0; i < 256; i++)
            {
                j = (j + s[i] + key[i % key.Length]) % 256;

                byte temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }

        public byte[] Run(byte[] data)
        {
            if (key == null)
                return null;


            int j = 0;
            byte[] results = new byte[data.Length];

            byte[] s = new byte[256];
            this.s.CopyTo(s, 0);
            int i = 0;
            byte keyCurrent;
            byte temp;
            for (int iData = 0; iData < data.Length; iData++)
            {
                i = (i + 1) % 256;
                j = (j + s[i]) % 256;

                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                keyCurrent = s[(s[i] + s[j]) % 256];

                results[iData] = (byte)(data[iData] ^ keyCurrent);

            }

            char[] resultChars = new char[Encoding.ASCII.GetCharCount(results, 0, results.Length)]; //org ASCII
            Encoding.ASCII.GetChars(results, 0, results.Length, resultChars, 0);
            this.latestData = new string(resultChars);
            Console.WriteLine(results);
            return results;
        }
        #endregion

        #region Encription and Decription
        public byte[] EncodeStream(string plainText)
        {
            byte[] plainBytesDef = Encoding.Default.GetBytes(plainText);
            byte[] plainBytes = Encoding.Convert(Encoding.Default, Encoding.ASCII, plainBytesDef);

            byte[] r = Run(plainBytes);

            return r;  //key: 1234 text: ananas -> 64	27	10	c1	92	9f   CORRECT! RC4!
        }

        public string DecodeStream(byte[] cypherText)
        {
            byte[] r = Run(cypherText);

            char[] resultChars = new char[Encoding.ASCII.GetCharCount(r, 0, r.Length)];
            Encoding.ASCII.GetChars(r, 0, r.Length, resultChars, 0);

            string plainText = new string(resultChars);
            return plainText;
        }
        #endregion

    }
}
