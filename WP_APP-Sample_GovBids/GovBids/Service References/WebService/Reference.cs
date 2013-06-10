﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace GovBids.WebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.AvailBidsSoap")]
    public interface AvailBidsSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetBids", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetBids(string agency, string category, string location, string title, System.AsyncCallback callback, object asyncState);
        
        string EndGetBids(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetBidIds", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetBidIds(string agency, string category, string location, string title, System.AsyncCallback callback, object asyncState);
        
        string EndGetBidIds(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetCategories", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetCategories(System.AsyncCallback callback, object asyncState);
        
        string EndGetCategories(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetAgencies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetAgencies(System.AsyncCallback callback, object asyncState);
        
        string EndGetAgencies(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetLocations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetLocations(System.AsyncCallback callback, object asyncState);
        
        string EndGetLocations(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AvailBidsSoapChannel : GovBids.WebService.AvailBidsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetBidsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetBidsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetBidIdsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetBidIdsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCategoriesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCategoriesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAgenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAgenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetLocationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetLocationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AvailBidsSoapClient : System.ServiceModel.ClientBase<GovBids.WebService.AvailBidsSoap>, GovBids.WebService.AvailBidsSoap {
        
        private BeginOperationDelegate onBeginGetBidsDelegate;
        
        private EndOperationDelegate onEndGetBidsDelegate;
        
        private System.Threading.SendOrPostCallback onGetBidsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetBidIdsDelegate;
        
        private EndOperationDelegate onEndGetBidIdsDelegate;
        
        private System.Threading.SendOrPostCallback onGetBidIdsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetCategoriesDelegate;
        
        private EndOperationDelegate onEndGetCategoriesDelegate;
        
        private System.Threading.SendOrPostCallback onGetCategoriesCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAgenciesDelegate;
        
        private EndOperationDelegate onEndGetAgenciesDelegate;
        
        private System.Threading.SendOrPostCallback onGetAgenciesCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetLocationsDelegate;
        
        private EndOperationDelegate onEndGetLocationsDelegate;
        
        private System.Threading.SendOrPostCallback onGetLocationsCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public AvailBidsSoapClient() {
        }
        
        public AvailBidsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AvailBidsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AvailBidsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AvailBidsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetBidsCompletedEventArgs> GetBidsCompleted;
        
        public event System.EventHandler<GetBidIdsCompletedEventArgs> GetBidIdsCompleted;
        
        public event System.EventHandler<GetCategoriesCompletedEventArgs> GetCategoriesCompleted;
        
        public event System.EventHandler<GetAgenciesCompletedEventArgs> GetAgenciesCompleted;
        
        public event System.EventHandler<GetLocationsCompletedEventArgs> GetLocationsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GovBids.WebService.AvailBidsSoap.BeginGetBids(string agency, string category, string location, string title, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetBids(agency, category, location, title, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string GovBids.WebService.AvailBidsSoap.EndGetBids(System.IAsyncResult result) {
            return base.Channel.EndGetBids(result);
        }
        
        private System.IAsyncResult OnBeginGetBids(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string agency = ((string)(inValues[0]));
            string category = ((string)(inValues[1]));
            string location = ((string)(inValues[2]));
            string title = ((string)(inValues[3]));
            return ((GovBids.WebService.AvailBidsSoap)(this)).BeginGetBids(agency, category, location, title, callback, asyncState);
        }
        
        private object[] OnEndGetBids(System.IAsyncResult result) {
            string retVal = ((GovBids.WebService.AvailBidsSoap)(this)).EndGetBids(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetBidsCompleted(object state) {
            if ((this.GetBidsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetBidsCompleted(this, new GetBidsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetBidsAsync(string agency, string category, string location, string title) {
            this.GetBidsAsync(agency, category, location, title, null);
        }
        
        public void GetBidsAsync(string agency, string category, string location, string title, object userState) {
            if ((this.onBeginGetBidsDelegate == null)) {
                this.onBeginGetBidsDelegate = new BeginOperationDelegate(this.OnBeginGetBids);
            }
            if ((this.onEndGetBidsDelegate == null)) {
                this.onEndGetBidsDelegate = new EndOperationDelegate(this.OnEndGetBids);
            }
            if ((this.onGetBidsCompletedDelegate == null)) {
                this.onGetBidsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetBidsCompleted);
            }
            base.InvokeAsync(this.onBeginGetBidsDelegate, new object[] {
                        agency,
                        category,
                        location,
                        title}, this.onEndGetBidsDelegate, this.onGetBidsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GovBids.WebService.AvailBidsSoap.BeginGetBidIds(string agency, string category, string location, string title, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetBidIds(agency, category, location, title, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string GovBids.WebService.AvailBidsSoap.EndGetBidIds(System.IAsyncResult result) {
            return base.Channel.EndGetBidIds(result);
        }
        
        private System.IAsyncResult OnBeginGetBidIds(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string agency = ((string)(inValues[0]));
            string category = ((string)(inValues[1]));
            string location = ((string)(inValues[2]));
            string title = ((string)(inValues[3]));
            return ((GovBids.WebService.AvailBidsSoap)(this)).BeginGetBidIds(agency, category, location, title, callback, asyncState);
        }
        
        private object[] OnEndGetBidIds(System.IAsyncResult result) {
            string retVal = ((GovBids.WebService.AvailBidsSoap)(this)).EndGetBidIds(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetBidIdsCompleted(object state) {
            if ((this.GetBidIdsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetBidIdsCompleted(this, new GetBidIdsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetBidIdsAsync(string agency, string category, string location, string title) {
            this.GetBidIdsAsync(agency, category, location, title, null);
        }
        
        public void GetBidIdsAsync(string agency, string category, string location, string title, object userState) {
            if ((this.onBeginGetBidIdsDelegate == null)) {
                this.onBeginGetBidIdsDelegate = new BeginOperationDelegate(this.OnBeginGetBidIds);
            }
            if ((this.onEndGetBidIdsDelegate == null)) {
                this.onEndGetBidIdsDelegate = new EndOperationDelegate(this.OnEndGetBidIds);
            }
            if ((this.onGetBidIdsCompletedDelegate == null)) {
                this.onGetBidIdsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetBidIdsCompleted);
            }
            base.InvokeAsync(this.onBeginGetBidIdsDelegate, new object[] {
                        agency,
                        category,
                        location,
                        title}, this.onEndGetBidIdsDelegate, this.onGetBidIdsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GovBids.WebService.AvailBidsSoap.BeginGetCategories(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCategories(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string GovBids.WebService.AvailBidsSoap.EndGetCategories(System.IAsyncResult result) {
            return base.Channel.EndGetCategories(result);
        }
        
        private System.IAsyncResult OnBeginGetCategories(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((GovBids.WebService.AvailBidsSoap)(this)).BeginGetCategories(callback, asyncState);
        }
        
        private object[] OnEndGetCategories(System.IAsyncResult result) {
            string retVal = ((GovBids.WebService.AvailBidsSoap)(this)).EndGetCategories(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCategoriesCompleted(object state) {
            if ((this.GetCategoriesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCategoriesCompleted(this, new GetCategoriesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCategoriesAsync() {
            this.GetCategoriesAsync(null);
        }
        
        public void GetCategoriesAsync(object userState) {
            if ((this.onBeginGetCategoriesDelegate == null)) {
                this.onBeginGetCategoriesDelegate = new BeginOperationDelegate(this.OnBeginGetCategories);
            }
            if ((this.onEndGetCategoriesDelegate == null)) {
                this.onEndGetCategoriesDelegate = new EndOperationDelegate(this.OnEndGetCategories);
            }
            if ((this.onGetCategoriesCompletedDelegate == null)) {
                this.onGetCategoriesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCategoriesCompleted);
            }
            base.InvokeAsync(this.onBeginGetCategoriesDelegate, null, this.onEndGetCategoriesDelegate, this.onGetCategoriesCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GovBids.WebService.AvailBidsSoap.BeginGetAgencies(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAgencies(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string GovBids.WebService.AvailBidsSoap.EndGetAgencies(System.IAsyncResult result) {
            return base.Channel.EndGetAgencies(result);
        }
        
        private System.IAsyncResult OnBeginGetAgencies(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((GovBids.WebService.AvailBidsSoap)(this)).BeginGetAgencies(callback, asyncState);
        }
        
        private object[] OnEndGetAgencies(System.IAsyncResult result) {
            string retVal = ((GovBids.WebService.AvailBidsSoap)(this)).EndGetAgencies(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAgenciesCompleted(object state) {
            if ((this.GetAgenciesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAgenciesCompleted(this, new GetAgenciesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAgenciesAsync() {
            this.GetAgenciesAsync(null);
        }
        
        public void GetAgenciesAsync(object userState) {
            if ((this.onBeginGetAgenciesDelegate == null)) {
                this.onBeginGetAgenciesDelegate = new BeginOperationDelegate(this.OnBeginGetAgencies);
            }
            if ((this.onEndGetAgenciesDelegate == null)) {
                this.onEndGetAgenciesDelegate = new EndOperationDelegate(this.OnEndGetAgencies);
            }
            if ((this.onGetAgenciesCompletedDelegate == null)) {
                this.onGetAgenciesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAgenciesCompleted);
            }
            base.InvokeAsync(this.onBeginGetAgenciesDelegate, null, this.onEndGetAgenciesDelegate, this.onGetAgenciesCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GovBids.WebService.AvailBidsSoap.BeginGetLocations(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetLocations(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string GovBids.WebService.AvailBidsSoap.EndGetLocations(System.IAsyncResult result) {
            return base.Channel.EndGetLocations(result);
        }
        
        private System.IAsyncResult OnBeginGetLocations(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((GovBids.WebService.AvailBidsSoap)(this)).BeginGetLocations(callback, asyncState);
        }
        
        private object[] OnEndGetLocations(System.IAsyncResult result) {
            string retVal = ((GovBids.WebService.AvailBidsSoap)(this)).EndGetLocations(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetLocationsCompleted(object state) {
            if ((this.GetLocationsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetLocationsCompleted(this, new GetLocationsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetLocationsAsync() {
            this.GetLocationsAsync(null);
        }
        
        public void GetLocationsAsync(object userState) {
            if ((this.onBeginGetLocationsDelegate == null)) {
                this.onBeginGetLocationsDelegate = new BeginOperationDelegate(this.OnBeginGetLocations);
            }
            if ((this.onEndGetLocationsDelegate == null)) {
                this.onEndGetLocationsDelegate = new EndOperationDelegate(this.OnEndGetLocations);
            }
            if ((this.onGetLocationsCompletedDelegate == null)) {
                this.onGetLocationsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetLocationsCompleted);
            }
            base.InvokeAsync(this.onBeginGetLocationsDelegate, null, this.onEndGetLocationsDelegate, this.onGetLocationsCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override GovBids.WebService.AvailBidsSoap CreateChannel() {
            return new AvailBidsSoapClientChannel(this);
        }
        
        private class AvailBidsSoapClientChannel : ChannelBase<GovBids.WebService.AvailBidsSoap>, GovBids.WebService.AvailBidsSoap {
            
            public AvailBidsSoapClientChannel(System.ServiceModel.ClientBase<GovBids.WebService.AvailBidsSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetBids(string agency, string category, string location, string title, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[4];
                _args[0] = agency;
                _args[1] = category;
                _args[2] = location;
                _args[3] = title;
                System.IAsyncResult _result = base.BeginInvoke("GetBids", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetBids(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetBids", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetBidIds(string agency, string category, string location, string title, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[4];
                _args[0] = agency;
                _args[1] = category;
                _args[2] = location;
                _args[3] = title;
                System.IAsyncResult _result = base.BeginInvoke("GetBidIds", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetBidIds(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetBidIds", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetCategories(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetCategories", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetCategories(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetCategories", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetAgencies(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAgencies", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetAgencies(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetAgencies", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetLocations(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetLocations", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetLocations(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetLocations", _args, result)));
                return _result;
            }
        }
    }
}
