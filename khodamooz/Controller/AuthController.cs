using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using khodamooz.data;
using Microsoft.AspNetCore.Identity;
using khodamooz.Models;
using khodamooz.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace khodamooz
{
  [Route("api/[controller]")]
  public class AuthController : Controller
  {
    private KhodamoozContext _context;
    private SignInManager<IdentityUser> _signInManager;
    private UserManager<IdentityUser> _userManager;
    private PasswordHasher<IdentityUser> _passHasher;
    private ILogger<AuthController> _logger;

    public AuthController(KhodamoozContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, PasswordHasher<IdentityUser> passHasher, ILogger<AuthController> logger)
    {
      _context = context;
      _signInManager = signInManager;
      _userManager = userManager;
      _passHasher = passHasher;
      _logger = logger;
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
        _logger.LogError($"exeption thrown while login : {0}", ex);
      }

      return BadRequest("Failed To Login.");
    }

    [HttpPost("getToken")]
    [ValidateModel]
    public async Task<IActionResult> getToken([FromBody] CredentialModel model)
    {
      try
      {
        var user = await _userManager.FindByNameAsync(model.UserName);
        if (user != null)
        {
          if (_passHasher.VerifyHashedPassword(user, user.PasswordHash, model.Password) == PasswordVerificationResult.Success)
          {
            var tokenClaims = new Claim[]
            {
              new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
              new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("THISISSYMMETRICSECURITYKEYFORKHODAMOOZ.IO"));
            var tokenCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "http://khodamooz.io",
                audience: "http://khodamooz.io",
                claims: tokenClaims,
                expires: DateTime.UtcNow.AddHours(3),
                signingCredentials: tokenCredentials
              );

            return Ok(new
            {
              token = new JwtSecurityTokenHandler().WriteToken(token),
              expiration = token.ValidTo
            }
              );
          }
        }
        else
        {
          return BadRequest("user or password is not correct.maybe this user doesnot exist.");
        }
      }
      catch (Exception ex)
      {
        _logger.LogError($"exeption thrown while generating token : {0}", ex);

      }

      return BadRequest("Failed To generate token.");
    }

  }
}
