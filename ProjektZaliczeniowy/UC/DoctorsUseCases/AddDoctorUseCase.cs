using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class AddDoctorUseCase : IAddDoctorUseCase
    {
        private readonly IDoctorRepo doctorRepo;

        public AddDoctorUseCase(IDoctorRepo doctorRepo)
        {
            this.doctorRepo = doctorRepo;
        }
        public void Execute(Doctor doctor)
        {
            doctorRepo.AddDoctor(doctor);
        }
    }
}
