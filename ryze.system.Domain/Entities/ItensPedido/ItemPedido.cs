using ryze.system.Domain.Entities.Pedidos;
using ryze.system.Domain.Entities.Produtos;
using ryze.system.DomainNotification.Validations;
using System;
using System.Collections.Generic;

namespace ryze.system.Domain.Entities.ItensPedido

{
    public class ItemPedido : BaseEntity
    {
        public ItemPedido(Guid pedidoId, Guid produtoId, int quantidade, decimal valor, decimal desconto)
        {
            ValidateDomain(pedidoId, produtoId, quantidade, valor, desconto);
        }

        public Guid PedidoId { get; set; }
        public Guid ProdutoId { get; set; }
        public int Quantidade { get; private set; }
        public decimal Valor { get; private set; }
        public decimal Desconto { get; private set; }

        public Pedido Pedido { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }


        public void Update(Guid pedidoId, Guid produtoId, int quantidade, decimal valor, decimal desconto)
        {
            ValidateDomain(pedidoId, produtoId, quantidade, valor,  desconto);
        }

        private void ValidateDomain(Guid pedidoId, Guid produtoId, int quantidade, decimal valor, decimal desconto)
        {
            DomainExceptionValidation.When(quantidade < 0, "Valor inválido");

            DomainExceptionValidation.When(valor < 0, "Estoque inválido");


            PedidoId = pedidoId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            Valor = valor;
            Desconto = desconto;
        }
    }
}
