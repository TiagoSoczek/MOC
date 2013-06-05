namespace ExemploNH.Model
{
	using System;

	public class Produto
	{
		public virtual int Id { get; set; }
		public virtual string Nome { get; set; }
		public virtual double Preco { get; set; }
		public virtual int Quantidade { get; set; }
		public virtual DateTime DataCadastro { get; set; }
	}
}