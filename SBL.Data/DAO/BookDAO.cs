using SBL.Data.IDAO;
using SBL.Data.Models.Domain;
using SBL.Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.DAO
{
    public class BookDAO : IBookDAO
    {
        private SBLContext context;
        public BookDAO()
        {
            context = new SBLContext();
        }
        public IList<Book> GetBooks()
        {
            return context.Books.ToList();
        }
    }
}
