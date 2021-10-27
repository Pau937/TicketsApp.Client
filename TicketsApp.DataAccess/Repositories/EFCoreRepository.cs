using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketsApp.Core.Interfaces;
using TicketsApp.DataAccess.Data;

namespace TicketsApp.DataAccess.Repositories
{
    public class EFCoreRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public EFCoreRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        private readonly DataContext _dbContext;
    }
}
