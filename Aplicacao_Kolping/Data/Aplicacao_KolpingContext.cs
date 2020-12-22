using Microsoft.EntityFrameworkCore;
using Aplicacao_Kolping.Models;

namespace Aplicacao_Kolping.Data
{
    public class Aplicacao_KolpingContext : DbContext
    {
        public Aplicacao_KolpingContext (DbContextOptions<Aplicacao_KolpingContext> options)
            : base(options)
        {
        }

        public DbSet<Modalidades> Modalidades { get; set; }
        public DbSet<Alunos> Alunos { get; set; }

        public DbSet<Pagamentos> Pagamentos { get; set; }

    }
}
