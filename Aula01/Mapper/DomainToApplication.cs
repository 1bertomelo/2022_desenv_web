using Aula01.Domain;
using Aula01.Model;
using AutoMapper;

namespace Aula01.Mapper
{
	public class DomainToApplication : Profile
	{
		public DomainToApplication()
		{
			CreateMap<Produto, ProdutoViewModel>();
			CreateMap<Usuario, UsuarioViewModel>();
			CreateMap<Fornecedor, FornecedorViewModel>();
		}		
	}
}
