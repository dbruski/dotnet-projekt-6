using Core;
using System.Collections.Generic;

namespace UC.PatientsUseCases
{
    public interface IViewPatientsUseCase
    {
        IEnumerable<Patient> Execute();
    }
}