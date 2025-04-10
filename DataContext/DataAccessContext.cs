using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.DataContext
{
    public class DataAccessContext : DbContext
    {
        public DataAccessContext(DbContextOptions<DataAccessContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }

    }
}
