using repositoryPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static repositoryPattern.Book;

namespace repositoryPattern.unitwork
{
    public interface IUnitOfWork
    {

        IRepository<Author> AuthorRepository {get;}
        IRepository<Book> BookRepository {get;}

        void Commit();
        
        void RejectChanges();
        
    }
}
