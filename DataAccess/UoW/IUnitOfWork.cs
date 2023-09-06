using System;
using SN.DataAccess.Repositories;

namespace SN.DataAccess.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges(bool ensureAutoHistory = false);

        IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = true) 
            where TEntity : class;
    }
}
