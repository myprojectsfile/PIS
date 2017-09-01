using khodamooz.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace khodamooz.data
{
    public class KhodamoozRepository:IKhodamoozRepository
    {

        private readonly KhodamoozContext _context;

        public KhodamoozRepository(KhodamoozContext context)
        {
            _context = context;
        }
        
        public User GetUser(string userName)
        {
            return _context.Users
                .Where(u => u.UserName == userName)
                .Cast<User>()
                .FirstOrDefault();
        }
    }
}