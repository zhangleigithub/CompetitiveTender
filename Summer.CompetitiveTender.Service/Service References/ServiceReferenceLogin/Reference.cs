﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Summer.CompetitiveTender.Service.ServiceReferenceLogin {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice.govpurchase.opensource.com/", ConfigurationName="ServiceReferenceLogin.LoginWebService")]
    public interface LoginWebService {
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(loginResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(login))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CAloginResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CAlogin))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Summer.CompetitiveTender.Service.ServiceReferenceLogin.CAloginResponse1 CAlogin(Summer.CompetitiveTender.Service.ServiceReferenceLogin.CAlogin1 request);
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(loginResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(login))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CAloginResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CAlogin))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Summer.CompetitiveTender.Service.ServiceReferenceLogin.loginResponse1 login(Summer.CompetitiveTender.Service.ServiceReferenceLogin.login1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.govpurchase.opensource.com/")]
    public partial class resultDO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int codeField;
        
        private byte[] fileContentField;
        
        private string messageField;
        
        private object objField;
        
        private object[] objListField;
        
        private bool successField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] fileContent {
            get {
                return this.fileContentField;
            }
            set {
                this.fileContentField = value;
                this.RaisePropertyChanged("fileContent");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public object obj {
            get {
                return this.objField;
            }
            set {
                this.objField = value;
                this.RaisePropertyChanged("obj");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("objList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=4)]
        public object[] objList {
            get {
                return this.objListField;
            }
            set {
                this.objListField = value;
                this.RaisePropertyChanged("objList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
                this.RaisePropertyChanged("success");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.govpurchase.opensource.com/")]
    public partial class loginResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private resultDO returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public resultDO @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
                this.RaisePropertyChanged("return");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.govpurchase.opensource.com/")]
    public partial class login : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string accountField;
        
        private string passwordField;
        
        private string acRoleField;
        
        private string macAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
                this.RaisePropertyChanged("account");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string acRole {
            get {
                return this.acRoleField;
            }
            set {
                this.acRoleField = value;
                this.RaisePropertyChanged("acRole");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string macAddress {
            get {
                return this.macAddressField;
            }
            set {
                this.macAddressField = value;
                this.RaisePropertyChanged("macAddress");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(baseUserWebDO))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.govpurchase.opensource.com/")]
    public abstract partial class baseEntity : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.govpurchase.opensource.com/")]
    public partial class baseUserWebDO : baseEntity {
        
        private string acIdField;
        
        private string acNameField;
        
        private string accountField;
        
        private long acrIdField;
        
        private bool acrIdFieldSpecified;
        
        private string acrNameField;
        
        private string auIDField;
        
        private string auNameField;
        
        private string azCodeField;
        
        private long azIdField;
        
        private bool azIdFieldSpecified;
        
        private string azNameField;
        
        private System.DateTime caBindTimeField;
        
        private bool caBindTimeFieldSpecified;
        
        private string caEncryptCertField;
        
        private System.DateTime caExpireTimeField;
        
        private bool caExpireTimeFieldSpecified;
        
        private string caSignCertField;
        
        private string caSnField;
        
        private string caUniqueIdField;
        
        private string idCardField;
        
        private System.DateTime idCardEndDateField;
        
        private bool idCardEndDateFieldSpecified;
        
        private string passwordField;
        
        private int regTypeField;
        
        private bool regTypeFieldSpecified;
        
        private int sourceField;
        
        private bool sourceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string acId {
            get {
                return this.acIdField;
            }
            set {
                this.acIdField = value;
                this.RaisePropertyChanged("acId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string acName {
            get {
                return this.acNameField;
            }
            set {
                this.acNameField = value;
                this.RaisePropertyChanged("acName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
                this.RaisePropertyChanged("account");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long acrId {
            get {
                return this.acrIdField;
            }
            set {
                this.acrIdField = value;
                this.RaisePropertyChanged("acrId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool acrIdSpecified {
            get {
                return this.acrIdFieldSpecified;
            }
            set {
                this.acrIdFieldSpecified = value;
                this.RaisePropertyChanged("acrIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string acrName {
            get {
                return this.acrNameField;
            }
            set {
                this.acrNameField = value;
                this.RaisePropertyChanged("acrName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string auID {
            get {
                return this.auIDField;
            }
            set {
                this.auIDField = value;
                this.RaisePropertyChanged("auID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string auName {
            get {
                return this.auNameField;
            }
            set {
                this.auNameField = value;
                this.RaisePropertyChanged("auName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string azCode {
            get {
                return this.azCodeField;
            }
            set {
                this.azCodeField = value;
                this.RaisePropertyChanged("azCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public long azId {
            get {
                return this.azIdField;
            }
            set {
                this.azIdField = value;
                this.RaisePropertyChanged("azId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool azIdSpecified {
            get {
                return this.azIdFieldSpecified;
            }
            set {
                this.azIdFieldSpecified = value;
                this.RaisePropertyChanged("azIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string azName {
            get {
                return this.azNameField;
            }
            set {
                this.azNameField = value;
                this.RaisePropertyChanged("azName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public System.DateTime caBindTime {
            get {
                return this.caBindTimeField;
            }
            set {
                this.caBindTimeField = value;
                this.RaisePropertyChanged("caBindTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caBindTimeSpecified {
            get {
                return this.caBindTimeFieldSpecified;
            }
            set {
                this.caBindTimeFieldSpecified = value;
                this.RaisePropertyChanged("caBindTimeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string caEncryptCert {
            get {
                return this.caEncryptCertField;
            }
            set {
                this.caEncryptCertField = value;
                this.RaisePropertyChanged("caEncryptCert");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public System.DateTime caExpireTime {
            get {
                return this.caExpireTimeField;
            }
            set {
                this.caExpireTimeField = value;
                this.RaisePropertyChanged("caExpireTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caExpireTimeSpecified {
            get {
                return this.caExpireTimeFieldSpecified;
            }
            set {
                this.caExpireTimeFieldSpecified = value;
                this.RaisePropertyChanged("caExpireTimeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string caSignCert {
            get {
                return this.caSignCertField;
            }
            set {
                this.caSignCertField = value;
                this.RaisePropertyChanged("caSignCert");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string caSn {
            get {
                return this.caSnField;
            }
            set {
                this.caSnField = value;
                this.RaisePropertyChanged("caSn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string caUniqueId {
            get {
                return this.caUniqueIdField;
            }
            set {
                this.caUniqueIdField = value;
                this.RaisePropertyChanged("caUniqueId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string idCard {
            get {
                return this.idCardField;
            }
            set {
                this.idCardField = value;
                this.RaisePropertyChanged("idCard");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public System.DateTime idCardEndDate {
            get {
                return this.idCardEndDateField;
            }
            set {
                this.idCardEndDateField = value;
                this.RaisePropertyChanged("idCardEndDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idCardEndDateSpecified {
            get {
                return this.idCardEndDateFieldSpecified;
            }
            set {
                this.idCardEndDateFieldSpecified = value;
                this.RaisePropertyChanged("idCardEndDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int regType {
            get {
                return this.regTypeField;
            }
            set {
                this.regTypeField = value;
                this.RaisePropertyChanged("regType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool regTypeSpecified {
            get {
                return this.regTypeFieldSpecified;
            }
            set {
                this.regTypeFieldSpecified = value;
                this.RaisePropertyChanged("regTypeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public int source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
                this.RaisePropertyChanged("source");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sourceSpecified {
            get {
                return this.sourceFieldSpecified;
            }
            set {
                this.sourceFieldSpecified = value;
                this.RaisePropertyChanged("sourceSpecified");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.govpurchase.opensource.com/")]
    public partial class CAloginResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private resultDO returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public resultDO @return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
                this.RaisePropertyChanged("return");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.govpurchase.opensource.com/")]
    public partial class CAlogin : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string caSignCertField;
        
        private string passwordField;
        
        private string acRoleField;
        
        private string macAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string caSignCert {
            get {
                return this.caSignCertField;
            }
            set {
                this.caSignCertField = value;
                this.RaisePropertyChanged("caSignCert");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string acRole {
            get {
                return this.acRoleField;
            }
            set {
                this.acRoleField = value;
                this.RaisePropertyChanged("acRole");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string macAddress {
            get {
                return this.macAddressField;
            }
            set {
                this.macAddressField = value;
                this.RaisePropertyChanged("macAddress");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CAlogin", WrapperNamespace="http://webservice.govpurchase.opensource.com/", IsWrapped=true)]
    public partial class CAlogin1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string caSignCert;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string acRole;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string macAddress;
        
        public CAlogin1() {
        }
        
        public CAlogin1(string caSignCert, string password, string acRole, string macAddress) {
            this.caSignCert = caSignCert;
            this.password = password;
            this.acRole = acRole;
            this.macAddress = macAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CAloginResponse", WrapperNamespace="http://webservice.govpurchase.opensource.com/", IsWrapped=true)]
    public partial class CAloginResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Summer.CompetitiveTender.Service.ServiceReferenceLogin.resultDO @return;
        
        public CAloginResponse1() {
        }
        
        public CAloginResponse1(Summer.CompetitiveTender.Service.ServiceReferenceLogin.resultDO @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="login", WrapperNamespace="http://webservice.govpurchase.opensource.com/", IsWrapped=true)]
    public partial class login1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string account;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string acRole;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string macAddress;
        
        public login1() {
        }
        
        public login1(string account, string password, string acRole, string macAddress) {
            this.account = account;
            this.password = password;
            this.acRole = acRole;
            this.macAddress = macAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="loginResponse", WrapperNamespace="http://webservice.govpurchase.opensource.com/", IsWrapped=true)]
    public partial class loginResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.govpurchase.opensource.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Summer.CompetitiveTender.Service.ServiceReferenceLogin.resultDO @return;
        
        public loginResponse1() {
        }
        
        public loginResponse1(Summer.CompetitiveTender.Service.ServiceReferenceLogin.resultDO @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LoginWebServiceChannel : Summer.CompetitiveTender.Service.ServiceReferenceLogin.LoginWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginWebServiceClient : System.ServiceModel.ClientBase<Summer.CompetitiveTender.Service.ServiceReferenceLogin.LoginWebService>, Summer.CompetitiveTender.Service.ServiceReferenceLogin.LoginWebService {
        
        public LoginWebServiceClient() {
        }
        
        public LoginWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Summer.CompetitiveTender.Service.ServiceReferenceLogin.CAloginResponse1 Summer.CompetitiveTender.Service.ServiceReferenceLogin.LoginWebService.CAlogin(Summer.CompetitiveTender.Service.ServiceReferenceLogin.CAlogin1 request) {
            return base.Channel.CAlogin(request);
        }
        
        public Summer.CompetitiveTender.Service.ServiceReferenceLogin.resultDO CAlogin(string caSignCert, string password, string acRole, string macAddress) {
            Summer.CompetitiveTender.Service.ServiceReferenceLogin.CAlogin1 inValue = new Summer.CompetitiveTender.Service.ServiceReferenceLogin.CAlogin1();
            inValue.caSignCert = caSignCert;
            inValue.password = password;
            inValue.acRole = acRole;
            inValue.macAddress = macAddress;
            Summer.CompetitiveTender.Service.ServiceReferenceLogin.CAloginResponse1 retVal = ((Summer.CompetitiveTender.Service.ServiceReferenceLogin.LoginWebService)(this)).CAlogin(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Summer.CompetitiveTender.Service.ServiceReferenceLogin.loginResponse1 Summer.CompetitiveTender.Service.ServiceReferenceLogin.LoginWebService.login(Summer.CompetitiveTender.Service.ServiceReferenceLogin.login1 request) {
            return base.Channel.login(request);
        }
        
        public Summer.CompetitiveTender.Service.ServiceReferenceLogin.resultDO login(string account, string password, string acRole, string macAddress) {
            Summer.CompetitiveTender.Service.ServiceReferenceLogin.login1 inValue = new Summer.CompetitiveTender.Service.ServiceReferenceLogin.login1();
            inValue.account = account;
            inValue.password = password;
            inValue.acRole = acRole;
            inValue.macAddress = macAddress;
            Summer.CompetitiveTender.Service.ServiceReferenceLogin.loginResponse1 retVal = ((Summer.CompetitiveTender.Service.ServiceReferenceLogin.LoginWebService)(this)).login(inValue);
            return retVal.@return;
        }
    }
}