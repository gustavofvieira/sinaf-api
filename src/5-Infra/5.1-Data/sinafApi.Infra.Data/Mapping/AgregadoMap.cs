using SinafApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SinafApi.Infra.Data.Mapping
{
    public class AgregadoMap : IEntityTypeConfiguration<Agregado>
    {
        public void Configure(EntityTypeBuilder<Agregado> builder)
        {

            builder.ToTable("Agregados");

            // Primary Key
            builder.HasKey(t => new { t.IdAgregado});


            builder.Property(c => c.IdAgregado)                
                .HasColumnName("IdAgregado");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.IdCliente)
                .HasColumnName("IdCliente");
        }
    
    }
}
