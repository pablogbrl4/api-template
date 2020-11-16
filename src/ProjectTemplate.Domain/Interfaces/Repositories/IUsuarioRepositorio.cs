using ProjectTemplate.Domain.Entities;

namespace ProjectTemplate.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario FazerLoginByUsuario(string codUsuario, string senhaUsuario);

    }
}
