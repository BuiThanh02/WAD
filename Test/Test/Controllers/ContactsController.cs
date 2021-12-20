using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class ContactsController : Controller
    {
        private DataContext context = new DataContext();
        // GET: Contacts
        public ActionResult Index()
        {
            var list = context.Contacts.ToList();
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Contacts contact = context.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                context.Entry(contact).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Contacts contact = context.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}