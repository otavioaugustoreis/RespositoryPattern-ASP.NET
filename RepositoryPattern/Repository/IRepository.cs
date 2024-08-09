using System.Linq.Expressions;

namespace RepositoryPattern.Repository
{
    public interface IRepository<T>
    {
        public IEnumerable<T> Get();
        public T GetId(Expression<Func<T, bool>> predicate);
        public T Post(T entidade);
        public T Put(T entidade);
        public T Delete(T entidade);
    }
}
