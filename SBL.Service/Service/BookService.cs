using SBL.Data.DAO;
using SBL.Data.IDAO;
using SBL.Data.Models.Domain;
using SBL.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Service.Service
{
    public class BookService : IBookService
    {
        private IBookDAO bookDAO;
        public BookService()
        {
            bookDAO = new BookDAO();
        }

        public IList<Book> GetBooks()
        {
            return bookDAO.GetBooks();
        }
    }
}
