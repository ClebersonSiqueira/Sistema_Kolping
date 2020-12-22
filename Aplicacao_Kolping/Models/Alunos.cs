using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Kolping.Models
{
    public class Alunos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public DateTime Nascimento { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Cep { get; set; }

    }
}
