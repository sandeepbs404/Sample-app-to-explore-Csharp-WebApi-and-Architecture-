using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Service.Products.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
    }

    public class AddProductRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
    }
}
