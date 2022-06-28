using SinafApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SinafApi.Infra.Data.Mapping
{
    public class SeguroMap : IEntityTypeConfiguration<Seguro>
    {
        public void Configure(EntityTypeBuilder<Seguro> builder)
        {
            builder.ToTable("Seguros");

            // Primary Key
            builder.HasKey(t => new { t.IdSeguro });


            builder.Property(c => c.IdSeguro)
                .HasColumnName("IdSeguro");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.Descricao)
                .HasColumnName("Descricao");

            builder.Property(c => c.ImportanciaAssegurada)
                .HasColumnName("ImportanciaAssegurada");

            builder.Property(c => c.Percentual)
                .HasColumnName("Percentual");

            builder.Property(c => c.PremioCobertura)
                .HasColumnName("PremioCobertura");

            builder.Property(c => c.NomeCorretor)
                .HasColumnName("NomeCorretor");

        }
    }
}
