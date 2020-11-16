using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTemplate.Infra.Data.Repositories
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(BaseContexto context) : base(context)
        {
        }

        public Usuario FazerLoginByUsuario(string codUsuario, string senhaUsuario)
        {
            var query =
                     _dbSet.Where(c => c.CodUsuario == codUsuario)
                           .Where(c => c.SenhaUsuario == senhaUsuario)
                               .SingleOrDefault();

            if (query != null)
            {
                return query;
            }

            return null;
        }
    }
}
