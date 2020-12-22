using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Kolping.Models
{
    public class Pagamentos
    {
        public int IdPagamento { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Pagamentos Pagamento { get; set; }

        public Pagamentos()
        {
        }

        public Pagamentos(int idPagamento, DateTime data, double valor, Pagamentos pagamento)
        {
            IdPagamento = idPagamento;
            Data = data;
            Valor = valor;
            Pagamento = pagamento;
        }
    }

}
