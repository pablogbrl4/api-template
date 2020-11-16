using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;

namespace ProjectTemplate.Domain.Services
{
    public class EdificacoesMoradoresServico : BaseServico<EdificacoesMoradores>, IEdificacoesMoradoresServico
    {
        protected readonly IEdificacoesMoradoresRepositorio _EdificacoesMoradoresRepositorio;

        public EdificacoesMoradoresServico(IEdificacoesMoradoresRepositorio repositorio) : base(repositorio)
        {
            _EdificacoesMoradoresRepositorio = repositorio;
        }

    }
}
