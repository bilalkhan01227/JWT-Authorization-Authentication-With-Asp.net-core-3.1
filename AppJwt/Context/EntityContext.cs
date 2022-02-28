using AppJwt.Models;
using authTesting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppJwt.Context
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<User> Users { get; set; }
       public DbSet<login> LSUser { get; set; }

       public DbSet<Prod> Products { get; set; }

    }
}
