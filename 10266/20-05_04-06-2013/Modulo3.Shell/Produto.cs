namespace Modulo3.Shell
{
	using System;

	public class Produto
	{
		public string Nome { get; set; }
		
		public double Preco { get; set; }

		/*public static void AplicarDesconto(Produto produto)
		{
			produto.Preco = produto.Preco * 0.9;
		}*/

		public void AplicarDesconto()
		{
			if (Preco >= 2000)
			{
				var msg = string.Format("O preço deve ser menor que {0:c}", 2000);

				throw new InvalidOperationException(msg);
			}

			Preco = Preco*0.9;
		}
	}
}
