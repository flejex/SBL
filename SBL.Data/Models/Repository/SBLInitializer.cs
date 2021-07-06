using SBL.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Models.Repository
{
    public class SBLInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SBLContext>
    {
        protected override void Seed(SBLContext context)
        {
            var users = new List<User>
            {
                new User() { Name = "user1", Email = "admin@sbl.com", Mobile = 0700044040, Password = "1234" }
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book() { Name = "book1", Author = "author1", Category = "category1", Date = Convert.ToDateTime("12/11/1979") },
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var authors = new List<Author>
            {
                new Author() { Released = "Released1" },
            };

            authors.ForEach(s => context.Authors.Add(s));
            context.SaveChanges();

            var categories = new List<Category>
            {
                new Category() { },
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var readlists = new List<ReadList>
            {
                new ReadList() { },
            };

            readlists.ForEach(s => context.ReadLists.Add(s));
            context.SaveChanges();

            var favorites = new List<Favorite>
            {
                new Favorite() { },
            };

            favorites.ForEach(s => context.Favorites.Add(s));
            context.SaveChanges();
        }

    }
}
