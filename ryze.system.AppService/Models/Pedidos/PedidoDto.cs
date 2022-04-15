using ryze.system.Domain.Entities.Clientes;
using ryze.system.Domain.Entities.Produtos;
using System;
using System.Collections.Generic;

namespace ryze.system.AppService.Models.Pedidos
{
    public class PedidoDto
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Guid ProdutoId { get; set; }
        public DateTime DataPedido { get; set; }
        public string Observacao { get; set; }
        public bool Status { get; set; }
        public Cliente Cliente { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
