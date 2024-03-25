using Business.Abstracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _productService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            _productService.Add(product);
        }

        [HttpGet("id")]
        public Product GetById([FromQuery] int id)
        {
            return _productService.GetById(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = _productService.GetById(id);
            _productService.Delete(product);
        }

        [HttpPut]
        public void Update(Product product)
        {
            _productService.Update(product);
        }
    }
}
