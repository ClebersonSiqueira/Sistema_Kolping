using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicacao_Kolping.Models;

namespace Aplicacao_Kolping.Data
{
    public class Aplicacao_KolpingContext : DbContext
    {
        public Aplicacao_KolpingContext(DbContextOptions<Aplicacao_KolpingContext> options)
            : base(options)
        {
        }

        public DbSet<Modalidades> Modalidades { get; set; }

        public DbSet<Alunos> Alunos { get; set; }

        public DbSet<Pagamentos> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modalidades>().HasMany<Alunos>(g => g.Alunos);
            modelBuilder.Entity<Alunos>().HasMany<Modalidades>(g => g.Modalidades);
            modelBuilder.Entity<Alunos>().HasMany<Pagamentos>();
        }

    }

}
