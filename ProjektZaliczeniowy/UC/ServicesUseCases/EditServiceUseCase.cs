using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.ServicesUseCases
{
    public class EditServiceUseCase : IEditServiceUseCase
    {
        private readonly IServiceRepo serviceRepo;
        public EditServiceUseCase(IServiceRepo serviceRepo)
        {
            this.serviceRepo = serviceRepo;
        }

        public void Execute(Service service)
        {
            serviceRepo.EditService(service);
        }
    }
}
