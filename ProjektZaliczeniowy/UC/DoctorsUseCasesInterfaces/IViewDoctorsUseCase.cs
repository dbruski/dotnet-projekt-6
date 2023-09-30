using Core;
using System.Collections.Generic;

namespace UC
{
    public interface IViewDoctorsUseCase
    {
        IEnumerable<Doctor> Execute();
    }
}