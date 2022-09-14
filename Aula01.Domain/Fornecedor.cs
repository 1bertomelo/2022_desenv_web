using Aula01.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
	public class Fornecedor
	{
		public Fornecedor(string nome, EnumTipoFornecedor tipoFornecedor, string documento, bool ativo)
		{
			Nome = nome;
			TipoFornecedor = tipoFornecedor;
			Documento = documento;
			Ativo = ativo;
		}

		public int Id { get; private set; }
		public string Nome { get; private set; }
		public EnumTipoFornecedor TipoFornecedor { get; private set; }

		public string Documento { get; private set; }
		public bool Ativo { get; private set; }
	}
}
