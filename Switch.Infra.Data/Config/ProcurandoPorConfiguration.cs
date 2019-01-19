using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using System;

namespace Switch.Infra.Data.Config
{
    public class ProcurandoPorConfiguration : IEntityTypeConfiguration<ProcurandoPor>
    {
        public void Configure(EntityTypeBuilder<ProcurandoPor> builder)
        {            
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(400);

            builder.HasData(
                new ProcurandoPor
                {
                    Id = (int)ProcurandoPorEnum.NaoEspecificado,
                    Descricao = "Não Especificado"
                },
                new ProcurandoPor
                {
                    Id = (int)ProcurandoPorEnum.Namoro,
                    Descricao = "Namoro"
                },
                new ProcurandoPor
                {
                    Id = (int)ProcurandoPorEnum.Amizade,
                    Descricao = "Amizade"
                },
                new ProcurandoPor
                {
                    Id = (int)ProcurandoPorEnum.RelacionamentoSerio,
                    Descricao = "Relacionamento Sério"
                }
            );
        }
    }
}
