namespace MOC10265.Model
{
	using System;
	using System.Collections.Generic;

	public class Produto
	{
		public Produto()
		{
			Departamentos = new List<Departamento>();
		}

		public int Id { get; set; }
		public byte[] Versao { get; set; }

		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public int Quantidade { get; set; }
		public bool Ativo { get; set; }
		public DateTime? DataPrimeiraCompra { get; set; }
		
		public IList<Departamento> Departamentos { get; set; }

		/*public override string ToString()
		{
			return "Produto#" + Id;
		}*/

		public override string ToString()
		{
			return string.Format("Id: {0}, Nome: {1}, Ativo: {2}", Id, Nome, Ativo);
		}

		public void AddDepartamento(Departamento departamento)
		{
			Departamentos.Add(departamento);
		}
	}
}