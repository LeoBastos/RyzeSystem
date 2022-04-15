using AutoMapper;
using ryze.system.AppService.Interfaces.ItensPedido;
using ryze.system.AppService.Models.ItensPedido;
using ryze.system.Domain.Entities.ItensPedido;
using ryze.system.Domain.Interfaces.ItensPedido;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.AppService.Services.ItensPedidos
{
    public class ItemPedidoService : IItemPedidoService
    {
        private IItemPedidoRepository _itemPedidoRepository;
        private readonly IMapper _mapper;

        public ItemPedidoService(IItemPedidoRepository itemPedidoRepository, IMapper mapper)
        {
            _itemPedidoRepository = itemPedidoRepository;
            _mapper = mapper;
        }

        public async Task<ItemPedidoDto> GetItemPedidoById(Guid id)
        {
            var entity = await _itemPedidoRepository.GetItemPedidoByIdAsync(id);
            
            return _mapper.Map<ItemPedidoDto>(entity);
        }

        public async Task<IEnumerable<ItemPedidoDto>> GetItemPedido()
        {
            var entity = await _itemPedidoRepository.GetItensPedidoAsync();

            return _mapper.Map<IEnumerable<ItemPedidoDto>>(entity);
        }

        
        public async Task Add(ItemPedidoDto itemPedidoDto)
        {
            var entity = _mapper.Map<ItemPedido>(itemPedidoDto);

            await _itemPedidoRepository.CreateAsync(entity);
        }

        public async Task Update(ItemPedidoDto itemPedidoDto)
        {
            var entity = _mapper.Map<ItemPedido>(itemPedidoDto);

            await _itemPedidoRepository.UpdateAsync(entity);
        }

        public async Task Remove(Guid id)
        {
            var entity = _itemPedidoRepository.GetItemPedidoByIdAsync(id).Result;

            await _itemPedidoRepository.RemoveAsync(entity);
        }
    }
}
