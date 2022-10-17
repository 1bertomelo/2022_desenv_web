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
		public async Task<IActionResult> Cadastrar([FromForm] ProdutoViewModel produtoViewModel)
		{
			var imagemNome = Guid.NewGuid() + "_" + produtoViewModel.file.FileName;
			produtoViewModel.Imagem = imagemNome;

			if (!ModelState.IsValid) return BadRequest(ModelState);

			if (!await UploadArquivo(produtoViewModel.file, imagemNome))
			{
				return BadRequest( new { success = false, mensagem = "Erro ao subir a imagem" }) ;
			}

			_produtoRepository.Adicionar(_mapper.Map<Produto>(produtoViewModel));
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



		private async Task<bool> UploadArquivo(IFormFile arquivo, string imgNome)
		{
			
			if (arquivo == null || arquivo.Length == 0)
			{
				return false;
			}

			var path = Path.Combine(Directory.GetCurrentDirectory(), "Content/Images", imgNome);


			using (var stream = new FileStream(path, FileMode.Create))
			{
				await arquivo.CopyToAsync(stream);
			}

			return true;
		}
	}
}
