using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.PatientsUseCases
{
    public class ViewPatientsUseCase : IViewPatientsUseCase
    {
        private readonly IPatientRepo patientRepo;
        public ViewPatientsUseCase(IPatientRepo patientRepo)
        {
            this.patientRepo = patientRepo;
        }

        public IEnumerable<Patient> Execute()
        {
            return patientRepo.GetPatients();
        }
    }
}
