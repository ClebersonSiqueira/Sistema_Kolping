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

        public AlunoPagamentoService(Aplicacao_KolpingContext context)
        {
            _context = context;
        }

        public async Task<List<Pagamentos>> FindAllAsync()
        {
            return await _context.Pagamentos.ToListAsync();
        }

        

    }
}
