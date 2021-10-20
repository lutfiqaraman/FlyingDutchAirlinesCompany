using System;
using System.Collections.Generic;

#nullable disable

namespace FlyingDutchAirlines.DatabaseLayer.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bookings = new HashSet<Booking>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
