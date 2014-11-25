using Abp.Domain.Entities;
using Abp.EntityFramework.Repositories;

namespace Onderdelenshop.EntityFramework.Repositories
{
    public abstract class OnderdelenshopRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<OnderdelenshopDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class OnderdelenshopRepositoryBase<TEntity> : OnderdelenshopRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
