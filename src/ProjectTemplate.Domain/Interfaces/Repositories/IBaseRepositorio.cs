﻿using ProjectTemplate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectTemplate.Domain.Interfaces.Repositories
{
    public interface IBaseRepositorio<T> where T : BaseEntidade
    {
        #region Escrita
        Task<int> Incluir(T entidade);

        Task<T> Alterar(T entidade);

        Task<bool> Excluir(int id);
        #endregion


        #region Leitura
        Task<T> BuscarPorId(int id);

        Task<IEnumerable<T>> BuscarTodos();

        Task<IEnumerable<T>> BuscarTodosComPesquisa(Expression<Func<T, bool>> expression);
        #endregion
    }
}
