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
            MapearModalidades(obj, aluno);

            _context.Add(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task InsertPagamento(AlunosFormViewModel obj)
        {
            Alunos aluno = _mapper.Map<Alunos>(obj);
            MapearPagamanetos(obj, aluno);

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
        private void MapearPagamanetos(AlunosFormViewModel obj, Alunos aluno)
        {
            var adicionar = obj.PostPagamentos.Where(p => !aluno.Pagamentos.Any(a => a.Id == p));

            foreach (var id in adicionar)
            {
                var pagamento = _context.Pagamentos.Find(id);

                if (pagamento == null)
                    continue;

                pagamento.Data = DateTime.Today;
                double ValorTotal = CalculaValor();
                pagamento.Valor = ValorTotal;

                aluno.AddPagamento(pagamento);
            }
        }
        public double CalculaValor()
        {
            return 20.0;
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

    }
}
