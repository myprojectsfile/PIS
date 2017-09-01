using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace khodamooz.data.Entities
{
    public class UserRole : IdentityRole<int>
    {
        public UserRole()
        {

        }

        public UserRole(string roleName) : base(roleName)
        {
        }
    }
}
