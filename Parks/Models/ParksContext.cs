using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Park>()
            .HasData(
                new Park { ParkId = 1, Name = "Mt. Rainier", Info = "39000 State Route 706 E, Ashford, WA 98304", Alerts = "Rain - 39°F" },
                new Park { ParkId = 2, Name = "Olympic", Info = "3002 Mt Angeles Rd, Port Angeles, WA 98362", Alerts = "Rain 40°F - FMultiple Closures Due to Weather" },
                new Park { ParkId = 3, Name = "North Cascades", Info = "North Cascades Highway, North Cascades National Park, WA", Alerts = "Rain - 39°F - State Route 20 Closed for the Season"},
                new Park { ParkId = 4, Name = "Sucia Island", Info = "Eastsound, Orcas Island, WA", Alerts = "Rain - 43°F" },
                new Park { ParkId = 5, Name = "Ebey's Landing", Info = "Whidbey Island", Alerts = "Rain - 40°F" }
            );
        }
    }
}