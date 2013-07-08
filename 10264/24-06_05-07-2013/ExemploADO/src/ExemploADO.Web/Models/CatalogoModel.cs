namespace ExemploADO.Web.Models
{
	using System.Collections.Generic;
	using Model;

	public class CatalogoModel
	{
		public CatalogoModel()
		{
			Modelos = new List<Modelo>();
			Carros = new List<Carro>();
		}

		public List<Modelo> Modelos { get; set; }
		public string Marca { get; set; }
		public List<Carro> Carros { get; set; }
	}
}