using ConnectFourApp.Shared.Models;

using Microsoft.EntityFrameworkCore;

namespace ConnectFourApp.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
    }
}
