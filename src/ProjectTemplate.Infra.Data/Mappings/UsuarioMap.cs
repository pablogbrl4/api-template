using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTemplate.Application.DTOs;

namespace ProjectTemplate.Infra.Data.Mappings
{
    public class UsuarioMap : BaseEntidadeMap<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);

            builder.ToTable("Usuario");

            // builder.Property(p => p.CodUsuario).IsRequired().HasColumnName("");

            builder.Property(p => p.CodUsuario).IsRequired();

            builder.Property(p => p.SenhaUsuario).IsRequired();



        }
    }
}
