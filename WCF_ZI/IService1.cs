using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCF_ZI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(string value);


        //RC4 Startsss
        [OperationContract]
        RC4 GetRC4Instance();
        
        [OperationContract]
        void SetRC4Key(string key);

        [OperationContract]
        string GetRC4Key();

        //RC4 Endssssssss

        //Tea startssss
        [OperationContract]
        TEA GetTEAInstance();

        [OperationContract]
        void SetTEAKey(uint[] key);
        ////////////////////

        //CBC statssssssssssssssss
        [OperationContract]
        CBC_Class GetCBCInstance();

        [OperationContract]
        string ENC_DEC(string ip);

        [OperationContract]
        string Dec();

        [OperationContract]
        void SetCBCKey(long[] keys);

        [OperationContract]
        void SetCBCIV(long[] iv);

        [OperationContract]
        void ClearEncryptedTexts();

        [OperationContract]
        void NewEncryptedText();
        ///////////////////



        //fajloviiiiiiiii
        [OperationContract]
        FileSystem GetFileInstance();

        [OperationContract]
        void SetOutputDirectory(string dir);

        [OperationContract]
        void EncodeFileFromPath(string path);

        [OperationContract]
        string DecodeFile(string fullFileName, string targetFolder);

        [OperationContract]
        bool IsValidCrc32(string path);

        [OperationContract]
        void rc4_check(bool ch);

        [OperationContract]
        void tea_check(bool ch);

        [OperationContract]
        void cbc_tea_check(bool ch);

        [OperationContract]
        void Set_Number_of_Threads(int num);

        //krajjj fajlovaaaa









        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCF_ZI.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
