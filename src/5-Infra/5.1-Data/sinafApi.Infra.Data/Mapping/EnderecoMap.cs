using SinafApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SinafApi.Infra.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {

            builder.ToTable("Enderecos");

            // Primary Key
            builder.HasKey(t => new { t.IdEndereco});


            builder.Property(c => c.IdEndereco)                
                .HasColumnName("IdEndereco");

            builder.Property(c => c.CEP)
                .HasColumnName("CEP");

            builder.Property(c => c.Rua)
                .HasColumnName("Rua");

            builder.Property(c => c.Bairro)
                .HasColumnName("Bairro");

            builder.Property(c => c.Cidade)
                .HasColumnName("Cidade");

            builder.Property(c => c.Estado)
                .HasColumnName("Estado");

            builder.Property(c => c.Pais)
                .HasColumnName("Pais");
            
            builder.Property(c => c.IdCliente)
                .HasColumnName("IdCliente");
        }
    
    }
}
