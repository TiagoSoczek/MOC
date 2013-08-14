namespace Modulo12.ClientWithoutWsdl
{
	using System.ServiceModel;
	using Model;
	using Model.Services;

	public class CatalogoServiceClient : ClientBase<ICatalogoService>, ICatalogoService
	{
		public string ObterDescricaoProduto(int idProduto)
		{
			return Channel.ObterDescricaoProduto(idProduto);
		}

		public ProdutoDto SalvarProduto(ProdutoDto produto)
		{
			return Channel.SalvarProduto(produto);
		}
	}
}