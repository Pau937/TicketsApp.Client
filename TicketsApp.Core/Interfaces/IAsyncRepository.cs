using System.Threading.Tasks;

namespace TicketsApp.Core.Interfaces
{
    public interface IAsyncRepository<T>
    {
        Task<T> GetByIdAsync(int id);
    }
}
