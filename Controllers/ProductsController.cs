using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new[] {
new Product { Id = 1, Name = "Apple" },
new Product { Id = 2, Name = "Banana" }
};
            return Ok(products);
        }
    }
}