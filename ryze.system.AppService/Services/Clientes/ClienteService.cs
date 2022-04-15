using AutoMapper;
using ryze.system.AppService.Interfaces.Clientes;
using ryze.system.AppService.Models.Clientes;
using ryze.system.Domain.Entities.Clientes;
using ryze.system.Domain.Interfaces.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryze.system.AppService.Services.Clientes
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }        

        public async Task<ClienteDto> GetClienteById(Guid id)
        {
            var entity = await _clienteRepository.GetClienteByIdAsync(id);

            return _mapper.Map<ClienteDto>(entity);
        }

        public async Task<IEnumerable<ClienteDto>> GetClientes()
        {
            var entity = await _clienteRepository.GetClientesAsync();

            return _mapper.Map<IEnumerable<ClienteDto>>(entity);
        }

        public async Task Add(ClienteDto clienteDto)
        {
            var entity = _mapper.Map<Cliente>(clienteDto);

            await _clienteRepository.CreateAsync(entity);
        }      

        public async Task Update(ClienteDto clienteDto)
        {
            var entity = _mapper.Map<Cliente>(clienteDto);

            await _clienteRepository.UpdateAsync(entity);
        }

        public async Task Remove(Guid id)
        {
            var entity = _clienteRepository.GetClienteByIdAsync(id).Result;

            entity.Remove();

            await _clienteRepository.RemoveAsync(entity);
        }
    }
}
