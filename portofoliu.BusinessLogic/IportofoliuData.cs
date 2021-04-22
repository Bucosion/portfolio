using portofoliu.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace portofoliu.BusinessLogic
{
     interface IPortofoliuData
     {
          void Add(Blog blog);
          IEnumerable GetAll();
          Blog GetBlog(int id);
          void Delete(int id);
          void Edit(Blog blog);
     }
}
