using ConsoleApp1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals;
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() { Id = 1, Name = "Dog"},
                new AnimalModel() { Id = 2, Name = "Bear"},
            };
        }
        [Route("", Name = "All")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return LocalRedirectPermanent("~/api/animals");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if(!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var animal = animals.FirstOrDefault(x => x.Id == id); 

            if (animal == null)
            {
                return NotFound();
            }

            return Ok(animal);
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);
            return CreatedAtAction("GetAnimalsById", new { id = animal.Id }, animal);
        }
    }
}
