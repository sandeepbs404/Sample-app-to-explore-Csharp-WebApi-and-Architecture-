using ProductManagement.Service.Products.Dto;
using System.Collections.Generic;

namespace ProductManagement.Service.Products.BusinessLogic.Service
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetProducts();
    }
}
