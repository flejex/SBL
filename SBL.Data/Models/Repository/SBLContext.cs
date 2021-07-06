using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBL.Data.Models.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SBL.Data.Models.Repository
{
    public class SBLContext : DbContext
    {
        //specify the connection string to use
        public SBLContext() : base("SBLContext")
        {
            Database.SetInitializer(new SBLInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ReadList> ReadLists { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        //prevent db from pluralizing db name 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
