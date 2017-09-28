﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marvin.Tools.Wcf.SystemTests.HelloWorld {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWorld.IHelloWorldWcfService", CallbackContract=typeof(Marvin.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IHelloWorldWcfService {
        
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldWcfServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHelloWorldWcfService/HelloCallback")]
        void HelloCallback(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldWcfService/ThrowCallback", ReplyAction="http://tempuri.org/IHelloWorldWcfService/ThrowCallbackResponse")]
        string ThrowCallback(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldWcfServiceChannel : Marvin.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldWcfServiceClient : System.ServiceModel.DuplexClientBase<Marvin.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfService>, Marvin.Tools.Wcf.SystemTests.HelloWorld.IHelloWorldWcfService {
        
        public HelloWorldWcfServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public HelloWorldWcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public HelloWorldWcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldWcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldWcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe(string clientId) {
            base.Channel.Subscribe(clientId);
        }
        
        public System.Threading.Tasks.Task SubscribeAsync(string clientId) {
            return base.Channel.SubscribeAsync(clientId);
        }
        
        public long Heartbeat(long beat) {
            return base.Channel.Heartbeat(beat);
        }
        
        public System.Threading.Tasks.Task<long> HeartbeatAsync(long beat) {
            return base.Channel.HeartbeatAsync(beat);
        }
        
        public void Unsubscribe() {
            base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync() {
            return base.Channel.UnsubscribeAsync();
        }
        
        public string Hello(string name) {
            return base.Channel.Hello(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync(string name) {
            return base.Channel.HelloAsync(name);
        }
        
        public string Throw(string name) {
            return base.Channel.Throw(name);
        }
        
        public System.Threading.Tasks.Task<string> ThrowAsync(string name) {
            return base.Channel.ThrowAsync(name);
        }
        
        public void TriggerHelloCallback(string name) {
            base.Channel.TriggerHelloCallback(name);
        }
        
        public System.Threading.Tasks.Task TriggerHelloCallbackAsync(string name) {
            return base.Channel.TriggerHelloCallbackAsync(name);
        }
        
        public void TriggerThrowCallback(string name) {
            base.Channel.TriggerThrowCallback(name);
        }
        
        public System.Threading.Tasks.Task TriggerThrowCallbackAsync(string name) {
            return base.Channel.TriggerThrowCallbackAsync(name);
        }
    }
}
