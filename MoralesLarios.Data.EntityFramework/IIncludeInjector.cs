using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace MoralesLarios.Data.EntityFramework
{
    internal interface IIncludeInjector<TEntity> where TEntity : class
    {

        DbQuery<TEntity> InjectorIncludes(DbQuery<TEntity> dbQry, params string[] includes);
        //IQueryable<TEntity> InjectorIncludes<TProperty>(IQueryable<TEntity> dbQry, params Expression<Func<TEntity, TProperty>>[] paths);

    }
}