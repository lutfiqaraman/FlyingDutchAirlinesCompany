using FlyingDutchAirlines.DatabaseLayer;
using FlyingDutchAirlines.RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace FlyingDutchmanAirlines_Tests
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        private FlyingDutchmanAirlinesContext Context;
        private CustomerRepository Repository;

        [TestInitialize]
        public void TestInitialize()
        {
            DbContextOptions<FlyingDutchmanAirlinesContext> dbContextOptions = 
                new DbContextOptionsBuilder<FlyingDutchmanAirlinesContext>().UseInMemoryDatabase("FlyingDutchmanAirlines").Options;

            Context = new FlyingDutchmanAirlinesContext(dbContextOptions);
            Repository = new CustomerRepository(Context);
            
            Assert.IsNotNull(Repository);
        }

        [TestMethod]
        public async Task CreateCustomer_Success()
        {
            bool result = await Repository.CreateCustomer("Donald Knuth");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task CreateCustomer_Failure_NameIsNull()
        {
            bool result = await Repository.CreateCustomer(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CreateCustomer_Failure_NameIsEmptyString()
        {
            Task<bool> task = Repository.CreateCustomer(string.Empty);
            Assert.IsFalse(task.Result);
        }

        [TestMethod]
        [DataRow('#')]
        [DataRow('$')]
        [DataRow('%')]
        [DataRow('&')]
        [DataRow('*')]
        public async Task CreateCustomer_Failure_NameContainsNotAllowedCharacters(char notAllowedCharacter)
        {
            bool result = await Repository.CreateCustomer("Donald Knuth" + notAllowedCharacter);
            Assert.IsFalse(result);
        }
    }
}
