using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;

namespace ProjectTemplate.Domain.Services
{
    public class EdificacoesServico : BaseServico<Edificacoes>, IEdificacoesServico
    {
        protected readonly IEdificacoesRepositorio _EdificacoesRepositorio;

        public EdificacoesServico(IEdificacoesRepositorio repositorio) : base(repositorio)
        {
            _EdificacoesRepositorio = repositorio;
        }

    }
}
