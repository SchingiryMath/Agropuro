using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropuro.Entities
{
    public class Dados_Pessoais
    {
        protected string Nome { get;}
        protected string CPF_CNPJ { get;}
        protected string Logradouro { get;}
        protected string CEP { get;}
        protected string Bairro { get;}
        protected string Numero { get;}
        protected string Email { get;}
        protected string Telefone { get;}

        protected Dados_Pessoais() 
        {
        }

        protected Dados_Pessoais(string nome, string cpf_cnpj, string logradouro, string cep, string bairro, string numero, string email, string telefone)
        {
            Nome = nome;
            CPF_CNPJ = cpf_cnpj;
            Logradouro = logradouro;
            CEP = cep;
            Bairro = bairro;
            Numero = numero;
            Email = email;
            Telefone = telefone;
        }
    }
}
