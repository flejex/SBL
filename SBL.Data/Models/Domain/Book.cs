using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Models.Domain
{
    public class Book
    {
        public int BookID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public System.DateTime Date { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<ReadList> ReadLists { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}
