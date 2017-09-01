using System;
using System.Security.Claims;
using System.Threading.Tasks;
using khodamooz.data.Entities;
using Microsoft.AspNetCore.Identity;

namespace khodamooz.data
{
    public class IdentityInitializer
    {
        private readonly RoleManager<UserRole> _roleMgr;
        private readonly UserManager<User> _userMgr;

        public IdentityInitializer(UserManager<User> userMgr, RoleManager<UserRole> roleMgr)
        {
            _userMgr = userMgr;
            _roleMgr = roleMgr;
        }

        public async Task Seed()
        {
            
            //var user = await _userMgr.FindByNameAsync("mohammad");

            //if (user == null)
            //{
            //    if (!await _roleMgr.RoleExistsAsync("Admin"))
            //    {
            //        var role = new UserRole("Admin");
            //        await _roleMgr.CreateAsync(role);
            //        await _roleMgr.AddClaimAsync(role, new Claim("IsAdmin", "True"));
            //    }

            //    var newUser = new User
            //    {
            //        UserName = "mohammad",
            //        FirstName = "mohammad",
            //        LastName = "Ahmadi",
            //        Email = "ahmadi.mohammad@bpmo.ir",
            //        SecurityStamp = Guid.NewGuid().ToString()
            //    };

            //    var userResult = await _userMgr.CreateAsync(newUser, "123");
            //    var roleResult = await _userMgr.AddToRoleAsync(newUser, "Admin");
            //    var claimResult = await _userMgr.AddClaimAsync(newUser, new Claim("SuperUser", "True"));

            //    if (!userResult.Succeeded || !roleResult.Succeeded || !claimResult.Succeeded)
            //    {
            //        throw new InvalidOperationException("Faild To Build Users and Roles");
            //    }
            //} 
        }
    }
}