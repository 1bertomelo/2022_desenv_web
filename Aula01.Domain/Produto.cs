using Aula01.Domain.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
	public class Produto
	{
		public Produto(int id,string nome, decimal preco, int estoque)
		{
			Id = id;
			Nome = nome;
			Preco = preco;
			Estoque = estoque;
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public int Estoque { get; set; }

		public ValidationResult validationResult { get; set; }

		public bool EhValido()
		{
			validationResult = new ProdutoValidation().Validate(this);
			return validationResult.IsValid;
		}
	} 
}
