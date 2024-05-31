using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaAmatorska.Domain.Entities;

namespace LigaAmatorska.Infrastructure.Presistence
{
    internal class LigaDbContext : DbContext
    {
        public LigaDbContext(DbContextOptions<LigaDbContext> options) : base(options)
        {
        }

        public DbSet<LigaAmatorska.Domain.Entities.Druzyna> Druzyny { get; set; }
        public DbSet<LigaAmatorska.Domain.Entities.Mecz> Mecze { get; set; }
        public DbSet<LigaAmatorska.Domain.Entities.Sedzia> Sedziowie { get; set; }
        public DbSet<LigaAmatorska.Domain.Entities.Statystyki> Statystyki { get; set; }
        public DbSet<LigaAmatorska.Domain.Entities.TypUprawnien> TypyUprawnien { get; set; }
        public DbSet<LigaAmatorska.Domain.Entities.Uzytkkownik> Uzytkownicy { get; set; }
        public DbSet<LigaAmatorska.Domain.Entities.Zawodnik> Zaowdnicy { get; set; }
        public DbSet<WynikiDruzyny> WynikiDruzynies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Zawodnik>().M
        }
    }
}