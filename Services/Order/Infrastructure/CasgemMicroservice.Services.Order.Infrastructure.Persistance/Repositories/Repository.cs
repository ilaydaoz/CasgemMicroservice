using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Infrastructure.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CasgemMicroservice.Services.Order.Infrastructure.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OrderContext _context;

        public Repository(OrderContext context)
        {
            _context = context;
        }

        public async Task<T> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();  
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            //.AsNoTracking() = değişiklik yapmıyor sadece çekiyor delete veya güncellemeişlerimleri yaparken tutmuyor
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetOrderById(Expression<Func<T, bool>> filter = null)
        {
            return await _context.Set<T>().Where(filter).ToListAsync();
            //return filter == null ?
            //     await _context.Set<T>().ToListAsync()
            //     : await _context.Set<T>().Where(filter).ToListAsync(); burda veri olmazsa bütün veileri çekiyor
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
