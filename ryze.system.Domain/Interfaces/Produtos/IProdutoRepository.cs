using ryze.system.Domain.Entities.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.Domain.Interfaces.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
        Task<Produto> GetProdutoByIdAsync(Guid id);
    }
}
