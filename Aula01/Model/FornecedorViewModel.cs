using Aula01.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Aula01.Model
{
	public class FornecedorViewModel
	{
		public int Id { get;  set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public string Nome { get;  set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public EnumTipoFornecedor TipoFornecedor { get;  set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public string Documento { get;  set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public bool Ativo { get;  set; }
	}
}
