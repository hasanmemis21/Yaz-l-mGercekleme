using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace YazılımGercekleme.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BooksDetails { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=nTierBookDb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AuthorConfig());
            //modelBuilder.ApplyConfiguration(new BookAuthorConfig());
            //modelBuilder.ApplyConfiguration(new BookConfig());
            //modelBuilder.ApplyConfiguration(new BookDetailConfig());
            //modelBuilder.ApplyConfiguration(new CategoryConfig());
            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuthorConfig).Assembly);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
