using ApiApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }

        public DbSet<AppUser> Users { get; set; }
    }
}