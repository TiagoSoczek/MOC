namespace Modulo8.Model
{
	public abstract class Empregado
	{
		public Empregado(string nome)
		{
			Nome = nome;
		}

		public string Nome { get; set; }
		public string Email { get; set; }

		public abstract void RealizarAtividade();

		public virtual int CalcularFerias()
		{
			return 30;
		}

		public override string ToString()
		{
			return string.Format("[Nome: {0}, Email: {1}]", Nome, Email);
		}
	}
}