namespace Modulo8.Model
{
	using System;

	public class Operario : Empregado
	{
		public Operario(string nome) : base(nome)
		{
		}

		public override void RealizarAtividade()
		{
			Console.WriteLine("CornoJob");
		}

		public override int CalcularFerias()
		{
			return (int) (base.CalcularFerias() * 0.5);
		}
	}
}