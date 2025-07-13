using ConsoleApp1.Models;

namespace ConsoleApp1.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return "Name from TestRepository";
        }
    }
}
