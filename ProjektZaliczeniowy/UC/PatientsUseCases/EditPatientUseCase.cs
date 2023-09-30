using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.PatientsUseCases
{
    public class EditPatientUseCase : IEditPatientUseCase
    {
        private readonly IPatientRepo patientRepo;
        public EditPatientUseCase(IPatientRepo patientRepo)
        {
            this.patientRepo = patientRepo;
        }

        public void Execute(Patient patient)
        {
            patientRepo.EditPatient(patient);
        }
    }
}
