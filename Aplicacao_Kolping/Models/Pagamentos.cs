using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Kolping.Models
{
    public class Pagamentos
    {
        public int IdPagamento { get; set; }
        public int IdAluno { get; set; }
        public DateTime DataPagamento { get; set; }
        public double ValorPago { get; set; }
        public string AulasPagas { get; set; }
        public Alunos Aluno { get; set; }

        public Pagamentos()
        {
        }

        public Pagamentos(int idAluno, int idPagamento, DateTime dataPagamento, double ValorPago, string AulasPagas)
        {
            IdAluno = idAluno;
            IdPagamento = idPagamento;
            DataPagamento = dataPagamento;
            this.ValorPago = ValorPago;
            this.AulasPagas = AulasPagas;
        }
    }
}
