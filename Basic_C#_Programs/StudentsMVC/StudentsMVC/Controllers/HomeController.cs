using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            
            ViewBag.Message = "Your contact page. Academy Of Learning Career Collage";

            return View();
        }
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Arezoo",
                    LastName = "Yousefi"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Ali",
                    LastName = "Miri"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Parmida",
                    LastName = "Miri"
                },
                new Instructor
                {
                    Id = 4,
                    FirstName = "Mantra",
                    LastName = "Miri"
                }
            };
            

            return View(instructors);
        }
    }
}