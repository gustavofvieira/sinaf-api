using SinafApi.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SinafApi.Infra.Data.Mapping;

namespace SinafApi.Infra.Data.Context
{
    public class DBSinafContext : DbContext
    {
        private readonly IHttpContextAccessor _accessor;

        public DBSinafContext(DbContextOptions<DBSinafContext> options) : base (options)
        {
            
        }

        public DBSinafContext(DbContextOptions<DBSinafContext> options, IHttpContextAccessor accessor) : base(options)
        {
            _accessor = accessor;
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        // Relação de mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new ClienteMap());
            // modelBuilder.ApplyConfiguration(new UsuarioMatriculaMap());

        }

    }
}
