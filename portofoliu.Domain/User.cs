using Sitecore.FakeDb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace portofoliu.Domain
{
     public class User
     {
          UserDbContext db = new UserDbContext();

          public void Add()
          {
               User User1 = new User() { id = 1, Title = 11, Content = "User #1" };
               User User2 = new User() { id = 2, Title = 21, Content = "User #2" };
               db.Users.Add(User1);
               db.Users.Add(User2);
               db.SaveChanges();
          }

          public IEnumerable GetAll()
          {
               var Users = db.Users.OrderBy(h => h.id);
               return Users;
          }

          public int id { get; set; }
          public string Content { get; set; }
          public int Title { get; set; }
     }
}
