using ProductManagement.Service.Products.BusinessLogic.Entity;
using System.Data.Entity.ModelConfiguration;

namespace ProductManagement.Service.Data.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            Property(product => product.Id).IsRequired();
            Property(product => product.Name).HasMaxLength(50);
            Property(product => product.Description).IsOptional();
            Property(product => product.ProductType).IsOptional();
        }
    }
}
