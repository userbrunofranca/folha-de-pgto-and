﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace Cliente.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ValidaCpfOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidaInssOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidaIrOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::Cliente.Properties.Settings.Default.Cliente_localhost_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ValidaCpfCompletedEventHandler ValidaCpfCompleted;
        
        /// <remarks/>
        public event ValidaInssCompletedEventHandler ValidaInssCompleted;
        
        /// <remarks/>
        public event ValidaIrCompletedEventHandler ValidaIrCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidaCpf", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ValidaCpf(string cpf) {
            object[] results = this.Invoke("ValidaCpf", new object[] {
                        cpf});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ValidaCpfAsync(string cpf) {
            this.ValidaCpfAsync(cpf, null);
        }
        
        /// <remarks/>
        public void ValidaCpfAsync(string cpf, object userState) {
            if ((this.ValidaCpfOperationCompleted == null)) {
                this.ValidaCpfOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidaCpfOperationCompleted);
            }
            this.InvokeAsync("ValidaCpf", new object[] {
                        cpf}, this.ValidaCpfOperationCompleted, userState);
        }
        
        private void OnValidaCpfOperationCompleted(object arg) {
            if ((this.ValidaCpfCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidaCpfCompleted(this, new ValidaCpfCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidaInss", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double ValidaInss(double salario) {
            object[] results = this.Invoke("ValidaInss", new object[] {
                        salario});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void ValidaInssAsync(double salario) {
            this.ValidaInssAsync(salario, null);
        }
        
        /// <remarks/>
        public void ValidaInssAsync(double salario, object userState) {
            if ((this.ValidaInssOperationCompleted == null)) {
                this.ValidaInssOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidaInssOperationCompleted);
            }
            this.InvokeAsync("ValidaInss", new object[] {
                        salario}, this.ValidaInssOperationCompleted, userState);
        }
        
        private void OnValidaInssOperationCompleted(object arg) {
            if ((this.ValidaInssCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidaInssCompleted(this, new ValidaInssCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidaIr", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double ValidaIr(double salario, int dependente) {
            object[] results = this.Invoke("ValidaIr", new object[] {
                        salario,
                        dependente});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void ValidaIrAsync(double salario, int dependente) {
            this.ValidaIrAsync(salario, dependente, null);
        }
        
        /// <remarks/>
        public void ValidaIrAsync(double salario, int dependente, object userState) {
            if ((this.ValidaIrOperationCompleted == null)) {
                this.ValidaIrOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidaIrOperationCompleted);
            }
            this.InvokeAsync("ValidaIr", new object[] {
                        salario,
                        dependente}, this.ValidaIrOperationCompleted, userState);
        }
        
        private void OnValidaIrOperationCompleted(object arg) {
            if ((this.ValidaIrCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidaIrCompleted(this, new ValidaIrCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ValidaCpfCompletedEventHandler(object sender, ValidaCpfCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidaCpfCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidaCpfCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ValidaInssCompletedEventHandler(object sender, ValidaInssCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidaInssCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidaInssCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ValidaIrCompletedEventHandler(object sender, ValidaIrCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidaIrCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidaIrCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591