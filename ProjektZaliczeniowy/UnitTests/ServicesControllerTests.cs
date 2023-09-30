using Core;
using DataStoreInMemory;
using System.Collections.Generic;
using UC.DataStoreInterfaces;
using Xunit;

namespace UnitTests
{
    public class ServicesControllerTests
    {
        private readonly IServiceRepo serviceRepo;

        public ServicesControllerTests()
        {
            serviceRepo = new ServiceInMemoryRepo();

            serviceRepo.AddService(new Service() { CategoryId = "1", Name = "Produkt 1", Price = 20.00 });
        }

        [Fact]
        public void TestAddService_AndGetAllServices()
        {
            serviceRepo.AddService(new Service() { CategoryId = "1", Name = "Produkt 2", Price = 200.00 });

            var result = serviceRepo.GetServices() as List<Service>;

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void TestRemoveService()
        {
            var services = serviceRepo.GetServices() as List<Service>;

            Service recentlyAddedService = services[0];
            Assert.Equal("Produkt 1", recentlyAddedService.Name);

            string recentlyAddedServiceId = recentlyAddedService.ServiceId;

            serviceRepo.DeleteService(recentlyAddedServiceId);

            var servicesAfterRemoval = serviceRepo.GetServices() as List<Service>;

            Assert.Equal(0, servicesAfterRemoval.Count);
        }

        [Fact]
        public void TestAndGetServiceById()
        {
            var services = serviceRepo.GetServices() as List<Service>;

            string recentlyAddedServiceId = services[0].ServiceId;

            Service serviceFromGet = serviceRepo.GetServiceById(recentlyAddedServiceId);

            Assert.Equal("Produkt 5", serviceFromGet.Name);
            Assert.Equal(600.00, serviceFromGet.Price);
        }
    }
}