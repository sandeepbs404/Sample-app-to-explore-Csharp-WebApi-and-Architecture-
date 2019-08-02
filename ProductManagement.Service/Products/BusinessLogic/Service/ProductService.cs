using ProductManagement.Service.Products.BusinessLogic.Entity;
using ProductManagement.Service.Products.Data;
using ProductManagement.Service.Products.Dto;
using System.Collections.Generic;

namespace ProductManagement.Service.Products.BusinessLogic.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductMapper productMapper;
        private readonly ProductRepository productRepository;

        public ProductService()
        {
            productMapper = new ProductMapper();
            productRepository = new ProductRepository();
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            var products = productRepository.GetProducts();
            var list = new List<ProductDto>();
            foreach (var item in products)
            {
                var result = productMapper.ModelToDto(item);
                list.Add(result);
            }
            return list;
            //return productMapper.EntitytToDtos(products);
        }
    }
}
