using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Modulo12.Servicos
{
    [ServiceContract]
    public interface IControleAcessoService
    {
        [OperationContract]
        bool Validar(string nome, string senha);

        [OperationContract]
        bool ValidarNome(string nome);
    }
}
