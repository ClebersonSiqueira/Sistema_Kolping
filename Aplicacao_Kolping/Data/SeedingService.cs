using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao_Kolping.Data;

namespace Aplicacao_Kolping.Data
{
    public class SeedingService
    {
        private Aplicacao_KolpingContext _context;

        public SeedingService(Aplicacao_KolpingContext context)
        {
            _context = context;
        }

    public void Seed()
        {
            if (_context.Modalidades.Any() || 
                _context.Alunos.Any() ||
                _context.Pagamentos.Any())
            {
                return; // DB has been seeded
            }
        }
    }
}
