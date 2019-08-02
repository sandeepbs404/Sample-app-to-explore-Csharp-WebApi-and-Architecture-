using ProductManagement.Service.Products.BusinessLogic.Entity;
using System.Data.Entity;

namespace ProductManagement.Service.Data
{
    public class ProductDbContext: DbContext
    {
        public IDbSet<Product> Products { get; set; }

        public ProductDbContext(string connection): base(connection)
        {

        }
    }
}
