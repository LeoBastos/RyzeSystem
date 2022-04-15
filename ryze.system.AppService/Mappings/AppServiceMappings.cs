using AutoMapper;
using ryze.system.AppService.Models.Clientes;
using ryze.system.AppService.Models.ItensPedido;
using ryze.system.AppService.Models.Pedidos;
using ryze.system.AppService.Models.Produtos;
using ryze.system.Domain.Entities.Clientes;
using ryze.system.Domain.Entities.ItensPedido;
using ryze.system.Domain.Entities.Pedidos;
using ryze.system.Domain.Entities.Produtos;

namespace ryze.system.AppService.Mappings
{
    public class AppServiceMappings : Profile
    {
        public AppServiceMappings()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Produto, ProdutoDto>().ReverseMap();
            CreateMap<Pedido, PedidoDto>().ReverseMap();
            CreateMap<ItemPedido, ItemPedidoDto>().ReverseMap();
        }
    }
}
