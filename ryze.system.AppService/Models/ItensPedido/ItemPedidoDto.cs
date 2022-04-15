using ryze.system.Domain.Entities.Pedidos;
using ryze.system.Domain.Entities.Produtos;
using System;
using System.Collections.Generic;

namespace ryze.system.AppService.Models.ItensPedido
{
    public class ItemPedidoDto
    {
        public Guid Id { get; set; }
        public Guid PedidoId { get; set; }
        public Guid ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }

        public Pedido Pedido { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
