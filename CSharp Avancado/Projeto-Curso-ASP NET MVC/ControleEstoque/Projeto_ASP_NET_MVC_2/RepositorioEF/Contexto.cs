using Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RepositorioEF
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Config")
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Aluno>().Property(x => x.Nome).IsRequired().HasColumnType("Varchar").HasMaxLength(75);
            modelBuilder.Entity<Aluno>().Property(x => x.Mae).IsRequired().HasColumnType("Varchar").HasMaxLength(75);
            modelBuilder.Entity<Aluno>().Property(x => x.DataNascimento).IsRequired().HasColumnType("Date");
        }
    }
}
