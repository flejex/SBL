using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Models.Domain
{
    public class ReadList
    {
        public int ReadListID { get; set; }
        //public int BookID { get; set; }
        public virtual Book Name { get; set; }

        //public virtual ICollection<Book> Books { get; set; }
    }
}
