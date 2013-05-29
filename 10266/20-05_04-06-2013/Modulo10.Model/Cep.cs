namespace Modulo10.Model
{
	public class Cep
	{
		public string Valor { get; set; }

		public static implicit operator string(Cep cep)
		{
			return cep.Valor;
		}

		public static implicit operator Cep(string cep)
		{
			return new Cep
				{
					Valor = cep
				};
		}
	}
}