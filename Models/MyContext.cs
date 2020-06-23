using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Models
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions options) : base (options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<PlayActivity> PlayActivities {get; set;}
        public DbSet<PlayDate> PlayDates {get; set;}

    }
}