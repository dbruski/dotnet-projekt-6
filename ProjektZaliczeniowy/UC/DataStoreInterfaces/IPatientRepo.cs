using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC.DataStoreInterfaces
{
    public interface IPatientRepo
    {
        public IEnumerable<Patient> GetPatients();

        public void AddPatient(Patient patient);

        public void EditPatient(Patient patient);

        public Patient GetPatientById(string patientId);

        public void DeletePatient(string patientId);
    }
}
