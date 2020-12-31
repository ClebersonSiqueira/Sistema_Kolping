using System.Collections.Generic;
namespace Aplicacao_Kolping.Models
{
    public class AlunosFormViewModel
    {
        public Alunos Aluno { get; set; }
        public ICollection<Modalidades> Modalidades { get; set; }

        public ICollection<Pagamentos> Pagamentos { get; set; }
    }
}
