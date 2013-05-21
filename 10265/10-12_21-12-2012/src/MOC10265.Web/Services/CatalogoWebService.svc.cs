using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MOC10265.Web.Services
{
	using Model;
	using Model.Repositories;
	using Model.Services;
	using Persistence.EF;

	public class CatalogoWebService : ICatalogoWebService
	{
		private CatalogoService _service;

		public CatalogoWebService()
		{
			IProdutoRepository produtoRepository = new ProdutoEFRepository();
			IDepartamentoRepository departamentoRepository = new DepartamentoEFRepository();

			_service = new CatalogoService(produtoRepository, departamentoRepository);
		}

		public List<Produto> PesquisarProdutos(string termo, int qtdeRegistros)
		{
			return _service.PesquisarProdutos(termo, qtdeRegistros);
		}
	}
}
