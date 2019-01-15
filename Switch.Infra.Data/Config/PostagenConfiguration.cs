using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class PostagenConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {

            builder.ToTable("postagens");

            builder.Property(e => e.Id).HasColumnType("int(11)");

            builder.Property(e => e.DataPublicacao).HasColumnType("datetime");

            builder.Property(e => e.Texto).HasColumnType("text");

        }
    }
}
