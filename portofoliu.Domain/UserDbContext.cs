using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace portofoliu.Domain
{
     public class UserDbContext : DbContext
     {
          public DbSet<User> Users { get; set; }
     }
}
