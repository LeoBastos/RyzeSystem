using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ryze.system.Domain.Interfaces.Clientes;
using ryze.system.Domain.Interfaces.ItensPedido;
using ryze.system.Domain.Interfaces.Pedidos;
using ryze.system.Domain.Interfaces.Produtos;
using ryze.system.Repository.Context;
using ryze.system.Repository.Repositories.Clientes;
using ryze.system.Repository.Repositories.ItensPedido;
using ryze.system.Repository.Repositories.Pedidos;
using ryze.system.Repository.Repositories.Produtos;

namespace ryze.system.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            #region Repositories
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IItemPedidoRepository, ItemPedidoRepository>();
            #endregion                     

            return services;
        }
    }
}
