using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
    {
        public class InsureeController : Controller
        {
            private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {

            if (ModelState.IsValid)
            {
                //1.a Base insuracne quote 
                insuree.Quote = 50;
                //1.b an if statment if the customer is under 18
                if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
                {
                    insuree.Quote += 100;
                }
                //1.c else if the customer is between 19 and 25.
                else if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 25)
                {
                    insuree.Quote += 50;
                }
                //1.d if the customer is over 25
                else
                {
                    insuree.Quote += 25;
                }
                //if the car is older than 22 years old set by the standard of this project, if it was to be used in the future. 
                //older then 2000
                if (DateTime.Now.Year - insuree.CarYear >= 22)
                {
                    insuree.Quote += 25;
                }
                //if the car was younger than 6 years old set by the standard of this project, if it was used in the future. 2015 to present
                else if (DateTime.Now.Year - insuree.CarYear <= 6)
                {
                    insuree.Quote += 25;
                }
                //if the car is a Porsche 911 Carrera
                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Quote += 50;
                }
                //if the car is a Porsche but different model
                else if (insuree.CarMake.ToLower() == "porsche")
                {
                    insuree.Quote += 25;
                }
                //if there are any speeding tickets
                if (insuree.SpeedingTickets > 0)
                {
                    insuree.Quote += insuree.SpeedingTickets * 10;
                }
                //if the DUI box is checked
                if (insuree.DUI == true)
                {
                    var quarter = Convert.ToDouble(insuree.Quote);
                    double answer = quarter * 1.25;
                    insuree.Quote = Convert.ToInt32(answer);
                }
                //if the CoverageType Box is checked
                if (insuree.CoverageType == true)
                {
                    var half = Convert.ToDouble(insuree.Quote);
                    double answer = half * 1.5;
                    insuree.Quote = Convert.ToInt32(answer);
                }
                //adding all inputed values after calculations to the database insuree
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
        //added admin method to view a list of items from the database: firstname, lastname, email and quotes which is called by the 
        //cshtml Admin.
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}