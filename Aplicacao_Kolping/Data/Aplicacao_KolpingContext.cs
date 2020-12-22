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
        public Aplicacao_KolpingContext (DbContextOptions<Aplicacao_KolpingContext> options)
            : base(options)
        {
        }

        public DbSet<Aplicacao_Kolping.Models.Modalidades> Modalidades { get; set; }
    }
}
