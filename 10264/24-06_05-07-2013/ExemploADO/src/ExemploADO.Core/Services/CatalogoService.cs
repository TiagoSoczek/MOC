namespace ExemploADO.Core.Services
{
	using System;
	using System.Collections.Generic;
	using Model;
	using Repositories;

	public class CatalogoService
	{
		private readonly IModeloRepository _modeloRepository;
		private readonly ICarroRepository _carroRepository;

		public CatalogoService(ICarroRepository carroRepository, IModeloRepository modeloRepository)
		{
			_carroRepository = carroRepository;
			_modeloRepository = modeloRepository;
		}

		public List<Modelo> ObterTodosModelos()
		{
			return _modeloRepository.ObterTodos();
		}

		public List<Carro> ObterCarrosPorMarca(string marca)
		{
			if (string.IsNullOrWhiteSpace(marca))
			{
				throw new Exception("Uma marca deve ser informada");
			}

			return _carroRepository.ObterPorMarca(marca);
		}
	}
}