using Microsoft.EntityFrameworkCore;
using PitchProPlannerApi.Models;

namespace PitchProPlannerApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options) { }

        public DbSet<Exercise> Exercise { get; set; }
    }
}
