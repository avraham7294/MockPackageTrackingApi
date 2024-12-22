using System;

namespace MockPackageTrackingApi.Models
{
    public class PackageTracking
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        public string Status { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
}
