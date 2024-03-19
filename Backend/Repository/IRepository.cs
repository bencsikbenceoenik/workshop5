using System.Linq;

namespace Backend.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Read();
        void Create(T item);
    }
}
