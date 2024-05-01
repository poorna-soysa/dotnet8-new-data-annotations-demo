using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NewDataAnnotationsDemoInDotNet8.Models;

namespace NewDataAnnotationsDemoInDotNet8.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderController(IValidator<Order> validator) 
    : ControllerBase
{
    [HttpPost]
    public IActionResult Create(Order order)
    {
        var result = validator.Validate(order);

        if (!result.IsValid)
        {
            return BadRequest(result.Errors);
        }
        return Ok(order);
    }
}
