﻿using Business.Abstracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    //api/Products
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            productService.Add(product);
        }

        [HttpGet("id")]
        public Product GetById([FromQuery] int id)
        {
            return productService.GetById(id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            productService.Delete(id);
        }

        [HttpPut]
        public void Update(Product product)
        {
            productService.Update(product);
        }
    }
}
