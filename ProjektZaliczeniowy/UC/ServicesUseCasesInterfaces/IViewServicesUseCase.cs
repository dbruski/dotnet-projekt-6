using Core;
using System.Collections.Generic;

namespace UC
{
    public interface IViewServicesUseCase
    {
        IEnumerable<Service> Execute();
    }
}