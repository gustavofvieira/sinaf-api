using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using SinafApi.Infra.Data.Context;
using SinafApi.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SinafApi.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected DBSinafContext _Db;
        // Flag: Has Dispose already been called?
        bool disposed = false;

        public BaseRepository(DBSinafContext Db)
        {
            _Db = Db;
        }

        public void CheckContext()
        {
            //Se existe um contexto novo
            // if (_Db == null  || _Db.IsDisposed())
            //     _Db = ContextUtils.GetNewContext();
        }

        public IQueryable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            CheckContext();
            var tEntities = _Db.Set<TEntity>().Where(predicate);
            return tEntities;
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            CheckContext();
            return _Db.Set<TEntity>().Any(predicate);
        }


        /// <summary>
        /// Obtem O registro de uma determinada entidade a partir do seu Id.
        /// </summary>
        /// <param name="id">Id da Entidade.</param>
        /// <returns></returns>
        public virtual TEntity ObtemPorId(params object[] id)
        {
            CheckContext();
            return _Db.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// GetBy, Metodo de busca Dinamica da Entidade.
        /// </summary>
        /// <param name="predicate"> Expresão lambda para Consulta ex: x=>x.id == varId </param>
        /// <param name="includes"> Array de Includes Necessarios caso precisde de proxyLoad para o objeto retornado , ex: x=>x.Table1, x=>x.table2 </param>
        /// <returns>Retorna a Entidade.</returns>
        public TEntity GetBy(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            return GetByAsQueryable(predicate, includes).FirstOrDefault();
        }

        /// <summary>
        /// Metodo de busca Dinamica da Entidade como IEnumerable.
        /// </summary>
        /// <param name="predicate"> Expresão lambda para para Consulta ex: x=>x.id == varId </param>
        /// <param name="includes"> Array de Includes Necessarios caso precisde de proxyLoad para o objeto retornado , ex: x=>x.Table1, x=>x.table2 </param>
        /// <returns>Retorna uma lista da entidade.</returns>
        public IEnumerable<TEntity> GetByToList(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            return GetByAsQueryable(predicate, includes).ToList();
        }

        /// <summary>
        /// GetBy, Metodo de busca Dinamica da Entidade como IQueryable.
        /// </summary>
        /// <param name="predicate"> Expresão lambda para para Consulta ex: x=>x.id == varId </param>
        /// <param name="includes"> Array de Includes Necessarios caso precisde de proxyLoad para o objeto retornado , ex: x=>x.Table1, x=>x.table2 </param>
        /// <returns>Retorna como IQueryable.</returns>
        public IQueryable<TEntity> GetByAsQueryable(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> result = Entity();
            if (predicate != null)
            {
                result = result.Where(predicate);
            }
            if (includes.Any())
            {
                result = includes.Aggregate(result, (current, include) => current.Include(include));
            }
            return result;
        }

        /// <summary>
        /// Obtem uma lista de todos os registros de uma determinada entidade.
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> ObtemTodos()
        {
            return Entity();
        }

        /// <summary>
        /// Obtém a Entidade do Repositório Atual.
        /// </summary>
        /// <returns></returns>
        public DbSet<TEntity> Entity()
        {
            CheckContext();
            return _Db.Set<TEntity>();
        }


        /// <summary>
        /// Atualiza o registro no banco de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser atualizado.</param>
        public void Update(TEntity obj)
        {
            CheckContext();
            _Db.Entry(obj).State = EntityState.Modified;
            _Db.SaveChanges();
        }

        public void Update(TEntity obj, params Expression<Func<TEntity, object>>[] properties)
        {
            CheckContext();
            _Db.Set<TEntity>().Attach(obj);
            var entityToUpdate = _Db.Entry(obj);

            foreach (var property in properties)
            {
                entityToUpdate.Property(property).IsModified = true;
            }
            _Db.SaveChanges();
        }

        /// <summary>
        /// Deleta o registro fisicamente no banco de dados.
        /// </summary>
        /// <param name="obj">Objeto a ser excluído.</param>
        public void Remove(TEntity obj)
        {
            CheckContext();
            _Db.Set<TEntity>().Remove(obj);
            _Db.SaveChanges();
        }

        public virtual void Remove(params object[] id)
        {
            CheckContext();
            var obj = _Db.Set<TEntity>().Find(id);
            if (obj != null)
            {
                _Db.Set<TEntity>().Remove(obj);
            }
        }

        /// <summary>
        /// Salva o registro no banco e retorna o Id do registro gravado.
        /// </summary>
        /// <param name="obj">Objeto a ser Salvo.</param>
        /// <returns></returns>
        public TEntity Add(TEntity obj)
        {
            CheckContext();
            _Db.Set<TEntity>().Add(obj);
            _Db.SaveChanges();

            return obj;
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ///// <summary>
        ///// Retorna o GETDATE() do banco de dados
        ///// </summary>
        ///// <returns></returns>
        public DateTime GetDbDate()
        {
            // está pegando temporariamento o horário do sistema,
            // mas futuramente precisa pegar a hora do Banco.
            return DateTime.Now;
        }

	}
}