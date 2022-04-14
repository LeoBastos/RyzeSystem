using ryze.system.Domain.Entities.Clientes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryze.system.Domain.Interfaces.Clientes
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> GetClienteByIdAsync(Guid id);
    }
}
