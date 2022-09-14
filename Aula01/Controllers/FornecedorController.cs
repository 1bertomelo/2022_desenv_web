using Aula01.Domain.Interfaces;
using Aula01.Model;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	public class FornecedorController : Controller
	{
		private readonly IFornecedorRepository _fornecedorRepository;

		public FornecedorController(IFornecedorRepository fornecedorRepository)
		{
			_fornecedorRepository = fornecedorRepository;
		}

		[HttpPost]
		public IActionResult Cadastrar(FornecedorViewModel fornecedorViewModel)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);
		//	_fornecedorRepository.Adicionar();

			return Ok();
		}
	}
}
