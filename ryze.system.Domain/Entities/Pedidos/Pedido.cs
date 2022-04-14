using ryze.system.Domain.Entities.Clientes;
using ryze.system.Domain.Entities.ItensPedido;
using ryze.system.DomainNotification.Validations;
using System;
using System.Collections.Generic;

namespace ryze.system.Domain.Entities.Pedidos
{
    public class Pedido : BaseEntity
    {
        public Pedido(Guid clienteId, Guid itemPedidoId, DateTime dataPedido, string observacao, bool status)
        {
            ClienteId = clienteId;
            ItemPedidoId = itemPedidoId;
            DataPedido = dataPedido;
            Observacao = observacao;
            Status = status;
        }

        public Guid ClienteId { get; private set; }
        public Guid ItemPedidoId { get; private set; }
        public DateTime DataPedido { get; private set; }        
        public string Observacao { get; private set; }
        public bool Status { get; private set; }

        public Cliente Cliente { get; set; }      


        public void Update(Guid clienteId, Guid itemPedidoId, DateTime dataPedido, string observacao, bool status)
        {
            ValidateDomain(clienteId, itemPedidoId, dataPedido, observacao, status);
        }


        private void ValidateDomain(Guid clienteId, Guid itemPedidoId, DateTime dataPedido, string observacao, bool status)
        {
            ClienteId = clienteId;
            ItemPedidoId = itemPedidoId;
            DataPedido = dataPedido;
            Observacao = observacao;
            Status = status;
        }
    }
}
