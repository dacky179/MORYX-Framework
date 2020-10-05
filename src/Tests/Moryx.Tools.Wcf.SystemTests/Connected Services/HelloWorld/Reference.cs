﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moryx.Tools.Wcf.SystemTests.HelloWorld
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Moryx.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfService", CallbackContract=typeof(Moryx.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfServiceCallback))]
    public interface IHelloWorldWcfService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionService/Subscribe", ReplyAction="http://tempuri.org/ISessionService/SubscribeResponse")]
        void Subscribe(string clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionService/Subscribe", ReplyAction="http://tempuri.org/ISessionService/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync(string clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionService/Heartbeat", ReplyAction="http://tempuri.org/ISessionService/HeartbeatResponse")]
        long Heartbeat(long beat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionService/Heartbeat", ReplyAction="http://tempuri.org/ISessionService/HeartbeatResponse")]
        System.Threading.Tasks.Task<long> HeartbeatAsync(long beat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISessionService/Unsubscribe")]
        void Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISessionService/Unsubscribe")]
        System.Threading.Tasks.Task UnsubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldWcfService/Hello", ReplyAction="http://tempuri.org/IHelloWorldWcfService/HelloResponse")]
        string Hello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldWcfService/Hello", ReplyAction="http://tempuri.org/IHelloWorldWcfService/HelloResponse")]
        System.Threading.Tasks.Task<string> HelloAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldWcfService/Throw", ReplyAction="http://tempuri.org/IHelloWorldWcfService/ThrowResponse")]
        string Throw(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldWcfService/Throw", ReplyAction="http://tempuri.org/IHelloWorldWcfService/ThrowResponse")]
        System.Threading.Tasks.Task<string> ThrowAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/TriggerHelloCallback")]
        void TriggerHelloCallback(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/TriggerHelloCallback")]
        System.Threading.Tasks.Task TriggerHelloCallbackAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/TriggerThrowCallback")]
        void TriggerThrowCallback(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/TriggerThrowCallback")]
        System.Threading.Tasks.Task TriggerThrowCallbackAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/DeferredDisconnect")]
        void DeferredDisconnect(int waitInMs);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/DeferredDisconnect")]
        System.Threading.Tasks.Task DeferredDisconnectAsync(int waitInMs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IHelloWorldWcfServiceCallback
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/HelloCallback")]
        void HelloCallback(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldWcfService/ThrowCallback", ReplyAction="http://tempuri.org/IHelloWorldWcfService/ThrowCallbackResponse")]
        string ThrowCallback(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IHelloWorldWcfServiceChannel : Moryx.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class HelloWorldWcfServiceClientBase : System.ServiceModel.DuplexClientBase<Moryx.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfService>, Moryx.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public HelloWorldWcfServiceClientBase(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance, HelloWorldWcfServiceClientBase.GetDefaultBinding(), HelloWorldWcfServiceClientBase.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IHelloWorldWcfService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloWorldWcfServiceClientBase(System.ServiceModel.InstanceContext callbackInstance, EndpointConfiguration endpointConfiguration) : 
                base(callbackInstance, HelloWorldWcfServiceClientBase.GetBindingForEndpoint(endpointConfiguration), HelloWorldWcfServiceClientBase.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloWorldWcfServiceClientBase(System.ServiceModel.InstanceContext callbackInstance, EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(callbackInstance, HelloWorldWcfServiceClientBase.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloWorldWcfServiceClientBase(System.ServiceModel.InstanceContext callbackInstance, EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, HelloWorldWcfServiceClientBase.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HelloWorldWcfServiceClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress)
        {
        }
        
        public void Subscribe(string clientId)
        {
            base.Channel.Subscribe(clientId);
        }
        
        public System.Threading.Tasks.Task SubscribeAsync(string clientId)
        {
            return base.Channel.SubscribeAsync(clientId);
        }
        
        public long Heartbeat(long beat)
        {
            return base.Channel.Heartbeat(beat);
        }
        
        public System.Threading.Tasks.Task<long> HeartbeatAsync(long beat)
        {
            return base.Channel.HeartbeatAsync(beat);
        }
        
        public void Unsubscribe()
        {
            base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync()
        {
            return base.Channel.UnsubscribeAsync();
        }
        
        public string Hello(string name)
        {
            return base.Channel.Hello(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync(string name)
        {
            return base.Channel.HelloAsync(name);
        }
        
        public string Throw(string name)
        {
            return base.Channel.Throw(name);
        }
        
        public System.Threading.Tasks.Task<string> ThrowAsync(string name)
        {
            return base.Channel.ThrowAsync(name);
        }
        
        public void TriggerHelloCallback(string name)
        {
            base.Channel.TriggerHelloCallback(name);
        }
        
        public System.Threading.Tasks.Task TriggerHelloCallbackAsync(string name)
        {
            return base.Channel.TriggerHelloCallbackAsync(name);
        }
        
        public void TriggerThrowCallback(string name)
        {
            base.Channel.TriggerThrowCallback(name);
        }
        
        public System.Threading.Tasks.Task TriggerThrowCallbackAsync(string name)
        {
            return base.Channel.TriggerThrowCallbackAsync(name);
        }
        
        public void DeferredDisconnect(int waitInMs)
        {
            base.Channel.DeferredDisconnect(waitInMs);
        }
        
        public System.Threading.Tasks.Task DeferredDisconnectAsync(int waitInMs)
        {
            return base.Channel.DeferredDisconnectAsync(waitInMs);
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
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IHelloWorldWcfService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IHelloWorldWcfService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://pxc-n2488:816/HelloWorldWcfService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return HelloWorldWcfServiceClientBase.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IHelloWorldWcfService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return HelloWorldWcfServiceClientBase.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IHelloWorldWcfService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IHelloWorldWcfService,
        }
    }
    
    public class HelloCallbackReceivedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        
        private object[] results;
        
        public HelloCallbackReceivedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState)
        {
            this.results = results;
        }
        
        public string message
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    public class ThrowCallbackReceivedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        
        private object[] results;
        
        public ThrowCallbackReceivedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState)
        {
            this.results = results;
        }
        
        public string message
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    public partial class HelloWorldWcfServiceClient : HelloWorldWcfServiceClientBase
    {
        
        public HelloWorldWcfServiceClient(EndpointConfiguration endpointConfiguration) : 
                this(new HelloWorldWcfServiceClientCallback(), endpointConfiguration)
        {
        }
        
        private HelloWorldWcfServiceClient(HelloWorldWcfServiceClientCallback callbackImpl, EndpointConfiguration endpointConfiguration) : 
                base(new System.ServiceModel.InstanceContext(callbackImpl), endpointConfiguration)
        {
            callbackImpl.Initialize(this);
        }
        
        public HelloWorldWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                this(new HelloWorldWcfServiceClientCallback(), binding, remoteAddress)
        {
        }
        
        private HelloWorldWcfServiceClient(HelloWorldWcfServiceClientCallback callbackImpl, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(new System.ServiceModel.InstanceContext(callbackImpl), binding, remoteAddress)
        {
            callbackImpl.Initialize(this);
        }
        
        public HelloWorldWcfServiceClient() : 
                this(new HelloWorldWcfServiceClientCallback())
        {
        }
        
        private HelloWorldWcfServiceClient(HelloWorldWcfServiceClientCallback callbackImpl) : 
                base(new System.ServiceModel.InstanceContext(callbackImpl))
        {
            callbackImpl.Initialize(this);
        }
        
        public event System.EventHandler<HelloCallbackReceivedEventArgs> HelloCallbackReceived;
        
        public event System.EventHandler<ThrowCallbackReceivedEventArgs> ThrowCallbackReceived;
        
        private void OnHelloCallbackReceived(object state)
        {
            if ((this.HelloCallbackReceived != null))
            {
                object[] results = ((object[])(state));
                this.HelloCallbackReceived(this, new HelloCallbackReceivedEventArgs(results, null, false, null));
            }
        }
        
        private void OnThrowCallbackReceived(object state)
        {
            if ((this.ThrowCallbackReceived != null))
            {
                object[] results = ((object[])(state));
                this.ThrowCallbackReceived(this, new ThrowCallbackReceivedEventArgs(results, null, false, null));
            }
        }
        
        private class HelloWorldWcfServiceClientCallback : object, IHelloWorldWcfServiceCallback
        {
            
            private HelloWorldWcfServiceClient proxy;
            
            public void Initialize(HelloWorldWcfServiceClient proxy)
            {
                this.proxy = proxy;
            }
            
            public void HelloCallback(string message)
            {
                this.proxy.OnHelloCallbackReceived(new object[] {
                            message});
            }
            
            public string ThrowCallback(string message)
            {
                this.proxy.OnThrowCallbackReceived(new object[] {
                            message});
                return default(string);
            }
        }
    }
}
