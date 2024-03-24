using Business.Abstracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Category category)
        {
            categoryService.Add(category);
        }

        [HttpGet("id")]
        public Category GetById([FromQuery] int id)
        {
            return categoryService.GetById(id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            categoryService.Delete(id);
        }

        [HttpPut]
        public void Update(Category category)
        {
            categoryService.Update(category);
        }
    }
}
