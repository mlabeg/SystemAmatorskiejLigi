using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ligaAmatorska.Domain.Entities;

namespace ligaAnatorska.Infrastructure.Presistence
{
	internal class LigaDbContext : DbContext
	{
		public LigaDbContext(DbContextOptions<LigaDbContext> options) : base(options)
		{
		}

		public DbSet<ligaAmatorska.Domain.Entities.Druzyna> Druzyny { get; set; }
		public DbSet<ligaAmatorska.Domain.Entities.Mecz> Mecze { get; set; }
		public DbSet<ligaAmatorska.Domain.Entities.Sedzia> Sedziowie { get; set; }
		public DbSet<ligaAmatorska.Domain.Entities.Statystyki> Statystyki { get; set; }
		public DbSet<ligaAmatorska.Domain.Entities.TypUprawnien> TypyUprawnien { get; set; }
		public DbSet<ligaAmatorska.Domain.Entities.Uzytkkownik> Uzytkownicy { get; set; }
		public DbSet<ligaAmatorska.Domain.Entities.Zawodnik> Zaowdnicy { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Zawodnik>().M
		}
	}
}