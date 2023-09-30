using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class ViewServicesUseCase : IViewServicesUseCase
    {
        private readonly IServiceRepo serviceRepo;
        public ViewServicesUseCase(IServiceRepo serviceRepo)
        {
            this.serviceRepo = serviceRepo;
        }

        public IEnumerable<Service> Execute()
        {
            return serviceRepo.GetServicesByCategoryNames();
        }
    }
}
