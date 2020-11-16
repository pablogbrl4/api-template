using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Infra.Data.Contexto;

namespace ProjectTemplate.Infra.Data.Repositories
{
    public class EdificacoesMoradoresRepositorio : BaseRepositorio<EdificacoesMoradores>, IEdificacoesMoradoresRepositorio
    {
        public EdificacoesMoradoresRepositorio(BaseContexto context) : base(context)
        {
        }

    }
}
