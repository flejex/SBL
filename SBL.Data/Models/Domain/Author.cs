using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Models.Domain
{
    public class Author
    {
        public int AuthorID { get; set; }
        //public int BookID { get; set; }
        public string Released { get; set; }

        //public virtual Book Name { get; set; }
        //public virtual ICollection<Book> Books { get; set; }

    }
}
