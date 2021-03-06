﻿namespace MOC10265.Model.Services
{
	using System.Collections.Generic;
	using Repositories;

	public class CatalogoService
	{
		private readonly IProdutoRepository _produtoRepository;
		private readonly IDepartamentoRepository _departamentoRepository;

		public CatalogoService(IProdutoRepository produtoRepository, IDepartamentoRepository departamentoRepository)
		{
			_produtoRepository = produtoRepository;
			_departamentoRepository = departamentoRepository;
		}

		public List<Departamento> ObterTodosDepartamentos()
		{
			return _departamentoRepository.ObterTodos();
		}

		public List<Produto> ObterTodosProdutos()
		{
			return _produtoRepository.ObterTodos();
		}

		public Produto ObterPorId(int id)
		{
			return _produtoRepository.ObterPorId(id);
		}

		public void Remover(int id)
		{
			_produtoRepository.Remover(id);
		}

		public Produto Salvar(Produto produto)
		{
			if (produto.Id > 0)
			{
				return _produtoRepository.Atualizar(produto);
			}

			return _produtoRepository.Inserir(produto);
		}

		public List<Produto> PesquisarProdutos(string termo, int qtdeRegistros)
		{
			return _produtoRepository.PesquisarProdutos(termo, qtdeRegistros);
		}
	}
}