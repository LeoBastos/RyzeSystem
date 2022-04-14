using ryze.system.Domain.Entities.Clientes;
using ryze.system.Domain.Entities.Produtos;
using System;
using System.Collections.Generic;

namespace ryze.system.Domain.Entities.Pedidos
{
    public class Pedido : BaseEntity
    {
        public Pedido(Guid clienteId, Guid produtoId, DateTime dataPedido, string observacao, bool status)
        {
            ClienteId = clienteId;
            ProdutoId = produtoId;
            DataPedido = dataPedido;
            Observacao = observacao;
            Status = status;
        }

        public Guid ClienteId { get; set; }
        public Guid ProdutoId { get; set; }
        public DateTime DataPedido { get; private set; }
        public string Observacao { get; private set; }
        public bool Status { get; private set; }
        public Cliente Cliente { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }


        public void Update(Guid clienteId, Guid produtoId, DateTime dataPedido, string observacao, bool status)
        {
            ValidateDomain(clienteId, produtoId, dataPedido, observacao, status);
        }


        private void ValidateDomain(Guid clienteId, Guid produtoId, DateTime dataPedido, string observacao, bool status)
        {
            ClienteId = clienteId;
            ProdutoId = produtoId;
            DataPedido = dataPedido;
            Observacao = observacao;
            Status = status;
        }
    }
}
