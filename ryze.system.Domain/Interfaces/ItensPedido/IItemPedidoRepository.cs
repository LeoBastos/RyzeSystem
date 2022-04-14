using ryze.system.Domain.Entities.ItensPedido;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.Domain.Interfaces.ItensPedido
{
    public interface IItemPedidoRepository : IRepository<ItemPedido>
    {
        Task<IEnumerable<ItemPedido>> GetItensPedidoAsync();
        Task<ItemPedido> GetItemPedidoByIdAsync(Guid id);
    }
}
