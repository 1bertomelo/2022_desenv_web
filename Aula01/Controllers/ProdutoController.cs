using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProdutoController : Controller
	{
		private readonly IProdutoRepository _produtoRepository;
		private IMapper _mapper;


		public ProdutoController(IProdutoRepository produtoRepository,
			IMapper mapper)
		{
			_produtoRepository = produtoRepository;
			_mapper = mapper;
		}

		[HttpPost]
		public IActionResult Cadastrar(ProdutoViewModel produto)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);

			_produtoRepository.Adicionar(_mapper.Map<Produto>(produto));
			return Ok(new { success = true, mensagem = "Inserido com sucesso" });
		}

		[HttpPut]
		public IActionResult Atualizar()
		{
			return Ok();
		}

		[HttpGet]
		public IActionResult ObterPorId(Guid id)
		{
			var pesquisa = _mapper.Map<ProdutoViewModel>(_produtoRepository.ObterProdutoId(id));
			if (pesquisa == null) return NotFound();
			return Ok(
				new
				{
					success = true,
					produto = pesquisa
				}
				);
		}
		[Route("ObterTodos")]
		[HttpGet]
		public IActionResult ObterTodos()
		{
			return Ok(
				new
				{
					success = true,
					listaProdutos = _mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.ObterTodos())
				}
				);
		}

	}
}
