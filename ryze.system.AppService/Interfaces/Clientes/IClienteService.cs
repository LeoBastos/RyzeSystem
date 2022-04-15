using ryze.system.AppService.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.AppService.Interfaces.Clientes
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDto>> GetClientes();
        Task<ClienteDto> GetClienteById(Guid id);

        Task Add(ClienteDto clienteDto);
        Task Update(ClienteDto clienteDto);
        Task Remove(Guid id);
    }
}
