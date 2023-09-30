using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.PatientsUseCases
{
    public class DeletePatientUseCase : IDeletePatientUseCase
    {
        private readonly IPatientRepo patientRepo;
        public DeletePatientUseCase(IPatientRepo patientRepo)
        {
            this.patientRepo = patientRepo;
        }
        public void DeletePatient(string patientId)
        {
            patientRepo.DeletePatient(patientId);
        }
    }
}
