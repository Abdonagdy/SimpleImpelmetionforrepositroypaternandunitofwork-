using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace repositoryPattern
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("Data Source=ABDONAGDY\\ABDONAGDY;Initial Catalog=RepositoryPattern;Integrated Security=True")
        {
        }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Books { get; set; }

    }
}
