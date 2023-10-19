using API_QLHS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_QLHS
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
        {
            
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
