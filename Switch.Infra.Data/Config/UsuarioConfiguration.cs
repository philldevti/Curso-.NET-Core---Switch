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
            builder.HasKey((u) => u.Id);
            builder.Property((u) => u.Nome).HasMaxLength(400).IsRequired();
            builder.Property((u) => u.Senha).HasMaxLength(12).IsRequired();
            builder.Property((u) => u.Sexo).IsRequired();
            builder.Property((u) => u.SobreNome).HasMaxLength(100).IsRequired();
            builder.Property((u) => u.UrlFoto).HasMaxLength(500).IsRequired();
            builder.Property((u) => u.DataNascimento).IsRequired();
        }
    }
}
