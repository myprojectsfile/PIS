using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace khodamooz.data
{
    public class IdentityInitializer
    {
        private readonly KhodamoozContext _context;
        private readonly ILogger<IdentityInitializer> _logger;
        private readonly RoleManager<IdentityRole> _roleMgr;
        private readonly UserManager<IdentityUser> _userMgr;

        public IdentityInitializer(UserManager<IdentityUser> userMgr, RoleManager<IdentityRole> roleMgr,
            KhodamoozContext context, ILogger<IdentityInitializer> logger)
        {
            _userMgr = userMgr;
            _roleMgr = roleMgr;
            _context = context;
            _logger = logger;
        }

        public async Task Seed()
        {
            //create database schema if none exists
            _context.Database.EnsureCreated();

            //Create Admin Role
            // await CreateRole("Admin");
            //Create TransportCorp Role
            await CreateRole("TransportCorp");

            try
            {
                _logger.LogInformation(" ----------- adding user and role -----------");

                // var userResult = CreateUserAsync("mohammad", "P@ssword123", "mohammad@bpmo.ir", true);
                // var roleResult = AddToRoleAsync("mohammad", "Admin");
                // var claimResult = AddClaimToUserAsync("mohammad","SuperUser");

                var userResult = CreateUserAsync("transco", "Tr@ns567", "transco@bpmo.ir", true);
                var roleResult = AddToRoleAsync("transco", "TransportCorp");
                var claimResult = AddClaimToUserAsync("transco","TransportCorp");

                _logger.LogInformation($"userResult:{0} , roleResult:{1} , claimResult:{2}", userResult, roleResult,
                    claimResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"------ Exception Uccer In IdentityInitializer: {0}", ex);
            }
        }

        public async Task<IdentityResult> CreateRole(string roleName)
        {
            //Check if role exist
            if (_context.Roles.Any(r => r.Name == roleName)) return IdentityResult.Success;
            //Create the Administartor Role
            return await _roleMgr.CreateAsync(new IdentityRole(roleName));
        }

        public async Task<IdentityResult> CreateUserAsync(string username, string password, string email, bool emailConfiremed)
        {
            return await _userMgr.CreateAsync(new IdentityUser { UserName = username, Email = email, EmailConfirmed = emailConfiremed },
                        password);
        }

        public async Task<IdentityResult> AddToRoleAsync(string username, string roleName)
        {
            var identityUser = await _userMgr.FindByNameAsync(username);
            return await _userMgr.AddToRoleAsync(identityUser, roleName);
        }

        public async Task<IdentityResult> AddClaimToUserAsync(string username, string claim)
        {
            var identityUser = await _userMgr.FindByNameAsync(username);
            return await _userMgr.AddClaimAsync(identityUser,
                new Claim(claim, "True"));
        }
    }
}