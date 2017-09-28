﻿using System;
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

            //If there is already an Administrator role, abort
            if (_context.Roles.Any(r => r.Name == "Admin")) return;

            //Create the Administartor Role
            await _roleMgr.CreateAsync(new IdentityRole("Admin"));

            //Create the default Admin account and apply the Administrator role
            var user = "mohammad";
            var password = "P@ssword123";

            _logger.LogInformation(" ----------- adding user and role -----------");

            try
            {
                var userResult =
                    await _userMgr.CreateAsync(new IdentityUser {UserName = user, Email = user, EmailConfirmed = true},
                        password);
                var roleResult = await _userMgr.AddToRoleAsync(await _userMgr.FindByNameAsync(user), "Admin");
                var claimResult = await _userMgr.AddClaimAsync(await _userMgr.FindByNameAsync(user),
                    new Claim("SuperUser", "True"));
                    
                _logger.LogInformation($"userResult:{0} , roleResult:{1} , claimResult:{2}", userResult, roleResult,
                    claimResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"------ Exception Uccer In IdentityInitializer: {0}", ex);
            }


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