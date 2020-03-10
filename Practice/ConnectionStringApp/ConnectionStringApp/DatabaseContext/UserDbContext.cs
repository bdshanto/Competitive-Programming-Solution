using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionStringApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnectionStringApp.DatabaseContext
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> option):base(option)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
