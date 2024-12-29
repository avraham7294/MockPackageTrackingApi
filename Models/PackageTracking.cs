using System;

namespace MockPackageTrackingApi.Models
{
    public class PackageTracking
    {
        public string Id { get; set; } // This will store the tracking number and act as the primary key
        public string Carrier { get; set; }
        public string Status { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
}
