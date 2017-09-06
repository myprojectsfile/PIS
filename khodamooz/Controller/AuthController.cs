using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using khodamooz.data;
using Microsoft.AspNetCore.Identity;
using khodamooz.Models;
using khodamooz.Filters;

namespace khodamooz
{
  [Route("api/[controller]")]
  public class AuthController : Controller
  {
    private KhodamoozContext _context;
    private SignInManager<IdentityUser> _signInManager;

    public AuthController(KhodamoozContext context, SignInManager<IdentityUser> signInManager)
    {
      _context = context;
      _signInManager = signInManager;
    }

    [HttpPost("login")]
    [ValidateModel]
    public async Task<IActionResult> Login([FromBody] CredentialModel model)
    {
      try
      {
        var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
        if (result.Succeeded)
        {
          return Ok();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }


      return BadRequest("Failed To Login.");
    }
  }
}
