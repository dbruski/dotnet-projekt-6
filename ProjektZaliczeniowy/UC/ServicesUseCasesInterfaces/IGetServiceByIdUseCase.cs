using Core;

namespace UC
{
    public interface IGetServiceByIdUseCase
    {
        Service Execute(string serviceId);
    }
}