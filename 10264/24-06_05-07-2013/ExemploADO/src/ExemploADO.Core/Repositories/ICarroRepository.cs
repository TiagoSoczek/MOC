namespace ExemploADO.Core.Repositories
{
	using System.Collections.Generic;
	using System.Net.Configuration;
	using Model;

	public interface ICarroRepository
	{
		List<Carro> ObterPorMarca(string marca);
	}
}