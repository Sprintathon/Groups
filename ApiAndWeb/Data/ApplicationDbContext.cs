using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiAndWeb.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Venue> Venues { get; set; }
        public DbSet<GroupEvent> GroupEvents { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<EventSchedule> EventSchedules { get; set; }
    }


}
