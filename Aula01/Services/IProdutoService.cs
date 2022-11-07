using Aula01.Model;

namespace Aula01.Services
{
	public interface IProdutoService
	{
		public Task Adicionar(ProdutoViewModel produto);
		public void Atualizar(ProdutoViewModel produto);
		public void Remover(Guid id);
		public ProdutoViewModel ObterProdutoId(Guid id);
		public IEnumerable<ProdutoViewModel> ObterProdutoName(string name);
		public IEnumerable<ProdutoViewModel> ObterTodos();
	}
}
