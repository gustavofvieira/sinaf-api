using SinafApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using SinafApi.Infra.Data.Mapping;

namespace SinafApi.Infra.Data.Context
{
    public class DBSinafContext : DbContext
    {

        public DBSinafContext(DbContextOptions<DBSinafContext> options) : base (options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Agregado> Agregados { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Apolice> Apolices { get; set; }

        // Relação de mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new AgregadoMap());
            modelBuilder.ApplyConfiguration(new SeguroMap());
            modelBuilder.ApplyConfiguration(new ApoliceMap());

        }

    }
}
