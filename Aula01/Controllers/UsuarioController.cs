using Aula01.Domain;
using Aula01.Domain.Interfaces;
using Aula01.Model;
using Aula01.Token;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace Aula01.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UsuarioController : Controller
	{
        private readonly IUsuarioRepository _usuarioRepository;
        private IMapper _mapper;

		public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
		{
			_usuarioRepository = usuarioRepository;
			_mapper = mapper;
		}

		[HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UsuarioViewModel usuarioViewModel)
        {
            // Recupera o usuário
            var buscaUsuario = _usuarioRepository.Autenticar(_mapper.Map<Usuario>(usuarioViewModel));

            // Verifica se o usuário existe
            if (buscaUsuario == null)
                return NotFound(new { message = "Usuário não existe e/ou Senha inválida!" });

            // Gera o Token
            var token = TokenService.GenerateToken(buscaUsuario);

            // Oculta a senha
            buscaUsuario.Password = "";

            // Retorna os dados
            return new
            {
                usuario = buscaUsuario,
                token = token
            };
        }
    }
}
