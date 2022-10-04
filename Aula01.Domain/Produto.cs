using Aula01.Domain.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
	public class Produto : Entity
	{
		public Produto(string nome, decimal preco, int estoque)
		{
			
			Nome = nome;
			Preco = preco;
			Estoque = estoque;
		}

		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public int Estoque { get; set; }

	} 
}
