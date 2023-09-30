using Core;

namespace UC
{
    public interface IGetDoctorByIdUseCase
    {
        Doctor Execute(string doctorId);
    }
}