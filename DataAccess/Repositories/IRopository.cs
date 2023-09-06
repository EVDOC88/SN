using System.Collections.Generic;
using System.Threading.Tasks;

namespace SN.DataAccess.Repositories
{
    public interface IRepository<T> where T : class
    {
        IAsyncEnumerable<T> GetAllAsync();
        Task<T> GetAsync(int id);
        Task CreateAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(T item);
    }
}