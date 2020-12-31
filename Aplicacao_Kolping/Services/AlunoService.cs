using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao_Kolping.Data;
using Aplicacao_Kolping.Models;
using Microsoft.EntityFrameworkCore;
using Aplicacao_Kolping.Services.Exceptions;

namespace Aplicacao_Kolping.Services
{
    public class AlunoService
    {
        private readonly Aplicacao_KolpingContext _context;

        public AlunoService(Aplicacao_KolpingContext context)
        {
            _context = context;
        }

        public async Task<List<Alunos>> FindAllAsync()
        {
            return await _context.Alunos.ToListAsync();
        }
        public async Task Insert(Alunos obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        
        public async Task<Alunos> FindByIdAsync(int id)
        {
            return await _context.Alunos.Include(obj => obj.Modalidade).FirstOrDefaultAsync(obj => obj.ID == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Alunos.FindAsync(id);
            _context.Alunos.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Alunos obj)
        {
            bool hasAny = await _context.Alunos.AnyAsync(x => x.ID == obj.ID);
            if (!hasAny)
            {
                throw new NotFoundException("Id Não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
