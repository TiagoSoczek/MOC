namespace Modulo14.Tests.Model
{
	using System;

	public class Produto
	{
		public delegate void EventoProduto(Produto p);
		public static event EventoProduto ProdutoForaEstoque;
		public static event Action<Produto> ProdutoVoltouNoEstoque;

		public string Nome { get; set; }
		public double Preco { get; set; }
		public DateTime DataCadastro { get; set; }

		public TimeSpan TempoDeCadastro
		{
			get { return (DateTime.Now - DataCadastro).Duration(); }
		}

		public int Quantidade { get; private set;}
		
		public bool Ativo { get; set; }

		public void AlterarQuantidade(int novaQuantidade)
		{
			if (Quantidade > 0 && novaQuantidade == 0)
			{
				if (ProdutoForaEstoque != null)
				{
					ProdutoForaEstoque(this);
				}
			}
			else if (Quantidade == 0 && novaQuantidade > 0)
			{
				if (ProdutoVoltouNoEstoque != null)
				{
					ProdutoVoltouNoEstoque(this);
				}
			}

			Quantidade = novaQuantidade;
		}

	}
}
