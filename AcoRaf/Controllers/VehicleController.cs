using AcoRaf.Context;
using AcoRaf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vehicle/Delete/5
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
