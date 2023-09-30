using Core;
using DataStoreInMemory;
using System;
using System.Collections.Generic;
using UC.DataStoreInterfaces;
using Xunit;

namespace UnitTests
{
    public class PatientsControllerTests
    {
        private readonly IPatientRepo patientsRepo;

        public PatientsControllerTests()
        {
            patientsRepo = new PatientInMemoryRepo();
            
            patientsRepo.AddPatient(new Patient() { PatientId = "1", Name = "Pacjent", LastName = "Pierwszy", Birthday = new System.DateTime(1999, 1, 13), Pesel = "99011312345", PhoneNumber = "600700800" });
        }

        [Fact]
        public void TestAdDPatient_AndGetAllPatients()
        {
           patientsRepo.AddPatient(new Patient() { PatientId = "2", Name = "Pacjent", LastName = "Drugi", Birthday = new System.DateTime(1988, 3, 23), Pesel = "88032312345", PhoneNumber = "600700800" });

            var result = patientsRepo.GetPatients() as List<Patient>;

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void TestAddPatientWithNotMatchingBirthdayAndPesel()
        {
            Assert.Throws<ArgumentException>(() => patientsRepo.AddPatient(new Patient() { PatientId = "1", Name = "Pacjent", LastName = "Pierwszy", Birthday = new System.DateTime(1999, 1, 13), Pesel = "55060612345", PhoneNumber = "600700800" }));
        }

        [Fact]
        public void TestAddPatientWithBirthdayInTheFuture()
        {
            Assert.Throws<ArgumentException>(() => patientsRepo.AddPatient(new Patient() { PatientId = "1", Name = "Pacjent", LastName = "Pierwszy", Birthday = new System.DateTime(2030, 5, 23), Pesel = "55060612345", PhoneNumber = "600700800" }));
        }

        [Fact]
        public void TestRemovePatient()
        {
            var patients = patientsRepo.GetPatients() as List<Patient>;

            Patient recentlyAddedPatient = patients[0];
            Assert.Equal("Pierwszy", recentlyAddedPatient.LastName);

            string recentlyAddedPatientId = recentlyAddedPatient.PatientId;

            patientsRepo.DeletePatient(recentlyAddedPatientId);

            var patientsAfterRemoval = patientsRepo.GetPatients() as List<Patient>;

            Assert.Equal(0, patientsAfterRemoval.Count);
        }

        [Fact]
        public void TestGetPatientById()
        {
            var patients = patientsRepo.GetPatients() as List<Patient>;

            string recentlyAddedPatientId = patients[0].PatientId;

            Patient patientFromGet = patientsRepo.GetPatientById(recentlyAddedPatientId);

            Assert.Equal("Pacjent", patientFromGet.Name);
            Assert.Equal("Pierwszy", patientFromGet.LastName);
        }
    }
}