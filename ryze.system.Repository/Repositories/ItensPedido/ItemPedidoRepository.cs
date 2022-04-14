using Microsoft.EntityFrameworkCore;
using ryze.system.Domain.Entities.ItensPedido;
using ryze.system.Domain.Interfaces.ItensPedido;
using ryze.system.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryze.system.Repository.Repositories.ItensPedido
{
    public class ItemPedidoRepository : IItemPedidoRepository
    {
        ApplicationDbContext _itemPedidoContext;

        public ItemPedidoRepository(ApplicationDbContext context)
        {
            _itemPedidoContext = context;
        }

        #region Query        

        public async Task<ItemPedido> GetItemPedidoByIdAsync(Guid id)
        {
            return await _itemPedidoContext.ItensPedido.FindAsync(id);
        }

        public async Task<IEnumerable<ItemPedido>> GetItensPedidoAsync()
        {
            return await _itemPedidoContext.ItensPedido.ToListAsync();
        }

        #endregion

        #region Command
        public async Task<ItemPedido> CreateAsync(ItemPedido entity)
        {
            _itemPedidoContext.Add(entity);

            await _itemPedidoContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ItemPedido> UpdateAsync(ItemPedido entity)
        {
            _itemPedidoContext.Add(entity);

            await _itemPedidoContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ItemPedido> RemoveAsync(ItemPedido entity)
        {
            _itemPedidoContext.Add(entity);

            await _itemPedidoContext.SaveChangesAsync();

            return entity;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
