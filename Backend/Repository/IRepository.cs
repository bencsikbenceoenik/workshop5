using System.Linq;

namespace Backend.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> ReadAll();
        void Create(T item);
    }
}
