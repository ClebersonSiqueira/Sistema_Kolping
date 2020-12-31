using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao_Kolping.Data;
using Aplicacao_Kolping.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplicacao_Kolping.Services
{
    public class ModalidadesService
    {
        private readonly Aplicacao_KolpingContext _context;

        public ModalidadesService(Aplicacao_KolpingContext context)
        {
            _context = context;
        }

        public async Task<List<Modalidades>> FindAllAsync()
        {

            return await _context.Modalidades.ToListAsync();
        }

    }
}
