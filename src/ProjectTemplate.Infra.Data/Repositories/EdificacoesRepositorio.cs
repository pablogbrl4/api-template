using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Infra.Data.Contexto;

namespace ProjectTemplate.Infra.Data.Repositories
{
    public class EdificacoesRepositorio : BaseRepositorio<Edificacoes>, IEdificacoesRepositorio
    {
        public EdificacoesRepositorio(BaseContexto context) : base(context)
        {
        }

    }
}
