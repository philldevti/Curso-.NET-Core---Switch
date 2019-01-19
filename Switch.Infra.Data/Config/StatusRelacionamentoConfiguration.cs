using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using System;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Descricao).HasMaxLength(400);

            builder.HasData(
                new StatusRelacionamento
                {
                    Id = (int)StatusRelacionamentoEnum.NaoEspecificado,
                    Descricao = "Não Especificado"
                },
                new StatusRelacionamento
                {
                    Id = (int)StatusRelacionamentoEnum.Solteiro,
                    Descricao = "Solteiro"
                },
                new StatusRelacionamento
                {
                    Id = (int)StatusRelacionamentoEnum.Casado,
                    Descricao = "Casado"
                },
                new StatusRelacionamento
                {
                    Id = (int)StatusRelacionamentoEnum.EmRelacionamentoSerio,
                    Descricao = "Em Relacionamento Sério"
                }
            );
        }
    }
}
