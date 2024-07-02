using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agropuro.Entities
{
    internal class Funcionario : Dados_Pessoais
    {
        protected int ID_Funcionario { get; }
        protected string CTPS { get; }
        protected string DataNascimento { get; }
        protected string ContaBancaria { get; }
        protected string Funcao { get; }
        protected double Salario { get; }
        protected DateTime Admissao { get; }
        protected DateTime Desligamento { get; }

        public Funcionario()
        {
        }

        public Funcionario(int id_Funcionario, string ctps, string dataNascimento, string contaBancaria, string funcao, double salario, DateTime admissao, DateTime desligamento)
        {
            ID_Funcionario = id_Funcionario;
            CTPS = ctps;
            DataNascimento = dataNascimento;
            ContaBancaria = contaBancaria;
            Funcao = funcao;
            Salario = salario;
            Admissao = admissao;
            Desligamento = desligamento;
        }

        public DateTime TempoEmpregado(DateTime tempoEmpregado) 
        {
            tempoEmpregado.Subtract(DateTime.Today - Admissao);
            return tempoEmpregado;
            
        }
    }
}
