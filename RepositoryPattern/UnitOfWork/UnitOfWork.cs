using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Context;

namespace RepositoryPattern.UnitOfWork
{
    public class UnitOfWork
    {

        public AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
