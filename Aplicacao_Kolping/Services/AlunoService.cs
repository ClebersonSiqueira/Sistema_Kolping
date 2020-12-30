using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao_Kolping.Data;
using Aplicacao_Kolping.Models;

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
            return _context.Alunos.FirstOrDefault(obj => obj.ID == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Alunos.Find(id);
            _context.Alunos.Remove(obj);
            _context.SaveChanges();
        }

    }
}
