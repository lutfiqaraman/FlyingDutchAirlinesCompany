using System;
using System.Collections.Generic;

#nullable disable

namespace FlyingDutchAirlines.DatabaseLayer.Models
{
    public partial class Flight
    {
        public Flight()
        {
            Bookings = new HashSet<Booking>();
        }

        public int FlightNumber { get; set; }
        public int Origin { get; set; }
        public int Destination { get; set; }

        public virtual Airport DestinationNavigation { get; set; }
        public virtual Airport OriginNavigation { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
