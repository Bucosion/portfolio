using portofoliu.BusinessLogic;
using portofoliu.Domain;
using portofoliu.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image = portofoliu.Helpers.Image;

namespace portofoliu.Controllers
{
     public class HomeController : Controller
     {
          SQLportofoliuData db = new SQLportofoliuData();
          Utilizator _user;
          public ActionResult Index()
          {
               var _user = (Utilizator)Session["_user"];
        //       ViewBag.user = _user.IsAdmin;
               ViewBag.Products = db.GetProducts();
               var model = db.GetBlogs();
               return View(model);
          }

          public ActionResult Login()
          {

               return View();
          }
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Login(Utilizator user)
          {
               _user = db.Check(user);
               Session["_user"] = _user;
               return RedirectToAction("Index");
          }



          public ActionResult Delete(int id)
          {
               db.Delete(id);
               return RedirectToAction("Index", "Home");
          }

          public ActionResult Blo_blog_add()
          {
               return View();
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Blo_blog_add(Blog blog)
          {
               blog.Image = Image.GetPath(RandomNumber.GetRImage());
               db.Add(blog);
               return View();
          }

          public ActionResult Eco_product_add()
          {
               return View();
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Eco_product_add(Product product)
          {
               db.Add(product);
               return View();
          }


          public ActionResult Dashboard()
          {
               var model = db.GetBlogs();
               return View(model);
          }

          public ActionResult Blo_blogs()
          {
               var model = db.GetBlogs();
               return View(model);
          }

          [HttpGet]
          public ActionResult Blo_blog_edit(int Id)
          {
               var model = db.GetBlog(Id);
               return View(model);
          }


          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Blo_blog_edit(Blog blog)
          {
               db.Edit(blog);
               return View();
          }


          public ActionResult Blo_blog_view()
          {
               var model = db.GetBlog(45);
               return View(model);
          }

          public ActionResult Blo_user_edit()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Blo_user_add()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Blo_users()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Eco_customers()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Eco_customer_add()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Eco_customer_edit()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Eco_order_edit()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Eco_order_add()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Eco_orders()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }


          public ActionResult Eco_product_edit()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Eco_products()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Ui_profile()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Ui_login()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }

          public ActionResult Ui_register()
          {
               ViewBag.Message = "Your contact page.";

               return View();
          }
     }
}