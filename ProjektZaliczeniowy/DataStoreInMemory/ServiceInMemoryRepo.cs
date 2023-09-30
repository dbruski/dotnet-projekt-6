using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace DataStoreInMemory
{
    public class ServiceInMemoryRepo : IServiceRepo
    {
        private List<Service> services;

        public ServiceInMemoryRepo()
        {
            services = new List<Service>();
        }

        public IEnumerable<Service> GetServices()
        {
            return services;
        }

        public IEnumerable<Service> GetServicesByCategoryNames()
        {
            var result = from s in services
                        orderby s.CategoryId ascending
                        select s;
            return result;
        }

        public void AddService(Service service)
        {
            Guid guid = Guid.NewGuid();
            service.ServiceId = guid.ToString();

            services.Add(service);
        }

        public void EditService(Service service)
        {
            var serviceToUpdate = GetServiceById(service.ServiceId);
            if (serviceToUpdate != null)
            {
                serviceToUpdate = service;
            }
        }

        public Service GetServiceById(string serviceId)
        {
            return services?.Find(serv => serv.ServiceId == serviceId);
        }

        public void DeleteService(string serviceId)
        {
            services?.Remove(GetServiceById(serviceId));
        }
    }
}
