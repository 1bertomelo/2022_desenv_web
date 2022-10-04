using Aula01.Domain;
using Aula01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Data.Repository
{
	public class FornecedorRepository : IFornecedorRepository
	{ //operações > Interfaces
		List<Fornecedor> fornecedores = new List<Fornecedor>();
		public FornecedorRepository()
		{
			//fornecedores.Add(new Fornecedor());
			//fornecedores.Add(new Fornecedor());
		}
		public void Adicionar(Fornecedor fornecedor)
		{
			fornecedores.Add(fornecedor);
		}
		public IEnumerable<Fornecedor> ObterTodosFornecedores()
		{
			return fornecedores;
		}

		public void Ativar(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}

		public void Atualizar(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}

		public void Inativar(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}

		public Fornecedor ObterFornecedor(int id)
		{
			throw new NotImplementedException();
		}

		
	}
}
