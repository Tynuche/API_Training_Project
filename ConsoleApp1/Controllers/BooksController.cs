using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return "Hello from getBy ID " + id;
        }

        [Route("{id:length(5):alpha}")]
        public string GetByIdString(string id)
        {
            return "Hello from string ID " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "Hello regex ID " + id;
        }
    }
}
