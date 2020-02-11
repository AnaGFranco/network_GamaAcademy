using Dapper;
using Dommel;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        public bool Delete(Guid id)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Delete(id);
            }
        }

        public void Execute(string sql, object parameters)
        {
            using (var db = SqlConnectionFactory.Create())
            {
                db.Query(sql, parameters);
            }
        }

        public IEnumerable<T> Execute<T>(string sql, object parameters)
        {
            using (var db = SqlConnectionFactory.Create())
            {
                return db.Query<T>(sql, parameters);
            }
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Select(predicate);
            }
        }

        public TEntity Get(Guid id)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Get<TEntity>(id);
            }
        }

        public Guid Insert(TEntity entity)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                cn.Insert(entity);

                return entity.Id;
            }
        }

        public bool Update(TEntity entity)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Update(entity);
            }
        }
    }
}
