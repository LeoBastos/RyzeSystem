using Microsoft.EntityFrameworkCore;
using ryze.system.Domain.Entities.Clientes;
using ryze.system.Domain.Interfaces.Clientes;
using ryze.system.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryze.system.Repository.Repositories.Clientes
{
    public class ClienteRepository : IClienteRepository
    {
        ApplicationDbContext _clienteContext;

        public ClienteRepository(ApplicationDbContext context)
        {
            _clienteContext = context;
        }

        #region Query

        public async Task<Cliente> GetClienteByIdAsync(Guid id)
        {
            return await _clienteContext.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _clienteContext.Clientes.Where(p => p.IsAtivo == true).ToListAsync();
        }

        #endregion

        #region Command

        public async Task<Cliente> CreateAsync(Cliente entity)
        {
            _clienteContext.Add(entity);

            await _clienteContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Cliente> UpdateAsync(Cliente entity)
        {
            _clienteContext.Update(entity);

            await _clienteContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Cliente> RemoveAsync(Cliente entity)
        {
            _clienteContext.Remove(entity);

            await _clienteContext.SaveChangesAsync();

            return entity;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}