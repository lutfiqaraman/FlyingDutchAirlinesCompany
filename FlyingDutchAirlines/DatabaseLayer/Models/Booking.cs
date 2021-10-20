using System;
using System.Collections.Generic;

#nullable disable

namespace FlyingDutchAirlines.DatabaseLayer.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int FlightNumber { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Flight FlightNumberNavigation { get; set; }
    }
}
