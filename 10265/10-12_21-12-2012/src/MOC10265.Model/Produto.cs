namespace MOC10265.Model
{
	using System;

	public class Produto
	{
		public int Id { get; set; }
		public byte[] Versao { get; set; }

		public string Nome { get; set; }
		public double Preco { get; set; }
		public int Quantidade { get; set; }
		public bool Ativo { get; set; }
		public DateTime? DataPrimeiraCompra { get; set; }

		/*public override string ToString()
		{
			return "Produto#" + Id;
		}*/

		public override string ToString()
		{
			return string.Format("Id: {0}, Nome: {1}, Ativo: {2}", Id, Nome, Ativo);
		}
	}
}