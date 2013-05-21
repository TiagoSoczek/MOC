using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MOC10265.Web.Services
{
	using Model;

	[ServiceContract]
	public interface ICatalogoWebService
	{
		[OperationContract]
		List<Produto> PesquisarProdutos(string termo, int qtdeRegistros);
	}
}
