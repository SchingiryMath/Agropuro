using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropuro.Entities
{
    internal class Cliente : Dados_Pessoais
    {
        protected int ID_Cliente { get; }
        protected DateTime DataNascimento { get; }
        protected double TotalGasto { get; }
        protected double ValorReceber { get; }
        protected DateTime UltimaCompra { get; }
        protected DateTime DataCadastro { get; }
        protected bool EmailVerificado { get; }
        protected bool PermissaoPrivacidade { get; }

        public Cliente()
        {
        }

        public Cliente(int id_Cliente, DateTime dataNascimento, double totalGasto, double valorReceber, DateTime ultimaCompra, DateTime dataCadastro, bool emailVerificado, bool permissaoPrivacidade)
        {
            ID_Cliente = id_Cliente;
            DataNascimento = dataNascimento;
            TotalGasto = totalGasto;
            ValorReceber = valorReceber;
            UltimaCompra = ultimaCompra;
            DataCadastro = dataCadastro;
            EmailVerificado = emailVerificado;
            PermissaoPrivacidade = permissaoPrivacidade;
        }
    }
}
