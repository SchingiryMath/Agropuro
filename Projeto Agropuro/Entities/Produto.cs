using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropuro.Entities
{
    public class Produto
    {
        protected int ID_Produto { get; }
        protected string Nome { get; }
        protected string Descricao { get; }
        protected double PrecoCompra { get; }
        protected double PrecoVenda { get; }

        public Produto()
        {
        }

        public Produto(int id_Produto, string nome, string descricao, double precoCompra, double precoVenda)
        {
            ID_Produto = id_Produto;
            Nome = nome;
            Descricao = descricao;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
        }
    }
}
