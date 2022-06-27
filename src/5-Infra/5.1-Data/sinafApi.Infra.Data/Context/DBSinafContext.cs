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

        public DbSet<Cliente> Cliente { get; set; }
        //public DbSet<Endereco> Endereco { get; set; }
        // Relação de mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new ClienteMap());

        }

    }
}
