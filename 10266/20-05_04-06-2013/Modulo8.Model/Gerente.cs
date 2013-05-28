namespace Modulo8.Model
{
	using System;

	public class Gerente : Empregado
	{
		public Gerente(string nome, string nivel) : base(nome)
		{
			Nivel = nivel;
		}

		public string Nivel { get; set; }

		public override void RealizarAtividade()
		{
			Console.WriteLine("Atividade gerencial");
		}

		public override int CalcularFerias()
		{
			return (int)(base.CalcularFerias() * 1.5);
		}

		public override string ToString()
		{
			return string.Format("[{0}, Nivel: {1}]", base.ToString(), Nivel);
		}
	}
}