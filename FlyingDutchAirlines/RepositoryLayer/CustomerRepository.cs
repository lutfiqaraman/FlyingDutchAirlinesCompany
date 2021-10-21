using System;
using System.Linq;

namespace FlyingDutchAirlines.RepositoryLayer
{
    public class CustomerRepository
    {
        public bool CreateCustomer(string name)
        {
            if (IsInvalidCustomerName(name))
                return false;

            return true;
        }

        private bool IsInvalidCustomerName(string name)
        {
            char[] notAllowCharacters = { '!', '@', '#', '$', '%', '&', '*'};
            return string.IsNullOrEmpty(name) || name.Any(x => notAllowCharacters.Contains(x));
        }
    }
}
