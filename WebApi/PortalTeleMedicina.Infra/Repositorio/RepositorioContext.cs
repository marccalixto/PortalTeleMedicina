using Microsoft.EntityFrameworkCore;

namespace PortalTeleMedicina.Infra.Repositorio
{
    public class RepositorioContext : DbContext
    {
        public RepositorioContext(DbContextOptions<RepositorioContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer();
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            //modelBuilder.ApplyConfiguration(new DependenteConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
