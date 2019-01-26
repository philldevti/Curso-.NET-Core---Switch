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
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome).IsRequired().HasMaxLength(400);
            builder.Property(e => e.Senha).IsRequired().HasMaxLength(400);
            builder.Property(e => e.Sexo).IsRequired();
            builder.Property(e => e.SobreNome).IsRequired().HasMaxLength(400);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(400);
            builder.Property(e => e.UrlFoto).IsRequired().HasMaxLength(400);
            builder.Property(e => e.DataNascimento).IsRequired();
            builder.HasOne(e => e.Identificacao).WithOne(i => i.Usuario).HasForeignKey<Identificacao>(o => o.UsuarioId);
            builder.HasMany(u => u.Comentarios).WithOne(c => c.Usuario);
            builder.HasMany(u => u.Amigos).WithOne(c => c.Usuario);            
            builder.HasMany(u => u.Postagens).WithOne(p => p.Usuario);
            builder.HasMany(u => u.UsuarioGrupos).WithOne(p => p.Usuario);
            builder.HasOne(u => u.StatusRelacionamento);
            builder.HasOne(u => u.ProcurandoPor);

        }
    }
}
