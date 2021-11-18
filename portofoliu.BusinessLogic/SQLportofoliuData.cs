using portofoliu.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace portofoliu.BusinessLogic
{
     public class SQLportofoliuData
     {
          portofoliuDbContext db = new portofoliuDbContext();

          public void Add(Blog blog)
          {
               
               db.Blogs.Add(blog);
               db.SaveChanges();
          }

          public void Add(Product product)
          {

               db.Products.Add(product);
               db.SaveChanges();
          }

          public IEnumerable GetBlogs()
          {
               var Blogs = db.Blogs.OrderBy(h => h.Id);
               return Blogs;
          }

          public IEnumerable GetProducts()
          {
               var Products = db.Products.ToList();
               return Products;
          }

          public Blog GetBlog(int Id)
          {
               return db.Blogs.Find(45);
          }

          public void Edit(Blog blog)
          {
               var model = GetBlog(blog.Id);
               model.Title = blog.Title;
               model.Content = blog.Content;
               model.Created_on = blog.Created_on;
               model.Tag = blog.Tag;
               model.Category = blog.Category;
               model.Status = blog.Status;
               model.Author = blog.Author;
               db.SaveChanges();
          }
          public void Delete(int Id)
          {

               var model = db.Blogs.Find(Id);
               db.Blogs.Remove(model);
               db.SaveChanges();
          }

          public Utilizator Check(Utilizator user)
          {
               var _user = db.Utilizators.Where(u => u.Username == user.Username)
                                   .Where(u => u.Password == user.Password)
                                   .FirstOrDefault();
               return (Utilizator)_user;

          }
     }
}
