using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using General.Data.Sql;
using General.Model;
using General.Service.Contract;
namespace General.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        ITeacherService teaSer;
        public HomeController(ITeacherService teaSer)
        {
            this.teaSer = teaSer;
        }
        public ActionResult Index()
        {
            
               // db.Database.Create();
                //var list = db.Set<Student>().ToList();
                //db.Database.Initialize(true);
                //var model = new Student { Name = "撒旦", Age = 12, Sex = "男", Point = 11, TeacherId = 1 };
                //db.Stduents.Add(model);
                //db.SaveChanges();
                var model = new Teacher { Age = 11, Name = "速度速度", Salary = 34343, Sex = "女", Dog="sds"};
                teaSer.Add(model);
                
                ViewBag.Message = "Database is build success!";
            

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
