using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao_Kolping.Models
{
    public class Pagamentos
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data do Pagamento")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:f2}")]
        [Display(Name = "Valor Pago")]
        public double Valor { get; set; }

        public int AlunoID { get; set; }

        public Alunos Aluno { get; set; }

        public Pagamentos()
        {
        }

        public Pagamentos(int id, DateTime data, double valor, Pagamentos pagamento, int AlunoId)
        {
            Id = id;
            Data = data;
            Valor = valor;
            AlunoID = AlunoId;
        }
    }

}
