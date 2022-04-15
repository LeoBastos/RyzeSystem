using ryzen.system.Common.Enums;
using System;

namespace ryze.system.AppService.Models.Clientes
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public bool IsAtivo { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public EUf? Uf { get; set; }
    }
}
