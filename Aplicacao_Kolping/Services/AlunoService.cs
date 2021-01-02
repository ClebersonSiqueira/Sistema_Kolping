using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao_Kolping.Data;
using Aplicacao_Kolping.Models;
using Microsoft.EntityFrameworkCore;
using Aplicacao_Kolping.Services.Exceptions;
using AutoMapper;

namespace Aplicacao_Kolping.Services
{
    public class AlunoService
    {
        private readonly Aplicacao_KolpingContext _context;
        private readonly IMapper _mapper;
        private readonly ModalidadesService modalidadesService;

        public AlunoService(Aplicacao_KolpingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Alunos>> FindAllAsync()
        {
            return await _context.Alunos.ToListAsync();
        }
        public async Task Insert(AlunosFormViewModel obj)
        {
            Alunos aluno = _mapper.Map<Alunos>(obj);
            await MapearModalidades(obj, aluno);

            _context.Add(aluno);
            await _context.SaveChangesAsync();
        }

        private async Task MapearModalidades(AlunosFormViewModel obj, Alunos aluno)
        {
            if (obj.PostModalidades.Any())
            {
                foreach (var id in obj.PostModalidades)
                {
                    
                }
            }
        }

        public async Task<Alunos> FindByIdAsync(int id)
        {
            return await _context.Alunos.Include(m => m.Modalidades).ThenInclude(m => m.Modalidade).FirstOrDefaultAsync(obj => obj.ID == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Alunos.FindAsync(id);
            _context.Alunos.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(AlunosFormViewModel obj)
        {
            Alunos aluno = await _context.Alunos.FindAsync(obj.ID);
            if (aluno == null)
            {
                throw new NotFoundException("Id Não encontrado");
            }
            try
            {
                aluno = _mapper.Map(obj, aluno);
                await MapearModalidades(obj, aluno);
                _context.Update(aluno);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
