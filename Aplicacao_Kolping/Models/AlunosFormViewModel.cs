﻿using System.Collections.Generic;
namespace Aplicacao_Kolping.Models
{
    public class AlunosFormViewModel : Alunos
    {
        public IList<int> PostModalidades { get; set; }
        public IList<int> PostPagamentos { get; set; }
    }
}
