namespace MOC10265.Persistence.EF
{
	using System.Collections.Generic;
	using System.Linq;
	using Model;
	using Model.Repositories;

	public class DepartamentoEFRepository : IDepartamentoRepository
	{
		public List<Departamento> ObterTodos()
		{
			using (var contexto = new CatalogoContextoDb())
			{
				return contexto.Linq<Departamento>().ToList();
			}
		}
	}
}