using Microsoft.EntityFrameworkCore;
using ryze.system.Domain.Entities.Pedidos;
using ryze.system.Domain.Interfaces.Pedidos;
using ryze.system.Repository.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.Repository.Repositories.Pedidos
{
    public class PedidoRepository : IPedidoRepository
    {
        ApplicationDbContext _pedidoContext;

        public PedidoRepository(ApplicationDbContext context)
        {
            _pedidoContext = context;
        }

        #region Query

        public async Task<Pedido> GetPedidoByIdAsync(Guid id)
        {
            return await _pedidoContext.Pedidos.FindAsync(id);
        }

        public async Task<IEnumerable<Pedido>> GetPedidosAsync()
        {
            return await _pedidoContext.Pedidos.ToListAsync();
        }

        #endregion

        public async Task<Pedido> CreateAsync(Pedido entity)
        {
            _pedidoContext.Add(entity);

            await _pedidoContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Pedido> UpdateAsync(Pedido entity)
        {
            _pedidoContext.Add(entity);

            await _pedidoContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Pedido> RemoveAsync(Pedido entity)
        {
            _pedidoContext.Add(entity);

            await _pedidoContext.SaveChangesAsync();

            return entity;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
