
using Microsoft.EntityFrameworkCore;
namespace BookApi.Models;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseMySql(connectionString: @"server=localhost;database=BookStoreDb2;uid=root;password=;", 
        //     new MySqlServerVersion(new Version(10, 4, 17)), 
        //     mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend));
        var connectionString = "server=localhost;database=book;uid=root;password=;";
        var serverVersion = new MySqlServerVersion(new Version(10, 4, 17));
        optionsBuilder.UseMySql(connectionString,serverVersion);
    }

    public DbSet<Book> Books { get; set; }

}