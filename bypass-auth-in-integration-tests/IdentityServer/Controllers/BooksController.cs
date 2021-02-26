using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    [Route("books")]
    [Authorize(Policy = Config.PolicyName)]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new[]
            {
                new { Title = "Design Patterns", Author = "Gamma/Helm/Johnson/Vlissides" },
                new { Title = "Introduction to Algorithms", Author = "Cormen/Leiserson/Rivest/Stein" },
                new { Title = "Building Microservices", Author = "Newman" },
                new { Title = "The Mythical Man Month", Author = "Brooks" },
                new { Title = "Discrete Mathematics", Author = "Truss" },
                new { Title = "Code Complete", Author = "McConnell" },
                new { Title = "Refactoring", Author = "Fowler" },
            });
        }
    }
}