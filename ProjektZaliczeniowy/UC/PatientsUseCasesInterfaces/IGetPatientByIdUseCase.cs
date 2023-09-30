using Core;

namespace UC.PatientsUseCases
{
    public interface IGetPatientByIdUseCase
    {
        Patient Execute(string patientId);
    }
}