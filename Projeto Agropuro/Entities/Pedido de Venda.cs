using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropuro.Entities
{
    internal class Pedido_de_Venda
    {
        protected int ID_PedidoVenda { get; }
        protected double PrecoVenda { get; }
        protected int UnidadeVendida { get; }
        protected int CondicaoPagamento { get; }

        public Pedido_de_Venda()
        {
        }

        public Pedido_de_Venda(int id_PedidoVenda, double precoVenda, int unidadeVendida, int condicaoPagamento)
        {
            ID_PedidoVenda = id_PedidoVenda;
            PrecoVenda = precoVenda;
            UnidadeVendida = unidadeVendida;
            CondicaoPagamento = condicaoPagamento;
        }

        public double ValorReceber()
        {
            return PrecoVenda / CondicaoPagamento;
        }
    }
}
