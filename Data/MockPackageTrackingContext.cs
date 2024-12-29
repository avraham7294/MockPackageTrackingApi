using Microsoft.EntityFrameworkCore;
using MockPackageTrackingApi.Models;

namespace MockPackageTrackingApi.Data
{
    public class MockPackageTrackingContext : DbContext
    {
        public MockPackageTrackingContext(DbContextOptions<MockPackageTrackingContext> options) : base(options) { }

        public DbSet<PackageTracking> PackageTrackings { get; set; }
    }
}