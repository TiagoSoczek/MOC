namespace Modulo12.Core.Services
{
	using System;
	using Model;
	using Model.Services;
	using NLog;

	public class CatalogoService : ICatalogoService
	{
		private Logger _logger = LogManager.GetCurrentClassLogger();

		public string ObterDescricaoProduto(int idProduto)
		{
			_logger.Debug("ObterDescricaoProduto: " + idProduto);

			return "Descrição qualquer do produto " + idProduto;
		}

		public ProdutoDto SalvarProduto(ProdutoDto produto)
		{
			_logger.Debug("SalvarProduto: " + produto);

			if (produto == null)
			{
				_logger.Error("Produto NULO");

				throw new ArgumentNullException("produto");
			}

			produto.Id = new Random().Next();

			_logger.Info("Produto Salvo com sucesso. Id: " + produto.Id);

			return produto;
		}
	}
}