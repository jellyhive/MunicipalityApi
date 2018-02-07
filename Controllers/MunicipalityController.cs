using System.Collections.Generic;
using System.Linq;
using MunicipalityApi.Models;
using Microsoft.AspNetCore.Mvc;
using MunicipalityApi.Helpers;
using MunicipalityApi.Interfaces;

namespace MunicipalityApi.Controllers
{
    [Route("api/[controller]")]
    public class MunicipalityController : Controller
    {
        private readonly IDataService dataService;

        public MunicipalityController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet]
        public IEnumerable<Municipality> GetAll()
        {
            return dataService.Municipalities;
        }

        [HttpGet("{id}", Name = "GetMunicipalityById")]
        public IActionResult GetById(long id)
        {
            var item =  dataService.Municipalities.FirstOrDefault(t => t.MunicipalityCode == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}