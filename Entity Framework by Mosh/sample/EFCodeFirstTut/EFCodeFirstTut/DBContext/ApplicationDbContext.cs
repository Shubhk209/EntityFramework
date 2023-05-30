using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirstTut.DBContext
{
    // Use to connect with database for load and save data.
    class ApplicationDbContext : DbContext
    {
        
        // create properties 

        public DbSet<Models.Post> Posts { get; set; }
    }
}
