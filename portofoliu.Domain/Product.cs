using Sitecore.FakeDb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace portofoliu.Domain
{
     public class Product :ICloneable
     {

          public int Id { get; set; }
          public string Title { get; set; }
          public string Description { get; set; }
          public int Price { get; set; }
          public string Feature1 { get; set; }
          public string Feature2 { get; set; }
          public string Feature3 { get; set; }
          public string Feature4 { get; set; }
          public string Feature5 { get; set; }
          public string Feature6 { get; set; }

          public object Clone()
          {
               return this.MemberwiseClone();
          }
     }
}

