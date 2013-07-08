namespace ExemploADO.Core.Repositories
{
	using System.Collections.Generic;
	using System.Linq;
	using Dapper;
	using Model;

	public class CarroDapperRepository : BaseRepository, ICarroRepository
	{
		public List<Carro> ObterPorMarca(string marca)
		{
			using (var con = ObterConexao())
			{
				string sql = @"SELECT * FROM Carro C
	INNER JOIN Modelo M
		ON C.IdModelo = M.Id
WHERE
	M.Marca LIKE @marca";
				var carros = con.Query<Carro>(sql, new { marca = marca });

				// TODO: modelo == null

				return carros.ToList();
			}
		}
	}
}