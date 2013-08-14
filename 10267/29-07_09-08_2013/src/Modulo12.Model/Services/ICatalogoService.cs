namespace Modulo12.Model.Services
{
	using System.ServiceModel;

	// [ServiceContract(Namespace = "http://soa.wise.com.br/")]
	[ServiceContract]
	public interface ICatalogoService
	{
		[OperationContract]
		string ObterDescricaoProduto(int idProduto);

		[OperationContract]
		ProdutoDto SalvarProduto(ProdutoDto produto);
	}
}