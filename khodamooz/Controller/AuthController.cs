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
using Microsoft.Extensions.Configuration;

namespace khodamooz
{
  [Route("api/[controller]")]
  public class AuthController : Controller
  {
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IPasswordHasher<IdentityUser> _passHasher;
    private readonly ILogger<AuthController> _logger;
    private readonly IConfigurationRoot _config;

    public AuthController(
      SignInManager<IdentityUser> signInManager,
      UserManager<IdentityUser> userManager,
      IPasswordHasher<IdentityUser> passHasher,
      ILogger<AuthController> logger,
      IConfigurationRoot config
      )
    {
      _signInManager = signInManager;
      _userManager = userManager;
      _passHasher = passHasher;
      _logger = logger;
      _config = config;
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
    public async Task<IActionResult> GetToken([FromBody] CredentialModel model)
    {
      try
      {
        var user = await _userManager.FindByNameAsync(model.UserName);
        if (user != null)
        {
          if (_passHasher.VerifyHashedPassword(user, user.PasswordHash, model.Password) == PasswordVerificationResult.Success)
          {
            var tokenClaims = new[]
            {
              new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
              new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["tokens:key"]));
            var tokenCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["tokens:issuer"],
                audience: _config["tokens:audience"],
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
