using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Infra.Data.Contexto;

namespace ProjectTemplate.Infra.Data.Repositories
{
    public class PontosEncontroRepositorio : BaseRepositorio<PontosEncontro>, IPontosEncontroRepositorio
    {
        public PontosEncontroRepositorio(BaseContexto context) : base(context)
        {
        }

    }
}
