using Microsoft.EntityFrameworkCore;
using WebRPG.Models;

namespace WebRPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapon  { get; set; }
    }
}
