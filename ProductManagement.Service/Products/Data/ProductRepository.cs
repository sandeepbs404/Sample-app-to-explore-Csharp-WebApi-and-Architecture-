using ProductManagement.Service.Products.BusinessLogic.Entity;
using System.Collections.Generic;

namespace ProductManagement.Service.Products.Data
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product {  Id=1, Name="Bat", ProductType="Sports"},
                new Product {  Id=2, Name="Ball", Description="Cricket ball with Kumble signature", ProductType="Sports"},
                new Product {  Id=3, Name="Soccer Ball", Description="Soccer Ball", ProductType="Sports"}
            };
            return products;
        } 
    }
}
