using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        // Best practice olarak asenkron metotlara isim verirken metot isimlerinin sonuna "Async" kelimesi eklenmelidir. Örneğin "AddAsync".
        // "Update" ve "Remove" metotlarının asenkron metotları bulunmamaktadır. Bunun sebebi, güncelleme ve silme işlemlerinin uzun süren işlemler olmasıdır.

        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAllAsync();

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
