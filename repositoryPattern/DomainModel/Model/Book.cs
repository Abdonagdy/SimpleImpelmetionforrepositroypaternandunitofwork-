using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositoryPattern
{
  
        [Table("Books")]
        public class Book
        {
            [Key]
            public int ID { get; set; }
            public string Title { get; set; }
            public int Author_ID { get; set; }

            [ForeignKey("Author_ID")]
            public virtual Author Author { get; set; }
        }
    }

