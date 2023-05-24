using System;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.IO.Hashing;  //CRC32 BY WINDOWS 
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace WCF_ZI
{
    public class FileSystem
    {
        public int Number_of_Threads = 1;
        public string outputDirectory;
        public bool isWatcherOn;
        //private bool algorythm; //rc-0 //tea-1
        public bool rc4_checked;  //tea 
        public bool tea_checked;  //tea 
        public bool cbc_tea_checked;  //tea 
        public byte[] hashCRC32;
        public string watchedDirectory;
        public int BmpWidth, BmpHeight;


        public FileSystem()
        {
            rc4_checked = true;
            tea_checked = false;
            cbc_tea_checked = false;
            outputDirectory = "";
        }
        public void SetOutputDirectory(string dir)
        {
            outputDirectory = dir;
        }

        public void EncodeFileFromPath(string path)
        {
            byte[] all_bytes = ReadBinaryFile(path);
            this.hashCRC32 = Crc32.Hash(all_bytes); //4*8 = 32 => Crc32

            if (outputDirectory.Length == 0)
                throw new Exception("Destination folder not set!");
            if (path.EndsWith(".txt"))
                EncodeTextFile(path, outputDirectory);
            else if (path.EndsWith(".bmp"))
                EncodeBmpFile(path, outputDirectory);
        }                                   //"C:\\Users\\asina\\Desktop\\zastita src\\ananas.txt        "C:\\Users\\asina\\Desktop\\zastita src
        public bool EncodeTextFile(string fullFileName, string outputDirectory)
        {
            string textForCoding = ReadTextFile(fullFileName);
            if (rc4_checked)
            {
                string outputFileName1 = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
                int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

                string outputFileName = fullFileName;
                if (lastBackslashIndex >= 0)
                {
                    outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
                }
                RC4 rc4 = RC4.GetInstance();
                byte[] encodedText = rc4.EncodeStream(textForCoding);

                WriteToBinaryFile(outputFileName, encodedText);

                return true;
            }
            else
            {
                string outputFileName1 = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.tea"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
                int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

                string outputFileName = fullFileName;
                if (lastBackslashIndex >= 0)
                {
                    outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
                }

                TEA tea = TEA.GetInstance();
                string encodedText = tea.Encrypt(textForCoding);

                WriteToTextFile(outputFileName, encodedText);

                return true;
            }

        }

        public void EncodeBmpFile(string fullFileName, string outputDirectory)
        {
            byte[] all_data = File.ReadAllBytes(fullFileName);
            byte[] header = new byte[54];
            Array.Copy(all_data, header, 54);

            //Enkriptuje podatke o pikselima
            var rc4 = RC4.GetInstance();            //skipujemo header
            byte[] data = rc4.Run(all_data.Skip(54).ToArray());


            // Spajamo header i enkriptovane podatke u novi niz bajtova
            byte[] encryptedData = new byte[header.Length + data.Length];//duzina header-a i tela, naravno
            Array.Copy(header, encryptedData, header.Length); //u encryptedData iskopiraj header
            Array.Copy(data, 0, encryptedData, header.Length, data.Length); //u encryptedData iskopiraj data, pocevsi od 54 indexa

            using (MemoryStream stream = new MemoryStream(encryptedData))
            {
                Bitmap image = new Bitmap(stream);
                string outputFileName1 = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.bmp"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
                int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

                string outputFileName = fullFileName;
                if (lastBackslashIndex >= 0)
                {
                    outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
                }
                image.Save(outputFileName);
            }

        }

        public string DecodeBmpFile(string fullFileName, string outputDirectory)
        {
            byte[] all_data = File.ReadAllBytes(fullFileName);
            byte[] header = new byte[54];
            Array.Copy(all_data, header, 54);

            //Decrypting the pixels
            var rc4 = RC4.GetInstance(); //skipping header
            byte[] data = rc4.Run(all_data.Skip(54).ToArray());

            //Concate header and Decrypted pixels into new array
            byte[] decryptedData = new byte[header.Length + data.Length];//duzina header-a i tela, naravno
            Array.Copy(header, decryptedData, header.Length); //u encryptedData iskopiraj header
            Array.Copy(data, 0, decryptedData, header.Length, data.Length); //u encryptedData iskopiraj data, pocevsi od 54 indexa

            using (MemoryStream stream = new MemoryStream(decryptedData))
            {
                Bitmap image = new Bitmap(stream);
                //string outputFileName = fullFileName.Remove(fullFileName.Length - 7, 7) + "Dec.bmp";

                string outputFileName1 = fullFileName.Remove(fullFileName.Length - 7, 7) + "Dec.bmp"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
                int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

                string outputFileName = fullFileName;
                if (lastBackslashIndex >= 0)
                {
                    outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
                }

                image.Save(outputFileName);
                return outputFileName;
            }

        }

        public string DecodeFile(string fullFileName, string targetFolder)
        {

            if (fullFileName.Contains("Enc.rc4"))
            {
                int lastBackslashIndex = fullFileName.LastIndexOf('\\');

                // Extract the portion of the string after the last '\' character
                string charsAfterLastBackslash = fullFileName.Substring(lastBackslashIndex + 1);

                string outputFileName = targetFolder + "\\" + charsAfterLastBackslash.Remove(charsAfterLastBackslash.Length - 7, 7) + "DecRC4.txt";

                byte[] codedText = ReadBinaryFile(fullFileName);

                var rc4 = RC4.GetInstance();
                string decodedText = rc4.DecodeStream(codedText);

                WriteToTextFile(outputFileName, decodedText);

                return outputFileName;
            }
            else if (fullFileName.Contains("Enc.tea"))
            {
                int lastBackslashIndex = fullFileName.LastIndexOf('\\');
                string charsAfterLastBackslash = fullFileName.Substring(lastBackslashIndex + 1);

                string outputFileName = targetFolder + "\\" + charsAfterLastBackslash.Remove(charsAfterLastBackslash.Length - 7, 7) + "DecTEA.txt";

                string codedText = ReadTextFile(fullFileName);

                var TEA = WCF_ZI.TEA.GetInstance();


                string decodedText = TEA.Decrypt(codedText);

                WriteToTextFile(outputFileName, decodedText);

                return outputFileName;
            }
            else if (fullFileName.Contains(".bmp"))
            {
                string OrgImgFileName = DecodeBmpFile(fullFileName, targetFolder);
                return OrgImgFileName;
            }

            return "";


        }

        public string ReadTextFile(string path)
        {
            ReadBinaryFile(path); //zasto uopste onda ovo koristim
            using (StreamReader sr = new StreamReader(path))
            {
                // Code goes here
                return sr.ReadToEnd().ToString();
            }
            
        }

        public byte[] ReadBinaryFile(string path)
        {
            long fileLength = new FileInfo(path).Length;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (BinaryReader br = new BinaryReader(fs))
            {
                byte[] all_bytes = br.ReadBytes((int)fileLength);
                return all_bytes;
            }
        }

        public static void WriteToTextFile(string path, string content)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(content);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }

        public static void WriteToBinaryFile(string path, byte[] content)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create);
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(content, 0, content.Length);
                }


            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }

        public bool IsValidCrc32(string path)
        {
            // Compute the CRC of the transmitted file
            byte[] transmittedFileBytes = File.ReadAllBytes(path);
            byte[] transmittedHash = Crc32.Hash(transmittedFileBytes);

            if (hashCRC32 != null && transmittedHash.SequenceEqual(hashCRC32))  //deep check
                return true;
            else
                return false;
        }
    }

}