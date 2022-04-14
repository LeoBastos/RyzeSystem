using ryze.system.Common.Enums;
using ryze.system.DomainNotification.Validations;

namespace ryze.system.Domain.Entities.Produtos
{
    public class Produto : BaseEntity
    {
        public Produto(string nome, decimal preco, int estoque, string imagem, TipoProduto tipoProduto, bool isAtivo)
        {
            ValidateDomain(nome, preco, estoque, imagem, tipoProduto, isAtivo);
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }
        public string Imagem { get; private set; }
        public TipoProduto TipoProduto { get; private set; }
        public bool IsAtivo { get; private set; }


        public void Update(string nome, decimal preco, int estoque, string imagem, TipoProduto tipoProduto, bool isAtivo)
        {
            ValidateDomain(nome, preco, estoque, imagem, tipoProduto, isAtivo);
        }

        public void Remove()
        {
            IsAtivo = false;
        }

        private void ValidateDomain(string nome, decimal preco, int estoque, string imagem, TipoProduto tipoProduto, bool isAtivo)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
              "Nome Inválido. Nome Fantasia é Obrigatório");

            DomainExceptionValidation.When(nome.Length < 3,
              "Nome Inválido. Minimo de 3 Caracteres");

            DomainExceptionValidation.When(preco < 0, "Valor inválido");

            DomainExceptionValidation.When(estoque < 0, "Estoque inválido");

            DomainExceptionValidation.When(imagem?.Length > 250, "Imagem inválida, Imagem muito grande, máximo de 250");

            Nome = nome;
            Preco = preco;
            Estoque = estoque;
            Imagem = imagem;
            TipoProduto = tipoProduto;
            IsAtivo = isAtivo;
        }
    }
}
