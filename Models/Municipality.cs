using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Newtonsoft.Json;

namespace MunicipalityApi.Models
{
    public class Municipality
    {
        public int MunicipalityCode { get; set; }

        public string Name { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public int CountyCode { get; set; }

        public string CountyName { get; set; }
    }
}