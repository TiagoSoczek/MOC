namespace ExemploADO.Model
{
	using System;
	using System.Collections.Generic;

	public enum CorCarro
	{
		Indefinido = 0,
		Preto = 1,
		Prata = 2
	}

	public class Carro
	{
		public int Id { get; set; }
		public Modelo Modelo { get; set; }
		public int AnoFabricacao { get; set; }
		public int AnoModelo { get; set; }
		public CorCarro Cor { get; set; }
		public DateTime CadastradoEm { get; set; }
	}
}