using Core;
using System.Collections.Generic;

namespace UC.DataStoreInterfaces
{
    public interface IDoctorRepo
    {
        void AddDoctor(Doctor doctor);
        Doctor GetDoctorById(string doctorId);
        IEnumerable<Doctor> GetDoctors();
    }
}