using System.Collections.Generic;
using System.IO;
using System.Linq;
using MunicipalityApi.Models;
using Newtonsoft.Json;

namespace MunicipalityApi.Helpers
{
    public class CacheHelper
    {
        private static IEnumerable<Municipality> _municipalities;

        private static IEnumerable<County> _counties;

        public static IEnumerable<Municipality> Municipalities
        {
            get
            {
                if(_municipalities == null){
                    _municipalities = GetMunicipalities();
                }
                return _municipalities;
            }
        }

        public static IEnumerable<County> Counties
        {
            get
            {
                if(_counties == null){
                    _counties = GetCounties();
                }
                return _counties;
            }
        }

        private static IEnumerable<County> GetCounties()
        { 
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Domain\\Seed\\County.json");
            var counties = JsonConvert.DeserializeObject<IEnumerable<County>>(File.ReadAllText(path));

            var municipalities = GetMunicipalities();

            foreach (var county in counties)
            {
                var countyMunicipalities = municipalities.Where(x => x.CountyCode.Equals(county.CountyCode));
                county.Municipalities = countyMunicipalities.ToList();
            }

            return counties;
        }

        
        private static IEnumerable<Municipality> GetMunicipalities()
        { 
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Domain\\Seed\\Municipality.json");
            var municipalities = JsonConvert.DeserializeObject<IEnumerable<Municipality>>(File.ReadAllText(path));
            return municipalities;
        }
    }
}