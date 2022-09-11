
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Aula01.Model
{
	public class ProdutoViewModel
	{

		[JsonIgnore]
		public int Id { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]

		public string Nome { get; set; }

		[Range(0, 1000, ErrorMessage = "Valor de {0} deve entre {1} e {2}.")]

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public decimal Preco { get; set; }

		[Range(0, 1000, ErrorMessage = "Valor de {0} deve entre {1} e {2}.")]

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int Estoque { get; set; }


	}
}
