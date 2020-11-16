using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;

namespace ProjectTemplate.Domain.Services
{
    public class PontosEncontroServico : BaseServico<PontosEncontro>, IPontosEncontroServico
    {
        protected readonly IPontosEncontroRepositorio _PontosEncontroRepositorio;

        public PontosEncontroServico(IPontosEncontroRepositorio repositorio) : base(repositorio)
        {
            _PontosEncontroRepositorio = repositorio;
        }

    }
}
