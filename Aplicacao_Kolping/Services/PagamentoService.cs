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
    public class PagamentoService
    {
        private readonly Aplicacao_KolpingContext _context;

        public PagamentoService(Aplicacao_KolpingContext context)
        {
            _context = context;
        }
        public List<Alunos> FindAllAlunos()
        {
            return _context.Alunos.ToList();
        }

        public List<Pagamentos> FindAllPagamentos()
        {
            return _context.Pagamentos.ToList();
        }
        public void Insert(Pagamentos obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
