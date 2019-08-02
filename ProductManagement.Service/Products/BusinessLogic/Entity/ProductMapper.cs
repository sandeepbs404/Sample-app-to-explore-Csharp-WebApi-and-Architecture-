using ObjectMapper.ManualMapper;
using ProductManagement.Service.Products.Dto;
using System;
using System.Collections.Generic;

namespace ProductManagement.Service.Products.BusinessLogic.Entity
{
    public class ProductMapper : BaseMapper<Product, ProductDto>
    {
        public override Product Create(ProductDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(ProductDto));
            }
            return new Product
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                ProductType = dto.ProductType
            };
        }

        public override ProductDto Create(Product model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(Product));
            }
            return new ProductDto
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                ProductType = model.ProductType
            };
        }

        public IEnumerable<ProductDto> EntitytToDtos(IEnumerable<Product> products)
        {
            return ModelsToDtos(products);
        }
    }
}
