using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC.DataStoreInterfaces
{
    public interface IServiceRepo
    {
        public IEnumerable<Service> GetServices();

        public IEnumerable<Service> GetServicesByCategoryNames();

        public void AddService(Service service);

        public void EditService(Service service);

        public Service GetServiceById(string serviceId);

        public void DeleteService(string serviceId); 
    }
}
