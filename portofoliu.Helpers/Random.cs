using System;
using System.Collections.Generic;
using System.Text;

namespace portofoliu.Helpers
{
     public class RandomNumber
     {
          static Random rnd = new Random();
          public static int GetR()
          {
               return rnd.Next(1, 30);
          }
          public static int GetRImage()
          {
               return rnd.Next(1, 6);
          }
     }
}