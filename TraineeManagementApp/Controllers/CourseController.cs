using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraineeManagement.Models;
using TraineeManagement.DatabaseContext;


namespace TraineeManagementApp.Controllers
{
    public class CourseController : Controller
    {



        public ActionResult Entry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Entry(Course course)
        {
            if (ModelState.IsValid)
            {
                TraineeDbContext db = new TraineeDbContext();
                db.Courses.Add(course);
                bool isSaved = db.SaveChanges() > 0;
                if (isSaved)
                {
                    return RedirectToAction("Search");
                    //ViewBag.Message = "Saved Successfully!";
                }
            }
            return View();
        }

        public ActionResult Search()
        {
            TraineeDbContext db = new TraineeDbContext();
            var courses = db.Courses.ToList();
            
            return View(courses);
        }
    }
}