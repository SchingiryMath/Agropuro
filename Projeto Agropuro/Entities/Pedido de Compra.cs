using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropuro.Entities
{
    public class Pedido_de_Compra : Fornecedor
    {
        protected int ID_PedidoCompra { get; }
        protected double PrecoCompra { get; }
        protected int UnidadeComprada { get; }
        protected int CondicaoPagamento { get; }

        public Pedido_de_Compra()
        {
        }

        public Pedido_de_Compra(int id_PedidoCompra, double precoCompra, int unidadeComprada, int condicaoPagamento)
        {
            ID_PedidoCompra = id_PedidoCompra;
            PrecoCompra = precoCompra;
            UnidadeComprada = unidadeComprada;
            CondicaoPagamento = condicaoPagamento;
        }

        public double PagarMes()
        {
            return PrecoCompra / CondicaoPagamento;
        }
    }
}
