using ryze.system.AppService.Models.Pedidos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.AppService.Interfaces.Pedidos
{
    public interface IPedidoService
    {
        Task<IEnumerable<PedidoDto>> GetPedidos();
        Task<PedidoDto> GetPedidoById(Guid id);

        Task Add(PedidoDto pedidoDto);
        Task Update(PedidoDto pedidoDto);
        Task Remove(Guid id);
    }
}
