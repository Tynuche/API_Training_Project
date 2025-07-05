using ConsoleApp1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[BindProperties(SupportsGet =true)]
    public class CountriesController : ControllerBase
    {
        //public CountryModel Country { get; set; }

        //public string Name { get; set; }

        //public int Population { get; set; }

        //public int Area { get; set; }

        //[HttpPost("{id}")]
        //public IActionResult AddCountry([FromRoute]int id, [FromHeader]string developer, [FromHeader]string course)
        //{
        //    return Ok($"Name = {developer}");
        //}

        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))]string[] countries ) 
        { 
            return Ok(countries); 
        }

        [HttpGet("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name="Id")]CountryModel country)
        {
            return Ok(country);
        }
    }
}
