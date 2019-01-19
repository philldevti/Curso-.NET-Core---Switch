using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {            
            builder.HasKey(c => c.Id);
            builder.Property(c => c.DataPublicacao).IsRequired();
            builder.Property(c => c.Texto).IsRequired().HasMaxLength(600);
            /// Redundante pois já está criado a navegação dentro de usuario
            //builder.HasOne(c => c.Usuario).WithMany(u => u.Comentarios);            
        }
    }
}
