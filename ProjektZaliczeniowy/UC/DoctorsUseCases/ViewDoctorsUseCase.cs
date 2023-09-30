using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC
{
    public class ViewDoctorsUseCase : IViewDoctorsUseCase
    {
        private readonly IDoctorRepo doctorRepo;
        public ViewDoctorsUseCase(IDoctorRepo doctorRepo)
        {
            this.doctorRepo = doctorRepo;
        }
        public IEnumerable<Doctor> Execute()
        {
            return doctorRepo.GetDoctors();
        }
    }
}
