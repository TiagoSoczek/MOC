﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modulo12.Web.Servicos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servicos.IControleAcessoService")]
    public interface IControleAcessoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControleAcessoService/Validar", ReplyAction="http://tempuri.org/IControleAcessoService/ValidarResponse")]
        bool Validar(string nome, string senha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControleAcessoService/ValidarNome", ReplyAction="http://tempuri.org/IControleAcessoService/ValidarNomeResponse")]
        bool ValidarNome(string nome);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControleAcessoServiceChannel : Modulo12.Web.Servicos.IControleAcessoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControleAcessoServiceClient : System.ServiceModel.ClientBase<Modulo12.Web.Servicos.IControleAcessoService>, Modulo12.Web.Servicos.IControleAcessoService {
        
        public ControleAcessoServiceClient() {
        }
        
        public ControleAcessoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ControleAcessoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControleAcessoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControleAcessoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Validar(string nome, string senha) {
            return base.Channel.Validar(nome, senha);
        }
        
        public bool ValidarNome(string nome) {
            return base.Channel.ValidarNome(nome);
        }
    }
}
