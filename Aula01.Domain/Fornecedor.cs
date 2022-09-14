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
		public int Id { get; private set; }
		public string Nome { get; private set; }
		public EnumTipoFornecedor TipoFornecedor { get; private set; }

		public string Documento { get; private set; }
		public bool Ativo { get; private set; }
	}
}
