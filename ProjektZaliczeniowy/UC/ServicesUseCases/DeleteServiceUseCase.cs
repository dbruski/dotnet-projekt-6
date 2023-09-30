using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class DeleteServiceUseCase : IDeleteServiceUseCase
    {
        private readonly IServiceRepo serviceRepo;
        public DeleteServiceUseCase(IServiceRepo serviceRepo)
        {
            this.serviceRepo = serviceRepo;
        }
        public void DeleteService(string serviceId)
        {
            serviceRepo.DeleteService(serviceId);
        }
    }
}
