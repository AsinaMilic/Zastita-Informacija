using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WCF_ZI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        public FileSystem fs = new FileSystem();
        public RC4 rc4 = RC4.GetInstance();
        public TEA tea = TEA.GetInstance();
        public CBC_Class cbc = CBC_Class.GetInstance();


        public Service1()
        {
            if (fs == null)
                fs = new FileSystem();
            if (rc4 == null)
                rc4 = new RC4();
            if (tea == null)
                tea = new TEA();
            if (cbc == null)
                cbc = new CBC_Class();
        }


        //RC4 startss
        public RC4 GetRC4Instance()
        {
            return rc4;
        }
        public void SetRC4Key(string key)
        {
            rc4.Key = key;
        }
        public string GetRC4Key()
        {
            return rc4.Key;
        }
        //RC4 endsss

        //Tea startssss
        public TEA GetTEAInstance()
        {
            return tea;
        }
        public void SetTEAKey(uint[] key)
        {
            tea.Key = key;
        }
        ////////

        //CBC startsssss
        public CBC_Class GetCBCInstance()
        {
            return cbc;
        }
        public string ENC_DEC(string ip)
        {
            return cbc.ENC_DEC(ip);
        }
        public string Dec()
        {
            return cbc.Dec();
        }
        public void SetCBCKey(long[] keys)
        {
            cbc.Keys = keys;
        }
        public void SetCBCIV(long[] iv)
        {
            cbc.IV = iv;
        }
        public void ClearEncryptedTexts()
        {
            cbc.encryptedTexts.Clear();
        }

        public void NewEncryptedText()
        {
            cbc.encryptedText = new List<long>();
        }
        //CBC endss


        //Files startsssssss

        public FileSystem GetFileInstance()
        {
            return fs;
        }
        public void SetOutputDirectory(string dir)
        {
            fs.SetOutputDirectory(dir);
        }

        public void EncodeFileFromPath(string path)
        {
            fs.EncodeFileFromPath(path);
        }
        public string DecodeFile(string fullFileName, string targetFolder)
        {
            return fs.DecodeFile(fullFileName, targetFolder);
        }

        public void rc4_check(bool ch)
        {
            fs.rc4_checked = ch;
        }

        public void cbc_tea_check(bool ch)
        {
            fs.cbc_tea_checked = ch;
        }

        public void tea_check(bool ch)
        {
            fs.tea_checked = ch;
        }

        public bool IsValidCrc32(string path)
        {
            return fs.IsValidCrc32(path);
        }
        public void Set_Number_of_Threads(int num)
        {
            fs.Number_of_Threads = num;
        }
        //File endsssss




        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
