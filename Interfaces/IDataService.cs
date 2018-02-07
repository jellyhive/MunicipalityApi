using System.Collections.Generic;
using MunicipalityApi.Models;

namespace MunicipalityApi.Interfaces
{
    public interface IDataService
    {
        IEnumerable<Municipality> Municipalities { get; }

        IEnumerable<County> Counties { get; }
    }
}