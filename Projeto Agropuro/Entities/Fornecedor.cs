using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropuro.Entities
{
    public class Fornecedor : Dados_Pessoais
    {
        protected int ID_Fornecedor { get; }
        protected string ContaBancaria { get; }
        protected double ValorPagar { get; }
        protected string Status { get; }
        protected int CodicaoPagamento { get; }
        protected string PrazoEntrega { get; }
        protected string Garatia { get; }
        protected string PoliticaDevolucao { get; }

        public Fornecedor()
        {
        }

        public Fornecedor(int id_Fornecedor, string contaBancaria, double valorPagar, string status, int codicaoPagamento, string prazoEntrega, string garatia, string politicaDevolucao)
        {
            ID_Fornecedor = id_Fornecedor;
            ContaBancaria = contaBancaria;
            ValorPagar = valorPagar;
            Status = status;
            CodicaoPagamento = codicaoPagamento;
            PrazoEntrega = prazoEntrega;
            Garatia = garatia;
            PoliticaDevolucao = politicaDevolucao;
        }
    }
}
