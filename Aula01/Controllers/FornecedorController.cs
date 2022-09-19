using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	public class FornecedorController : Controller
	{
		private readonly IFornecedorRepository _fornecedorRepository;
		private IMapper _mapper;
		public FornecedorController(
			IFornecedorRepository fornecedorRepository,
			IMapper mapper
		)
		{
			_fornecedorRepository = fornecedorRepository;
			_mapper = mapper;
		}

		[HttpPost]
		public IActionResult Cadastrar(FornecedorViewModel fornecedorViewModel)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);
			_fornecedorRepository.Adicionar(
				_mapper.Map<Fornecedor>(fornecedorViewModel));

			return Ok();
		}
	}
}
