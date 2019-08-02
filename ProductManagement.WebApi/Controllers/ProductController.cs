using ProductManagement.Service.Products.BusinessLogic.Service;
using ProductManagement.Service.Products.Dto;
using System;
using System.Web.Http;

namespace ProductManagement.WebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService) {
            this.productService = productService;
        }

        [HttpGet]
        [Route(Name ="GetProduct")]
        public IHttpActionResult Get()
        {
            var products = productService.GetProducts();//new List<string> { "Bat", "Ball", "Cycle", "Soccer Ball" };
            return Ok(products);
        }

        [HttpPost]
        [Route(Name ="AddProduct")]
        public IHttpActionResult Post([FromBody]AddProductRequest productRequest)
        {
            return CreatedAtRoute("GetProduct", new {  }, productRequest);
        }
    }
}
