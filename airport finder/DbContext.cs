using airport_finder.Models;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System.Runtime;

namespace airport_finder
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }



        public DbSet<AirportInfo> airportinfo { get; set; }
        public DbSet<CityInfo> cityInfo { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<StateImg> StateImg { get; set; }

    }
}
