﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapNotify
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NotificationDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Notifi" +
        "cations")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SoapNotify.ErrorDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SoapNotify.MsgLogDTO))]
    public partial class NotificationDTO : object
    {
        
        private System.Nullable<System.DateTime> AddDateField;
        
        private string DescriptionField;
        
        private SoapNotify.DictionaryItemDTO EndpointField;
        
        private bool GhostField;
        
        private int IDField;
        
        private string InfoPKField;
        
        private System.Collections.Generic.KeyValuePair<string, string>[] KeyValueField;
        
        private System.DateTime OccuranceDateField;
        
        private string SourceIPField;
        
        private SoapNotify.DictionaryItemDTO SystemField;
        
        private string UserField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> AddDate
        {
            get
            {
                return this.AddDateField;
            }
            set
            {
                this.AddDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoapNotify.DictionaryItemDTO Endpoint
        {
            get
            {
                return this.EndpointField;
            }
            set
            {
                this.EndpointField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Ghost
        {
            get
            {
                return this.GhostField;
            }
            set
            {
                this.GhostField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InfoPK
        {
            get
            {
                return this.InfoPKField;
            }
            set
            {
                this.InfoPKField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.KeyValuePair<string, string>[] KeyValue
        {
            get
            {
                return this.KeyValueField;
            }
            set
            {
                this.KeyValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OccuranceDate
        {
            get
            {
                return this.OccuranceDateField;
            }
            set
            {
                this.OccuranceDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SourceIP
        {
            get
            {
                return this.SourceIPField;
            }
            set
            {
                this.SourceIPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoapNotify.DictionaryItemDTO System
        {
            get
            {
                return this.SystemField;
            }
            set
            {
                this.SystemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DictionaryItemDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Dictio" +
        "naries")]
    public partial class DictionaryItemDTO : object
    {
        
        private string CodeField;
        
        private bool GhostField;
        
        private int IDField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Ghost
        {
            get
            {
                return this.GhostField;
            }
            set
            {
                this.GhostField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Notifi" +
        "cations")]
    public partial class ErrorDTO : SoapNotify.NotificationDTO
    {
        
        private string ErrorMessageField;
        
        private string StackTraceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessageField;
            }
            set
            {
                this.ErrorMessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace
        {
            get
            {
                return this.StackTraceField;
            }
            set
            {
                this.StackTraceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MsgLogDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Notifi" +
        "cations")]
    public partial class MsgLogDTO : SoapNotify.NotificationDTO
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions")]
    public partial class ResultDTO : object
    {
        
        private string ErrorDescField;
        
        private SoapNotify.ErrorCode ErrorTypeField;
        
        private bool IsOKField;
        
        private string MessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDesc
        {
            get
            {
                return this.ErrorDescField;
            }
            set
            {
                this.ErrorDescField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoapNotify.ErrorCode ErrorType
        {
            get
            {
                return this.ErrorTypeField;
            }
            set
            {
                this.ErrorTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOK
        {
            get
            {
                return this.IsOKField;
            }
            set
            {
                this.IsOKField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Enums")]
    public enum ErrorCode : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BrakBledu = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        A01_BladAutentykacji = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        A02_BladAutoryzacji = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        A03_Exception = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        A04_BledneParametryWejsciowe = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NotificationListsDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Notifi" +
        "cations")]
    public partial class NotificationListsDTO : object
    {
        
        private SoapNotify.ErrorDTO[] ErrorsField;
        
        private SoapNotify.MsgLogDTO[] MsgsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoapNotify.ErrorDTO[] Errors
        {
            get
            {
                return this.ErrorsField;
            }
            set
            {
                this.ErrorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoapNotify.MsgLogDTO[] Msgs
        {
            get
            {
                return this.MsgsField;
            }
            set
            {
                this.MsgsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatListDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Stats")]
    public partial class StatListDTO : object
    {
        
        private SoapNotify.StatDTO[] StatsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoapNotify.StatDTO[] Stats
        {
            get
            {
                return this.StatsField;
            }
            set
            {
                this.StatsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatDTO", Namespace="http://schemas.datacontract.org/2004/07/MonitoringManager_PROD.Definitions.Stats")]
    public partial class StatDTO : object
    {
        
        private int CountField;
        
        private System.DateTime DateFromField;
        
        private System.DateTime DateToField;
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count
        {
            get
            {
                return this.CountField;
            }
            set
            {
                this.CountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateFrom
        {
            get
            {
                return this.DateFromField;
            }
            set
            {
                this.DateFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTo
        {
            get
            {
                return this.DateToField;
            }
            set
            {
                this.DateToField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoapNotify.INotify")]
    public interface INotify
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotify/AddNotification", ReplyAction="http://tempuri.org/INotify/AddNotificationResponse")]
        System.Threading.Tasks.Task<SoapNotify.ResultDTO> AddNotificationAsync(SoapNotify.NotificationDTO notification, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotify/GetAllNotifications", ReplyAction="http://tempuri.org/INotify/GetAllNotificationsResponse")]
        System.Threading.Tasks.Task<SoapNotify.NotificationListsDTO> GetAllNotificationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotify/ClearLastNotifications", ReplyAction="http://tempuri.org/INotify/ClearLastNotificationsResponse")]
        System.Threading.Tasks.Task<SoapNotify.ResultDTO> ClearLastNotificationsAsync(bool clearErrors, bool clearMsgs, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotify/GetStats", ReplyAction="http://tempuri.org/INotify/GetStatsResponse")]
        System.Threading.Tasks.Task<SoapNotify.StatListDTO> GetStatsAsync(int interval, int count, string hash);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public interface INotifyChannel : SoapNotify.INotify, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.4.0.0")]
    public partial class NotifyClient : System.ServiceModel.ClientBase<SoapNotify.INotify>, SoapNotify.INotify
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NotifyClient() : 
                base(NotifyClient.GetDefaultBinding(), NotifyClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INotify.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotifyClient(EndpointConfiguration endpointConfiguration) : 
                base(NotifyClient.GetBindingForEndpoint(endpointConfiguration), NotifyClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotifyClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NotifyClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotifyClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NotifyClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotifyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<SoapNotify.ResultDTO> AddNotificationAsync(SoapNotify.NotificationDTO notification, string hash)
        {
            return base.Channel.AddNotificationAsync(notification, hash);
        }
        
        public System.Threading.Tasks.Task<SoapNotify.NotificationListsDTO> GetAllNotificationsAsync()
        {
            return base.Channel.GetAllNotificationsAsync();
        }
        
        public System.Threading.Tasks.Task<SoapNotify.ResultDTO> ClearLastNotificationsAsync(bool clearErrors, bool clearMsgs, string hash)
        {
            return base.Channel.ClearLastNotificationsAsync(clearErrors, clearMsgs, hash);
        }
        
        public System.Threading.Tasks.Task<SoapNotify.StatListDTO> GetStatsAsync(int interval, int count, string hash)
        {
            return base.Channel.GetStatsAsync(interval, count, hash);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INotify))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INotify))
            {
                return new System.ServiceModel.EndpointAddress("http://10.0.0.2/Notify.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return NotifyClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INotify);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return NotifyClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INotify);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INotify,
        }
    }
}
