namespace ExemploADO.Tests
{
	using System;
	using Core.Repositories;
	using Core.Services;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class CatalogoServiceTestCase
	{
		[TestMethod]
		public void ObterTodosModelos()
		{
			ICarroRepository carroRepository = new CarroRepository();
			IModeloRepository modeloRepository = new ModeloDapperRepository();

			var catalogoService = new CatalogoService(carroRepository, modeloRepository);

			var modelos = catalogoService.ObterTodosModelos();

			foreach (var modelo in modelos)
			{
				Console.WriteLine(modelo);
			}
		}
	}
}