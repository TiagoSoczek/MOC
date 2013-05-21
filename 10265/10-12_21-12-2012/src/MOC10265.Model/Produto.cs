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

		public virtual int Id { get; set; }
		public virtual byte[] Versao { get; set; }

		public virtual string Nome { get; set; }
		public virtual decimal Preco { get; set; }
		public virtual int Quantidade { get; set; }
		public virtual bool Ativo { get; set; }
		public virtual DateTime? DataPrimeiraCompra { get; set; }

		public virtual IList<Departamento> Departamentos { get; set; }

		/*public override string ToString()
		{
			return "Produto#" + Id;
		}*/

		public override string ToString()
		{
			return string.Format("Id: {0}, Nome: {1}, Ativo: {2}", Id, Nome, Ativo);
		}

		public virtual void AddDepartamento(Departamento departamento)
		{
			Departamentos.Add(departamento);
		}
	}
}