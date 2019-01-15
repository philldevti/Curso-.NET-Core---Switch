using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class StatusrelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.ToTable("statusrelacionamento");

            builder.Property(e => e.Id).HasColumnType("int(11)");

            builder.Property(e => e.Description).HasColumnType("text");
        }
    }
}
