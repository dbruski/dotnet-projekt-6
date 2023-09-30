using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.PatientsUseCases
{
    public class GetPatientByIdUseCase : IGetPatientByIdUseCase
    {
        private readonly IPatientRepo patientRepo;
        public GetPatientByIdUseCase(IPatientRepo patientRepo)
        {
            this.patientRepo = patientRepo;
        }

        public Patient Execute(string patientId)
        {
            return patientRepo.GetPatientById(patientId);
        }
    }
}
