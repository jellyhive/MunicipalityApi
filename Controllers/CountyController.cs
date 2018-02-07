using System.Collections.Generic;
using System.Linq;
using MunicipalityApi.Models;
using Microsoft.AspNetCore.Mvc;
using MunicipalityApi.Helpers;
using MunicipalityApi.Interfaces;

namespace MunicipalityApi.Controllers
{
    [Route("api/[controller]")]
    public class CountyController : Controller
    {
        private readonly IDataService dataService;

        public CountyController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet]
        public IEnumerable<County> GetAll()
        {
            return dataService.Counties.ToList();
        }   

        [HttpGet("{id}", Name = "GetLanById")]
        public IActionResult GetById(long id)
        {
            var item = dataService.Counties.FirstOrDefault(t => t.CountyCode == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}