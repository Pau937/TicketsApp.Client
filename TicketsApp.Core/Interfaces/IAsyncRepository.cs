using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketsApp.Core.Interfaces
{
    public interface IAsyncRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> GetAll();
    }
}
