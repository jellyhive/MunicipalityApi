using System.Collections.Generic;
using MunicipalityApi.Helpers;
using MunicipalityApi.Interfaces;
using MunicipalityApi.Models;

namespace MunicipalityApi.Services
{
    public class CacheDataService : IDataService
    {
        IEnumerable<Municipality> IDataService.Municipalities => CacheHelper.Municipalities;
        
        IEnumerable<County> IDataService.Counties => CacheHelper.Counties;
    }
}