namespace Modulo6.Model
{
	public class Conexao
	{
		private static Conexao _atual;

		public static Conexao ObterAtual()
		{
			// Não está thread-safe!

			if (_atual == null)
			{
				_atual = new Conexao();
			}

			return _atual;
		}

		private Conexao()
		{
		}
	}
}