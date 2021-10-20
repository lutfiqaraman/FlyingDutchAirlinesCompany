using System;
using System.Collections.Generic;

#nullable disable

namespace FlyingDutchAirlines.DatabaseLayer.Models
{
    public partial class Airport
    {
        public Airport()
        {
            FlightDestinationNavigations = new HashSet<Flight>();
            FlightOriginNavigations = new HashSet<Flight>();
        }

        public int AirportId { get; set; }
        public string City { get; set; }
        public string Iata { get; set; }

        public virtual ICollection<Flight> FlightDestinationNavigations { get; set; }
        public virtual ICollection<Flight> FlightOriginNavigations { get; set; }
    }
}
