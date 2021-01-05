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

            modelBuilder.Entity<AlunosModalidades>().HasKey(am => new { am.AlunoID, am.ModalidadeID });


            modelBuilder.Entity<AlunosModalidades>()
                .HasOne(a => a.Aluno)
                .WithMany(m => m.Modalidades)
                .HasForeignKey(a => a.AlunoID);

            modelBuilder.Entity<AlunosModalidades>()
                .HasOne(m => m.Modalidade)
                .WithMany(a => a.Alunos)
                .HasForeignKey(m => m.ModalidadeID);

            modelBuilder.Entity<Pagamentos>()
                .HasKey(p => new { p.IdPagamento })
                .HasName("PrimaryKey_IdPagamento");

        }
    }
}
