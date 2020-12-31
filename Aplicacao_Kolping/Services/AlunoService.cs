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

        public List<Alunos> FindAll()
        {
            return _context.Alunos.ToList();
        }
        public void Insert(Alunos obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        
        public Alunos FindById(int id)
        {
            return _context.Alunos.Include(obj => obj.Modalidades).FirstOrDefault(obj => obj.ID == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Alunos.Find(id);
            _context.Alunos.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Alunos obj)
        {
            if(!_context.Alunos.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id Não encontrado");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
