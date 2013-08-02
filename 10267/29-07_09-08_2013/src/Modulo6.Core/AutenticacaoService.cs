namespace Modulo6.Core
{
	public class AutenticacaoService
	{
		public bool Autenticar(string usuario, string senha)
		{


			if (usuario == "tiago" && senha == "123")
			{
				return true;
			}

			return false;
		}
	}
}