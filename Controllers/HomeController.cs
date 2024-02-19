using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers;

[ApiController]
public class HomeController: ControllerBase
{
    [HttpGet("/a")]
    public string Get()
    {
        return "Hello World!";
    }
}