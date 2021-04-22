using Sitecore.FakeDb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace portofoliu.Domain
{

     public class Blog : ICloneable
     {

          public int Id { get; set; }
          public string Title { get; set; }
          public string Content { get; set; }
          public string Created_on { get; set; }
          public string Image { get; set; }
          public string Tag { get; set; }
          public string Category { get; set; }
          public string Status { get; set; }
          public string Author { get; set; }

          public object Clone()
          {
               return this.MemberwiseClone();
          }
     }
}