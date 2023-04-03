using repositoryPattern.unitwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork  unitOfWork = new UnitOfWork();
            // Create
            var author = new Author() { Name = "Kris" };
            unitOfWork.AuthorRepository.Add(author);
            unitOfWork.Commit(); // Save changes to database
            // Update
            author = unitOfWork.AuthorRepository.Entities
                .FirstOrDefault(n => n.Name == "kris");
            author.Name = "Dan";
            unitOfWork.Commit(); // Save changes to database
            // Delete
            author = unitOfWork.AuthorRepository.Entities
                .FirstOrDefault(n => n.Name == "Dan");
            unitOfWork.AuthorRepository.Remove(author);
            unitOfWork.Commit(); // Save changes to database
            //Console.WriteLine(author.Name);
            // Delete
            author = unitOfWork.AuthorRepository.Entities
                 .FirstOrDefault(n => n.Name == "Dan");
            unitOfWork.AuthorRepository.Remove(author);
          //  Ops i don't want to do this
            unitOfWork.RejectChanges(); // Reject all changes
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
