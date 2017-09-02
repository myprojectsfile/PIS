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
        
    }
}