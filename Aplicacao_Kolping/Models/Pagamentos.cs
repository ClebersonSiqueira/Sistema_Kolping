using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Kolping.Models
{
    public class Pagamentos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Pagamentos()
        {
        }

        public Pagamentos(int id, DateTime data, double valor, Pagamentos pagamento)
        {
            Id = id;
            Data = data;
            Valor = valor;
        }
    }

}
