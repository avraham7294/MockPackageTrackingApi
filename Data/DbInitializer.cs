using System;
using System.Linq;
using MockPackageTrackingApi.Models;

namespace MockPackageTrackingApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MockPackageTrackingContext context)
        {
            context.Database.EnsureCreated();

            if (context.Packages.Any())
            {
                return; // Database has been seeded
            }

            var packages = new[]
            {
                new PackageTracking
                {
                    TrackingNumber = "ABC123456",
                    Carrier = "MockCarrier",
                    Status = "In Transit",
                    ShippingDate = DateTime.Now.AddDays(-5),
                    DeliveryDate = DateTime.Now.AddDays(2),
                    Origin = "New York, NY",
                    Destination = "Los Angeles, CA"
                },
                new PackageTracking
                {
                    TrackingNumber = "DEF789012",
                    Carrier = "MockCarrier",
                    Status = "Delivered",
                    ShippingDate = DateTime.Now.AddDays(-10),
                    DeliveryDate = DateTime.Now.AddDays(-3),
                    Origin = "Chicago, IL",
                    Destination = "Houston, TX"
                }
            };

            context.Packages.AddRange(packages);
            context.SaveChanges();
        }
    }
}
