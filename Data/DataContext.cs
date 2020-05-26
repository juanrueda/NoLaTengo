using Microsoft.EntityFrameworkCore;
using NoLaTengo.Models;

namespace NoLaTengo.Data {
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) {}

        public DbSet<Category> Categories {get; set; }
        public DbSet<Book> Libros {get; set; }
        public DbSet<Movie> Peliculas {get; set;}
    }
}