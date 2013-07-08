namespace ExemploADO.Core.Repositories
{
	using System.Collections.Generic;
	using Model;

	public class ModeloMemoryRepository : IModeloRepository
	{
		public List<Modelo> ObterTodos()
		{
			return new List<Modelo>
			{
				new Modelo
				{
					Marca = "Fiat",
					Nome = "Uno"
				},
				new Modelo
				{
					Marca = "Ford",
					Nome = "Fiesta"
				},
				new Modelo
				{
					Marca = "GM",
					Nome = "Chevette"
				}
			};
		}
	}
}