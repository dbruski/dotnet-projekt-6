using Core;

namespace UC.PatientsUseCases
{
    public interface IAddPatientUseCase
    {
        void Execute(Patient patient);
    }
}