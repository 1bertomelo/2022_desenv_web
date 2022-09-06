using Aula01.Domain.Interfaces;
using Aula01.Model;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProdutoController : Controller
	{
		private IProdutoRepository _produtoRepository;

		public ProdutoController(IProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}

		[HttpPost]
		public IActionResult Cadastrar(Produto produto)
		{
			//_produtoRepository.Adicionar();
			return Ok(produto);
		}

		[HttpPut]
		public IActionResult Atualizar()
		{
			return Ok();
		}

		[HttpGet]
		public IActionResult ObterPorId(int id)
		{
			return Ok();
		}
		[Route("ObterTodos")]
		[HttpGet]
		public IActionResult ObterTodos()
		{
			return Ok();
		}


	}
}
