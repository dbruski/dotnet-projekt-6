using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.ServicesUseCases
{
    public class AddServiceUseCase : IAddServiceUseCase
    {
        private readonly IServiceRepo serviceRepo;
        public AddServiceUseCase(IServiceRepo serviceRepo)
        {
            this.serviceRepo = serviceRepo;
        }

        public void Execute(Service service)
        {
            serviceRepo.AddService(service);
        }
    }
}
