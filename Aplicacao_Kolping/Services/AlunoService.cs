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
            MapearModalidades(obj, aluno);

            _context.Add(aluno);
            await _context.SaveChangesAsync();
        }

        

        private void MapearModalidades(AlunosFormViewModel obj, Alunos aluno)
        {
            if (!obj.PostModalidades.Any())
                return;

            var excluir = aluno.Modalidades.Where(m => !obj.PostModalidades.Any(p => p == m.ModalidadeID)).ToList();
            var adicionar = obj.PostModalidades.Where(p => !aluno.Modalidades.Any(a => a.ModalidadeID == p));

            if (excluir.Any())
            {
                foreach (var modalidade in excluir)
                    aluno.removeModalidade(modalidade.Modalidade);
            }

            if (!adicionar.Any())
                return;

            foreach (var id in adicionar)
            {
                var modalidade = _context.Modalidades.Find(id);

                if (modalidade == null)
                    continue;

                aluno.AddModalidade(modalidade);
            }
        }

        public async Task<Alunos> FindByIdAsync(int id)
        {
            return await _context.Alunos
                .Include(p => p.Pagamentos)
                .Include(m => m.Modalidades)
                .ThenInclude(m => m.Modalidade)
                .FirstOrDefaultAsync(obj => obj.ID == id);
        }
       

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Alunos.FindAsync(id);
            _context.Alunos.Remove(obj);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(AlunosFormViewModel obj)
        {
            Alunos aluno = await _context.Alunos.Include(a => a.Modalidades).ThenInclude(a => a.Modalidade).FirstOrDefaultAsync(a => a.ID == obj.ID);
            if (aluno == null)
            {
                throw new NotFoundException("Id Não encontrado");
            }

            try
            {
                aluno = _mapper.Map(obj, aluno);
                MapearModalidades(obj, aluno);
                _context.Update(aluno);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
        public async Task<List<Pagamentos>> FindAllPagamentosAsync()
        {
            return await _context.Pagamentos.ToListAsync();
        }

        
        
            public async Task AdicionaPagamentoAsync(int Id)
        {
            {
                Pagamentos pagamento = new Pagamentos { DataPagamento = DateTime.Now, IdAluno = Id };
                _context.Pagamentos.Add(pagamento);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeletaPagamentoAsync(int id)
        {
            {
                var pagamento = _context.Pagamentos.Find(id);
                _context.Pagamentos.Remove(pagamento);
                await _context.SaveChangesAsync();
            }
        }

        public int PesquisaPagamento (int id)
        {
            var pagamento = _context.Pagamentos.Find(id);
            int retorno = pagamento.IdAluno;
            return retorno;
        }
    }
}
