using Microsoft.AspNetCore.Mvc;
using static System.IO.File;

namespace CSharpBackend_FirstProject.Controllers;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
  [HttpGet("oi")] 
  public ActionResult OutroTest() 
    {
        return Content (ReadAllText("Views/index.html"), "text/html");
        
    }
}