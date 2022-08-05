using ApiAndDatabase.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiAndDatabase
{
    public class DBContextBooks:DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DBContextBooks(DbContextOptions options) : base(options) { }
    }
}
