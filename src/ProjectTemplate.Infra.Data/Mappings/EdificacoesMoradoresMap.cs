using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTemplate.Application.DTOs;

namespace ProjectTemplate.Infra.Data.Mappings
{
    public class EdificacoesMoradoresMap : BaseEntidadeMap<EdificacoesMoradores>
    {
        public override void Configure(EntityTypeBuilder<EdificacoesMoradores> builder)
        {
            base.Configure(builder);

            builder.ToTable("EdificacoesMoradores");

            builder.Property(p => p.COD_EDIFICACAO).IsRequired();

            builder.HasIndex(p => p.COD_EDIFICACAO).IsUnique();

        }
    }
}
