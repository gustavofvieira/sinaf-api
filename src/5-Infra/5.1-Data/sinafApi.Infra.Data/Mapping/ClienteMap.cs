using SinafApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SinafApi.Infra.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.ToTable("Cliente");

            // Primary Key
            builder.HasKey(t => new { t.IdCliente});


            builder.Property(c => c.IdCliente)                
                .HasColumnName("IdCliente");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.Cpf)
                .HasColumnName("Cpf");

            //builder.Property(c => c.DtNasc)
            //    .HasColumnName("DtNasc");

            builder.Property(c => c.Sexo)
                .HasColumnName("Sexo");
        }
    
    }
}
