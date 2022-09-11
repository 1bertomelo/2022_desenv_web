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
		private List<Produto> ListaProduto;
		public ProdutoRepository()
		{
			ListaProduto = new List<Produto>();
			ListaProduto.Add(new Produto(1,  "X",  10M,  20));
			ListaProduto.Add(new Produto(2, "Y", 20M, 30));

		}
		public void Adicionar(Produto produto)
		{
			ListaProduto.Add(produto);
		} 

		public IEnumerable<Produto> ObterTodos()
		{
			return ListaProduto;
		}

		public void Atualizar(Produto produto)
		{
			throw new NotImplementedException();
		}

		public Produto ObterProdutoId(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Produto> ObterProdutoName(string name)
		{
			throw new NotImplementedException();
		}

		

		public void Remover(int id)
		{
			throw new NotImplementedException();
		}
	}
}
