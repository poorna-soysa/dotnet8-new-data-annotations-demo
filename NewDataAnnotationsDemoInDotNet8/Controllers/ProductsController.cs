using Microsoft.AspNetCore.Mvc;
using NewDataAnnotationsDemoInDotNet8.Models;

namespace NewDataAnnotationsDemoInDotNet8.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        return Ok(product);
    }
}
