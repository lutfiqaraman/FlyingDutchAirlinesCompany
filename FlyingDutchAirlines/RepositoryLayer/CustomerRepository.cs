using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingDutchAirlines.RepositoryLayer
{
    public class CustomerRepository
    {
        public bool CreateCustomer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return true;
        }
    }
}
