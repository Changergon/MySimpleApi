using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var customers = new[] {
new Customer { Id = 1, FullName = "Alice" },
new Customer { Id = 2, FullName = "Bob" }
};
            return Ok(customers);
        }
    }
}