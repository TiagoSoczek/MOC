namespace Modulo9.Shell
{
	using System;

	public class Arquivo : IDisposable
	{
		private byte[] _conteudo;

		public Arquivo()
		{
			Console.WriteLine("CTOR");
			_conteudo = new byte[1024*1024];
		}

		~Arquivo()
		{
			Console.WriteLine("Destrutor");
		}

		public void Dispose()
		{
			Console.WriteLine("Dispose");
			GC.SuppressFinalize(this);
		}
	}
}