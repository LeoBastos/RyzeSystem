using Microsoft.EntityFrameworkCore;
using ryze.system.Domain.Entities.Produtos;
using ryze.system.Domain.Interfaces.Produtos;
using ryze.system.Repository.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.Repository.Repositories.Produtos
{
    public class ProdutoRepository : IProdutoRepository
    {
        ApplicationDbContext _produtoContext;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _produtoContext = context;
        }

        #region Query

        public async Task<Produto> GetProdutoByIdAsync(Guid id)
        {
            return await _produtoContext.Produtos.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            return await _produtoContext.Produtos.ToListAsync();
        }

        #endregion

        #region Command

        public async Task<Produto> CreateAsync(Produto entity)
        {
            _produtoContext.Add(entity);

            await _produtoContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Produto> UpdateAsync(Produto entity)
        {
            _produtoContext.Update(entity);

            await _produtoContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Produto> RemoveAsync(Produto entity)
        {
            _produtoContext.Remove(entity);

            await _produtoContext.SaveChangesAsync();

            return entity;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
