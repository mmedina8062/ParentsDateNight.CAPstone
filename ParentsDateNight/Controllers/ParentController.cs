using Microsoft.AspNet.Identity;
using ParentsDateNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParentsDateNight.Controllers
{
    public class ParentController : Controller
    {
        ApplicationDbContext context;

        public ParentController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Parent
        public ActionResult Index()
        {
            var parent = context.Parents.ToList();
            return View(parent);
        }

        // GET: Parent/Details/5
        public ActionResult Details(int id)
        {
            var applicationId = User.Identity.GetUserId();
            Parent parent = context.Parents.FirstOrDefault(p => p.ApplicationId == applicationId);

            if (parent == null)
            {
                return HttpNotFound();
            }
            return View(parent);
        }

        // GET: Parent/Create
        public ActionResult Create()
        {
            Parent parent = new Parent();
            return View(parent);
        }

        // POST: Parent/Create
        [HttpPost]
        public ActionResult Create(Parent parent)
        {
            try
            {
                parent.ApplicationId = User.Identity.GetUserId();
                context.Parents.Add(parent);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Parent/Edit/5
        public ActionResult Edit(int id)
        {
            Parent parent = context.Parents.Where(d => d.Id == id).SingleOrDefault();
            
            if (parent == null)
            {
                return HttpNotFound();
            }
            return View(parent);
        }

        // POST: Parent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Parent parent)
        {
            try
            {
                Parent editParent = context.Parents.Find(id);
                editParent.FirstName = parent.FirstName;
                editParent.LastName = parent.LastName;
                editParent.StreetAddress = parent.StreetAddress;
                editParent.City = parent.City;
                editParent.State = parent.State;
                editParent.ZipCode = parent.ZipCode;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(HttpNotFound());
            }
        }

        // GET: Parent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Parent/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
