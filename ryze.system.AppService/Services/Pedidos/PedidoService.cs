using AutoMapper;
using ryze.system.AppService.Interfaces.Pedidos;
using ryze.system.AppService.Models.Pedidos;
using ryze.system.Domain.Entities.Pedidos;
using ryze.system.Domain.Interfaces.Pedidos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.AppService.Services.Pedidos
{
    public class PedidoService : IPedidoService
    {
        private IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        #region Query
        public async Task<PedidoDto> GetPedidoById(Guid id)
        {
            var entity = await _pedidoRepository.GetPedidoByIdAsync(id);

            return _mapper.Map<PedidoDto>(entity);
        }

        public async Task<IEnumerable<PedidoDto>> GetPedidos()
        {
            var entity = await _pedidoRepository.GetPedidosAsync();

            return _mapper.Map<IEnumerable<PedidoDto>>(entity);
        }

        #endregion

        #region Command
        public async Task Add(PedidoDto pedidoDto)
        {
            var entity = _mapper.Map<Pedido>(pedidoDto);

            await _pedidoRepository.CreateAsync(entity);
        }

        public async Task Update(PedidoDto pedidoDto)
        {
            var entity = _mapper.Map<Pedido>(pedidoDto);

            await _pedidoRepository.UpdateAsync(entity);
        }
        public async Task Remove(Guid id)
        {
            var entity = _pedidoRepository.GetPedidoByIdAsync(id).Result;

            await _pedidoRepository.RemoveAsync(entity);
        }
        #endregion
    }
}
