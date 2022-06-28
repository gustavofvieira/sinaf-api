using SinafApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SinafApi.Infra.Data.Mapping
{
    public class ApoliceMap : IEntityTypeConfiguration<Apolice>
    {
        public void Configure(EntityTypeBuilder<Apolice> builder)
        {

            builder.ToTable("Apolices");

            // Primary Key
            builder.HasKey(t => new { t.IdApolice});


            builder.Property(c => c.IdApolice)                
                .HasColumnName("IdApolice");

            builder.Property(c => c.IdCliente)
                .HasColumnName("IdCliente");

            builder.Property(c => c.IdSeguro)
                .HasColumnName("IdSeguro");

            builder.Property(c => c.Status)
                .HasColumnName("Status");
        }
    
    }
}
