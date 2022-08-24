using Aula01.Model;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProdutoController : Controller
	{	private readonly List<Produto> produtosList;
		public ProdutoController()
		{
			produtosList = new List<Produto>();
			produtosList.Add(new Produto()
			{
				Id = 1, Nome = "produto 1",Preco = 1000, Estoque = 10
			});
			produtosList.Add(new Produto()
			{
				Id = 2,	Nome = "produto 2", Preco = 2000, Estoque = 1
			});
		}

		[HttpPost]
		public IActionResult Cadastrar(Produto produto)
		{
			produtosList.Add(produto);
;			return Ok(produto);
		}

		[HttpPut]
		public IActionResult Atualizar()
		{
			return Ok();
		}

		[HttpGet]
		public IActionResult ObterPorId(int id)
		{
			var pesquisa = produtosList.Where(p => p.Id == id);
			if (!pesquisa.Any()) return NotFound();
			return Ok(pesquisa);
		}
		[Route("ObterTodos")]
		[HttpGet]
		public IActionResult ObterTodos()
		{
			return Ok(produtosList);
		}


	}
}
