using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");

            builder.Property(e => e.Id).HasColumnType("int(11)");

            builder.Property(e => e.DataNascimento).HasColumnType("datetime");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(400)");

            builder.Property(e => e.Senha)
                .IsRequired()
                .HasColumnType("varchar(12)");

            builder.Property(e => e.Sexo).HasColumnType("int(11)");

            builder.Property(e => e.SobreNome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.UrlFoto)
                .IsRequired()
                .HasColumnType("varchar(500)");
        }
    }
}
