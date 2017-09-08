using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace khodamooz
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    // GET: api/1alues
    [Authorize(Policy = "SuperUsers")]
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new[] {"value1", "value2"};
    }
  }
}
