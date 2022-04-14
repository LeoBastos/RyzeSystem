using ryze.system.Domain.Entities.Pedidos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.Domain.Interfaces.Pedidos
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<IEnumerable<Pedido>> GetPedidosAsync();
        Task<Pedido> GetPedidoByIdAsync(Guid id);
    }
}
