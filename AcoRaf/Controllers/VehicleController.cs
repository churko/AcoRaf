using AcoRaf.Context;
using AcoRaf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AcoRaf.Controllers
{
    public class VehicleController : Controller
    {
        private AcoRafContext db = new AcoRafContext();

        // GET: Vehicle
        public ActionResult Index()
        {
            return View(db.Vehicles.ToList());
        }

        // GET: Vehicle/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var vehicle = db.Vehicles.Find(id);       
            
            if(vehicle == null)
            {
                return HttpNotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicle/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Vehicles.Add(vehicle);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(vehicle);
            }
            catch
            {
                return View(vehicle);
            }
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var vehicle = db.Vehicles.Find(id);

            if (vehicle == null)
            {
                return HttpNotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        public ActionResult Edit(Vehicle vehicle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(vehicle).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(vehicle);
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var vehicle = db.Vehicles.Find(id);

            if (vehicle == null)
            {
                return HttpNotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Vehicle vehicle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vehicle = db.Vehicles.Find(id);

                    if(vehicle == null)
                    {
                        return HttpNotFound();
                    }

                    db.Vehicles.Remove(vehicle);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(vehicle);
            }
            catch
            {
                return View(vehicle);
            }
        }
    }
}
