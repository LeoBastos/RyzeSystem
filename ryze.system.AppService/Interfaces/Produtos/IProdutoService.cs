using ryze.system.AppService.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.AppService.Interfaces.Produtos
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDto>> GetProdutos();
        Task<ProdutoDto> GetProdutoById(Guid id);

        Task Add(ProdutoDto produtoDto);
        Task Update(ProdutoDto produtoDto);
        Task Remove(Guid id);
    }
}
