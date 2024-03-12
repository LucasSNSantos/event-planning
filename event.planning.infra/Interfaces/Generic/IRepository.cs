using System.Linq.Expressions;

namespace infra.Interfaces.Generic
{
    public interface IRepository<T> where T : class
    {
        ValueTask<IEnumerable<T>> GetAll();
        ValueTask<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        ValueTask<IEnumerable<T>> FindLoaded(Expression<Func<T, bool>> predicate);
        ValueTask<T> GetById(int id);
        bool Remove(T entity);
        void Add(T entity);
        void Update(T entity);

    }
}
