using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class GetServiceByIdUseCase : IGetServiceByIdUseCase
    {
        private readonly IServiceRepo serviceRepo;
        public GetServiceByIdUseCase(IServiceRepo serviceRepo)
        {
            this.serviceRepo = serviceRepo;
        }

        public Service Execute(string serviceId)
        {
            return serviceRepo.GetServiceById(serviceId);
        }
    }
}
