using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain.Validations
{
	public class ProdutoValidation : AbstractValidator<Produto>
	{
		public ProdutoValidation()
		{
			RuleFor(p => p.Nome)
				.NotEmpty()
					.WithMessage("Nome não pode estar vazio")
				.NotNull()
					.WithMessage("Nome não pode ser nulo")
				.Length(2, 250)
					.WithMessage("Nome deve conter entre 2 e 250 caracteres");

			RuleFor(p => p.Estoque)
				.NotNull()
				.WithMessage("Estoque não pode ser nulo")
				.GreaterThanOrEqualTo(0)
				.WithMessage("Estoque não pode ser negativo");

			RuleFor(p => p.Preco)
				.NotNull()
				.WithMessage("Preco não pode ser nulo")
				.GreaterThanOrEqualTo(0)
				.WithMessage("Preco não pode ser negativo");

		}
	} 
}
