using Aula01.Domain;
using Aula01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Data.Repository
{
	public class ProdutoRepository : IProdutoRepository
	{
		private readonly GestaoProdutoContext _context;

		public ProdutoRepository(GestaoProdutoContext context)
		{
			_context = context;
		}

		public void Adicionar(Produto produto)
		{
			_context.Produtos.Add(produto);
			Gravar();
		} 

		public IEnumerable<Produto> ObterTodos()
		{
			return _context.Produtos.ToList();
		}

		public void Atualizar(Produto produto)
		{
			_context.Produtos.Update(produto);
			Gravar();
		}

		public Produto ObterProdutoId(Guid id)
		{
			return _context.Produtos.Where(p => p.Id == id).FirstOrDefault();
		}

		public IEnumerable<Produto> ObterProdutoName(string name)
		{
			return _context.Produtos.Where(p => p.Nome == name);
		}

		

		public void Remover(Guid id)
		{
			_context.Remove(id);
		}

		private void Gravar()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
