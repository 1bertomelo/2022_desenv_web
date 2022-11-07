using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Model;
using Aula01.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProdutoController : Controller
	{
		private readonly IProdutoService _produtoService;
		


		public ProdutoController(IProdutoService produtoService
			)
		{
			_produtoService = produtoService;
			
		}

		[Authorize]
		[HttpPost]
		public async Task<IActionResult> Cadastrar([FromForm] ProdutoViewModel produtoViewModel)
		{
			try
			{
				if (!ModelState.IsValid) return BadRequest(ModelState);

				await _produtoService.Adicionar(produtoViewModel);

				return Ok(new { success = true, mensagem = "Inserido com sucesso" });
			}
			catch (Exception ex)
			{

				return BadRequest(new { success = false, mensagem = ex.Message });
			}
			
		}

		[HttpPut]
		public IActionResult Atualizar()
		{
			return Ok();
		}

		[HttpGet]
		public IActionResult ObterPorId(Guid id)
		{
			var pesquisa = _produtoService.ObterProdutoId(id);
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
					listaProdutos = _produtoService.ObterTodos()
				}
				);
		}



		
	}
}
