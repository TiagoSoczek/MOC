namespace ExemploADO.Core.Repositories
{
	using System.Collections.Generic;
	using System.Linq;
	using Dapper;
	using Model;

	public class ModeloDapperRepository : BaseRepository, IModeloRepository
	{
		public List<Modelo> ObterTodos()
		{
			using (var conn = ObterConexao())
			{
				var modelos = conn.Query<Modelo>("SELECT * FROM Modelo");

				return modelos.ToList();
			}
		}
	}
}