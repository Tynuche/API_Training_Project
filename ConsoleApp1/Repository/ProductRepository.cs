﻿using ConsoleApp1.Models;

namespace ConsoleApp1.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> products = new List<ProductModel>();
        public int AddProduct(ProductModel product)
        {
            product.Id = products.Count + 1; // Simple ID assignment based on count
            products.Add(product);
            return product.Id;
        }

        public List<ProductModel> GetAllProducts()
        {
            return products;
        }

        public string GetName()
        {
           return "Name from ProductRepository";
        }
    }
}
