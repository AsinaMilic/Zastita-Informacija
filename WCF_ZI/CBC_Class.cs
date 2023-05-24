using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_ZI
{
    public class CBC_Class
    {
        public static CBC_Class instance = null;
        public List<long> encryptedText = new List<long>();
        public List<List<long>> encryptedTexts = new List<List<long>>();
        public long[] Keys = new long[4];
        public long[] IV = new long[2];
        public CBC_Class()
        {

        }

        public List<long> EncryptedText
        {
            get { return encryptedText; }
            set { encryptedText = value; }
        }

        public static CBC_Class GetInstance()
        {
            if(instance==null)
                instance = new CBC_Class();
            return instance;
        }
        public long[] TEAEncryption(long[] msg)
        {
            long m = msg[0];
            long n = msg[1];
            long delta = 0x9e3779b9;
            long sum = 0;
            long[] result = new long[2];

            for (int i = 0; i < 32; i++)
            {
                sum += delta;
                m += ((n << 4) + Keys[0]) ^ (n + sum) ^ ((n >> 5) + Keys[1]);
                n += ((m << 4) + Keys[2]) ^ (m + sum) ^ ((m >> 5) + Keys[3]);
            }

            result[0] = m;
            result[1] = n;

            return result;
        }

        public long[] encryption(long[] OriginalText, long[] IVText)
        {
            long[] xored = new long[2];
            xored[0] = OriginalText[0] ^ IVText[0];
            xored[1] = OriginalText[1] ^ IVText[1];

            return TEAEncryption(xored);
        }

        public long[] Decryption(long[] DecryptedText, long[] IVText)
        {
            long[] xored = new long[2];
            xored[0] = DecryptedText[0] ^ IVText[0];
            xored[1] = DecryptedText[1] ^ IVText[1];

            return xored;
        }

        public long[] TEADecryption(long[] EncryptedText, long[] IVText)
        {
            long m = EncryptedText[0];
            long n = EncryptedText[1];
            long delta = 0x9e3779b9;
            long sum2 = delta << 5;

            long[] result = new long[2];

            for (int i = 0; i < 32; i++)
            {
                n -= ((m << 4) + Keys[2]) ^ (m + sum2) ^ ((m >> 5) + Keys[3]);
                m -= ((n << 4) + Keys[0]) ^ (n + sum2) ^ ((n >> 5) + Keys[1]);
                sum2 -= delta;
            }

            result[0] = m;
            result[1] = n;

            return Decryption(result, IVText);
        }

        //ip="ivanALEK"-radi| "ivanALEKsa","ivanALEKs"-ne radi | "ivanALEKanja"-radi. Radi do 12 izgleda
        public string ENC_DEC(string ip)
        {
                encryptedText.Clear();
                long[] result = new long[2];
                char[] b11 = new char[8];
                char[] b22 = new char[8];

                Random random = new Random();
                //for (int i = 0; i < 4; i++){
                //   long randomLong = (long)(random.NextDouble() * long.MaxValue);
                //    TEAKeys[i] = 10 + randomLong;
                //}

                List<string> msg = new List<string>(); //use to store blocks


                CBC_Class c1 = new CBC_Class();

                StringBuilder s = new StringBuilder();
                int c = 0;
                int gc = 0;

                // below logic is used to convert message into blocks for certain size

                for (int i = 0; i < ip.Length; i++)
                {
                    s.Append(ip[i]);
                    gc = ++c;

                    if (c == 4)
                    {
                        c = 0;
                        msg.Add(s.ToString());
                        s.Clear();
                    }
                }

                if (gc != 4)
                {
                    while (s.Length != 4)
                    {
                        s.Append(" ");
                    }
                    c = 0;
                    msg.Add(s.ToString());
                    s.Clear();
                }

                b11 = msg[0].ToCharArray();

                if (msg.Count == 1)
                {
                    String s2 = "    ";
                    b22 = s2.ToCharArray();
                }
                else
                {
                    b22 = msg[1].ToCharArray();
                }

                int[] bk1 = new int[b11.Length];
                int[] bk2 = new int[b22.Length];

                long[] blocks = new long[2];

                for (int i = 0; i < bk1.Length; i++)
                {
                    bk1[i] = (int)b11[i];
                }

                for (int i = 0; i < bk2.Length; i++)
                {
                    bk2[i] = (int)b22[i];
                }

                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                foreach (int N in bk1)
                {
                    sb1.Append(N);
                }
                foreach (int N in bk2)
                {
                    sb2.Append(N);
                }

                blocks[0] = long.Parse(sb1.ToString());
                blocks[1] = long.Parse(sb2.ToString());

                random = new Random();
                long[] iv = new long[2];


                iv[0] = IV[0];
                iv[1] = IV[1];

                result = c1.encryption(blocks, iv);

                encryptedText.Add(result[0]);
                encryptedText.Add(result[1]);
                

                Console.WriteLine("encrypted result:" + result[0] + result[1]);

                int m = 2;
                // condition is use when text is not mutliple of 64 bits then just encrypt and decypt portion of message whiiv satisfies bits, whiiv are multiple of 64 bits
                while (m < msg.Count)
                {
                    if (m == msg.Count - 1)
                    {
                        b11 = msg[m].ToCharArray();
                        String s2 = "    ";
                        b22 = s2.ToCharArray();
                    }
                    else
                    {
                        b11 = msg[m].ToCharArray();
                        b22 = msg[m + 1].ToCharArray();
                    }

                    int[] bk11 = new int[b11.Length];
                    int[] bk22 = new int[b22.Length];

                    long[] blocks2 = new long[2];

                    for (int i = 0; i < bk11.Length; i++)
                    {
                        bk11[i] = (int)b11[i];
                    }

                    for (int i = 0; i < bk22.Length; i++)
                    {
                        bk22[i] = (int)b22[i];
                    }

                    StringBuilder sb11 = new StringBuilder();
                    StringBuilder sb22 = new StringBuilder();
                    foreach (int N in bk11)
                    {
                        sb11.Append(N);
                    }
                    foreach (int N in bk22)
                    {
                        sb22.Append(N);
                    }

                    blocks2[0] = long.Parse(sb11.ToString());
                    blocks2[1] = long.Parse(sb22.ToString());

                    iv[0] = result[0];
                    iv[1] = result[1];

                    result = c1.encryption(blocks2, iv);
                    encryptedText.Add(result[0]);
                    encryptedText.Add(result[1]);

                    Console.WriteLine(result[0] + result[1]);
                    m += 2;

                }
                //List<long> list = new List<long>();
                encryptedTexts.Add(new List<long>(encryptedText));
                return result[0].ToString() + result[1].ToString();
            
               
        }


        public string Dec()
        {
            Console.WriteLine("Decrypted result");
            string decMessage = String.Empty;

            foreach (List<long> encryptedText in encryptedTexts)
            {
                long[] encr = new long[2];
                encr[0] = encryptedText[0];
                encr[1] = encryptedText[1];

                long[] decryptedResult = new long[2];

                long[] iV = new long[2];
                iV[0] = IV[0];
                iV[1] = IV[1];

                CBC_Class C = new CBC_Class();
                decryptedResult = C.TEADecryption(encr, iV);

                char[] p1 = decryptedResult[0].ToString().ToCharArray();
                int[] tp11 = new int[p1.Length];

                for (int i = 0; i < p1.Length; i++)
                {
                    tp11[i] = int.Parse(p1[i].ToString());
                }

                char[] p2 = decryptedResult[1].ToString().ToCharArray();
                int[] tp22 = new int[p2.Length];

                for (int i = 0; i < p2.Length; i++)
                {
                    tp22[i] = (int)char.GetNumericValue(p2[i]);
                }

                int k = 0;
                while (k <= tp11.Length - 2)
                {
                    StringBuilder sb3 = new StringBuilder();
                    sb3.Append(tp11[k]);
                    sb3.Append(tp11[k + 1]);
                    int a = int.Parse(sb3.ToString());

                    if (a == 32)
                    {
                        Console.Write(" "); // print plain(original) text 
                        k = k + 2;
                    }
                    else if ((a >= 97 && a <= 122) || (a >= 65 && a <= 90))
                    {
                        char c2 = (char)a;
                        Console.Write(c2); // print plain(original) text
                        decMessage += c2;
                        k = k + 2;
                    }
                    else
                    {
                        sb3.Append(tp11[k + 2]);

                        int a2 = int.Parse(sb3.ToString());

                        if ((a2 >= 97 && a2 <= 122) || (a2 >= 65 && a2 <= 90))
                        {
                            char c2 = (char)a2;
                            Console.Write(c2);
                            decMessage += c2;
                        }
                        k = k + 3;
                    }
                }

                int k2 = 0;
                while (k2 <= tp22.Length - 2)
                {
                    StringBuilder sb4 = new StringBuilder();
                    sb4.Append(tp22[k2]);
                    sb4.Append(tp22[k2 + 1]);
                    int a = int.Parse(sb4.ToString());

                    if (a == 32)
                    {
                        Console.Write(" ");
                        k2 = k2 + 2;
                    }
                    else if ((a >= 97 && a <= 122) || (a >= 65 && a <= 90))
                    {
                        char c2 = (char)a;
                        Console.Write(c2);
                        decMessage += c2;
                        k2 = k2 + 2;
                    }
                    else
                    {
                        sb4.Append(tp22[k2 + 2]);

                        int a2 = int.Parse(sb4.ToString());
                        if ((a2 >= 97 && a2 <= 122) || (a2 >= 65 && a2 <= 90))
                        {
                            char c2 = (char)a2;
                            Console.Write(c2);
                            decMessage += c2;
                        }
                        k2 = k2 + 3;
                    }
                }
                //ovde bih mogao da stavim ako je decMessage.Length veca od 8 da obustavim radnju
                int n = 2;
                long[] decrypted_result = new long[2]; //ovo sam stavio opet od 340 linije pd githuba
                //while (n < encryptedText.Count)
                //{
                //    iV[0] = encr[0];
                //    iV[1] = encr[1];
                //    encr[0] = encryptedText[n];
                //    encr[1] = encryptedText[n + 1];

                //    decrypted_result = C.TEADecryption(encr, iV);

                //    char[] pn1 = decrypted_result[0].ToString().ToCharArray();
                //    int[] tpn11 = new int[pn1.Length];
                //    for (int i = 0; i < pn1.Length; i++)
                //    {
                //        tpn11[i] = (int)Char.GetNumericValue(pn1[i]);
                //    }

                //    char[] pn2 = decrypted_result[1].ToString().ToCharArray();
                //    int[] tpn22 = new int[pn2.Length];
                //    for (int i = 0; i < pn2.Length; i++)
                //    {
                //        tpn22[i] = (int)Char.GetNumericValue(pn2[i]);
                //    }
                //}
            }
                return decMessage;
        }
    }
}


