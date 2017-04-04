using Nord.Context;
using Nord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nord.Controllers
{
    public class FacultyController : Controller
    {
        DataContext db = new DataContext();
        // GET: Faculty
        public ActionResult Index()
        {
            var facultati = db.Facultati.ToList();         
            return View(facultati);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Faculty());
        }
        [HttpPost]
        public ActionResult Create(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                db.Facultati.Add(faculty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            var list = db.Students.ToList().Where(x => x.FacultyId == id);
            return View(list);
        }
 
    }
}