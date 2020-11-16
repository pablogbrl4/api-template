using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTemplate.Domain.Entities;

namespace ProjectTemplate.Infra.Data.Mappings
{
    public class PontosEncontroMap : BaseEntidadeMap<PontosEncontro>
    {
        public override void Configure(EntityTypeBuilder<PontosEncontro> builder)
        {
            base.Configure(builder);

            builder.ToTable("PontosEncontro");

            builder.Property(p => p.Name).IsRequired();

        }
    }
}
