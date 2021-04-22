using System;
using System.Collections.Generic;
using System.Text;

namespace portofoliu.Helpers
{
     public class Image
     {
          public static string GetPath(int number)
          {
               string Path = "";
               switch (number)
               {
                    case 1:
                         Path = "~/Content/assets/images/blog/b-1.jpg";
                         break;
                    case 2:
                         Path = "~/Content/assets/images/blog/b-2.jpg";
                         break;
                    case 3:
                         Path = "~/Content/assets/images/blog/b-3.jpg";
                         break;
                    case 4:
                         Path = "~/Content/assets/images/blog/b-4.jpg";
                         break;
                    case 5:
                         Path = "~/Content/assets/images/blog/b-5.jpg";
                         break;
                    case 6:
                         Path = "~/Content/assets/images/blog/b-6.jpg";
                         break;
               }
               return Path;
          }
     }
}
