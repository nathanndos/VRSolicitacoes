using Entity;
using Entity.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DAL
{
    public class dbEntities : DbContext
    {
        private static dbEntities? context;

        public static dbEntities get
        {
            get
            {
                if (context == null)
                    context = new dbEntities();

                return context;
            }
        }

        public dbEntities(DbContextOptions<dbEntities> options) : base(options) { }

        public dbEntities() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=(local)\\SQL2019;database=vrsolicitacoes;integrated security=true;trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pessoa>(i =>
            {
                i.HasKey("Ide");
                i.Property<Guid>("Ide");
                i.Property<string>("Name");
                i.Property<string>("LastName");
            });
        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
