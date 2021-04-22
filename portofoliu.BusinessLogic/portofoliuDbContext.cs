using portofoliu.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace portofoliu.BusinessLogic
{
     class portofoliuDbContext : DbContext
     {
          public DbSet<Blog> Blogs { get; set; }
     }
}
