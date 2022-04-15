using ryze.system.AppService.Models.ItensPedido;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.AppService.Interfaces.ItensPedido
{
    public interface IItemPedidoService
    {
        Task<IEnumerable<ItemPedidoDto>> GetItemPedido();
        Task<ItemPedidoDto> GetItemPedidoById(Guid id);

        Task Add(ItemPedidoDto itemPedidoDto);
        Task Update(ItemPedidoDto itemPedidoDto);
        Task Remove(Guid id);
    }
}
