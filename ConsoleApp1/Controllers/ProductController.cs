using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }
    }
    //Don't forget to oush to github when you are done
}
