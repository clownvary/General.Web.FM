using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General.Data.Sql;
using General.Model;
namespace General.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (GeneralDbContext db = new GeneralDbContext())
            {
               // db.Database.Create();
                //var list = db.Set<Student>().ToList();
                //db.Database.Initialize(true);
                //var model = new Student { Name = "撒旦", Age = 12, Sex = "男", Point = 11, TeacherId = 1 };
                //db.Stduents.Add(model);
                //db.SaveChanges();
                ViewBag.Message = "Database is build success!";
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
