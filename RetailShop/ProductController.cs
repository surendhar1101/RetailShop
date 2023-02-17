using Microsoft.AspNetCore.Mvc;
using RetailShop.Model;
using RetailShop.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailShopAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) { 
        
                _productService = productService;
        }
        // GET: api/<ValuesController>
        [HttpGet("GetAllProductsList")]
        public IActionResult Get()
        {

            return Ok(_productService.GetProducts());
        }

        // GET api/<ValuesController>/5
        [HttpGet("GetProductBy/{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_productService.GetProducts(id));
        }

        // POST api/<ValuesController>
        [HttpPost("AddProduct/")]
        public void Post(ProductViewModel product)
        {
            _productService.PostProduct(product);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("EditProductBy/{id}")]
        public void Put(Guid id,ProductViewModel product)
        {
            _productService.PutProduct(id,product);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteProductBy/{id}")]
        public void Delete(Guid id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
