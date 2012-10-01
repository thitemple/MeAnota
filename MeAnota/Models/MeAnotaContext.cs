using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MeAnota.Models
{
    public class MeAnotaContext : DbContext
    {
        public MeAnotaContext() : base("MeAnotaConnString")
        {

        }

        public DbSet<Anotacao> Anotacoes { get; set; }
        public DbSet<Bloco> Blocos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Anotacao>().ToTable("Nota");
            modelBuilder.Configurations.Add(new BlocoConfiguration());
        }

        private class BlocoConfiguration : EntityTypeConfiguration<Bloco> 
        {
            internal BlocoConfiguration()
            {
                HasMany(x => x.Colaboradores)
                    .WithMany(x => x.Blocos)
                    .Map(x => x.ToTable("ColaboradoresBloco"));
            }
        }
    }
}