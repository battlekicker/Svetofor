using Microsoft.EntityFrameworkCore;
using Svetofor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Svetofor.App_Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options) 
            : base(options) 
        { 
            Database.EnsureCreated(); 
        }
    }
}
