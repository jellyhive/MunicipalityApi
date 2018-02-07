using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace MunicipalityApi.Models
{
    public class County
    {
        [Key]
        public int CountyCode { get; set; }

        public string Name { get; set; }

        public List<Municipality> Municipalities { get; set; }

        
    }
}