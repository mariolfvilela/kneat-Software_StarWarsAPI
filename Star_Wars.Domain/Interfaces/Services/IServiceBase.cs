﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Star_Wars.Domain.Common;

namespace Star_Wars.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable
        where TEntity : EntityBase
    {
        /// <summary>
        /// Incluir um registro no banco de dados.
        /// </summary>
        /// <param name="entidade">Entidade a ser incluída.</param>
        /// <returns>A entidade incluída.</returns>
        TEntity Add(TEntity entidade);

        /// <summary>
        /// Excluir um registro no banco de dados.
        /// </summary>
        /// <param name="id">ID do registro a ser excluído.</param>
        void Remove(int id);

        /// <summary>
        /// Excluir um registro no banco de dados.
        /// </summary>
        /// <param name="entidade">Entidade a ser excluída.</param>
        void Excluir(TEntity entidade);

        /// <summary>
        /// Alterar um registro no banco de dados.
        /// </summary>
        /// <param name="entidade">Entidade a ser alterada.</param>
        /// <returns>A entidade alterada.</returns>
        TEntity Update(TEntity entidade);

        /// <summary>
        /// Selecionar um registro no banco de dados.
        /// </summary>
        /// <param name="id">ID do registro a ser retornado.</param>
        /// <returns>Entidade do registro encontrado.</returns>
        TEntity GetById(int id);

        /// <summary>
        /// Selecionar todos os registros no banco de dados para uma determinada entidade.
        /// </summary>
        /// <returns>Uma listagem dos registros encontrados.</returns>
        IEnumerable<TEntity> GetAll();

        Task<IEnumerable<TEntity>> ListAsync();
    }
}
