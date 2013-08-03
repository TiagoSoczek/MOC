namespace Modulo6.Core
{
	using System.Diagnostics;

	public class AutenticacaoService
	{
		public bool Autenticar(string usuario, string senha)
		{
			Trace.WriteLine("Usuário: " + usuario);
			Trace.WriteLine("Senha: " + usuario);

			if (usuario == "tiago" && senha == "123")
			{
				return true;
			}

			Trace.TraceError("Usuário ou senha inválidos");

			return false;
		}
	}
}