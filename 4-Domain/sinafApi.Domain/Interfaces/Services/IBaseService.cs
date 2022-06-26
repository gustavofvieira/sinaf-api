using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SinafApi.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : class
    {

        /// <summary>
        /// Salva o registro no banco e retorna o Id do registro gravado.
        /// </summary>
        /// <param name="obj">Objeto a ser Salvo.</param>
        /// <returns></returns>
        TEntity Add(TEntity obj);


        /// <summary>
        /// Obtem O registro de uma determinada entidade a partir do seu Id.
        /// </summary>
        /// <param name="predicate">Expression<Func<TEntity, bool>></param>
        /// <returns>IEnumerable<TEntity></returns>
        IQueryable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Checar se existe registro dentro de um predicado.
        /// </summary>
        /// <param name="predicate">Expression<Func<TEntity, bool>></param>
        /// <returns>bool</returns>
        bool Any(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Obtem O registro de uma determinada entidade a partir do seu Id.
        /// </summary>
        /// <param name="id">Id da Entidade.</param>
        /// <returns></returns>
        TEntity ObtemPorId(params object[] id);

        /// <summary>
        /// Obtem uma lista de todos os registros de uma determinada entidade.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> ObtemTodos();

        /// <summary>
        /// Obtém a Entidade do Repositório Atual.
        /// </summary>
        /// <returns></returns>
        DbSet<TEntity> Entity();

        /// <summary>
        /// Atualiza o registro no banco de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser atualizado.</param>
        void Update(TEntity obj);

        /// <summary>
        /// Atualiza o registro no banco de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser atualizado.</param>
        /// <param name="properties">Expression<Func<TEntity, object>>[] properties Propriedades a ser atualizadas</param>
        void Update(TEntity obj, params Expression<Func<TEntity, object>>[] properties);

        /// <summary>
        /// Deleta o registro fisicamente no banco de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser excluído.</param>
        void Remove(TEntity obj);

        /// <summary>
        /// Deleta o registro fisicamente no banco de dados pela chave primaria
        /// </summary>
        /// <param name="id">Id da Entidade.</param>
        /// <returns></returns>
        void Remove(params object[] id);
        /// <summary>
        /// GetBy, Metodo de busca Dinamica da Entidade.
        /// </summary>
        /// <param name="predicate"> Expresão lambda para Consulta ex: x=>x.id == varId </param>
        /// <param name="includes"> Array de Includes Necessarios caso precisde de proxyLoad para o objeto retornado , ex: x=>x.Table1, x=>x.table2 </param>
        /// <returns>Retorna a Entidade.</returns>
        TEntity GetBy(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// Metodo de busca Dinamica da Entidade como IEnumerable.
        /// </summary>
        /// <param name="predicate"> Expresão lambda para para Consulta ex: x=>x.id == varId </param>
        /// <param name="includes"> Array de Includes Necessarios caso precisde de proxyLoad para o objeto retornado , ex: x=>x.Table1, x=>x.table2 </param>
        /// <returns>Retorna uma lista da entidade.</returns>
        IEnumerable<TEntity> GetByToList(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        /// <summary>
        /// GetBy, Metodo de busca Dinamica da Entidade como IQueryable.
        /// </summary>
        /// <param name="predicate"> Expresão lambda para para Consulta ex: x=>x.id == varId </param>
        /// <param name="includes"> Array de Includes Necessarios caso precisde de proxyLoad para o objeto retornado , ex: x=>x.Table1, x=>x.table2 </param>
        /// <returns>Retorna como IQueryable.</returns>
        IQueryable<TEntity> GetByAsQueryable(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);


    }
}
