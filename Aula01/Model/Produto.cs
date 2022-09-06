﻿using Aula01.Model.Validations;
using FluentValidation.Results;
using System.Text.Json.Serialization;

namespace Aula01.Model
{
	public class Produto
	{
		[JsonIgnore]
		public int Id { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public int Estoque { get; set; }
		
		public ValidationResult validationResult { get; set; }

		public bool EhValido()
		{
			validationResult =  new ProdutoValidation().Validate(this);
			return validationResult.IsValid;
		}
	}
}
