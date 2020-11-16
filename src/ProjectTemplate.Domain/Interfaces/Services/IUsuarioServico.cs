using ProjectTemplate.Domain.Entities;

namespace ProjectTemplate.Domain.Interfaces.Services
{
    public interface IUsuarioServico : IBaseServico<Usuario>
    {
        Usuario FazerLoginByUsuario(string codUsuario, string senhaUsuario);
    }
}
