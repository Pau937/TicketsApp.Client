using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketsApp.Core.Interfaces;

namespace TicketsApp.DataAccess.Repositories
{
    public class EFCoreRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public EFCoreRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected readonly DataContext _dbContext;
    }
}
