using FlyingDutchAirlines.DatabaseLayer;
using FlyingDutchAirlines.DatabaseLayer.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FlyingDutchAirlines.RepositoryLayer
{
    public class CustomerRepository
    {
        private readonly FlyingDutchmanAirlinesContext Context;

        public CustomerRepository(FlyingDutchmanAirlinesContext context)
        {
            Context = context;
        }

        public async Task<bool> CreateCustomer(string name)
        {
            Customer newCustomer = new Customer(name);

            if (IsInvalidCustomerName(name))
                return false;

            using (Context)
            {
                Context.Customers.Add(newCustomer);
                await Context.SaveChangesAsync();
            }

            return true;
        }

        private bool IsInvalidCustomerName(string name)
        {
            char[] notAllowCharacters = { '!', '@', '#', '$', '%', '&', '*'};
            return string.IsNullOrEmpty(name) || name.Any(x => notAllowCharacters.Contains(x));
        }
    }
}
