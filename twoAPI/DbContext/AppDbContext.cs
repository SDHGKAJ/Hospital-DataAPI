using Microsoft.EntityFrameworkCore;
using twoAPI.Model;

    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions _options;
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options) { }
        public DbSet<people> hospital { get; set; }
        
    }

