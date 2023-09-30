using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace DataStoreInMemory
{
    public class PatientInMemoryRepo : IPatientRepo
    {
        private List<Patient> patients;

        public PatientInMemoryRepo()
        {
            patients = new List<Patient>();
        }

        public IEnumerable<Patient> GetPatients()
        {
            return patients;
        }

        public void AddPatient(Patient patient)
        {
            string yearFromBirthday = patient.Birthday.Year.ToString().Substring(2, 2);
            string monthFromBirthday = patient.Birthday.Month < 10 ? $"0{patient.Birthday.Month}" : patient.Birthday.Month.ToString();
            string dayFromBirthday = patient.Birthday.Day < 10 ? $"0{patient.Birthday.Day}" : patient.Birthday.Day.ToString();

            string yearFromPesel = patient.Pesel.Substring(0, 2);
            string monthFromPesel = patient.Pesel.Substring(2, 2);
            string dayFromPesel = patient.Pesel.Substring(4, 2);

            if (yearFromBirthday != yearFromPesel || monthFromBirthday != monthFromPesel || dayFromBirthday != dayFromPesel)
            {
                throw new ArgumentException("Pesel nie zgadza się z datą urodzenia!");
            }

            if (DateTime.Compare(patient.Birthday, DateTime.Now) > 0)
            {
                throw new ArgumentException("Data urodzenia nie może być późniejsza niż dziś!");
            }

            Guid guid = Guid.NewGuid();
            patient.PatientId = guid.ToString();

            patients.Add(patient);
        }

        public void EditPatient(Patient patient)
        {
            var patientToUpdate = GetPatientById(patient.PatientId);
            if (patientToUpdate != null)
            {
                patientToUpdate = patient;
            }
        }

        public Patient GetPatientById(string patientId)
        {
            return patients?.Find(patient => patient.PatientId == patientId);
        }

        public void DeletePatient(string patientId)
        {
            patients?.Remove(GetPatientById(patientId));
        }
    }
}
