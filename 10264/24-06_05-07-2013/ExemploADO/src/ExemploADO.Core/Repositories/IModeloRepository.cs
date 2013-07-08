namespace ExemploADO.Core.Repositories
{
	using System.Collections.Generic;
	using Model;

	public interface IModeloRepository
	{
		List<Modelo> ObterTodos();
	}
}