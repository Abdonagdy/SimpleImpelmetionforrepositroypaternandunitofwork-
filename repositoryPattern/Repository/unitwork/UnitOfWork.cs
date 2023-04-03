using repositoryPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static repositoryPattern.Book;

namespace repositoryPattern.unitwork
{
    public class UnitOfWork : IUnitOfWork
    {
        //inject context
        private  MyDbContext _dbContext;
        #region Repositories
        public IRepository<Author> AuthorRepository =>
           new GenericRepository<Author>(_dbContext);
        public IRepository<Book> BookRepository =>
           new GenericRepository<Book>(_dbContext);
        #endregion
        public UnitOfWork()
        {
            _dbContext = new MyDbContext();
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
         public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries()
                  .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
