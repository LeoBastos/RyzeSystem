using ryze.system.Common.Enums;
using System;

namespace ryze.system.AppService.Models.Produtos
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Imagem { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public bool IsAtivo { get; set; }
    }
}
