using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/api/get-all")]
        [Route("~/getall")]
        [Route("~/get-all")]
        //[Route("values/getall")]
        public string GetAll()
        {
            return "Hello from get all";
        }

        //[Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "Hello from get all authors";
        }

        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello from getBy ID " +id;
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "Hello author address " + id + " " + authorId;
        }

        //[Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "Hello author from Search";
        }
    }
}
