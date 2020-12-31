using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao_Kolping.Data;
using Aplicacao_Kolping.Models;
using Microsoft.EntityFrameworkCore;


namespace Aplicacao_Kolping.Services
{
    public class AlunoPagamentoService
    {
        private readonly Aplicacao_KolpingContext _context;
        private readonly Alunos _aluno;

        public AlunoPagamentoService(Aplicacao_KolpingContext context, Alunos aluno)
        {
            _context = context;
            _aluno = aluno;
        }

        public async Task <List<Pagamentos>> FindByDateAsync (DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pagamentos select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => _context.Alunos)
                .Include(x => _aluno.Modalidades)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

    }
}
