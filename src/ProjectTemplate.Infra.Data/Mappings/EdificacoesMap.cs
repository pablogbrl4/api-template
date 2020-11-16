using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTemplate.Domain.Entities;

namespace ProjectTemplate.Infra.Data.Mappings
{
    public class EdificacoesMap : BaseEntidadeMap<Edificacoes>
    {
        public override void Configure(EntityTypeBuilder<Edificacoes> builder)
        {
            base.Configure(builder);

            builder.ToTable("Edificacoes");

            builder.Property(p => p.COD_EDIFICACAO).IsRequired();

            builder.HasIndex(p => p.COD_EDIFICACAO).IsUnique();

        }
    }
}
