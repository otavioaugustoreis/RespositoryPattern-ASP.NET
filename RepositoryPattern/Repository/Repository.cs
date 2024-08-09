using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Context;
using System.Linq.Expressions;

namespace RepositoryPattern.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public T Delete(T entidade)
        {
            _context.Set<T>().Remove(entidade);
            return entidade;
        }

        public IEnumerable<T> Get()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T? GetId(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public T Post(T entidade)
        {
            _context.Set<T>().Add(entidade);

            return entidade;
        }

        public T Put(T entidade)
        {
            _context.Set<T>().Update(entidade);

            return entidade;
        }
    }
}
