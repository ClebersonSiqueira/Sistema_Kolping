using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Kolping.Models
{
    public class AlunosModalidades
    {
        public int AlunoID { get; set; }
        public Alunos Aluno { get; set; }

        public int ModalidadeID { get; set; }
        public Modalidades Modalidade { get; set; }
    }
}
