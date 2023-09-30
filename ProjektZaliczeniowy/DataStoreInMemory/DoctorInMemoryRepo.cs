using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace DataStoreInMemory
{
    public class DoctorInMemoryRepo : IDoctorRepo
    {
        private List<Doctor> doctors;

        public DoctorInMemoryRepo()
        {
            doctors = new List<Doctor>();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return doctors;
        }

        public void AddDoctor(Doctor doctor)
        {
            Guid guid = Guid.NewGuid();
            doctor.DoctorId = guid.ToString();

            doctors.Add(doctor);
        }

        public Doctor GetDoctorById(string doctorId)
        {
            return doctors?.Find(doctor => doctor.DoctorId == doctorId);
        }
    }
}
