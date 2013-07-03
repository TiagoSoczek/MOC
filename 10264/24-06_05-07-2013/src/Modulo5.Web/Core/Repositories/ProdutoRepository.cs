namespace Modulo5.Web.Core.Repositories
{
	using System;
	using System.Collections.Generic;
	using Areas.Admin.Models;

	public class ProdutoRepository
	{
		public List<Produto> ObterTodos()
		{
			List<Produto> produtos = new List<Produto>();
			var agora = DateTime.Now;
			Random rnd = new Random();

			for (int i = 0; i < rnd.Next(50, 100); i++)
			{
				Produto p = new Produto();

				p.Id = rnd.Next(i, 100);
				p.Nome = "Produto#" + rnd.Next(i, 1000);
				p.Preco = rnd.Next(1, 500);
				p.Quantidade = rnd.Next(i, 100);
				p.DataCadastro = agora.AddHours(-i);

				produtos.Add(p);
			}

			return produtos;
		}

	}
}