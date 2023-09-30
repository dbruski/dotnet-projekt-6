using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class GetDoctorByIdUseCase : IGetDoctorByIdUseCase
    {
        private readonly IDoctorRepo doctorRepo;
        public GetDoctorByIdUseCase(IDoctorRepo doctorRepo)
        {
            this.doctorRepo = doctorRepo;
        }

        public Doctor Execute(string doctorId)
        {
            return doctorRepo.GetDoctorById(doctorId);
        }
    }
}
