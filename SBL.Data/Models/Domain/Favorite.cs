using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Models.Domain
{
    public class Favorite
    {
        public int FavoriteID { get; set; }

        //forign key to book/user
        //public int BookID { get; set; }

        //can hold more than one entity
        //public virtual Book Name { get; set; }
        //public virtual ICollection<Book> Books { get; set; }
    }
}
