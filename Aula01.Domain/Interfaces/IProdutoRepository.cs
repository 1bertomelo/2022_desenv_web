using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain.Interfaces
{
	public interface IProdutoRepository
	{ 
		public void Adicionar(Produto produto);
		public void Atualizar(Produto produto);
		public void Remover(Guid id);
		public Produto ObterProdutoId(Guid id);
		public IEnumerable<Produto> ObterProdutoName(string name);
		public IEnumerable<Produto> ObterTodos();

	}
}
