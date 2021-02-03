﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobsWebApp_MVC5_.Models;
using WebApplication2.Models;

namespace JobsWebApp_MVC5_.Controllers
{
    public class JobsCategoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: JobsCategories
        public ActionResult Index()
        {
            return View(db.JobsCategories.ToList());
        }

        // GET: JobsCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsCategory jobsCategory = db.JobsCategories.Find(id);
            if (jobsCategory == null)
            {
                return HttpNotFound();
            }
            return View(jobsCategory);
        }

        // GET: JobsCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobsCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,JobName,JobDescription")] JobsCategory jobsCategory)
        {
            if (ModelState.IsValid)
            {
                db.JobsCategories.Add(jobsCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobsCategory);
        }

        // GET: JobsCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsCategory jobsCategory = db.JobsCategories.Find(id);
            if (jobsCategory == null)
            {
                return HttpNotFound();
            }
            return View(jobsCategory);
        }

        // POST: JobsCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,JobName,JobDescription")] JobsCategory jobsCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobsCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobsCategory);
        }

        // GET: JobsCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsCategory jobsCategory = db.JobsCategories.Find(id);
            if (jobsCategory == null)
            {
                return HttpNotFound();
            }
            return View(jobsCategory);
        }

        // POST: JobsCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobsCategory jobsCategory = db.JobsCategories.Find(id);
            db.JobsCategories.Remove(jobsCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
