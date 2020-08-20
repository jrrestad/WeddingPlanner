using Microsoft.EntityFrameworkCore;

namespace Wedding_Planner_Two.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Wedding> Weddings {get;set;}
        public DbSet<Attending> Attendees {get;set;}
    }
}