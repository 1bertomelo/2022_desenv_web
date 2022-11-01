using Aula01.Domain;
using Aula01.Model;
using AutoMapper;

namespace Aula01.Mapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<ProdutoViewModel, Produto>()
			   .ConstructUsing(q => new Produto(q.Nome, q.Preco, q.Estoque, q.Imagem));


			CreateMap<FornecedorViewModel, Fornecedor>()
				.ConstructUsing(f =>
				new Fornecedor(
					f.Nome, f.TipoFornecedor, f.Documento,f.Ativo));

			CreateMap<UsuarioViewModel, Usuario>()
			   .ConstructUsing(q => new Usuario(q.UserName, q.Password));
		}
	}
}

