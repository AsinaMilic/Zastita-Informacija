﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_ZI.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RC4", Namespace="http://schemas.datacontract.org/2004/07/WCF_ZI")]
    [System.SerializableAttribute()]
    public partial class RC4 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string key1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string latestDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="key")]
        public string key1 {
            get {
                return this.key1Field;
            }
            set {
                if ((object.ReferenceEquals(this.key1Field, value) != true)) {
                    this.key1Field = value;
                    this.RaisePropertyChanged("key1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string latestData {
            get {
                return this.latestDataField;
            }
            set {
                if ((object.ReferenceEquals(this.latestDataField, value) != true)) {
                    this.latestDataField = value;
                    this.RaisePropertyChanged("latestData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TEA", Namespace="http://schemas.datacontract.org/2004/07/WCF_ZI")]
    [System.SerializableAttribute()]
    public partial class TEA : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint[] KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint[] key1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint[] Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="key")]
        public uint[] key1 {
            get {
                return this.key1Field;
            }
            set {
                if ((object.ReferenceEquals(this.key1Field, value) != true)) {
                    this.key1Field = value;
                    this.RaisePropertyChanged("key1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CBC_Class", Namespace="http://schemas.datacontract.org/2004/07/WCF_ZI")]
    [System.SerializableAttribute()]
    public partial class CBC_Class : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long[] EncryptedTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long[] IVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long[] KeysField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long[] encryptedText1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long[][] encryptedTextsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] EncryptedText {
            get {
                return this.EncryptedTextField;
            }
            set {
                if ((object.ReferenceEquals(this.EncryptedTextField, value) != true)) {
                    this.EncryptedTextField = value;
                    this.RaisePropertyChanged("EncryptedText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] IV {
            get {
                return this.IVField;
            }
            set {
                if ((object.ReferenceEquals(this.IVField, value) != true)) {
                    this.IVField = value;
                    this.RaisePropertyChanged("IV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] Keys {
            get {
                return this.KeysField;
            }
            set {
                if ((object.ReferenceEquals(this.KeysField, value) != true)) {
                    this.KeysField = value;
                    this.RaisePropertyChanged("Keys");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="encryptedText")]
        public long[] encryptedText1 {
            get {
                return this.encryptedText1Field;
            }
            set {
                if ((object.ReferenceEquals(this.encryptedText1Field, value) != true)) {
                    this.encryptedText1Field = value;
                    this.RaisePropertyChanged("encryptedText1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[][] encryptedTexts {
            get {
                return this.encryptedTextsField;
            }
            set {
                if ((object.ReferenceEquals(this.encryptedTextsField, value) != true)) {
                    this.encryptedTextsField = value;
                    this.RaisePropertyChanged("encryptedTexts");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileSystem", Namespace="http://schemas.datacontract.org/2004/07/WCF_ZI")]
    [System.SerializableAttribute()]
    public partial class FileSystem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BmpHeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BmpWidthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number_of_ThreadsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool cbc_tea_checkedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] hashCRC32Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isWatcherOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string outputDirectoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool rc4_checkedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool tea_checkedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string watchedDirectoryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BmpHeight {
            get {
                return this.BmpHeightField;
            }
            set {
                if ((this.BmpHeightField.Equals(value) != true)) {
                    this.BmpHeightField = value;
                    this.RaisePropertyChanged("BmpHeight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BmpWidth {
            get {
                return this.BmpWidthField;
            }
            set {
                if ((this.BmpWidthField.Equals(value) != true)) {
                    this.BmpWidthField = value;
                    this.RaisePropertyChanged("BmpWidth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number_of_Threads {
            get {
                return this.Number_of_ThreadsField;
            }
            set {
                if ((this.Number_of_ThreadsField.Equals(value) != true)) {
                    this.Number_of_ThreadsField = value;
                    this.RaisePropertyChanged("Number_of_Threads");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool cbc_tea_checked {
            get {
                return this.cbc_tea_checkedField;
            }
            set {
                if ((this.cbc_tea_checkedField.Equals(value) != true)) {
                    this.cbc_tea_checkedField = value;
                    this.RaisePropertyChanged("cbc_tea_checked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] hashCRC32 {
            get {
                return this.hashCRC32Field;
            }
            set {
                if ((object.ReferenceEquals(this.hashCRC32Field, value) != true)) {
                    this.hashCRC32Field = value;
                    this.RaisePropertyChanged("hashCRC32");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isWatcherOn {
            get {
                return this.isWatcherOnField;
            }
            set {
                if ((this.isWatcherOnField.Equals(value) != true)) {
                    this.isWatcherOnField = value;
                    this.RaisePropertyChanged("isWatcherOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string outputDirectory {
            get {
                return this.outputDirectoryField;
            }
            set {
                if ((object.ReferenceEquals(this.outputDirectoryField, value) != true)) {
                    this.outputDirectoryField = value;
                    this.RaisePropertyChanged("outputDirectory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool rc4_checked {
            get {
                return this.rc4_checkedField;
            }
            set {
                if ((this.rc4_checkedField.Equals(value) != true)) {
                    this.rc4_checkedField = value;
                    this.RaisePropertyChanged("rc4_checked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool tea_checked {
            get {
                return this.tea_checkedField;
            }
            set {
                if ((this.tea_checkedField.Equals(value) != true)) {
                    this.tea_checkedField = value;
                    this.RaisePropertyChanged("tea_checked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string watchedDirectory {
            get {
                return this.watchedDirectoryField;
            }
            set {
                if ((object.ReferenceEquals(this.watchedDirectoryField, value) != true)) {
                    this.watchedDirectoryField = value;
                    this.RaisePropertyChanged("watchedDirectory");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCF_ZI")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRC4Instance", ReplyAction="http://tempuri.org/IService1/GetRC4InstanceResponse")]
        Client_ZI.ServiceReference1.RC4 GetRC4Instance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRC4Instance", ReplyAction="http://tempuri.org/IService1/GetRC4InstanceResponse")]
        System.Threading.Tasks.Task<Client_ZI.ServiceReference1.RC4> GetRC4InstanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetRC4Key", ReplyAction="http://tempuri.org/IService1/SetRC4KeyResponse")]
        void SetRC4Key(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetRC4Key", ReplyAction="http://tempuri.org/IService1/SetRC4KeyResponse")]
        System.Threading.Tasks.Task SetRC4KeyAsync(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRC4Key", ReplyAction="http://tempuri.org/IService1/GetRC4KeyResponse")]
        string GetRC4Key();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRC4Key", ReplyAction="http://tempuri.org/IService1/GetRC4KeyResponse")]
        System.Threading.Tasks.Task<string> GetRC4KeyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTEAInstance", ReplyAction="http://tempuri.org/IService1/GetTEAInstanceResponse")]
        Client_ZI.ServiceReference1.TEA GetTEAInstance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTEAInstance", ReplyAction="http://tempuri.org/IService1/GetTEAInstanceResponse")]
        System.Threading.Tasks.Task<Client_ZI.ServiceReference1.TEA> GetTEAInstanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetTEAKey", ReplyAction="http://tempuri.org/IService1/SetTEAKeyResponse")]
        void SetTEAKey(uint[] key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetTEAKey", ReplyAction="http://tempuri.org/IService1/SetTEAKeyResponse")]
        System.Threading.Tasks.Task SetTEAKeyAsync(uint[] key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCBCInstance", ReplyAction="http://tempuri.org/IService1/GetCBCInstanceResponse")]
        Client_ZI.ServiceReference1.CBC_Class GetCBCInstance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCBCInstance", ReplyAction="http://tempuri.org/IService1/GetCBCInstanceResponse")]
        System.Threading.Tasks.Task<Client_ZI.ServiceReference1.CBC_Class> GetCBCInstanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ENC_DEC", ReplyAction="http://tempuri.org/IService1/ENC_DECResponse")]
        string ENC_DEC(string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ENC_DEC", ReplyAction="http://tempuri.org/IService1/ENC_DECResponse")]
        System.Threading.Tasks.Task<string> ENC_DECAsync(string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Dec", ReplyAction="http://tempuri.org/IService1/DecResponse")]
        string Dec();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Dec", ReplyAction="http://tempuri.org/IService1/DecResponse")]
        System.Threading.Tasks.Task<string> DecAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetCBCKey", ReplyAction="http://tempuri.org/IService1/SetCBCKeyResponse")]
        void SetCBCKey(long[] keys);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetCBCKey", ReplyAction="http://tempuri.org/IService1/SetCBCKeyResponse")]
        System.Threading.Tasks.Task SetCBCKeyAsync(long[] keys);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetCBCIV", ReplyAction="http://tempuri.org/IService1/SetCBCIVResponse")]
        void SetCBCIV(long[] iv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetCBCIV", ReplyAction="http://tempuri.org/IService1/SetCBCIVResponse")]
        System.Threading.Tasks.Task SetCBCIVAsync(long[] iv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ClearEncryptedTexts", ReplyAction="http://tempuri.org/IService1/ClearEncryptedTextsResponse")]
        void ClearEncryptedTexts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ClearEncryptedTexts", ReplyAction="http://tempuri.org/IService1/ClearEncryptedTextsResponse")]
        System.Threading.Tasks.Task ClearEncryptedTextsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewEncryptedText", ReplyAction="http://tempuri.org/IService1/NewEncryptedTextResponse")]
        void NewEncryptedText();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewEncryptedText", ReplyAction="http://tempuri.org/IService1/NewEncryptedTextResponse")]
        System.Threading.Tasks.Task NewEncryptedTextAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFileInstance", ReplyAction="http://tempuri.org/IService1/GetFileInstanceResponse")]
        Client_ZI.ServiceReference1.FileSystem GetFileInstance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFileInstance", ReplyAction="http://tempuri.org/IService1/GetFileInstanceResponse")]
        System.Threading.Tasks.Task<Client_ZI.ServiceReference1.FileSystem> GetFileInstanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetOutputDirectory", ReplyAction="http://tempuri.org/IService1/SetOutputDirectoryResponse")]
        void SetOutputDirectory(string dir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetOutputDirectory", ReplyAction="http://tempuri.org/IService1/SetOutputDirectoryResponse")]
        System.Threading.Tasks.Task SetOutputDirectoryAsync(string dir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncodeFileFromPath", ReplyAction="http://tempuri.org/IService1/EncodeFileFromPathResponse")]
        void EncodeFileFromPath(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EncodeFileFromPath", ReplyAction="http://tempuri.org/IService1/EncodeFileFromPathResponse")]
        System.Threading.Tasks.Task EncodeFileFromPathAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecodeFile", ReplyAction="http://tempuri.org/IService1/DecodeFileResponse")]
        string DecodeFile(string fullFileName, string targetFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DecodeFile", ReplyAction="http://tempuri.org/IService1/DecodeFileResponse")]
        System.Threading.Tasks.Task<string> DecodeFileAsync(string fullFileName, string targetFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsValidCrc32", ReplyAction="http://tempuri.org/IService1/IsValidCrc32Response")]
        bool IsValidCrc32(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsValidCrc32", ReplyAction="http://tempuri.org/IService1/IsValidCrc32Response")]
        System.Threading.Tasks.Task<bool> IsValidCrc32Async(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/rc4_check", ReplyAction="http://tempuri.org/IService1/rc4_checkResponse")]
        void rc4_check(bool ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/rc4_check", ReplyAction="http://tempuri.org/IService1/rc4_checkResponse")]
        System.Threading.Tasks.Task rc4_checkAsync(bool ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tea_check", ReplyAction="http://tempuri.org/IService1/tea_checkResponse")]
        void tea_check(bool ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tea_check", ReplyAction="http://tempuri.org/IService1/tea_checkResponse")]
        System.Threading.Tasks.Task tea_checkAsync(bool ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/cbc_tea_check", ReplyAction="http://tempuri.org/IService1/cbc_tea_checkResponse")]
        void cbc_tea_check(bool ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/cbc_tea_check", ReplyAction="http://tempuri.org/IService1/cbc_tea_checkResponse")]
        System.Threading.Tasks.Task cbc_tea_checkAsync(bool ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Set_Number_of_Threads", ReplyAction="http://tempuri.org/IService1/Set_Number_of_ThreadsResponse")]
        void Set_Number_of_Threads(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Set_Number_of_Threads", ReplyAction="http://tempuri.org/IService1/Set_Number_of_ThreadsResponse")]
        System.Threading.Tasks.Task Set_Number_of_ThreadsAsync(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Client_ZI.ServiceReference1.CompositeType GetDataUsingDataContract(Client_ZI.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Client_ZI.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Client_ZI.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client_ZI.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client_ZI.ServiceReference1.IService1>, Client_ZI.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(string value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(string value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Client_ZI.ServiceReference1.RC4 GetRC4Instance() {
            return base.Channel.GetRC4Instance();
        }
        
        public System.Threading.Tasks.Task<Client_ZI.ServiceReference1.RC4> GetRC4InstanceAsync() {
            return base.Channel.GetRC4InstanceAsync();
        }
        
        public void SetRC4Key(string key) {
            base.Channel.SetRC4Key(key);
        }
        
        public System.Threading.Tasks.Task SetRC4KeyAsync(string key) {
            return base.Channel.SetRC4KeyAsync(key);
        }
        
        public string GetRC4Key() {
            return base.Channel.GetRC4Key();
        }
        
        public System.Threading.Tasks.Task<string> GetRC4KeyAsync() {
            return base.Channel.GetRC4KeyAsync();
        }
        
        public Client_ZI.ServiceReference1.TEA GetTEAInstance() {
            return base.Channel.GetTEAInstance();
        }
        
        public System.Threading.Tasks.Task<Client_ZI.ServiceReference1.TEA> GetTEAInstanceAsync() {
            return base.Channel.GetTEAInstanceAsync();
        }
        
        public void SetTEAKey(uint[] key) {
            base.Channel.SetTEAKey(key);
        }
        
        public System.Threading.Tasks.Task SetTEAKeyAsync(uint[] key) {
            return base.Channel.SetTEAKeyAsync(key);
        }
        
        public Client_ZI.ServiceReference1.CBC_Class GetCBCInstance() {
            return base.Channel.GetCBCInstance();
        }
        
        public System.Threading.Tasks.Task<Client_ZI.ServiceReference1.CBC_Class> GetCBCInstanceAsync() {
            return base.Channel.GetCBCInstanceAsync();
        }
        
        public string ENC_DEC(string ip) {
            return base.Channel.ENC_DEC(ip);
        }
        
        public System.Threading.Tasks.Task<string> ENC_DECAsync(string ip) {
            return base.Channel.ENC_DECAsync(ip);
        }
        
        public string Dec() {
            return base.Channel.Dec();
        }
        
        public System.Threading.Tasks.Task<string> DecAsync() {
            return base.Channel.DecAsync();
        }
        
        public void SetCBCKey(long[] keys) {
            base.Channel.SetCBCKey(keys);
        }
        
        public System.Threading.Tasks.Task SetCBCKeyAsync(long[] keys) {
            return base.Channel.SetCBCKeyAsync(keys);
        }
        
        public void SetCBCIV(long[] iv) {
            base.Channel.SetCBCIV(iv);
        }
        
        public System.Threading.Tasks.Task SetCBCIVAsync(long[] iv) {
            return base.Channel.SetCBCIVAsync(iv);
        }
        
        public void ClearEncryptedTexts() {
            base.Channel.ClearEncryptedTexts();
        }
        
        public System.Threading.Tasks.Task ClearEncryptedTextsAsync() {
            return base.Channel.ClearEncryptedTextsAsync();
        }
        
        public void NewEncryptedText() {
            base.Channel.NewEncryptedText();
        }
        
        public System.Threading.Tasks.Task NewEncryptedTextAsync() {
            return base.Channel.NewEncryptedTextAsync();
        }
        
        public Client_ZI.ServiceReference1.FileSystem GetFileInstance() {
            return base.Channel.GetFileInstance();
        }
        
        public System.Threading.Tasks.Task<Client_ZI.ServiceReference1.FileSystem> GetFileInstanceAsync() {
            return base.Channel.GetFileInstanceAsync();
        }
        
        public void SetOutputDirectory(string dir) {
            base.Channel.SetOutputDirectory(dir);
        }
        
        public System.Threading.Tasks.Task SetOutputDirectoryAsync(string dir) {
            return base.Channel.SetOutputDirectoryAsync(dir);
        }
        
        public void EncodeFileFromPath(string path) {
            base.Channel.EncodeFileFromPath(path);
        }
        
        public System.Threading.Tasks.Task EncodeFileFromPathAsync(string path) {
            return base.Channel.EncodeFileFromPathAsync(path);
        }
        
        public string DecodeFile(string fullFileName, string targetFolder) {
            return base.Channel.DecodeFile(fullFileName, targetFolder);
        }
        
        public System.Threading.Tasks.Task<string> DecodeFileAsync(string fullFileName, string targetFolder) {
            return base.Channel.DecodeFileAsync(fullFileName, targetFolder);
        }
        
        public bool IsValidCrc32(string path) {
            return base.Channel.IsValidCrc32(path);
        }
        
        public System.Threading.Tasks.Task<bool> IsValidCrc32Async(string path) {
            return base.Channel.IsValidCrc32Async(path);
        }
        
        public void rc4_check(bool ch) {
            base.Channel.rc4_check(ch);
        }
        
        public System.Threading.Tasks.Task rc4_checkAsync(bool ch) {
            return base.Channel.rc4_checkAsync(ch);
        }
        
        public void tea_check(bool ch) {
            base.Channel.tea_check(ch);
        }
        
        public System.Threading.Tasks.Task tea_checkAsync(bool ch) {
            return base.Channel.tea_checkAsync(ch);
        }
        
        public void cbc_tea_check(bool ch) {
            base.Channel.cbc_tea_check(ch);
        }
        
        public System.Threading.Tasks.Task cbc_tea_checkAsync(bool ch) {
            return base.Channel.cbc_tea_checkAsync(ch);
        }
        
        public void Set_Number_of_Threads(int num) {
            base.Channel.Set_Number_of_Threads(num);
        }
        
        public System.Threading.Tasks.Task Set_Number_of_ThreadsAsync(int num) {
            return base.Channel.Set_Number_of_ThreadsAsync(num);
        }
        
        public Client_ZI.ServiceReference1.CompositeType GetDataUsingDataContract(Client_ZI.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Client_ZI.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Client_ZI.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}