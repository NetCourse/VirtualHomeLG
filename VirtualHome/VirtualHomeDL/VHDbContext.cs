using VirtualHomeDL.Models;
using Microsoft.EntityFrameworkCore;

namespace VirtualHomeDL
{
    public class VHDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=XE2130868WC;Database=VHomeDb;Trusted_Connection=True;");
        }

        public DbSet<DoorLock> DoorLocks { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Light> Lights { get; set; }

        public DbSet<TV> TVs { get; set; }
    }
}
