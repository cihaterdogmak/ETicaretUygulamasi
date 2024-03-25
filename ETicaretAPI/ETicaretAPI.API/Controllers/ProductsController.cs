using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers;

public class ProductsController : ControllerBase
{
    // GET
    public IActionResult GetProducts()
    {
        return Ok();
    }
}