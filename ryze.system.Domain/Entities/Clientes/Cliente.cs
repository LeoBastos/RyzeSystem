using ryze.system.DomainNotification.Validations;
using ryzen.system.Common.Enums;
using System;

namespace ryze.system.Domain.Entities.Clientes
{
    public class Cliente : BaseEntity
    {
        public Cliente()
        {

        }
        
        public Cliente(string nomeFantasia, string telefone, string email, string cnpj, bool isAtivo, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, EUf? uf)
        {
            ValidateDomain(nomeFantasia, telefone, email, cnpj, isAtivo, cep, logradouro, numero,complemento, bairro, cidade, uf);           
        }

        public string NomeFantasia { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Cnpj { get; private set; }
        public bool IsAtivo { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public EUf? Uf { get; private set; }


        public void Update(string nomeFantasia, string telefone, string email, string cnpj, bool isAtivo, string cep,
            string logradouro, string numero, string complemento, string bairro, string cidade, EUf? uf)
        {
            ValidateDomain(nomeFantasia,telefone, email, cnpj,isAtivo, cep, logradouro, numero, complemento, bairro, cidade, uf);            
        }

        public void Remove()
        {
            IsAtivo = false;            
        }
        
        private void ValidateDomain(string nomeFantasia, string telefone, string email, string cnpj, bool isAtivo, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, EUf? uf)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nomeFantasia),
              "Nome Inválido. Nome Fantasia é Obrigatório");

            DomainExceptionValidation.When(nomeFantasia.Length < 3,
              "Nome Inválido. Minimo de 3 Caracteres");

            DomainExceptionValidation.When(string.IsNullOrEmpty(telefone),
             "Descrição Inválida. Descrição é Obrigatório");

            DomainExceptionValidation.When(string.IsNullOrEmpty(email),
            "Descrição Inválida. Descrição é Obrigatório");

            DomainExceptionValidation.When(email.Length < 3,
              "Nome Inválido. Minimo de 3 Caracteres");

            DomainExceptionValidation.When(string.IsNullOrEmpty(cnpj),
            "Descrição Inválida. Descrição é Obrigatório");

            DomainExceptionValidation.When(string.IsNullOrEmpty(cep),
            "Descrição Inválida. Descrição é Obrigatório");

             DomainExceptionValidation.When(string.IsNullOrEmpty(logradouro),
            "Descrição Inválida. Descrição é Obrigatório");

            DomainExceptionValidation.When(string.IsNullOrEmpty(numero),
           "Descrição Inválida. Descrição é Obrigatório");

            DomainExceptionValidation.When(string.IsNullOrEmpty(bairro),
           "Descrição Inválida. Descrição é Obrigatório");

            DomainExceptionValidation.When(string.IsNullOrEmpty(cidade),
           "Descrição Inválida. Descrição é Obrigatório");            

            NomeFantasia = nomeFantasia;
            Telefone = telefone;
            Email = email;
            Cnpj = cnpj; 
            IsAtivo = isAtivo;  
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }
    }
}
