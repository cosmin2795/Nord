using Nord.Context;
using Nord.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nord.Controllers
{
    public class StudentController : Controller
    {
        DataContext db = new DataContext();
        
        // GET: Student
        public ActionResult Index()
        {   
            var studenti = db.Students.ToList();
            return View(studenti);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int id,Student a)
        {
            db.Students.ToList().RemoveAt(id);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student stud = db.Students.Single(a => a.StudentId == id);
            return View(stud);
        }
        [HttpPost]
        public ActionResult Edit(Student stud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var list = db.Cours.ToList().Where(x => x.StudentId == id);
            return View(list);
        }



    }
}
